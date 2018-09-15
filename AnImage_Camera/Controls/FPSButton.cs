using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnImage_Camera
{
    public class FPSButton : DropDownListButton
    {
        ToolStripMenuItem lastCheckItem = null;
        int _fps;
        public FPSButton()
        {
            _fps = 0;

            AddToolStripItem(1);
            AddToolStripItem(5);
            AddToolStripItem(10);
            AddToolStripItem(15);
            AddToolStripItem(20);
            AddToolStripItem(25);
            AddToolStripItem(30);
            AddToolStripItem(33);
            AddToolStripItem(50);

            foreach (ToolStripMenuItem item in menuStrip.Items)
            {
                item.Click += Item_Click;
                int fps = (int)item.Tag;
                if (fps == 20)
                {
                    FPS = fps;
                    item.Checked = true;
                    lastCheckItem = item;
                }
            }
        }

        void AddToolStripItem(int fps)
        {
            var item = menuStrip.Items.Add(fps.ToString());
            item.Tag = fps;
        }

        private void Item_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            int fps = (int)item.Tag;
            FPS = fps;

            item.Checked = true;
            lastCheckItem.Checked = false;
            lastCheckItem = item;
        }

        public int FPS
        {
            get => _fps;
            set
            {
                _fps = value;
                if (_fps < 1)
                    _fps = 1;
                if (_fps > 100)
                    _fps = 100;
                Text = $"FPS {_fps}   ·";
            }
        }
    }
}
