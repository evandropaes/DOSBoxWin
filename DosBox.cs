using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Diagnostics;

namespace DosBlaster
{
    public class DosBox
    {
        public readonly string Directory;
        public readonly string ExePath;
        public readonly string MachineType;
        public readonly string CpuType;
        public readonly string Scaler;
        public readonly bool EnableEMS;

        public DosBox(string directory, string cpuType, string machineType, string scaler, bool enableEMS)
        {
            Directory = directory;
            ExePath = Path.Combine(Directory, "dosbox.exe");
            MachineType = machineType;
            Scaler = scaler;
            EnableEMS = enableEMS;
        }

        public void Run(GameExecutable executable)
        {
            Mediator.MainForm.Hide();

            string confPath = CreateNewConf(executable.Game);
            ProcessStartInfo psi = new ProcessStartInfo(ExePath);
            psi.UseShellExecute = false;
            psi.Arguments = "\"" + executable.ExePath + "\" -userconf \"" + UserConfigPath + "\" -conf \"" + confPath + "\" -noconsole -machine " + MachineType + " -forcescaler " + Scaler;
            psi.CreateNoWindow = true;
            Process process = Process.Start(psi);
            int cycles = 0;
            while (process.WaitForExit(1000) == false)
            {
                process.Refresh();
                Match match = Regex.Match(process.MainWindowTitle, @"(\d+) cycles");
                if (match.Success)
                {
                    cycles = int.Parse(match.Groups[1].Value);
                }
            }
            
            Mediator.MainForm.Show();
            File.Delete(confPath);
            executable.Game.Cycles = cycles;
        }

        public string UserConfigPath
        {
            get { return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"DosBox\\dosbox-0.74.conf"); }
        }

        public string CreateNewConf(Game game)
        {
            string destPath = Path.GetTempFileName();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("[cpu]");
            sb.AppendLine("cputype=" + (EnableEMS ? "on" : "off"));
            sb.AppendLine("[dos]");
            sb.AppendLine("ems=" + (EnableEMS ? "on" : "off"));
            sb.AppendLine("[cpu]");
            sb.AppendLine("cycles=" + "fixed " + game.Cycles.ToString());
            sb.AppendLine("[autoexec]");
            sb.AppendLine(game.Autoexec);
            File.AppendAllText(destPath, sb.ToString());
            return destPath;
        }

        public bool Verify()
        {
            return File.Exists(ExePath);
        }

    }
}
