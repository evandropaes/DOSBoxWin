using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace DosBlaster
{
    public partial class ExecutableListDialog : Form
    {
        Game _game;
        public ExecutableListDialog()
        {
            InitializeComponent();
        }

        private void ExecutableListDialog_Load(object sender, EventArgs e)
        {

        }

        public void Assign(Game game)
        {
            _game = game;
            foreach (string filename in Directory.GetFiles(game.Directory, "*", SearchOption.TopDirectoryOnly))
            {
                string ext = Path.GetExtension(filename).ToLower();
                if (ext == ".bat" || ext == ".com")
                {
                    if (Path.GetFileName(filename).ToLower() != "autoexec.bat")
                    {
                        ctlList.Items.Add(Path.GetFileName(filename));
                    }
                }
                else if (ext == ".exe")
                {
                    BinaryType binaryType;
                    GetBinaryType(filename, out binaryType);
                    if (binaryType == BinaryType.SCS_DOS_BINARY)
                    {
                        ctlList.Items.Add(Path.GetFileName(filename));
                    }
                }
            }
        }

        public string Filename
        {
            get { return ctlList.SelectedItem.ToString(); }
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        [DllImport("kernel32.dll", CharSet=CharSet.Auto)]
        static extern bool GetBinaryType(string lpApplicationName, out BinaryType lpBinaryType);

        public enum BinaryType
        {
            SCS_32BIT_BINARY = 0,
            SCS_DOS_BINARY = 1,
            SCS_WOW_BINARY = 2,
            SCS_PIF_BINARY = 3,
            SCS_POSIX_BINARY = 4,
            SCS_OS216_BINARY = 5,
            SCS_64BIT_BINARY = 6
        }

        private void ctlList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (ctlList.SelectedIndex != -1)
            {
                cmdOK_Click(null, null);
            }
        }

    }
}