namespace QuanLyDaiLy
{
    partial class MuaHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MuaHang));
            this.pnlMatHang = new System.Windows.Forms.Panel();
            this.pnlGiaoDich = new System.Windows.Forms.Panel();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.cbMatHang = new System.Windows.Forms.ComboBox();
            this.btnXuatHang = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.gvHang = new System.Windows.Forms.DataGridView();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.nbSoLuong = new System.Windows.Forms.NumericUpDown();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.pnlMatHang.SuspendLayout();
            this.pnlGiaoDich.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMatHang
            // 
            this.pnlMatHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnlMatHang.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMatHang.Controls.Add(this.pnlGiaoDich);
            this.pnlMatHang.Location = new System.Drawing.Point(3, 0);
            this.pnlMatHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlMatHang.Name = "pnlMatHang";
            this.pnlMatHang.Size = new System.Drawing.Size(909, 655);
            this.pnlMatHang.TabIndex = 0;
            // 
            // pnlGiaoDich
            // 
            this.pnlGiaoDich.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGiaoDich.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlGiaoDich.Controls.Add(this.btnXoa);
            this.pnlGiaoDich.Controls.Add(this.cbMatHang);
            this.pnlGiaoDich.Controls.Add(this.btnXuatHang);
            this.pnlGiaoDich.Controls.Add(this.btnThem);
            this.pnlGiaoDich.Controls.Add(this.gvHang);
            this.pnlGiaoDich.Controls.Add(this.txtThanhTien);
            this.pnlGiaoDich.Controls.Add(this.labelControl6);
            this.pnlGiaoDich.Controls.Add(this.labelControl2);
            this.pnlGiaoDich.Controls.Add(this.txtDonGia);
            this.pnlGiaoDich.Controls.Add(this.labelControl1);
            this.pnlGiaoDich.Controls.Add(this.labelControl4);
            this.pnlGiaoDich.Controls.Add(this.txtDonViTinh);
            this.pnlGiaoDich.Controls.Add(this.nbSoLuong);
            this.pnlGiaoDich.Controls.Add(this.labelControl3);
            this.pnlGiaoDich.Location = new System.Drawing.Point(3, 4);
            this.pnlGiaoDich.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlGiaoDich.Name = "pnlGiaoDich";
            this.pnlGiaoDich.Size = new System.Drawing.Size(902, 647);
            this.pnlGiaoDich.TabIndex = 11;
            this.pnlGiaoDich.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGiaoDich_Paint);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(698, 188);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(138, 79);
            this.btnXoa.TabIndex = 28;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // cbMatHang
            // 
            this.cbMatHang.Font = new System.Drawing.Font("Tahoma", 15F);
            this.cbMatHang.FormattingEnabled = true;
            this.cbMatHang.Location = new System.Drawing.Point(169, 42);
            this.cbMatHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbMatHang.Name = "cbMatHang";
            this.cbMatHang.Size = new System.Drawing.Size(241, 38);
            this.cbMatHang.TabIndex = 27;
            this.cbMatHang.SelectedIndexChanged += new System.EventHandler(this.cbMatHang_SelectedIndexChanged_1);
            // 
            // btnXuatHang
            // 
            this.btnXuatHang.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnXuatHang.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnXuatHang.Appearance.Options.UseFont = true;
            this.btnXuatHang.Appearance.Options.UseForeColor = true;
            this.btnXuatHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatHang.ImageOptions.Image")));
            this.btnXuatHang.Location = new System.Drawing.Point(322, 545);
            this.btnXuatHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXuatHang.Name = "btnXuatHang";
            this.btnXuatHang.Size = new System.Drawing.Size(271, 75);
            this.btnXuatHang.TabIndex = 26;
            this.btnXuatHang.Text = "Lập phiếu xuất hàng";
            this.btnXuatHang.Click += new System.EventHandler(this.btnXuatHang_Click_1);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnThem.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.Appearance.Options.UseForeColor = true;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(522, 188);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(133, 79);
            this.btnThem.TabIndex = 25;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // gvHang
            // 
            this.gvHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvHang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvHang.Location = new System.Drawing.Point(71, 295);
            this.gvHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gvHang.Name = "gvHang";
            this.gvHang.RowHeadersWidth = 51;
            this.gvHang.Size = new System.Drawing.Size(775, 213);
            this.gvHang.TabIndex = 24;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtThanhTien.Location = new System.Drawing.Point(624, 110);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(241, 38);
            this.txtThanhTien.TabIndex = 23;
            this.txtThanhTien.TextChanged += new System.EventHandler(this.txtThanhTien_TextChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(481, 110);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(119, 30);
            this.labelControl6.TabIndex = 22;
            this.labelControl6.Text = "Thành tiền";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(481, 41);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(99, 30);
            this.labelControl2.TabIndex = 16;
            this.labelControl2.Text = "Số lượng";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtDonGia.Location = new System.Drawing.Point(169, 113);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(241, 38);
            this.txtDonGia.TabIndex = 21;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(3, 41);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(103, 30);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "Mặt hàng";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(3, 188);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(121, 30);
            this.labelControl4.TabIndex = 18;
            this.labelControl4.Text = "Đơn vị tính";
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtDonViTinh.Location = new System.Drawing.Point(169, 190);
            this.txtDonViTinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(241, 38);
            this.txtDonViTinh.TabIndex = 20;
            // 
            // nbSoLuong
            // 
            this.nbSoLuong.Font = new System.Drawing.Font("Tahoma", 15F);
            this.nbSoLuong.Location = new System.Drawing.Point(624, 46);
            this.nbSoLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nbSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbSoLuong.Name = "nbSoLuong";
            this.nbSoLuong.Size = new System.Drawing.Size(84, 38);
            this.nbSoLuong.TabIndex = 19;
            this.nbSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbSoLuong.ValueChanged += new System.EventHandler(this.nbSoLuong_ValueChanged_1);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(3, 113);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(86, 30);
            this.labelControl3.TabIndex = 17;
            this.labelControl3.Text = "Đơn giá";
            // 
            // MuaHang
            // 
            this.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.pnlMatHang);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MuaHang";
            this.Size = new System.Drawing.Size(916, 655);
            this.pnlMatHang.ResumeLayout(false);
            this.pnlGiaoDich.ResumeLayout(false);
            this.pnlGiaoDich.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbSoLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMatHang;
        private System.Windows.Forms.Panel pnlGiaoDich;
        private System.Windows.Forms.ComboBox cbMatHang;
        private DevExpress.XtraEditors.SimpleButton btnXuatHang;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.DataGridView gvHang;
        private System.Windows.Forms.TextBox txtThanhTien;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txtDonGia;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.NumericUpDown nbSoLuong;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
    }
}
