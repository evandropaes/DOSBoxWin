using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Design;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace DosBlaster
{
    [Designer(typeof(ParentControlDesigner))]
    public partial class BorderPanel : Panel
    {
        Color _leftBorder = Color.Transparent;
        Color _topBorder = Color.Transparent;
        Color _rightBorder = Color.Transparent;
        Color _bottomBorder = Color.Transparent;
        protected int _leftPadding = 0;
        protected int _topPadding = 0;
        protected int _rightPadding = 0;
        protected int _bottomPadding = 0;

        public BorderPanel()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (Pen pen = new Pen(_leftBorder))
            {
                e.Graphics.DrawLine(pen, new Point(0, 0), new Point(0, Height));
            }

            using (Pen pen = new Pen(_topBorder))
            {
                e.Graphics.DrawLine(pen, new Point(0, 0), new Point(Width, 0));
            }

            using (Pen pen = new Pen(_rightBorder))
            {
                e.Graphics.DrawLine(pen, new Point(Width - 1, 0), new Point(Width - 1, Height));
            }

            using (Pen pen = new Pen(_bottomBorder))
            {
                e.Graphics.DrawLine(pen, new Point(0, Height - 1), new Point(Width, Height - 1));
            }
            base.OnPaint(e);
        }

        public Color LeftBorder
        {
            get { return _leftBorder; }
            set 
            { 
                _leftBorder = value;
                Padding = new Padding((_leftBorder == Color.Transparent ? 0 : 1), (_topBorder == Color.Transparent ? 0 : 1), (_rightBorder == Color.Transparent ? 0 : 1), (_bottomBorder == Color.Transparent ? 0 : 1));
                Invalidate();
            }
        }

        public Color TopBorder
        {
            get { return _topBorder; }
            set
            {
                _topBorder = value;
                Padding = new Padding((_leftBorder == Color.Transparent ? 0 : 1), (_topBorder == Color.Transparent ? 0 : 1), (_rightBorder == Color.Transparent ? 0 : 1), (_bottomBorder == Color.Transparent ? 0 : 1));
                Invalidate();
            }
        }

        public Color RightBorder
        {
            get { return _rightBorder; }
            set
            {
                _rightBorder = value;
                Padding = new Padding((_leftBorder == Color.Transparent ? 0 : 1), (_topBorder == Color.Transparent ? 0 : 1), (_rightBorder == Color.Transparent ? 0 : 1), (_bottomBorder == Color.Transparent ? 0 : 1));
                Invalidate();
            }
        }

        public Color BottomBorder
        {
            get { return _bottomBorder; }
            set
            {
                _bottomBorder = value;
                Padding = new Padding((_leftBorder == Color.Transparent ? 0 : 1), (_topBorder == Color.Transparent ? 0 : 1), (_rightBorder == Color.Transparent ? 0 : 1), (_bottomBorder == Color.Transparent ? 0 : 1));
                Invalidate();
            }
        }
    }
}
