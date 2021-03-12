using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace DosBlaster
{
    [StructLayout(LayoutKind.Sequential)]
    public struct HMUTEX
    {
        public IntPtr Handle;

        public HMUTEX(IntPtr handle)
        {
            Handle = handle;
        }

        public static HMUTEX Create()
        {
            return CreateMutex(IntPtr.Zero, false, null);
        }

        public static HMUTEX Create(bool initialOwner, string name)
        {
            return CreateMutex(IntPtr.Zero, initialOwner, name);
        }

        public void Close()
        {
            CloseHandle(Handle);
            Handle = IntPtr.Zero;
        }

        public bool WaitOne(int timeout)
        {
            if (Handle != IntPtr.Zero)
            {
                return (WaitForSingleObject(Handle, timeout) == 0);
            }
            else
            {
                return false;
            }
        }

        public bool WaitOne()
        {
            if (Handle != IntPtr.Zero)
            {
                return (WaitForSingleObject(Handle, -1) == 0);
            }
            else
            {
                return false;
            }
        }

        public void Release()
        {
            ReleaseMutex(Handle);
        }

        public static implicit operator IntPtr(HMUTEX handle)
        {
            return handle.Handle;
        }

        public static implicit operator HMUTEX(IntPtr handle)
        {
            return new HMUTEX(handle);
        }

        public bool IsValid
        {
            get { return Handle != IntPtr.Zero; }
        }


        [DllImport("kernel32.dll", CharSet=CharSet.Auto, SetLastError=true)]
        static extern HMUTEX CreateMutex(IntPtr lpMutexAttributes, bool bInitialOwner, string lpName);
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern int WaitForSingleObject(IntPtr hHandle, int dwMilliseconds);
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern bool CloseHandle(IntPtr hObject);
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern bool ReleaseMutex(IntPtr hMutex);


    }
}
