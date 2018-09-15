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
    public partial class Form1 : BorderlessForm
    {
        public Form1()
        {
            InitializeComponent();
            Borderless = true;
            Borderless_shadow = true;
            Borderless_drag = true;
            Borderless_resize = true;
        }
    }
}
