using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnImage_Camera
{
    public class DropDownListButton : Button
    {
        public ContextMenuStrip menuStrip;
        public DropDownListButton()
        {
            menuStrip = new ContextMenuStrip();
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;

            FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            FlatAppearance.MouseDownBackColor = BackColor;
            FlatAppearance.MouseOverBackColor = BackColor;
            Image = global::AnImage_Camera.Properties.Resources.arrow_down2_over;
            ImageAlign = ContentAlignment.BottomRight;

            Click += DropDownListButton_Click;
            MouseEnter += DropDownListButton_MouseEnter;
            MouseLeave += DropDownListButton_MouseLeave;
        }

        Point pt = Point.Empty;
        private void DropDownListButton_Click(object sender, EventArgs e)
        {
            if (pt == Point.Empty)
                pt = new System.Drawing.Point(0, Height);
            menuStrip.Show(this, pt);
        }

        private void DropDownListButton_MouseEnter(object sender, EventArgs e)
        {
            Image = global::AnImage_Camera.Properties.Resources.arrow_down2;
        }

        private void DropDownListButton_MouseLeave(object sender, EventArgs e)
        {
            Image = global::AnImage_Camera.Properties.Resources.arrow_down2_over;
        }
    }
}
