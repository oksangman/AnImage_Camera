using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace AnImage_Camera
{
    public partial class BorderlessForm : Form
    {

        bool borderless = false; // is the window currently borderless
        bool borderless_resize = false; // should the window allow resizing by dragging the borders while borderless
        bool borderless_drag = false; // should the window allow moving my dragging the client area
        bool borderless_shadow = false; // should the window display a native aero shadow while borderless

        bool IsApply = true;


        public BorderlessForm()
        {
            InitializeComponent();
        }

        public void ApplyOption(bool less, bool resize, bool drag, bool shadow)
        {
            IsApply = true;
            borderless = less;
            borderless_resize = resize;
            borderless_drag = drag;
            borderless_shadow = shadow;
            set_borderless(borderless);
            set_borderless_shadow(borderless_shadow);
            Win32.ShowWindow(Handle, (int)Win32.SW_SHOW);
        }

        bool maximized(IntPtr hwnd)
        {
            Win32.WINDOWPLACEMENT placement = new Win32.WINDOWPLACEMENT();
            if (!Win32.GetWindowPlacement(Handle, ref placement))
            {
                return false;
            }

            return placement.showCmd == Win32.SW_MAXIMIZE;
        }

        void adjust_maximized_client_rect(IntPtr window, Win32.RECT rect)
        {
            if (!maximized(window))
            {
                return;
            }

            IntPtr monitor = Win32.MonitorFromWindow(window, Win32.MONITOR_DEFAULTTONULL);
            if (monitor == IntPtr.Zero)
            {
                return;
            }

            Win32.MONITORINFOEX monitor_info = new Win32.MONITORINFOEX();
            if (!Win32.GetMonitorInfo(monitor, ref monitor_info))
            {
                return;
            }

            // when maximized, make the client area fill just the monitor (without task bar) rect,
            // not the whole window rect which extends beyond the monitor.
            rect = monitor_info.WorkArea;
        }
        bool composition_enabled()
        {
            bool composition_enabled = false;
            bool success = Win32.DwmIsCompositionEnabled(out composition_enabled) == Win32.S_OK;
            return composition_enabled && success;
        }
        Win32.Style select_borderless_style()
        {
            return composition_enabled() ? Win32.Style.aero_borderless : Win32.Style.basic_borderless;
        }

        void set_shadow(IntPtr handle, bool enabled)
        {
            if (composition_enabled())
            {
                Win32.MARGINS[] shadow_state = new Win32.MARGINS[2] { new Win32.MARGINS(), new Win32.MARGINS() };
                for (int i = 0; i < 2; ++i)
                {
                    shadow_state[i].bottomHeight = i;
                    shadow_state[i].topHeight = i;
                    shadow_state[i].leftWidth = i;
                    shadow_state[i].rightWidth = i;
                }
                Win32.DwmExtendFrameIntoClientArea(handle, ref shadow_state[enabled ? 1 : 0]);
            }
        }

        void set_borderless(bool enabled)
        {
            Win32.Style new_style = (enabled) ? select_borderless_style() : Win32.Style.windowed;
            Win32.Style old_style = (Win32.Style)Win32.GetWindowLongPtr(Handle, Win32.GWL_STYLE);

            if (new_style != old_style)
            {
                borderless = enabled;
                Win32.SetWindowLongPtr(new HandleRef(this, Handle), Win32.GWL_STYLE, (IntPtr)new_style);

                // when switching between borderless and windowed, restore appropriate shadow state
                set_shadow(Handle, borderless_shadow && (new_style != Win32.Style.windowed));
                // redraw frame
                Win32.SetWindowPos(Handle, IntPtr.Zero, 0, 0, 0, 0, Win32.SWP_FRAMECHANGED | Win32.SWP_NOMOVE | Win32.SWP_NOSIZE);
                Win32.ShowWindow(Handle, (int)Win32.SW_SHOW);
            }
        }

        void set_borderless_shadow(bool enabled)
        {
            if (borderless)
            {
                borderless_shadow = enabled;
                set_shadow(Handle, enabled);
            }
        }
        protected override void WndProc(ref Message m)
        {
            if (IsApply == false)
            {
                base.WndProc(ref m);
                return;
            }
            if (m.Msg == Win32.WM_NCCREATE)
            {
                Win32.CREATESTRUCT userdata = (Win32.CREATESTRUCT)Marshal.PtrToStructure(m.LParam, typeof(Win32.CREATESTRUCT));

                // store window instance pointer in window user data
                Win32.SetWindowLongPtr(new HandleRef(this, m.HWnd), Win32.GWLP_USERDATA, userdata.lpCreateParams);
            }
            switch (m.Msg)
            {
                case Win32.WM_NCCALCSIZE:
                    {
                        if ((int)m.WParam == 1 && borderless)
                        {
                            Win32.NCCALCSIZE_PARAMS param = (Win32.NCCALCSIZE_PARAMS)Marshal.PtrToStructure(m.LParam, typeof(Win32.NCCALCSIZE_PARAMS));
                            adjust_maximized_client_rect(Handle, param.rgrc[0]);
                            m.Result = IntPtr.Zero;
                            return;
                        }
                        break;
                    }
                case Win32.WM_NCHITTEST:
                    {
                        // When we have no border or title bar, we need to perform our
                        // own hit testing to allow resizing and moving.
                        if (borderless)
                        {
                            m.Result = (IntPtr)hit_test(new Point((int)m.LParam));
                            return;
                        }
                        break;
                    }
                case Win32.WM_NCACTIVATE:
                    {
                        if (!composition_enabled())
                        {
                            // Prevents window frame reappearing on window activation
                            // in "basic" theme, where no aero shadow is present.
                            m.Result = (IntPtr)1;
                            return;
                        }
                        break;
                    }

                //case Win32.WM_CLOSE:
                //    {
                //        //  Close();
                //        Win32.DestroyWindow(Handle);
                //        m.Result = IntPtr.Zero;
                //        return;
                //    }

                //case Win32.WM_DESTROY:
                //    {
                //        Environment.Exit(0);
                //        m.Result = IntPtr.Zero;
                //        return;
                //    }

                //case Win32.WM_KEYDOWN:
                //case Win32.WM_SYSKEYDOWN:
                //    {
                //        switch ((int)m.WParam)
                //        {
                //            case Win32.VK_F8: { borderless_drag = !borderless_drag; m.Result = IntPtr.Zero; return; }
                //            case Win32.VK_F9: { borderless_resize = !borderless_resize; m.Result = IntPtr.Zero; return; }
                //            case Win32.VK_F10: { set_borderless(!borderless); m.Result = IntPtr.Zero; return; }
                //            case Win32.VK_F11: { set_borderless_shadow(!borderless_shadow); m.Result = IntPtr.Zero; return; }
                //        }
                //        break;
                //    }
            }
            base.WndProc(ref m);
        }


        public bool Borderless
        {
            get => borderless;
            set
            {
                if (borderless != value)
                    set_borderless(value);
            }
        }

        public bool Borderless_resize { get => borderless_resize; set => borderless_resize = value; }
        public bool Borderless_drag { get => borderless_drag; set => borderless_drag = value; }
        public bool Borderless_shadow
        {
            get => borderless_shadow;
            set
            {
                if (borderless_shadow != value)
                    set_borderless_shadow(value);
            }
        }

        int hit_test(Point cursor)
        {
            // identify borders and corners to allow resizing the window.
            // Note: On Windows 10, windows behave differently and
            // allow resizing outside the visible window frame.
            // This implementation does not replicate that behavior.
            Point border = new Point(
                        Win32.GetSystemMetrics(Win32.SM_CXFRAME) + Win32.GetSystemMetrics(Win32.SM_CXPADDEDBORDER),
                Win32.GetSystemMetrics(Win32.SM_CYFRAME) + Win32.GetSystemMetrics(Win32.SM_CXPADDEDBORDER)
            );
            Win32.RECT window;
            if (!Win32.GetWindowRect(Handle, out window))
            {
                return (int)Win32.HitTest.Nowhere;
            }

            Win32.HitTest drag = borderless_drag ? Win32.HitTest.Caption : Win32.HitTest.Client;

            const int client = 0b0000;
            const int left = 0b0001;
            const int right = 0b0010;
            const int top = 0b0100;
            const int bottom = 0b1000;

            int result =
                left * ((cursor.X < (window.left + border.X)) ? 1 : 0) |
                right * ((cursor.X >= (window.right - border.X)) ? 1 : 0) |
                top * ((cursor.Y < (window.top + border.Y)) ? 1 : 0) |
                bottom * ((cursor.Y >= (window.bottom - border.Y)) ? 1 : 0);

            switch (result)
            {
                case left: return (int)(borderless_resize ? Win32.HitTest.Left : drag);
                case right: return (int)(borderless_resize ? Win32.HitTest.Right : drag);
                case top: return (int)(borderless_resize ? Win32.HitTest.Top : drag);
                case bottom: return (int)(borderless_resize ? Win32.HitTest.Bottom : drag);
                case top | left: return (int)(borderless_resize ? Win32.HitTest.TopLeft : drag);
                case top | right: return (int)(borderless_resize ? Win32.HitTest.TopRight : drag);
                case bottom | left: return (int)(borderless_resize ? Win32.HitTest.BottomLeft : drag);
                case bottom | right: return (int)(borderless_resize ? Win32.HitTest.BottomRight : drag);
                case client: return (int)drag;
                default: return (int)Win32.HitTest.Nowhere;
            }
        }
    }
}
