namespace AnImage_Camera
{
    partial class Form1
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbCaption = new AnImage_Camera.TitleBar();
            this.cpMain = new AnImage_Camera.CapturePanel();
            this.SuspendLayout();
            // 
            // lbCaption
            // 
            this.lbCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbCaption.Location = new System.Drawing.Point(0, 0);
            this.lbCaption.MinimumSize = new System.Drawing.Size(1, 1);
            this.lbCaption.Name = "lbCaption";
            this.lbCaption.Size = new System.Drawing.Size(433, 31);
            this.lbCaption.TabIndex = 0;
            // 
            // cpMain
            // 
            this.cpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpMain.Location = new System.Drawing.Point(0, 31);
            this.cpMain.Name = "cpMain";
            this.cpMain.Padding = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.cpMain.Size = new System.Drawing.Size(433, 455);
            this.cpMain.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(433, 486);
            this.Controls.Add(this.cpMain);
            this.Controls.Add(this.lbCaption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(16, 39);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Magenta;
            this.ResumeLayout(false);

        }

        #endregion

        private TitleBar lbCaption;
        private CapturePanel cpMain;
    }
}

