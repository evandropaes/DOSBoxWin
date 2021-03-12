using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;
using FreeZip;
using Microsoft.VisualBasic.FileIO;

namespace DosBlaster
{
    public static class Mediator
    {
        public static MainForm MainForm;
        static ListView ListView;
        static MyStatusStrip StatusStrip;
        static Dictionary<string, ListViewGroup> ListViewGroups = new Dictionary<string, ListViewGroup>();

        public static void Initialize(MainForm mainForm, ListView listView, MyStatusStrip statusStrip)
        {
            MainForm = mainForm;
            ListView = listView;
            StatusStrip = statusStrip;
            LoadGamesIntoListView();
            if (GetDosBox().Verify() == false)
            {
                SysUtils.MessageBoxEx(mainForm, "Please download and install DosBox from http://www.dosbox.com.", "DosBlaster", MessageBoxIcon.Exclamation, 5000, "OK");
            }
        }

        public static void LoadGamesIntoListView()
        {
            ListView.Items.Clear();
            foreach (string directory in Directory.GetDirectories(GameFolderPath))
            {
                Game game = new Game(directory);                
                AddGameToListView(game);
            }
        }

        #region File Commands

        public static void ImportGameZip(object sender, EventArgs e)
        {
            if (VerifyGameFolderPath())
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Title = "Select a ZIP file containing the DOS game...";
                dialog.Filter = "Zip Files (*.zip)|*.zip;*.exe";
                if (dialog.ShowDialog(MainForm) == DialogResult.OK)
                {
                    MainForm.Cursor = Cursors.WaitCursor;
                    string tmpPath = Path.GetTempFileName();
                    File.Delete(tmpPath);
                    Directory.CreateDirectory(tmpPath);
                    try
                    {
                        ZipReader reader = new ZipReader(dialog.FileName);
                        reader.ExtractTo(tmpPath, true);
                        while (Directory.GetFiles(tmpPath).Length == 0 && Directory.GetDirectories(tmpPath).Length == 1)
                        {
                            tmpPath = Directory.GetDirectories(tmpPath)[0];
                        }
                        string folderName = Path.GetFileNameWithoutExtension(dialog.FileName);
                        string gamePath = Path.Combine(GameFolderPath, folderName);
                        bool canMove = true;
                        if (Directory.Exists(gamePath))
                        {
                            DialogResult dialogResult = MessageBox.Show(MainForm, "Game Folder already exists, overwrite it?", "DosBlaster", MessageBoxButtons.OKCancel);
                            if (dialogResult == DialogResult.Cancel)
                            {
                                canMove = false;
                            }
                            else
                            {
                                Directory.Delete(gamePath, true);
                            }
                        }
                        if (canMove)
                        {
                            Directory.Move(tmpPath, gamePath);
                            Game game = new Game(gamePath);
                            game.Name = folderName;
                            game.Category = "Not Set";
                            MessageBox.Show(MainForm, "Game Imported Successfully", "DosBlaster", MessageBoxButtons.OK);
                            RemoveGameFromListView(game);
                            ListViewItem item = AddGameToListView(game);
                            item.EnsureVisible();
                        }                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(MainForm, ex.Message, "DosBlaster", MessageBoxButtons.OK);
                        if (Directory.Exists(tmpPath))
                        {
                            Directory.Delete(tmpPath, true);
                        }
                    }
                    MainForm.Cursor = Cursors.Default;
                }
            }
        }

        public static void ImportGameFolder(object sender, EventArgs e)
        {
            if (VerifyGameFolderPath())
            {
                try
                {
                    FolderBrowserDialog dialog = new FolderBrowserDialog();
                    dialog.Description = "Select a folder containing the game...";
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        MainForm.Cursor = Cursors.WaitCursor;
                        string sourcePath = dialog.SelectedPath;
                        while (Directory.GetFiles(sourcePath).Length == 0 && Directory.GetDirectories(sourcePath).Length == 1)
                        {
                            sourcePath = Directory.GetDirectories(sourcePath)[0];
                        }
                        string folderName = Path.GetFileNameWithoutExtension(sourcePath);
                        string gamePath = Path.Combine(GameFolderPath, folderName);
                        bool canMove = true;
                        if (Directory.Exists(gamePath))
                        {
                            DialogResult dialogResult = MessageBox.Show(MainForm, "Game Folder already exists, overwrite it?", "DosBlaster", MessageBoxButtons.OKCancel);
                            if (dialogResult == DialogResult.Cancel)
                            {
                                canMove = false;
                            }
                            else
                            {
                                Directory.Delete(gamePath, true);
                            }
                        }
                        if (canMove)
                        {                            
                            FileSystem.CopyDirectory(sourcePath, gamePath);
                            Game game = new Game(gamePath);
                            game.Name = folderName;
                            game.Category = "Not Set";
                            
                            RemoveGameFromListView(game);
                            ListViewItem item = AddGameToListView(game);
                            item.EnsureVisible();
                            MessageBox.Show(MainForm, "Game Imported Successfully", "DosBlaster", MessageBoxButtons.OK);
                        }
                        MainForm.Cursor = Cursors.Default;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(MainForm, ex.Message, "DosBlaster", MessageBoxButtons.OK);
                }
            }
        }

        public static void ImportDOS32AZip(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select a ZIP file containing DOS32A.exe...";
            dialog.Filter = "Zip Files (*.zip)|*.zip";
            if (dialog.ShowDialog(MainForm) == DialogResult.OK)
            {
                string tmpPath = Path.GetTempFileName();
                File.Delete(tmpPath);
                Directory.CreateDirectory(tmpPath);
                try
                {
                    ZipReader reader = new ZipReader(dialog.FileName);
                    reader.ExtractTo(tmpPath, true);
                    if (Directory.GetFiles(tmpPath, "dos32a.exe", System.IO.SearchOption.AllDirectories).Length >= 1)
                    {
                        string destPath = Path.Combine(Mediator.SysPath, "DOS32A");
                        if (!Directory.Exists(destPath))
                        {
                            Directory.CreateDirectory(destPath);
                        }
                        FileSystem.CopyDirectory(tmpPath, destPath, true);
                        MessageBox.Show(MainForm, "DOS32A imported successfully.", "DosBlaster", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show(MainForm, "DOS32A.exe is not found in the ZIP archive.", "DosBlaster", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(MainForm, ex.Message, "DosBlaster", MessageBoxButtons.OK);
                }
            }
        }

        public static void ShowConfigurationsDialog(object sender, EventArgs e)
        {
            using (ConfigurationsDialog dialog = new ConfigurationsDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    LoadGamesIntoListView();
                }
            }
        }

        public static void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Game Commands

        public static void RunGame(object sender, EventArgs e)
        {
            Game game = GetSelectedGame();
            if (game != null)
            {
                GameExecutable executable = game.GetTargetExecutable();
                if (executable != null)
                {
                    Mediator.SetProfileString("DosBoxDirectory", DetectDosBox(), Mediator.SysProfilePath);
                    DosBox dosBox = GetDosBox();
                    if (dosBox.Verify())
                    {
                        int tick = Environment.TickCount;
                        dosBox.Run(executable);
                        tick = Environment.TickCount - tick;
                        game.PlayCount++;
                        game.PlayTime += tick / 1000;
                        StatusStrip.SetGame(game);
                    }
                    else
                    {
                        MessageBox.Show(MainForm, "DosBox executable is not found." + Environment.NewLine + "Download DosBox from http://www.dosbox.com.", "DosBlaster", MessageBoxButtons.OK);
                    }
                }
            }
        }

        public static void DeleteGame(object sender, EventArgs e)
        {
            Game game = GetSelectedGame();
            if (game != null)
            {
                DialogResult result = MessageBox.Show(MainForm, "Do you want to delete " + game.Name + "?", "DosBlaster", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    string name = game.Name;
                    Directory.Delete(game.Directory, true);
                    RemoveGameFromListView(game);
                    MessageBox.Show(MainForm, name + " deleted.", "DosBlaster", MessageBoxButtons.OK);
                }
            }
        }

        public static void ShowGameProperties(object sender, EventArgs e)
        {
            Game game = GetSelectedGame();
            if (game != null)
            {
                using (GamePropertiesDialog dialog = new GamePropertiesDialog())
                {
                    dialog.Assign(game);
                    if (dialog.ShowDialog(MainForm) == DialogResult.OK)
                    {
                        RemoveGameFromListView(game);
                        ListViewItem item = AddGameToListView(game);
                        ListView.SelectedItems.Clear();
                        item.Selected = true;
                        item.EnsureVisible();
                    }
                }
            }
        }

        #endregion

        #region Help Commands

        public static void ShowHelp(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo(Path.Combine(Application.StartupPath, "DosBlaster-3.chm"));
            psi.UseShellExecute = true;
            Process.Start(psi);
        }

        public static void ShowDosBlasterWebsite(object sender, EventArgs e)
        {
            Process.Start("http://sourceforge.net/projects/dosblasterx/");
        }

        public static void ShowDosBoxWebsite(object sender, EventArgs e)
        {
            Process.Start("http://www.dosbox.com/");
        }

        public static void ShowAboutDosBlaster(object sender, EventArgs e)
        {
            using (AboutDialog dialog = new AboutDialog())
            {
                dialog.ShowDialog(MainForm);
            }
        }

        public static void ShowAboutDosBox(object sender, EventArgs e)
        {
        }

        #endregion 

        #region Support Functions

        public static Game GetSelectedGame()
        {
            if (ListView.SelectedItems.Count == 1)
            {
                ListViewItem item = ListView.SelectedItems[0];
                return (Game)item.Tag;
            }
            else
            {
                return null;
            }
        }

        public static string GameFolderPath
        {
            get
            {
                return GetProfileString("GamesDirectory", SysProfilePath);
            }
        }

        public static string DosBoxPath
        {
            get
            {
                return GetProfileString("DosBoxDirectory", SysProfilePath);
            }
        }

        public static void EnsurePathsValid()
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "DosBlaster");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            path = GetProfileString("GamesDirectory", SysProfilePath);
            if (!Directory.Exists(path))
            {
                path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "DosBlaster");
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                SetProfileString("GamesDirectory", path, SysProfilePath);
            }
            path = GetProfileString("DosBoxDirectory", SysProfilePath);
            if (!File.Exists(path))
            {
                path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "DOSBox-0.74");
                if (Directory.Exists(path))
                {
                    SetProfileString("DosBoxDirectory", path, SysProfilePath);
                }
            }
        }

        public static bool VerifyGameFolderPath()
        {
            if (!Directory.Exists(GameFolderPath))
            {
                MessageBox.Show(MainForm, "Game Folder is not configured properly.");
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool VerifyDosBoxPath()
        {
            if (!File.Exists(DosBoxPath))
            {
                MessageBox.Show(MainForm, "DosBox is not configured properly.");
                return false;
            }
            else
            {
                return true;
            }
        }

        public static string SysProfilePath
        {
            get { return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "DosBlaster\\DosBlaster.ini"); }
        }

        public static string SysPath
        {
            get { return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "DosBlaster"); }
        }

        public static string GetProfileString(string keyName, string path)
        {
            StringBuilder stringBuilder = new StringBuilder(256);
            GetPrivateProfileString("Options", keyName, "", stringBuilder, 256, path);
            return stringBuilder.ToString();
        }

        public static void SetProfileString(string keyName, string value, string path)
        {
            StringBuilder stringBuilder = new StringBuilder(256);
            WritePrivateProfileString("Options", keyName, value, path);
        }

        public static void SetProfileString(string appName, string keyName, string value, string path)
        {
            StringBuilder stringBuilder = new StringBuilder(256);
            WritePrivateProfileString(appName, keyName, value, path);
        }

        public static int GetProfileInt(string keyName, string path)
        {
            StringBuilder stringBuilder = new StringBuilder(256);
            return GetPrivateProfileInt("Options", keyName, 0, path);
        }

        public static void SetProfileInt(string keyName, int value, string path)
        {
            StringBuilder stringBuilder = new StringBuilder(256);
            WritePrivateProfileString("Options", keyName, value.ToString(), path);
        }

        public static string GetProfile(string appName, string path)
        {
            StringBuilder stringBuilder = new StringBuilder(1024);
            IntPtr tmp = Marshal.AllocCoTaskMem(32 * 1024);
            IntPtr ptr = tmp;
            GetPrivateProfileSection(appName, ptr, 1024, path);
            List<string> list = new List<string>();
            while (Marshal.ReadInt16(ptr) != 0)
            {
                string s = Marshal.PtrToStringUni(ptr);
                list.Add(s);
                ptr = new IntPtr(ptr.ToInt32() + (s.Length + 1) * 2);
            }
            Marshal.FreeCoTaskMem(tmp);
            return string.Join(Environment.NewLine, list.ToArray());
        }

        public static void SetProfile(string appName, string value, string path)
        {
            string[] lines = value.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            IntPtr tmp = Marshal.AllocCoTaskMem(32 * 1024);
            IntPtr ptr = tmp;
            for (int i = 0; i < lines.Length; i++)
            {
                IntPtr sPtr = Marshal.StringToCoTaskMemUni(lines[i]);
                memcpy(ptr, sPtr, lines[i].Length * 2);
                Marshal.WriteInt16(new IntPtr(ptr.ToInt32() + lines[i].Length * 2), 0);
                ptr = new IntPtr(ptr.ToInt32() + (lines[i].Length + 1) * 2);
                Marshal.FreeCoTaskMem(sPtr);
            }
            Marshal.WriteInt16(new IntPtr(ptr.ToInt32()), 0);
            Marshal.WriteInt16(new IntPtr(ptr.ToInt32() + 2), 0);
            WritePrivateProfileSection(appName, tmp, path);
            Marshal.FreeCoTaskMem(tmp);
        }

        public static string GetGameProfilePath(string folderName)
        {
            return Path.Combine(GameFolderPath, folderName + "\\game.ini");
        }

        public static ListViewItem AddGameToListView(Game game)
        {
            ListViewItem item = ListView.Items.Add(game.Name);
            item.Group = CreateOrGetListViewGroup(game.GetGroupName(MainForm.SortMode));
            item.ImageIndex = 0;
            item.Tag = game;
            return item;
        }

        public static ListViewGroup CreateOrGetListViewGroup(string groupName)
        {
            if (ListViewGroups.ContainsKey(groupName))
            {
                return ListViewGroups[groupName];
            }
            else
            {
                ListViewGroup group = new ListViewGroup(groupName, groupName);
                ListView.Groups.Add(group);
                ListViewGroups.Add(groupName, group);
                return group;
            }
        }

        public static void RemoveGameFromListView(Game game)
        {
            foreach (ListViewItem item in ListView.Items)
            {
                Game game2 = (Game)item.Tag;
                if (game2.Directory == game.Directory)
                {
                    item.Remove();
                    return;
                }
            }
        }

        public static string DetectDosBox()
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "DOSBox-0.74\\DosBox.exe");
            if (File.Exists(path))
            {
                return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "DOSBox-0.74");
            }
            else
            {
                return null;
            }
        }

        public static DosBox GetDosBox()
        {
            return new DosBox(GetProfileString("DosBoxDirectory", SysProfilePath), MainForm.CpuType, MainForm.MachineType, MainForm.Scaler, MainForm.EMS);
        }

        #endregion 

        [DllImport("kernel32.dll", CharSet=CharSet.Auto)]
        static extern int GetPrivateProfileString(string lpAppName, string lpKeyName, string lpDefault, StringBuilder lpReturnedString, int nSize, string lpFileName);
        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        static extern bool WritePrivateProfileString(string lpAppName, string lpKeyName, string lpString, string lpFileName);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        static extern int GetPrivateProfileInt(string lpAppName, string lpKeyName, int nDefault, string lpFileName);
        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        static extern bool WritePrivateProfileSection(string lpAppName, IntPtr lpString, string lpFileName);
        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        static extern int GetPrivateProfileSection(string lpAppName, IntPtr lpReturnedString, int nSize, string lpFileName);
        [DllImport("msvcrt.dll", CharSet = CharSet.Auto)]
        static extern IntPtr memcpy(IntPtr dest, IntPtr src, int count);

    }

    public enum SortMode
    {
        Category,
        Publisher,
        Year
    }
}
