using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnImage_Camera
{
    public class ResolutionButton : DropDownListButton
    {
        ToolStripMenuItem lastCheckItem = null;
        Size _resolution = new Size();
        public ResolutionButton()
        {
            AddToolStripItem(300, 200);
            AddToolStripItem(320, 240);
            AddToolStripItem(400, 300);
            AddToolStripItem(512, 384);
            AddToolStripItem(576, 432);
            AddToolStripItem(640, 360);
            AddToolStripItem(640, 480);
            AddToolStripItem(800, 480);
            AddToolStripItem(800, 600);
            AddToolStripItem(960, 720);
            AddToolStripItem(1024, 768);

            Resolution = new Size(960, 720);

            foreach (ToolStripMenuItem item in menuStrip.Items)
            {
                item.Click += Item_Click;
                Size resolution = (Size)item.Tag;
                if (resolution == Resolution)
                {
                    item.Checked = true;
                    lastCheckItem = item;
                }
            }
        }

        void AddToolStripItem(int width, int height)
        {
            var item = menuStrip.Items.Add($"{width}x{height}");
            item.Tag = new Size(width, height);
        }

        private void Item_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            Size resolution = (Size)item.Tag;
            Resolution = resolution;

            item.Checked = true;
            lastCheckItem.Checked = false;
            lastCheckItem = item;
        }

        public Size Resolution
        {
            get => _resolution;
            set
            {
                _resolution = value;
                Text = $"{_resolution.Width} x {_resolution.Height}   ·";
            }
        }
    }
}
