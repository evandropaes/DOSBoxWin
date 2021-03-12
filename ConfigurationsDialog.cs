using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace DosBlaster
{
    public partial class ConfigurationsDialog : Form
    {
        public ConfigurationsDialog()
        {
            InitializeComponent();
        }

        private void OptionDialog_Load(object sender, EventArgs e)
        {
            ctlDosBoxDirectory.Text = Mediator.GetProfileString("DosBoxDirectory", Mediator.SysProfilePath);
            ctlGameDirectory.Text = Mediator.GetProfileString("GamesDirectory", Mediator.SysProfilePath);
        }

        private void cmdDetect_Click(object sender, EventArgs e)
        {
            string path = Mediator.DetectDosBox();
            if (path == null)
            {
                DialogResult result = MessageBox.Show(Mediator.MainForm, "DosBox is not installed. Do you want to visit DosBox website to download DosBox?", "DosBlaster", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    Process.Start("http://www.dosbox.com");
                }
            }
            else
            {
                ctlDosBoxDirectory.Text = path;
            }
        }

        private void cmdDefaults_Click(object sender, EventArgs e)
        {
            ctlGameDirectory.Text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "DosBlaster");
        }

        private void cmdBrowseDosBox_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Select the folder containing DosBox.exe...";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(Path.Combine(dialog.SelectedPath, "DosBox.exe")))
                {
                    ctlDosBoxDirectory.Text = dialog.SelectedPath;
                }
                else
                {
                    MessageBox.Show(Mediator.MainForm, "DosBox.exe does not exists in the selected folder", "DosBlaster", MessageBoxButtons.OK);
                }
            }
        }

        private void cmdBrowseGame_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Select the folder containing the DOS games folders...";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ctlGameDirectory.Text = dialog.SelectedPath;
            }
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            Mediator.SetProfileString("DosBoxDirectory", ctlDosBoxDirectory.Text, Mediator.SysProfilePath);
            Mediator.SetProfileString("GamesDirectory", ctlGameDirectory.Text, Mediator.SysProfilePath);
            DialogResult = DialogResult.OK;

        }

        
    }
}