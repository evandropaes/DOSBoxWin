using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;

namespace DosBlaster
{
    public partial class AboutDialog : Form
    {
        public AboutDialog()
        {
            InitializeComponent();
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void AboutDialog_Load(object sender, EventArgs e)
        {
            ctlAvailableMemory.Text = "Memory Used: " + SysUtils.FormatLong(GC.GetTotalMemory(false)) + "B";
            FileVersionInfo verInfo = FileVersionInfo.GetVersionInfo(Environment.GetCommandLineArgs()[0]);
            ctlVersion.Text = "Version: " + verInfo.ProductVersion.ToString() + " (" + Environment.OSVersion.ToString() + ")";
            ctlProductName.Text = Application.ProductName;
        }

        private void cmdOK_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

    }
}