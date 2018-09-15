using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnImage_Camera
{
    public partial class TitleBar : UserControl
    {
        public TitleBar()
        {
            InitializeComponent();
            SetStyle(ControlStyles.Selectable, false);
        }

        [DefaultValue(DockStyle.None)]
        [Localizable(true)]
        [RefreshProperties(RefreshProperties.Repaint)]
        public override DockStyle Dock { get => base.Dock; set { base.Dock = DockStyle.Top; } }


        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Right)
            {
                if (e.Y < Height)
                {
                    var p = MousePosition.X + (MousePosition.Y * 0x10000);
                    Win32.SendMessage(Parent.Handle, Win32.WM_POPUPSYSTEMMENU, (int)0, (int)p);
                }
            }
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case Win32.WM_NCHITTEST:
                //case Win32.WM_NCMOUSEMOVE:
                //case Win32.WM_NCLBUTTONDOWN:
                //case Win32.WM_NCLBUTTONUP:
                //case Win32.WM_NCLBUTTONDBLCLK:
                //case Win32.WM_NCRBUTTONDOWN:
                //case Win32.WM_NCRBUTTONUP:
                //case Win32.WM_NCRBUTTONDBLCLK:
                //case Win32.WM_NCMBUTTONDOWN:
                //case Win32.WM_NCMBUTTONUP:
                //case Win32.WM_NCMBUTTONDBLCLK:
                //case Win32.WM_NCXBUTTONDOWN:
                //case Win32.WM_NCXBUTTONUP:
                //case Win32.WM_NCXBUTTONDBLCLK:
                //case Win32.WM_NCMOUSEHOVER:
                //case Win32.WM_NCMOUSELEAVE:
                    m.Result = (IntPtr)Win32.HitTest.Transparent;
                    return;
            }
            base.WndProc(ref m);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            ((Form)Parent).WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (((Form)Parent).WindowState == FormWindowState.Normal)
            {
                ((Form)Parent).WindowState = FormWindowState.Maximized;
                btnMaximize.Normal = Properties.Resources.btn_maximize2;
                btnMaximize.MouseOver = Properties.Resources.btn_maximize2;
            }
            else if (((Form)Parent).WindowState == FormWindowState.Maximized)
            {
                ((Form)Parent).WindowState = FormWindowState.Normal;
                btnMaximize.Normal = Properties.Resources.btn_maximize;
                btnMaximize.MouseOver = Properties.Resources.btn_maximize;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ((Form)Parent).Close();
        }

        private void pcIcon_Click(object sender, EventArgs e)
        {
            Point pt = PointToScreen(pcIcon.Location);
            pt.Y += Height;
            var p = pt.X + (pt.Y * 0x10000);
            Win32.SendMessage(Parent.Handle, Win32.WM_POPUPSYSTEMMENU, (int)0, (int)p);
        }

        private void pcIcon_DoubleClick(object sender, EventArgs e)
        {
            ((Form)Parent).Close();
        }

        private void TitleBar_Resize(object sender, EventArgs e)
        {
            int locationY = Height / 2 - lbCaption.Height / 2 + 1;

            if (lbCaption.Location.Y != locationY)
            {
                lbCaption.Location = new Point(lbCaption.Location.X, locationY);
            }

        }
    }
}
