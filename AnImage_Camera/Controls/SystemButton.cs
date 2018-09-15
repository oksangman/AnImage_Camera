using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace AnImage_Camera
{
    public class SystemButton : Button
    {
        private Image normal = null;
        private Image mouseOver = null;

        bool IsMouseOver = false;

        public SystemButton()
        {
            SetStyle(ControlStyles.Selectable, false);
            TabStop = false;
        }

        [DefaultValue(null)]
        [Category("Custom")]
        public Image Normal
        {
            get => normal;
            set
            {
                normal = value;
                if (!IsMouseOver)
                    Image = normal;
            }
        }
        [DefaultValue(null)]
        [Category("Custom")]
        public Image MouseOver
        {
            get => mouseOver;
            set
            {
                mouseOver = value;
                if (IsMouseOver)
                    Image = mouseOver;
            }
        }


    }
}
