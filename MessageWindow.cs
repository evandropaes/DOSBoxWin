using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DosBlaster
{
    public class MessageWindow : Control
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Parent = HWND_MESSAGE;
                cp.ClassName=null;
                cp.Caption = "XYZWindow";
                cp.ExStyle = 0;
                cp.Style = 0;
                cp.X = 0;
                cp.Y = 0;
                cp.Width = 0;
                cp.Height = 0;
                return cp;
            }
        }

        public void CreateWindow()
        {
            CreateHandle();
        }

        static IntPtr HWND_MESSAGE = new IntPtr(-3);
    }
}
