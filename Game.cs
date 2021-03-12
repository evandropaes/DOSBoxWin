using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace DosBlaster
{
    public class Game
    {
        string _gameDirectory;

        public Game(string gameDirectory)
        {
            _gameDirectory = gameDirectory;
        }

        public string AutoexecPath
        {
            get { return Path.Combine(_gameDirectory, "autoexec.bat"); }
        }

        public string Name
        {
            get { return Mediator.GetProfileString("Name", Mediator.GetGameProfilePath(_gameDirectory)); }
            set { Mediator.SetProfileString("Name", value, Mediator.GetGameProfilePath(_gameDirectory)); }
        }

        public string Category
        {
            get { return Mediator.GetProfileString("Category", Mediator.GetGameProfilePath(_gameDirectory)); }
            set { Mediator.SetProfileString("Category", value, Mediator.GetGameProfilePath(_gameDirectory)); }
        }

        public string Publisher
        {
            get { return Mediator.GetProfileString("Publisher", Mediator.GetGameProfilePath(_gameDirectory)); }
            set { Mediator.SetProfileString("Publisher", value, Mediator.GetGameProfilePath(_gameDirectory)); }
        }

        public string Year
        {
            get { return Mediator.GetProfileString("Year", Mediator.GetGameProfilePath(_gameDirectory)); }
            set { Mediator.SetProfileString("Year", value, Mediator.GetGameProfilePath(_gameDirectory)); }
        }

        public int Cycles
        {
            get { return Mediator.GetProfileInt("Cycles", Mediator.GetGameProfilePath(_gameDirectory)); }
            set { Mediator.SetProfileInt("Cycles", value, Mediator.GetGameProfilePath(_gameDirectory)); }
        }

        public string Autoexec
        {
            get { return (File.Exists(AutoexecPath) ? File.ReadAllText(AutoexecPath) : ""); }
            set { File.WriteAllText(Path.Combine(_gameDirectory, "autoexec.bat"), value); }
        }

        public string Directory
        {
            get { return _gameDirectory; }
        }

        public bool IsUsingDosExtender()
        {
            string dos4GW = Path.Combine(_gameDirectory, "dos4gw.exe");
            return File.Exists(dos4GW);
        }

        public bool IsUsingDos32A()
        {
            string dos4GW_bak = Path.Combine(_gameDirectory, "dos4gw.bak");
            return File.Exists(dos4GW_bak);
        }

        public bool IsUsingDos4GW()
        {
            string dos4GW_bak = Path.Combine(_gameDirectory, "dos4gw.bak");
            return !File.Exists(dos4GW_bak);
        }

        public void SetDos32A()
        {
            try
            {
                string dos4GW = Path.Combine(_gameDirectory, "dos4gw.exe");
                string dos4GW_bak = Path.Combine(_gameDirectory, "dos4gw.bak");
                string dos32Dir = Path.Combine(Mediator.SysPath, "DOS32A");
                string[] dos32Paths = System.IO.Directory.GetFiles(Path.Combine(Mediator.SysPath, "DOS32A"), "dos32a.exe", SearchOption.AllDirectories);
                if (dos32Paths.Length == 1)
                {
                    File.Copy(dos4GW, dos4GW_bak, true);
                    File.Copy(dos32Paths[0], dos4GW, true);
                }
            }
            catch (DirectoryNotFoundException ex)
            {
                MessageBox.Show(Mediator.MainForm, "DOS32A package is missing. Import DOS32A package first.", "DosBlaster", MessageBoxButtons.OK);
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(Mediator.MainForm, "DOS32A package is missing. Import DOS32A package first.", "DosBlaster", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Mediator.MainForm, ex.Message, "DosBlaster", MessageBoxButtons.OK);
            }
        }

        public void SetDos4GW()
        {
            string dos4GW = Path.Combine(_gameDirectory, "dos4gw.exe");
            string dos4GW_bak = Path.Combine(_gameDirectory, "dos4gw.bak");
            File.Copy(dos4GW_bak, dos4GW, true);
            File.Delete(dos4GW_bak);
        }

        public GameExecutable GetTargetExecutable()
        {
            using (ExecutableListDialog dialog = new ExecutableListDialog())
            {
                dialog.Assign(this);
                if (dialog.ShowDialog(Mediator.MainForm) == DialogResult.OK)
                {
                    return new GameExecutable(this, Path.Combine(Directory, dialog.Filename));
                }
                else
                {
                    return null;
                }
            }
        }

        public int PlayCount
        {
            get { return Mediator.GetProfileInt("PlayCount", Mediator.GetGameProfilePath(_gameDirectory)); }
            set { Mediator.SetProfileInt("PlayCount", value, Mediator.GetGameProfilePath(_gameDirectory)); }
        }

        public int PlayTime
        {
            get { return Mediator.GetProfileInt("PlayTime", Mediator.GetGameProfilePath(_gameDirectory)); }
            set { Mediator.SetProfileInt("PlayTime", value, Mediator.GetGameProfilePath(_gameDirectory)); }
        }

        public string GetGroupName(SortMode sortMode)
        {
            if (sortMode == SortMode.Category)
            {
                return Category;
            }
            else if (sortMode == SortMode.Publisher)
            {
                if (string.IsNullOrEmpty(Publisher))
                {
                    return "Unknown";
                }
                else
                {
                    return Publisher;
                }
            }
            else 
            {
                if (string.IsNullOrEmpty(Year))
                {
                    return "Unknown";
                }
                else
                {
                    return Year;
                }
            }
        }
    }
}
