using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnImage_Camera
{
    public class NonClickLabel : Label
    {
        public NonClickLabel()
        {
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case Win32.WM_NCHITTEST:
                case Win32.WM_NCMOUSEMOVE:
                case Win32.WM_NCLBUTTONDOWN:
                case Win32.WM_NCLBUTTONUP:
                case Win32.WM_NCLBUTTONDBLCLK:
                case Win32.WM_NCRBUTTONDOWN:
                case Win32.WM_NCRBUTTONUP:
                case Win32.WM_NCRBUTTONDBLCLK:
                case Win32.WM_NCMBUTTONDOWN:
                case Win32.WM_NCMBUTTONUP:
                case Win32.WM_NCMBUTTONDBLCLK:
                case Win32.WM_NCXBUTTONDOWN:
                case Win32.WM_NCXBUTTONUP:
                case Win32.WM_NCXBUTTONDBLCLK:
                case Win32.WM_NCMOUSEHOVER:
                case Win32.WM_NCMOUSELEAVE:
                    m.Result = (IntPtr)Win32.HitTest.Transparent;
                    return;
            }
            base.WndProc(ref m);
        }
    }
}
