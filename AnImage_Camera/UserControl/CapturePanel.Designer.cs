namespace AnImage_Camera
{
    partial class CapturePanel
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CapturePanel));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRecord = new AnImage_Camera.CheckButton();
            this.cbAlwayTop = new System.Windows.Forms.CheckBox();
            this.cbVisibleMouse = new System.Windows.Forms.CheckBox();
            this.btnFPS = new AnImage_Camera.FPSButton();
            this.btnResolution = new AnImage_Camera.ResolutionButton();
            this.pbCapture = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCapture)).BeginInit();
            this.SuspendLayout();
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 1;
            this.toolTip.ReshowDelay = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btnRecord, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbAlwayTop, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbVisibleMouse, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnFPS, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnResolution, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(437, 32);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // btnRecord
            // 
            this.btnRecord.AutoSize = true;
            this.btnRecord.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRecord.Checked = false;
            this.btnRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRecord.FlatAppearance.BorderSize = 0;
            this.btnRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecord.Image = ((System.Drawing.Image)(resources.GetObject("btnRecord.Image")));
            this.btnRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecord.Location = new System.Drawing.Point(335, 3);
            this.btnRecord.MaximumSize = new System.Drawing.Size(100, 26);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(99, 26);
            this.btnRecord.TabIndex = 9;
            this.btnRecord.TabStop = false;
            this.btnRecord.Text = "    Record start";
            this.btnRecord.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // cbAlwayTop
            // 
            this.cbAlwayTop.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbAlwayTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbAlwayTop.Image = global::AnImage_Camera.Properties.Resources.pin;
            this.cbAlwayTop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbAlwayTop.Location = new System.Drawing.Point(3, 3);
            this.cbAlwayTop.Name = "cbAlwayTop";
            this.cbAlwayTop.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbAlwayTop.Size = new System.Drawing.Size(40, 26);
            this.cbAlwayTop.TabIndex = 2;
            this.cbAlwayTop.Text = "            ";
            this.cbAlwayTop.UseVisualStyleBackColor = true;
            this.cbAlwayTop.CheckedChanged += new System.EventHandler(this.cbAlwayTop_CheckedChanged);
            // 
            // cbVisibleMouse
            // 
            this.cbVisibleMouse.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbVisibleMouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbVisibleMouse.Image = ((System.Drawing.Image)(resources.GetObject("cbVisibleMouse.Image")));
            this.cbVisibleMouse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbVisibleMouse.Location = new System.Drawing.Point(49, 3);
            this.cbVisibleMouse.Name = "cbVisibleMouse";
            this.cbVisibleMouse.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbVisibleMouse.Size = new System.Drawing.Size(38, 26);
            this.cbVisibleMouse.TabIndex = 3;
            this.cbVisibleMouse.Text = "            ";
            this.cbVisibleMouse.UseVisualStyleBackColor = true;
            // 
            // btnFPS
            // 
            this.btnFPS.AutoSize = true;
            this.btnFPS.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFPS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFPS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFPS.FPS = 20;
            this.btnFPS.Image = ((System.Drawing.Image)(resources.GetObject("btnFPS.Image")));
            this.btnFPS.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnFPS.Location = new System.Drawing.Point(93, 3);
            this.btnFPS.Name = "btnFPS";
            this.btnFPS.Size = new System.Drawing.Size(71, 26);
            this.btnFPS.TabIndex = 7;
            this.btnFPS.Text = "FPS 20   ·";
            this.btnFPS.UseVisualStyleBackColor = true;
            // 
            // btnResolution
            // 
            this.btnResolution.AutoSize = true;
            this.btnResolution.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnResolution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnResolution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResolution.Image = ((System.Drawing.Image)(resources.GetObject("btnResolution.Image")));
            this.btnResolution.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnResolution.Location = new System.Drawing.Point(170, 3);
            this.btnResolution.Name = "btnResolution";
            this.btnResolution.Resolution = new System.Drawing.Size(960, 720);
            this.btnResolution.Size = new System.Drawing.Size(83, 26);
            this.btnResolution.TabIndex = 8;
            this.btnResolution.Text = "960 x 720   ·";
            this.btnResolution.UseVisualStyleBackColor = true;
            // 
            // pbCapture
            // 
            this.pbCapture.BackColor = System.Drawing.Color.Magenta;
            this.pbCapture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbCapture.Location = new System.Drawing.Point(4, 32);
            this.pbCapture.Name = "pbCapture";
            this.pbCapture.Size = new System.Drawing.Size(437, 581);
            this.pbCapture.TabIndex = 0;
            this.pbCapture.TabStop = false;
            // 
            // CapturePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbCapture);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CapturePanel";
            this.Padding = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.Size = new System.Drawing.Size(445, 617);
            this.Resize += new System.EventHandler(this.CapturePanel_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCapture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCapture;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.CheckBox cbAlwayTop;
        public System.Windows.Forms.CheckBox cbVisibleMouse;
        public FPSButton btnFPS;
        public ResolutionButton btnResolution;
        public CheckButton btnRecord;
    }
}
