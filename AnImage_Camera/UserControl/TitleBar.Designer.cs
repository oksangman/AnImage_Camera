namespace AnImage_Camera
{
    partial class TitleBar
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
            this.pcIcon = new System.Windows.Forms.PictureBox();
            this.lbCaption = new AnImage_Camera.NonClickLabel();
            this.btnMinimize = new AnImage_Camera.SystemButton();
            this.btnMaximize = new AnImage_Camera.SystemButton();
            this.btnClose = new AnImage_Camera.SystemButton();
            ((System.ComponentModel.ISupportInitialize)(this.pcIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pcIcon
            // 
            this.pcIcon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pcIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcIcon.Image = global::AnImage_Camera.Properties.Resources.camera_icon3;
            this.pcIcon.Location = new System.Drawing.Point(0, 0);
            this.pcIcon.Name = "pcIcon";
            this.pcIcon.Size = new System.Drawing.Size(30, 30);
            this.pcIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcIcon.TabIndex = 8;
            this.pcIcon.TabStop = false;
            this.pcIcon.Click += new System.EventHandler(this.pcIcon_Click);
            this.pcIcon.DoubleClick += new System.EventHandler(this.pcIcon_DoubleClick);
            // 
            // lbCaption
            // 
            this.lbCaption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCaption.AutoEllipsis = true;
            this.lbCaption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbCaption.Font = new System.Drawing.Font("굴림", 9F);
            this.lbCaption.Location = new System.Drawing.Point(35, 9);
            this.lbCaption.Name = "lbCaption";
            this.lbCaption.Size = new System.Drawing.Size(564, 12);
            this.lbCaption.TabIndex = 9;
            this.lbCaption.Text = "AnImage_Camera";
            this.lbCaption.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lbCaption.UseMnemonic = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::AnImage_Camera.Properties.Resources.btn_minimize;
            this.btnMinimize.Location = new System.Drawing.Point(605, 0);
            this.btnMinimize.MouseOver = global::AnImage_Camera.Properties.Resources.btn_minimize;
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Normal = global::AnImage_Camera.Properties.Resources.btn_minimize;
            this.btnMinimize.Size = new System.Drawing.Size(35, 30);
            this.btnMinimize.TabIndex = 7;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = global::AnImage_Camera.Properties.Resources.btn_maximize;
            this.btnMaximize.Location = new System.Drawing.Point(641, 0);
            this.btnMaximize.MouseOver = global::AnImage_Camera.Properties.Resources.btn_maximize;
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Normal = global::AnImage_Camera.Properties.Resources.btn_maximize;
            this.btnMaximize.Size = new System.Drawing.Size(35, 30);
            this.btnMaximize.TabIndex = 6;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::AnImage_Camera.Properties.Resources.btn_close;
            this.btnClose.Location = new System.Drawing.Point(677, 0);
            this.btnClose.MouseOver = global::AnImage_Camera.Properties.Resources.btn_close_over;
            this.btnClose.Name = "btnClose";
            this.btnClose.Normal = global::AnImage_Camera.Properties.Resources.btn_close;
            this.btnClose.Size = new System.Drawing.Size(46, 30);
            this.btnClose.TabIndex = 5;
            this.btnClose.TabStop = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // TitleBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbCaption);
            this.Controls.Add(this.pcIcon);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnMaximize);
            this.Controls.Add(this.btnClose);
            this.MinimumSize = new System.Drawing.Size(1, 1);
            this.Name = "TitleBar";
            this.Size = new System.Drawing.Size(723, 30);
            this.Resize += new System.EventHandler(this.TitleBar_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pcIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private NonClickLabel lbCaption;
        private System.Windows.Forms.PictureBox pcIcon;
        private SystemButton btnMinimize;
        private SystemButton btnMaximize;
        private SystemButton btnClose;
    }
}
