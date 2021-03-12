using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Reflection;

namespace DosBlaster
{
    public static class SysUtils
    {
        static long _frequency;
        static HMUTEX AppMutex;
        public static MessageWindow MsgWindow = new MessageWindow();
        public static Form MainForm;
        static SysUtils()
        {
            QueryPerformanceFrequency(out _frequency);
            MsgWindow.CreateControl();
        }

        public static void Alert(IWin32Window window, string message)
        {
            MessageBox.Show(window, message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Warn(IWin32Window window, string message)
        {
            MessageBox.Show(window, message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void Stop(IWin32Window window, string message)
        {
            MessageBox.Show(window, message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool Confirm(IWin32Window window, string message)
        {
            return (MessageBox.Show(window, message, Application.ProductName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK);
        }

        public static bool Confirm(IWin32Window window, string message, MessageBoxIcon icon)
        {
            return (MessageBox.Show(window, message, Application.ProductName, MessageBoxButtons.OKCancel, icon) == DialogResult.OK);
        }
                
        public static byte[] GetBytesFromIntPtr(IntPtr intPtr)
        {
            if (IntPtr.Size == 4)
            {
                return BitConverter.GetBytes(intPtr.ToInt32());
            }
            else
            {
                return BitConverter.GetBytes(intPtr.ToInt64());
            }
        }

        public static int GetInt32FromIntPtr(IntPtr intPtr)
        {
            return BitConverter.ToInt32(GetBytesFromIntPtr(intPtr), 0);
        }

        public static bool LockApp(string mutexName)
        {
            AppMutex = HMUTEX.Create(true, mutexName);
            if (Marshal.GetLastWin32Error() == ERROR_ALREADY_EXISTS)
            {
                AppMutex.Close();
                return false;
            }
            else
            {
                return AppMutex.IsValid;
            }
        }

        public static bool UnlockApp()
        {
            if (AppMutex.IsValid)
            {
                AppMutex.Release();
                AppMutex.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string FormatLong(long size)
        {
            if (size < 1024)
            {
                return size.ToString();
            }
            else if (size < 1024 * 1024)
            {
                return (size / 1024).ToString() + "K";
            }
            else if (size < 1024 * 1024 * 1024)
            {
                return Math.Round((float)size / 1024 / 1024, 1).ToString() + "M";
            }
            else if (size < (long)1024 * 1024 * 1024 * 1024)
            {
                return Math.Round((float)size / 1024 / 1024 / 1024, 2).ToString() + "G";
            }
            else
            {
                return Math.Round((float)size / (long)1024 / 1024 / 1024 / 1024, 3).ToString() + "T";
            }
        }

        public static void Serialize(string filename, object obj)
        {
            string tmpPath = Path.GetTempFileName();
            using (Stream stream = File.Create(tmpPath))
            {
                Serialize(stream, obj);
            }
            File.Copy(tmpPath, filename, true);
            File.Delete(tmpPath);
        }

        public static void Serialize(Stream stream, object obj)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, obj);
        }

        public static object Deserialize(string filename)
        {
            using (Stream stream = File.OpenRead(filename))
            {
                return Deserialize(stream);
            }
        }

        public static object Deserialize(Stream stream)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            return formatter.Deserialize(stream);
        }

        public static Stream GetResourceStream(string ns)
        {
            Stream stream = GetResourceStream(Assembly.GetCallingAssembly(), ns);
            if (stream == null)
            {
                stream = GetResourceStream(Assembly.GetEntryAssembly(), ns);
                if (stream == null)
                {
                    stream = GetResourceStream(Assembly.GetExecutingAssembly(), ns);
                }
            }
            return stream;
        }

        static Stream GetResourceStream(Assembly assembly, string ns)
        {
            return assembly.GetManifestResourceStream(ns);
        }

        public static Rectangle[] SpawnRectangles(Rectangle rectangle, int count, Point offset)
        {
            List<Rectangle> list = new List<Rectangle>();
            for (int i = 0; i < count; i++)
            {
                list.Add(rectangle);
                rectangle.Offset(offset);
            }
            return list.ToArray();
        }

        public static void SetSpring(ListView listView, int springIndex)
        {
            int fixedWidths = 0;
            foreach (ColumnHeader item in listView.Columns)
            {
                if (item.Index != springIndex)
                {
                    fixedWidths += item.Width;
                }
            }
            listView.Columns[springIndex].Width = listView.ClientSize.Width - fixedWidths;
        }

        public static T[] Slice<T>(T[] items, int index, int count)
        {
            T[] tmp = new T[count];
            Array.Copy(items, index, tmp, 0, count);
            return tmp;
        }

        public static T[] Join<T>(T[] lhs, T[] rhs)
        {
            T[] array = new T[lhs.Length + rhs.Length];
            Array.Copy(lhs, array, lhs.Length);
            Array.Copy(rhs, 0, array, lhs.Length, rhs.Length);
            return array;
        }

        public static decimal GetClock()
        {
            long ticks;
            QueryPerformanceCounter(out ticks);
            return (decimal)ticks / _frequency;
        }

        public static string SecToString(decimal secs)
        {
            if (secs < 0.000001m)
            {
                return Math.Round(secs * 1000000000, 2).ToString() + "ns";
            }
            else if (secs < 0.001m)
            {
                return Math.Round(secs * 1000000, 2).ToString() + "us";
            }
            else if (secs < 1m)
            {
                return Math.Round(secs * 1000, 2).ToString() + "ms";
            }
            else if (secs < 60m)
            {
                return Math.Round(secs, 2).ToString() + "s";
            }
            else
            {
                return Math.Round(secs / 60, 2).ToString() + "mins";
            }
        }

        public static UnrollPlan UnrollLoop(int total, int stride)
        {
            return new UnrollPlan(total, stride);
        }

        public static object BufferToStructure(byte[] buffer, Type type)
        {
            GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            object obj = Marshal.PtrToStructure(handle.AddrOfPinnedObject(), type);
            handle.Free();
            return obj;
        }

        public static int Clamp(int value, int min, int max)
        {
            return Math.Max(min, Math.Max(max, value));
        }

        public static int ModC(int value, int modulus)
        {
            return value - (value % modulus);
        }

        public static T[][] MakeJaggedArray<T>(int rank0, int rank1)
        {
            T[][] tmp = new T[rank0][];
            for (int i = 0; i < rank0; i++)
            {
                tmp[i] = new T[rank1];
            }
            return tmp;
        }

        public static int MessageBoxEx(IWin32Window window, string message, string title, MessageBoxIcon icon, int delay, params string[] buttonTexts)
        {
            using (MessageDialog dialog = new MessageDialog())
            {
                dialog.Title = title;
                dialog.Message = message;
                dialog.MessageBoxIcon = icon;
                dialog.Delay = delay;
                for (int i = 0; i < buttonTexts.Length; i++)
                {
                    dialog.AddButton(buttonTexts[i]);
                }
                return dialog.ShowDialog(window);
            }
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool QueryPerformanceCounter(out long lpPerformanceCount);
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool QueryPerformanceFrequency(out long lpPerformanceCount);
        [DllImport("msvcrt.dll", SetLastError = true)]
        static extern IntPtr memcpy(IntPtr dest, IntPtr src, int count);
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern ExecutionState SetThreadExecutionState(ExecutionState esFlags);

        const int ERROR_ALREADY_EXISTS = 183;
    }

    public enum ExecutionState
    {
        Continuous = unchecked((int)0x80000000),
        DisplayRequired = 0x00000002,
        SystemRequired = 0x00000001,
        None = 0
    }


}
