using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

public class Win32
{
    public const int S_OK = 0x00000000;
    public const int GWL_STYLE = -16;

    public const int WM_NCACTIVATE = 0x0086;
    public const int WM_CLOSE = 0x0010;
    public const int WM_DESTROY = 0x0002;

    public const int WM_KEYDOWN = 0x0100;
    public const int WM_SYSKEYDOWN = 0x0104;

    public const int WM_NCHITTEST = 0x0084;
    public const int WM_NCMOUSEMOVE = 0x00A0;
    public const int WM_NCLBUTTONDOWN = 0x00A1;
    public const int WM_NCLBUTTONUP = 0x00A2;
    public const int WM_NCLBUTTONDBLCLK = 0x00A3;
    public const int WM_NCRBUTTONDOWN = 0x00A4;
    public const int WM_NCRBUTTONUP = 0x00A5;
    public const int WM_NCRBUTTONDBLCLK = 0x00A6;
    public const int WM_NCMBUTTONDOWN = 0x00A7;
    public const int WM_NCMBUTTONUP = 0x00A8; 
    public const int WM_NCMBUTTONDBLCLK = 0x00A9;
    public const int WM_NCXBUTTONDOWN = 0x00AB;
    public const int WM_NCXBUTTONUP = 0x00AC;
    public const int WM_NCXBUTTONDBLCLK = 0x00AD;
    public const int WM_NCMOUSEHOVER = 0x02A0;
    public const int WM_NCMOUSELEAVE = 0x02A2;

    public const int WM_NCCALCSIZE = 0x0083;
    public const int WM_NCCREATE = 0x0081;
    public const int WM_POPUPSYSTEMMENU = 0x313;

    public const int WS_POPUP = unchecked((int)0x80000000);
    public const int WS_THICKFRAME = 0x00040000;
    public const int WS_CAPTION = 0x00C00000;
    public const int WS_SIZEBOX = 0x00040000;
    public const int WS_SYSMENU = 0x80000;
    public const int WS_MINIMIZEBOX = 0x20000;
    public const int WS_MAXIMIZEBOX = 0x10000;
    public const int WS_OVERLAPPED = 0x00000000;
    public const int WS_OVERLAPPEDWINDOW = WS_OVERLAPPED | WS_CAPTION | WS_SYSMENU | WS_THICKFRAME | WS_MINIMIZEBOX | WS_MAXIMIZEBOX;


    public const int SWP_ASYNCWINDOWPOS = 0x4000;
    public const int SWP_DEFERERASE = 0x2000;
    public const int SWP_DRAWFRAME = 0x0020;
    public const int SWP_FRAMECHANGED = 0x0020;
    public const int SWP_HIDEWINDOW = 0x0080;
    public const int SWP_NOACTIVATE = 0x0010;
    public const int SWP_NOCOPYBITS = 0x0100;
    public const int SWP_NOMOVE = 0x0002;
    public const int SWP_NOOWNERZORDER = 0x0200;
    public const int SWP_NOREDRAW = 0x0008;
    public const int SWP_NOREPOSITION = 0x0200;
    public const int SWP_NOSENDCHANGING = 0x0400;
    public const int SWP_NOSIZE = 0x0001;
    public const int SWP_NOZORDER = 0x0004;
    public const int SWP_SHOWWINDOW = 0x0040;

    public const int HWND_TOP = 0;
    public const int HWND_BOTTOM = 1;
    public const int HWND_TOPMOST = -1;
    public const int HWND_NOTOPMOST = -2;

    public const int VK_F8 = 0x77;
    public const int VK_F9 = 0x78;
    public const int VK_F10 = 0x79;
    public const int VK_F11 = 0x7A;


    public const int GWLP_USERDATA = (-21);

    [DllImport("User32.dll")]
    public static extern bool ReleaseCapture();

    [DllImport("User32.dll")]
    public static extern IntPtr SetCapture(IntPtr hWnd);
    [DllImport("user32.dll")]
    public static extern int GetSystemMetrics(int smIndex);
    [DllImport("user32.dll", SetLastError = true)]
    public static extern bool GetWindowRect(IntPtr hwnd, out RECT lpRect);


    [DllImport("user32.dll", EntryPoint = "GetWindowLong")]
    public static extern IntPtr GetWindowLongPtr(IntPtr hWnd, int nIndex);

    public static IntPtr SetWindowLongPtr(HandleRef hWnd, int nIndex, IntPtr dwNewLong)
    {
        if (IntPtr.Size == 8)
            return SetWindowLongPtr64(hWnd, nIndex, dwNewLong);
        else
            return new IntPtr(SetWindowLong32(hWnd, nIndex, dwNewLong.ToInt32()));
    }

    [DllImport("user32.dll", EntryPoint = "SetWindowLong")]
    private static extern int SetWindowLong32(HandleRef hWnd, int nIndex, int dwNewLong);

    [DllImport("user32.dll", EntryPoint = "SetWindowLongPtr")]
    private static extern IntPtr SetWindowLongPtr64(HandleRef hWnd, int nIndex, IntPtr dwNewLong);

    [DllImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int cx, int cy, uint uFlags);

    [DllImport("user32.dll", SetLastError = true)]
    public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
    [DllImport("user32.dll")]
    public static extern IntPtr MonitorFromWindow(IntPtr hwnd, uint dwFlags);

    [DllImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool GetWindowPlacement(IntPtr hWnd, ref WINDOWPLACEMENT lpwndpl);
    [DllImport("user32.dll", CharSet = CharSet.Auto)]
    public static extern bool GetMonitorInfo(IntPtr hMonitor, ref MONITORINFOEX lpmi);

    //[DllImport("user32.dll")]
    //public static extern bool GetMonitorInfo(IntPtr hMonitor, ref MONITORINFO lpmi);

    [DllImport("User32.dll")]
    public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
    [DllImport("dwmapi.dll")]
    public static extern int DwmIsCompositionEnabled(out bool enabled);
    [DllImport("dwmapi.dll")]
    public static extern int DwmExtendFrameIntoClientArea(IntPtr hwnd, ref MARGINS margins);


    [StructLayout(LayoutKind.Sequential)]
    public struct MARGINS
    {
        public int leftWidth;
        public int rightWidth;
        public int topHeight;
        public int bottomHeight;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public struct CREATESTRUCT
    {
        public IntPtr lpCreateParams;
        public IntPtr hInstance;
        public IntPtr hMenu;
        public IntPtr hwndParent;
        public int cy;
        public int cx;
        public int y;
        public int x;
        public int style;
        public IntPtr lpszName;
        public IntPtr lpszClass;
        public int dwExStyle;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct NCCALCSIZE_PARAMS
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public RECT[] rgrc;
        public WINDOWPOS lppos;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct WINDOWPOS
    {
        public IntPtr hwnd;
        public IntPtr hwndInsertAfter;
        public int x;
        public int y;
        public int cx;
        public int cy;
        public uint flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RECT
    {
        public int left;
        public int top;
        public int right;
        public int bottom;
        public RECT(int left, int top, int right, int bottom)
        {
            this.left = left;
            this.top = top;
            this.right = right;
            this.bottom = bottom;
        }
        public RECT(Rectangle r)
        {
            this.left = r.Left;
            this.top = r.Top;
            this.right = r.Right;
            this.bottom = r.Bottom;
        }
        public static RECT FromXYWH(int x, int y, int width, int height)
        {
            return new RECT(x, y, x + width, y + height);
        }
        public Size Size
        {
            get
            {
                return new Size(this.right - this.left, this.bottom - this.top);
            }
        }
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct WINDOWPLACEMENT
    {
        public int length;
        public int flags;
        public int showCmd;
        public System.Drawing.Point ptMinPosition;
        public System.Drawing.Point ptMaxPosition;
        public System.Drawing.Rectangle rcNormalPosition;
    }
    private const int CCHDEVICENAME = 32;

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public struct MONITORINFOEX
    {
        public int Size;
        public RECT Monitor;
        public RECT WorkArea;
        public uint Flags;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CCHDEVICENAME)]
        public string DeviceName;

        public void Init()
        {
            this.Size = 40 + 2 * CCHDEVICENAME;
            this.DeviceName = string.Empty;
        }
    }



    public enum HitTest
    {
        Caption = 2,
        Transparent = -1,
        Nowhere = 0,
        Client = 1,
        Left = 10,
        Right = 11,
        Top = 12,
        TopLeft = 13,
        TopRight = 14,
        Bottom = 15,
        BottomLeft = 16,
        BottomRight = 17,
        Border = 18
    }
    public enum Style
    {
        windowed         = WS_OVERLAPPEDWINDOW | WS_THICKFRAME | WS_CAPTION | WS_SYSMENU /*| WS_MINIMIZEBOX | WS_MAXIMIZEBOX*/,
        aero_borderless  = WS_POPUP            | WS_THICKFRAME | WS_CAPTION | WS_SYSMENU /*| WS_MAXIMIZEBOX | WS_MINIMIZEBOX*/,
        basic_borderless = WS_POPUP            | WS_THICKFRAME              | WS_SYSMENU /*| WS_MAXIMIZEBOX | WS_MINIMIZEBOX*/
    };
    public const UInt32 SW_HIDE = 0;
    public const UInt32 SW_SHOWNORMAL = 1;
    public const UInt32 SW_NORMAL = 1;
    public const UInt32 SW_SHOWMINIMIZED = 2;
    public const UInt32 SW_SHOWMAXIMIZED = 3;
    public const UInt32 SW_MAXIMIZE = 3;
    public const UInt32 SW_SHOWNOACTIVATE = 4;
    public const UInt32 SW_SHOW = 5;
    public const UInt32 SW_MINIMIZE = 6;
    public const UInt32 SW_SHOWMINNOACTIVE = 7;
    public const UInt32 SW_SHOWNA = 8;
    public const UInt32 SW_RESTORE = 9;

    public const int MONITOR_DEFAULTTONULL = 0;
    public const int MONITOR_DEFAULTTOPRIMARY = 1;
    public const int MONITOR_DEFAULTTONEAREST = 2;

    public enum ShowWindowCommands
    {
        /// <summary>
        /// Hides the window and activates another window.
        /// </summary>
        Hide = 0,
        /// <summary>
        /// Activates and displays a window. If the window is minimized or 
        /// maximized, the system restores it to its original size and position.
        /// An application should specify this flag when displaying the window 
        /// for the first time.
        /// </summary>
        Normal = 1,
        /// <summary>
        /// Activates the window and displays it as a minimized window.
        /// </summary>
        ShowMinimized = 2,
        /// <summary>
        /// Maximizes the specified window.
        /// </summary>
        Maximize = 3, // is this the right value?
                      /// <summary>
                      /// Activates the window and displays it as a maximized window.
                      /// </summary>       
        ShowMaximized = 3,
        /// <summary>
        /// Displays a window in its most recent size and position. This value 
        /// is similar to <see cref="Win32.ShowWindowCommand.Normal"/>, except 
        /// the window is not activated.
        /// </summary>
        ShowNoActivate = 4,
        /// <summary>
        /// Activates the window and displays it in its current size and position. 
        /// </summary>
        Show = 5,
        /// <summary>
        /// Minimizes the specified window and activates the next top-level 
        /// window in the Z order.
        /// </summary>
        Minimize = 6,
        /// <summary>
        /// Displays the window as a minimized window. This value is similar to
        /// <see cref="Win32.ShowWindowCommand.ShowMinimized"/>, except the 
        /// window is not activated.
        /// </summary>
        ShowMinNoActive = 7,
        /// <summary>
        /// Displays the window in its current size and position. This value is 
        /// similar to <see cref="Win32.ShowWindowCommand.Show"/>, except the 
        /// window is not activated.
        /// </summary>
        ShowNA = 8,
        /// <summary>
        /// Activates and displays the window. If the window is minimized or 
        /// maximized, the system restores it to its original size and position. 
        /// An application should specify this flag when restoring a minimized window.
        /// </summary>
        Restore = 9,
        /// <summary>
        /// Sets the show state based on the SW_* value specified in the 
        /// STARTUPINFO structure passed to the CreateProcess function by the 
        /// program that started the application.
        /// </summary>
        ShowDefault = 10,
        /// <summary>
        ///  <b>Windows 2000/XP:</b> Minimizes a window, even if the thread 
        /// that owns the window is not responding. This flag should only be 
        /// used when minimizing windows from a different thread.
        /// </summary>
        ForceMinimize = 11
    }
    public const int SM_CXSCREEN            = 0;  // 0x00
    public const int SM_CYSCREEN            = 1;  // 0x01
    public const int SM_CXVSCROLL           = 2;  // 0x02
    public const int SM_CYHSCROLL           = 3;  // 0x03
    public const int SM_CYCAPTION           = 4;  // 0x04
    public const int SM_CXBORDER            = 5;  // 0x05
    public const int SM_CYBORDER            = 6;  // 0x06
    public const int SM_CXDLGFRAME          = 7;  // 0x07
    public const int SM_CXFIXEDFRAME        = 7;  // 0x07
    public const int SM_CYDLGFRAME          = 8;  // 0x08
    public const int SM_CYFIXEDFRAME        = 8;  // 0x08
    public const int SM_CYVTHUMB = 9;  // 0x09
    public const int SM_CXHTHUMB            = 10; // 0x0A
    public const int SM_CXICON              = 11; // 0x0B
    public const int SM_CYICON              = 12; // 0x0C
    public const int SM_CXCURSOR            = 13; // 0x0D
    public const int SM_CYCURSOR            = 14; // 0x0E
    public const int SM_CYMENU              = 15; // 0x0F
    public const int SM_CXFULLSCREEN        = 16; // 0x10
    public const int SM_CYFULLSCREEN = 17; // 0x11
    public const int SM_CYKANJIWINDOW = 18; // 0x12
    public const int SM_MOUSEPRESENT        = 19; // 0x13
    public const int SM_CYVSCROLL           = 20; // 0x14
    public const int SM_CXHSCROLL           = 21; // 0x15
    public const int SM_DEBUG               = 22; // 0x16
    public const int SM_SWAPBUTTON          = 23; // 0x17
    public const int SM_CXMIN               = 28; // 0x1C
    public const int SM_CYMIN               = 29; // 0x1D
    public const int SM_CXSIZE              = 30; // 0x1E
    public const int SM_CYSIZE              = 31; // 0x1F
    public const int SM_CXSIZEFRAME         = 32; // 0x20
    public const int SM_CXFRAME             = 32; // 0x20
    public const int SM_CYSIZEFRAME         = 33; // 0x21
    public const int SM_CYFRAME             = 33; // 0x21
    public const int SM_CXMINTRACK          = 34; // 0x22
    public const int SM_CYMINTRACK          = 35; // 0x23
    public const int SM_CXDOUBLECLK         = 36; // 0x24
    public const int SM_CYDOUBLECLK = 37; // 0x25
    public const int SM_CXICONSPACING           = 38; // 0x26
    public const int SM_CYICONSPACING           = 39; // 0x27
    public const int SM_MENUDROPALIGNMENT       = 40; // 0x28
    public const int SM_PENWINDOWS          = 41; // 0x29
    public const int SM_DBCSENABLED         = 42; // 0x2A
    public const int SM_CMOUSEBUTTONS           = 43; // 0x2B
    public const int SM_SECURE              = 44; // 0x2C
    public const int SM_CXEDGE              = 45; // 0x2D
    public const int SM_CYEDGE              = 46; // 0x2E
    public const int SM_CXMINSPACING        = 47; // 0x2F
    public const int SM_CYMINSPACING        = 48; // 0x30
    public const int SM_CXSMICON            = 49; // 0x31
    public const int SM_CYSMICON            = 50; // 0x32
    public const int SM_CYSMCAPTION         = 51; // 0x33
    public const int SM_CXSMSIZE            = 52; // 0x34
    public const int SM_CYSMSIZE            = 53; // 0x35
    public const int SM_CXMENUSIZE          = 54; // 0x36
    public const int SM_CYMENUSIZE          = 55; // 0x37
    public const int SM_ARRANGE             = 56; // 0x38
    public const int SM_CXMINIMIZED         = 57; // 0x39
    public const int SM_CYMINIMIZED         = 58; // 0x3A
    public const int SM_CXMAXTRACK          = 59; // 0x3B
    public const int SM_CYMAXTRACK          = 60; // 0x3C
    public const int SM_CXMAXIMIZED         = 61; // 0x3D
    public const int SM_CYMAXIMIZED         = 62; // 0x3E
    public const int SM_NETWORK             = 63; // 0x3F
    public const int SM_CLEANBOOT           = 67; // 0x43
    public const int SM_CXDRAG              = 68; // 0x44
    public const int SM_CYDRAG              = 69; // 0x45
    public const int SM_SHOWSOUNDS          = 70; // 0x46
    public const int SM_CXMENUCHECK         = 71; // 0x47
    public const int SM_CYMENUCHECK         = 72; // 0x48
    public const int SM_SLOWMACHINE         = 73; // 0x49
    public const int SM_MIDEASTENABLED          = 74; // 0x4A
    public const int SM_MOUSEWHEELPRESENT       = 75; // 0x4B
    public const int SM_XVIRTUALSCREEN          = 76; // 0x4C
    public const int SM_YVIRTUALSCREEN          = 77; // 0x4D
    public const int SM_CXVIRTUALSCREEN         = 78; // 0x4E
    public const int SM_CYVIRTUALSCREEN         = 79; // 0x4F
    public const int SM_CMONITORS           = 80; // 0x50
    public const int SM_SAMEDISPLAYFORMAT       = 81; // 0x51
    public const int SM_IMMENABLED          = 82; // 0x52
    public const int SM_CXFOCUSBORDER           = 83; // 0x53
    public const int SM_CYFOCUSBORDER           = 84; // 0x54
    public const int SM_TABLETPC            = 86; // 0x56
    public const int SM_MEDIACENTER         = 87; // 0x57
    public const int SM_STARTER             = 88; // 0x58
    public const int SM_SERVERR2            = 89; // 0x59
    public const int SM_MOUSEHORIZONTALWHEELPRESENT = 91; // 0x5B
    public const int SM_CXPADDEDBORDER          = 92; // 0x5C
    public const int SM_DIGITIZER           = 94; // 0x5E
    public const int SM_MAXIMUMTOUCHES          = 95; // 0x5F

    public const int SM_REMOTESESSION           = 0x1000; // 0x1000
    public const int SM_SHUTTINGDOWN        = 0x2000; // 0x2000
    public const int SM_REMOTECONTROL           = 0x2001; // 0x2001


    public const int SM_CONVERTIBLESLATEMODE = 0x2003;
    public const int SM_SYSTEMDOCKED = 0x2004;


}