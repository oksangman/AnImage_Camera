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

    public partial class CapturePanel : UserControl
    {
        List<Control> listControls = new List<Control>();
        public CapturePanel()
        {
            InitializeComponent();

            toolTip.SetToolTip(cbAlwayTop, "Always on top");
            toolTip.SetToolTip(cbVisibleMouse, "Mouse cursor recording");
            toolTip.SetToolTip(btnFPS, "Recording frame per second");
            toolTip.SetToolTip(btnResolution, "Recording window size change");


            listControls.Add(cbAlwayTop);
            listControls.Add(cbVisibleMouse);
            listControls.Add(btnFPS);
            listControls.Add(btnResolution);
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case Win32.WM_NCHITTEST:
                    m.Result = (IntPtr)Win32.HitTest.Transparent;
                    return;
            }
            base.WndProc(ref m);
        }
        private void cbAlwayTop_CheckedChanged(object sender, EventArgs e)
        {
            Form form = (Form)Parent;
            form.TopMost = cbAlwayTop.Checked;
        }

        private void CapturePanel_Resize(object sender, EventArgs e)
        {
            foreach (Control c in listControls)
            {
                if (c.Bounds.IntersectsWith(btnRecord.Bounds))
                {
                    c.Visible = false;
                }
                else
                    c.Visible = true;
            }

            if (btnRecord.Location.X < 3)
            {
                btnRecord.AutoSize = false;
                btnRecord.Width = Width - 3;
            }
            else
            {
                btnRecord.AutoSize = true;
            }
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            if (btnRecord.Checked)
                btnRecord.BackColor = Color.LightGray;
            else
                btnRecord.BackColor = Color.White;
        }
    }
}
