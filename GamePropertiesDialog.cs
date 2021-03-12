using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DosBlaster
{
    public partial class GamePropertiesDialog : Form
    {
        Game _game;
        public GamePropertiesDialog()
        {
            InitializeComponent();
        }

        private void GamePropertiesDialog_Load(object sender, EventArgs e)
        {

        }

        public void Assign(Game game)
        {
            _game = game;
            ctlDirectoryName.Text = Path.GetFileName(game.Directory);
            ctlTitle.Text = game.Name;
            ctlCategory.Text = game.Category;
            ctlPublisher.Text = game.Publisher;
            ctlYear.Text = game.Year;
            ctlAutoexec.Text = game.Autoexec;
            if (_game.IsUsingDosExtender())
            {
                ctlDOS32A.Checked = _game.IsUsingDosExtender() && _game.IsUsingDos32A();
                ctlDOS4GW.Checked = _game.IsUsingDosExtender() && _game.IsUsingDos4GW();
            }
            else
            {
                ctlDOS32A.Enabled = false;
                ctlDOS32A.Checked = false;
                ctlDOS4GW.Enabled = false;
                ctlDOS4GW.Checked = false;
            }
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ctlTitle.Text))
            {
                MessageBox.Show(Mediator.MainForm, "Title cannot be empty", "DosBlaster", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(ctlCategory.Text))
            {
                MessageBox.Show(Mediator.MainForm, "Category cannot be empty", "DosBlaster", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _game.Name = ctlTitle.Text;
            _game.Category = ctlCategory.Text;
            _game.Publisher = ctlPublisher.Text;
            _game.Year = ctlYear.Text;
            _game.Autoexec = ctlAutoexec.Text;
            DialogResult = DialogResult.OK;
        }
        
        private void ctlDOS4GW_Click(object sender, EventArgs e)
        {
            _game.SetDos4GW();
            ctlDOS32A.Checked = _game.IsUsingDosExtender() && _game.IsUsingDos32A();
            ctlDOS4GW.Enabled = _game.IsUsingDosExtender() && _game.IsUsingDos4GW();
        }

        private void ctlDOS32A_Click(object sender, EventArgs e)
        {
            _game.SetDos32A();
            ctlDOS32A.Checked = _game.IsUsingDosExtender() && _game.IsUsingDos32A();
            ctlDOS4GW.Enabled = _game.IsUsingDosExtender() && _game.IsUsingDos4GW();
        }
    }
}