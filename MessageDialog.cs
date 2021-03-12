using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DosBlaster
{
    public partial class MessageDialog : Form
    {
        string _message;
        MessageBoxIcon _icon;
        List<Button> _buttons = new List<Button>();
        int _buttonIndex;
        int _cancelIndex;
        int _delay;
        int _timeOut;
        string _acceptText;

        public MessageDialog()
        {
            InitializeComponent();
            _buttonIndex = -1;
        }

        public MessageDialog(string title, string message, MessageBoxIcon icon)
        {
            InitializeComponent();
            Text = title;
            _message = message;
            _buttonIndex = -1;
        }

        public string Title
        {
            get { return Text; }
            set { Text = value; }
        }

        public string Message
        {
            get { return _message; }
            set { _message = value; Invalidate(); }
        }

        public MessageBoxIcon MessageBoxIcon
        {
            get { return _icon; }
            set { _icon = value; Invalidate(); }
        }

        public int Delay
        {
            get { return _delay; }
            set { _delay = value; }
        }

        private void MessageDialog_Load(object sender, EventArgs e)
        {
        }

        Icon GetIconFromMessageBoxIcon(MessageBoxIcon icon)
        {
            switch (icon)
            {
                case MessageBoxIcon.Asterisk:
                    return SystemIcons.Asterisk;
                case MessageBoxIcon.Error:
                    return SystemIcons.Error;
                case MessageBoxIcon.Exclamation:
                    return SystemIcons.Exclamation;
                case MessageBoxIcon.Question:
                    return SystemIcons.Question;
                default:
                    return null;
            }
        }

        public new int ShowDialog()
        {
            if (Delay > 0)
            {
                _timeOut = _delay;
                timer.Start();
            }
            base.ShowDialog();
            return _buttonIndex;
        }

        public new int ShowDialog(IWin32Window window)
        {
            if (Delay > 0)
            {
                _timeOut = _delay;
                timer.Start();
            }
            base.ShowDialog(window);
            return _buttonIndex;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle iconRect;
            Rectangle textRect;
            Graphics g = e.Graphics;
            if (_icon == MessageBoxIcon.None)
            {
                textRect = new Rectangle(12, 12, ClientSize.Width - 24, 32);
            }
            else
            {
                iconRect = new Rectangle(12, 12, 32, 32);
                textRect = new Rectangle(12 + 32 + 12, 12, ClientSize.Width - 24 - 32 - 12, 32);
                Icon icon = GetIconFromMessageBoxIcon(_icon);
                g.DrawIcon(icon, iconRect);
            }
            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            g.DrawString(_message, Font, Brushes.Black, textRect, sf);
            base.OnPaint(e);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (_buttonIndex == -1)
                {
                    _buttonIndex = _cancelIndex;
                }
            }
            base.OnFormClosing(e);
        }

        public void AddButton(string text)
        {
            Button button = new Button();
            button.Text = text;
            Controls.Add(button);
            

            if (_buttons.Count == 0)
            {
                AcceptButton = button;
                if (Delay > 0)
                {
                    button.Enabled = false;
                    _acceptText = text;
                }                
            }
            else
            {
                CancelButton = button;
                _cancelIndex = _buttons.Count - 1;
            }
            _buttons.Add(button);

            int minWidth = _buttons.Count * (button.Width + 12) + 12;
            int dx = (ClientSize.Width - minWidth) / 2;
            for (int i = 0; i < _buttons.Count; i++)
            {
                _buttons[i].Bounds = new Rectangle(dx + 12, ClientSize.Height - 35, button.Width, button.Height);
                _buttons[i].Tag = i;
                _buttons[i].Click += new EventHandler(MessageDialog_Click);
                dx += _buttons[i].Width + 12;
            }
        }

        void MessageDialog_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            _buttonIndex = (int)button.Tag;
            Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Button button = (Button)AcceptButton;
            if (_timeOut > 0)
            {
                _timeOut -= 1000;
                button.Text = "Wait " + (_timeOut / 1000).ToString() + "s";                
            }
            else
            {
                timer.Stop();
                if (AcceptButton != null)
                {                    
                    button.Enabled = true;
                    button.Text = _acceptText;
                }
            }
        }
    }

    public enum MessageDialogButtonType
    {
        Normal,
        Default,
        Cancel        
    }
}