namespace QuanLyDaiLy
{
    partial class QuyChe
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuyChe));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlQuyChe = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnToChuc = new DevExpress.XtraEditors.SimpleButton();
            this.btnQDTienNo = new DevExpress.XtraEditors.SimpleButton();
            this.btnQDMatHang = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.pnlQuyChe);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(946, 642);
            this.panel1.TabIndex = 0;
            // 
            // pnlQuyChe
            // 
            this.pnlQuyChe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlQuyChe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlQuyChe.Location = new System.Drawing.Point(239, 4);
            this.pnlQuyChe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlQuyChe.Name = "pnlQuyChe";
            this.pnlQuyChe.Size = new System.Drawing.Size(703, 635);
            this.pnlQuyChe.TabIndex = 3;
            this.pnlQuyChe.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlQuyChe_Paint);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.btnToChuc);
            this.panel2.Controls.Add(this.btnQDTienNo);
            this.panel2.Controls.Add(this.btnQDMatHang);
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 639);
            this.panel2.TabIndex = 2;
            // 
            // btnToChuc
            // 
            this.btnToChuc.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnToChuc.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnToChuc.Appearance.Options.UseFont = true;
            this.btnToChuc.Appearance.Options.UseForeColor = true;
            this.btnToChuc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnToChuc.ImageOptions.Image")));
            this.btnToChuc.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnToChuc.Location = new System.Drawing.Point(5, 437);
            this.btnToChuc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnToChuc.Name = "btnToChuc";
            this.btnToChuc.Size = new System.Drawing.Size(225, 177);
            this.btnToChuc.TabIndex = 2;
            this.btnToChuc.Text = "Quy chế tổ chức";
            this.btnToChuc.Click += new System.EventHandler(this.btnToChuc_Click);
            // 
            // btnQDTienNo
            // 
            this.btnQDTienNo.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnQDTienNo.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnQDTienNo.Appearance.Options.UseFont = true;
            this.btnQDTienNo.Appearance.Options.UseForeColor = true;
            this.btnQDTienNo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQDTienNo.ImageOptions.Image")));
            this.btnQDTienNo.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnQDTienNo.Location = new System.Drawing.Point(5, 4);
            this.btnQDTienNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQDTienNo.Name = "btnQDTienNo";
            this.btnQDTienNo.Size = new System.Drawing.Size(225, 170);
            this.btnQDTienNo.TabIndex = 0;
            this.btnQDTienNo.Text = "Quy định tiền nợ";
            this.btnQDTienNo.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnQDMatHang
            // 
            this.btnQDMatHang.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnQDMatHang.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnQDMatHang.Appearance.Options.UseFont = true;
            this.btnQDMatHang.Appearance.Options.UseForeColor = true;
            this.btnQDMatHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQDMatHang.ImageOptions.Image")));
            this.btnQDMatHang.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnQDMatHang.Location = new System.Drawing.Point(5, 233);
            this.btnQDMatHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQDMatHang.Name = "btnQDMatHang";
            this.btnQDMatHang.Size = new System.Drawing.Size(225, 176);
            this.btnQDMatHang.TabIndex = 1;
            this.btnQDMatHang.Text = "Quy định mặt hàng";
            this.btnQDMatHang.Click += new System.EventHandler(this.btnQDMatHang_Click);
            // 
            // QuyChe
            // 
            this.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "QuyChe";
            this.Size = new System.Drawing.Size(950, 646);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnToChuc;
        private DevExpress.XtraEditors.SimpleButton btnQDMatHang;
        private DevExpress.XtraEditors.SimpleButton btnQDTienNo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlQuyChe;
    }
}
