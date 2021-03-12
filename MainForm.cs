using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DosBlaster
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Mediator.EnsurePathsValid();
            Mediator.Initialize(this, ctlListView, statusStrip);
            ctlMachineType.Text = Mediator.GetProfileString("MachineType", Mediator.SysProfilePath);
            if (ctlMachineType.Text == "")
            {
                ctlMachineType.SelectedIndex = 6;
            }
            ctlScaler.Text = Mediator.GetProfileString("Scaler", Mediator.SysProfilePath);
            if (ctlScaler.Text == "")
            {
                ctlScaler.SelectedIndex = 0;
            }
            ctlCpuType.Text = Mediator.GetProfileString("CpuType", Mediator.SysProfilePath);
            if (ctlCpuType.Text == "")
            {
                ctlCpuType.SelectedIndex = 0;
            }
            ctlSort.SelectedIndex = Mediator.GetProfileInt("Sort", Mediator.SysProfilePath);
        }

        public string MachineType
        {
            get { return ctlMachineType.Text; }
        }

        public string CpuType
        {
            get { return ctlCpuType.Text; }
        }

        public string Scaler
        {
            get { return ctlScaler.Text; }
        }

        public SortMode SortMode
        {
            get { return (SortMode)ctlSort.SelectedIndex; }
        }

        public bool EMS
        {
            get { return ctlEMS.Checked; }
        }

        private void ctlListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Mediator.GetSelectedGame() != null)
            {
                Mediator.RunGame(null, null);
            }
        }

        private void ctlListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && Mediator.GetSelectedGame() != null)
            {
                mnuContext.Show(ctlListView, ctlListView.PointToClient(Control.MousePosition));
            }
        }

        private void cmdPlayGame_Click(object sender, EventArgs e)
        {
            Mediator.RunGame(null, null);
        }

        private void cmdDeleteGame_Click(object sender, EventArgs e)
        {
            Mediator.DeleteGame(null, null);
        }

        private void cmdProperties_Click(object sender, EventArgs e)
        {
            Mediator.ShowGameProperties(null, null);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Mediator.SetProfileString("MachineType", ctlMachineType.Text, Mediator.SysProfilePath);
            Mediator.SetProfileString("Scaler", ctlScaler.Text, Mediator.SysProfilePath);
            Mediator.SetProfileString("CpuType", ctlCpuType.Text, Mediator.SysProfilePath);
        }

        private void ctlListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                if (e.Item != null)
                {
                    Game game = (Game)e.Item.Tag;
                    statusStrip.SetGame(game);
                }
                else
                {
                    statusStrip.SetGame(null);
                }
            }
            else
            {
                statusStrip.SetGame(null);
            }
        }

        private void ctlSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mediator.LoadGamesIntoListView();
        }
    }
}