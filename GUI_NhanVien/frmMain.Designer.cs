namespace GUI_NhanVien
{
    partial class frmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tChuongTrinh = new System.Windows.Forms.ToolStripMenuItem();
            this.tDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.tChucVu = new System.Windows.Forms.ToolStripMenuItem();
            this.tNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.tNghiepVu = new System.Windows.Forms.ToolStripMenuItem();
            this.tQuaTrinhLuong = new System.Windows.Forms.ToolStripMenuItem();
            this.tBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.tGiupDo = new System.Windows.Forms.ToolStripMenuItem();
            this.tHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.tDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.tDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.tTao = new System.Windows.Forms.ToolStripMenuItem();
            this.tDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.tThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sttNguoiDung = new System.Windows.Forms.ToolStripStatusLabel();
            this.sttThoiGian = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tChuongTrinh,
            this.tDanhMuc,
            this.tNghiepVu,
            this.tBaoCao,
            this.tGiupDo,
            this.tHeThong});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(694, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tChuongTrinh
            // 
            this.tChuongTrinh.Enabled = false;
            this.tChuongTrinh.Name = "tChuongTrinh";
            this.tChuongTrinh.Size = new System.Drawing.Size(107, 24);
            this.tChuongTrinh.Text = "Chương trình";
            // 
            // tDanhMuc
            // 
            this.tDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tChucVu,
            this.tNhanVien});
            this.tDanhMuc.Enabled = false;
            this.tDanhMuc.Name = "tDanhMuc";
            this.tDanhMuc.Size = new System.Drawing.Size(88, 24);
            this.tDanhMuc.Text = "Danh mục";
            // 
            // tChucVu
            // 
            this.tChucVu.Name = "tChucVu";
            this.tChucVu.Size = new System.Drawing.Size(152, 26);
            this.tChucVu.Text = "Chức Vụ";
            this.tChucVu.Click += new System.EventHandler(this.tChucVu_Click);
            // 
            // tNhanVien
            // 
            this.tNhanVien.Name = "tNhanVien";
            this.tNhanVien.Size = new System.Drawing.Size(152, 26);
            this.tNhanVien.Text = "Nhân Viên";
            this.tNhanVien.Click += new System.EventHandler(this.tNhanVien_Click);
            // 
            // tNghiepVu
            // 
            this.tNghiepVu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tQuaTrinhLuong});
            this.tNghiepVu.Enabled = false;
            this.tNghiepVu.Name = "tNghiepVu";
            this.tNghiepVu.Size = new System.Drawing.Size(91, 24);
            this.tNghiepVu.Text = "Nghiệp Vụ";
            // 
            // tQuaTrinhLuong
            // 
            this.tQuaTrinhLuong.Name = "tQuaTrinhLuong";
            this.tQuaTrinhLuong.Size = new System.Drawing.Size(193, 26);
            this.tQuaTrinhLuong.Text = "Quá Trình Lương";
            this.tQuaTrinhLuong.Click += new System.EventHandler(this.tQuaTrinhLuong_Click);
            // 
            // tBaoCao
            // 
            this.tBaoCao.Enabled = false;
            this.tBaoCao.Name = "tBaoCao";
            this.tBaoCao.Size = new System.Drawing.Size(77, 24);
            this.tBaoCao.Text = "Báo Cáo";
            // 
            // tGiupDo
            // 
            this.tGiupDo.Enabled = false;
            this.tGiupDo.Name = "tGiupDo";
            this.tGiupDo.Size = new System.Drawing.Size(76, 24);
            this.tGiupDo.Text = "Giúp Đỡ";
            // 
            // tHeThong
            // 
            this.tHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tDangNhap,
            this.tDoiMatKhau,
            this.tTao,
            this.tDangXuat,
            this.tThoat});
            this.tHeThong.Name = "tHeThong";
            this.tHeThong.Size = new System.Drawing.Size(86, 24);
            this.tHeThong.Text = "Hệ Thống";
            // 
            // tDangNhap
            // 
            this.tDangNhap.Name = "tDangNhap";
            this.tDangNhap.Size = new System.Drawing.Size(175, 26);
            this.tDangNhap.Text = "Đăng Nhập";
            this.tDangNhap.Click += new System.EventHandler(this.tDangNhap_Click);
            // 
            // tDoiMatKhau
            // 
            this.tDoiMatKhau.Enabled = false;
            this.tDoiMatKhau.Name = "tDoiMatKhau";
            this.tDoiMatKhau.Size = new System.Drawing.Size(175, 26);
            this.tDoiMatKhau.Text = "Đổi Mật Khẩu";
            this.tDoiMatKhau.Click += new System.EventHandler(this.tDoiMatKhau_Click);
            // 
            // tTao
            // 
            this.tTao.Name = "tTao";
            this.tTao.Size = new System.Drawing.Size(175, 26);
            this.tTao.Text = "Tạo Mới";
            this.tTao.Click += new System.EventHandler(this.tTao_Click);
            // 
            // tDangXuat
            // 
            this.tDangXuat.Enabled = false;
            this.tDangXuat.Name = "tDangXuat";
            this.tDangXuat.Size = new System.Drawing.Size(175, 26);
            this.tDangXuat.Text = "Đăng Xuất";
            this.tDangXuat.Click += new System.EventHandler(this.tDangXuat_Click);
            // 
            // tThoat
            // 
            this.tThoat.Name = "tThoat";
            this.tThoat.Size = new System.Drawing.Size(175, 26);
            this.tThoat.Text = "Thoát";
            this.tThoat.Click += new System.EventHandler(this.tThoat_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sttNguoiDung,
            this.sttThoiGian});
            this.statusStrip1.Location = new System.Drawing.Point(0, 513);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(694, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sttNguoiDung
            // 
            this.sttNguoiDung.Name = "sttNguoiDung";
            this.sttNguoiDung.Size = new System.Drawing.Size(123, 20);
            this.sttNguoiDung.Text = "Chưa Đăng Nhập";
            // 
            // sttThoiGian
            // 
            this.sttThoiGian.Name = "sttThoiGian";
            this.sttThoiGian.Size = new System.Drawing.Size(72, 20);
            this.sttThoiGian.Text = "Thời Gian";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI_NhanVien.Properties.Resources.logo_transparent1;
            this.pictureBox1.Location = new System.Drawing.Point(71, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(520, 404);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 538);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lí Nhân Viên";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tChuongTrinh;
        private System.Windows.Forms.ToolStripMenuItem tDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem tChucVu;
        private System.Windows.Forms.ToolStripMenuItem tNhanVien;
        private System.Windows.Forms.ToolStripMenuItem tNghiepVu;
        private System.Windows.Forms.ToolStripMenuItem tBaoCao;
        private System.Windows.Forms.ToolStripMenuItem tGiupDo;
        private System.Windows.Forms.ToolStripMenuItem tHeThong;
        private System.Windows.Forms.ToolStripMenuItem tDangNhap;
        private System.Windows.Forms.ToolStripMenuItem tDoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem tTao;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sttNguoiDung;
        private System.Windows.Forms.ToolStripStatusLabel sttThoiGian;
        private System.Windows.Forms.ToolStripMenuItem tQuaTrinhLuong;
        private System.Windows.Forms.ToolStripMenuItem tDangXuat;
        private System.Windows.Forms.ToolStripMenuItem tThoat;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

