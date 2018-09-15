using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnImage_Camera
{
    public class CheckButton : Button
    {
        private bool _checked;

        public CheckButton()
        {
            Checked = false;
            Click += CheckButton_Click;
            TabStop = false;
            SetStyle(ControlStyles.Selectable, false);

            ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            Checked = !Checked;
        }

        public bool Checked
        {
            get => _checked;
            set
            {
                _checked = value;
                if (_checked)
                { 
                    Image = global::AnImage_Camera.Properties.Resources.Record_Pressed;
                    Text = "    Record stop";
                }
                else
                { 
                    Image = global::AnImage_Camera.Properties.Resources.Record_Normal;
                    Text = "    Record start";
                }
            }
        }
    }
}
