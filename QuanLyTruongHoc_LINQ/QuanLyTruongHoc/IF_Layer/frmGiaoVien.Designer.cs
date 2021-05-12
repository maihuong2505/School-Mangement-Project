namespace QuanLyTruongHoc.IF_Layer
{
    partial class frmGiaoVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiaoVien));
            this.label1 = new System.Windows.Forms.Label();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSuaThongTin = new System.Windows.Forms.Button();
            this.btnSuaDangNhap = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.ptbInfo = new System.Windows.Forms.PictureBox();
            this.btnDanhSachLop = new System.Windows.Forms.Button();
            this.btnKeHoach = new System.Windows.Forms.Button();
            this.btnHuongDan = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblMaGV = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblMon = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblDienThoai = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.OrangeRed;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(362, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(664, 73);
            this.label1.TabIndex = 7;
            this.label1.Text = "QUẢN LÝ HỌC SINH";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.Brown;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Location = new System.Drawing.Point(1245, 100);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(2);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(124, 34);
            this.btnDangXuat.TabIndex = 6;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.BtnDangXuat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.OrangeRed;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1372, 120);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnSuaThongTin
            // 
            this.btnSuaThongTin.BackColor = System.Drawing.Color.White;
            this.btnSuaThongTin.Cursor = System.Windows.Forms.Cursors.No;
            this.btnSuaThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSuaThongTin.Location = new System.Drawing.Point(497, 586);
            this.btnSuaThongTin.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaThongTin.Name = "btnSuaThongTin";
            this.btnSuaThongTin.Size = new System.Drawing.Size(166, 28);
            this.btnSuaThongTin.TabIndex = 65;
            this.btnSuaThongTin.Text = "Chỉnh sửa thông tin cá nhân";
            this.btnSuaThongTin.UseVisualStyleBackColor = false;
            this.btnSuaThongTin.Click += new System.EventHandler(this.BtnSuaThongTin_Click);
            // 
            // btnSuaDangNhap
            // 
            this.btnSuaDangNhap.BackColor = System.Drawing.Color.White;
            this.btnSuaDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSuaDangNhap.Location = new System.Drawing.Point(186, 586);
            this.btnSuaDangNhap.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaDangNhap.Name = "btnSuaDangNhap";
            this.btnSuaDangNhap.Size = new System.Drawing.Size(185, 28);
            this.btnSuaDangNhap.TabIndex = 64;
            this.btnSuaDangNhap.Text = "Chỉnh sửa thông tin đăng nhập";
            this.btnSuaDangNhap.UseVisualStyleBackColor = false;
            this.btnSuaDangNhap.Click += new System.EventHandler(this.BtnSuaDangNhap_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(234, 460);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 61;
            this.label5.Text = "Địa chỉ: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(560, 410);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 59;
            this.label7.Text = "SĐT: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(234, 410);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 57;
            this.label4.Text = "Mã GV: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(528, 360);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 55;
            this.label6.Text = "Giới tính: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(212, 310);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "Họ và tên: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(211, 360);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = "Ngày sinh: ";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblInfo.Location = new System.Drawing.Point(274, 233);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(326, 39);
            this.lblInfo.TabIndex = 49;
            this.lblInfo.Text = "Thông tin giáo viên";
            // 
            // ptbInfo
            // 
            this.ptbInfo.Location = new System.Drawing.Point(66, 211);
            this.ptbInfo.Margin = new System.Windows.Forms.Padding(2);
            this.ptbInfo.Name = "ptbInfo";
            this.ptbInfo.Size = new System.Drawing.Size(719, 438);
            this.ptbInfo.TabIndex = 48;
            this.ptbInfo.TabStop = false;
            // 
            // btnDanhSachLop
            // 
            this.btnDanhSachLop.BackColor = System.Drawing.Color.Brown;
            this.btnDanhSachLop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDanhSachLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSachLop.ForeColor = System.Drawing.Color.White;
            this.btnDanhSachLop.Location = new System.Drawing.Point(853, 353);
            this.btnDanhSachLop.Margin = new System.Windows.Forms.Padding(2);
            this.btnDanhSachLop.Name = "btnDanhSachLop";
            this.btnDanhSachLop.Size = new System.Drawing.Size(200, 75);
            this.btnDanhSachLop.TabIndex = 72;
            this.btnDanhSachLop.Text = "Danh sách các lớp";
            this.btnDanhSachLop.UseVisualStyleBackColor = false;
            this.btnDanhSachLop.Click += new System.EventHandler(this.BtnDanhSachLop_Click);
            // 
            // btnKeHoach
            // 
            this.btnKeHoach.BackColor = System.Drawing.Color.Brown;
            this.btnKeHoach.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKeHoach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeHoach.ForeColor = System.Drawing.Color.White;
            this.btnKeHoach.Location = new System.Drawing.Point(1113, 353);
            this.btnKeHoach.Margin = new System.Windows.Forms.Padding(2);
            this.btnKeHoach.Name = "btnKeHoach";
            this.btnKeHoach.Size = new System.Drawing.Size(200, 75);
            this.btnKeHoach.TabIndex = 73;
            this.btnKeHoach.Text = "Kế hoạch trong tháng";
            this.btnKeHoach.UseVisualStyleBackColor = false;
            this.btnKeHoach.Click += new System.EventHandler(this.BtnKeHoach_Click);
            // 
            // btnHuongDan
            // 
            this.btnHuongDan.BackColor = System.Drawing.Color.Brown;
            this.btnHuongDan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHuongDan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuongDan.ForeColor = System.Drawing.Color.White;
            this.btnHuongDan.Location = new System.Drawing.Point(988, 446);
            this.btnHuongDan.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuongDan.Name = "btnHuongDan";
            this.btnHuongDan.Size = new System.Drawing.Size(200, 75);
            this.btnHuongDan.TabIndex = 74;
            this.btnHuongDan.Text = "Hướng dẫn sử dụng";
            this.btnHuongDan.UseVisualStyleBackColor = false;
            this.btnHuongDan.Click += new System.EventHandler(this.BtnHuongDan_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(173, 510);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 20);
            this.label8.TabIndex = 75;
            this.label8.Text = "Môn giảng dạy: ";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.ForeColor = System.Drawing.Color.Blue;
            this.lblHoTen.Location = new System.Drawing.Point(313, 310);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(0, 20);
            this.lblHoTen.TabIndex = 76;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.ForeColor = System.Drawing.Color.Blue;
            this.lblNgaySinh.Location = new System.Drawing.Point(313, 360);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(0, 20);
            this.lblNgaySinh.TabIndex = 77;
            // 
            // lblMaGV
            // 
            this.lblMaGV.AutoSize = true;
            this.lblMaGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaGV.ForeColor = System.Drawing.Color.Blue;
            this.lblMaGV.Location = new System.Drawing.Point(313, 410);
            this.lblMaGV.Name = "lblMaGV";
            this.lblMaGV.Size = new System.Drawing.Size(0, 20);
            this.lblMaGV.TabIndex = 78;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.ForeColor = System.Drawing.Color.Blue;
            this.lblDiaChi.Location = new System.Drawing.Point(313, 460);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(0, 20);
            this.lblDiaChi.TabIndex = 79;
            // 
            // lblMon
            // 
            this.lblMon.AutoSize = true;
            this.lblMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMon.ForeColor = System.Drawing.Color.Blue;
            this.lblMon.Location = new System.Drawing.Point(313, 510);
            this.lblMon.Name = "lblMon";
            this.lblMon.Size = new System.Drawing.Size(0, 20);
            this.lblMon.TabIndex = 80;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.ForeColor = System.Drawing.Color.Blue;
            this.lblGioiTinh.Location = new System.Drawing.Point(619, 360);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(0, 20);
            this.lblGioiTinh.TabIndex = 81;
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDienThoai.ForeColor = System.Drawing.Color.Blue;
            this.lblDienThoai.Location = new System.Drawing.Point(619, 410);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(0, 20);
            this.lblDienThoai.TabIndex = 82;
            // 
            // frmGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyTruongHoc.Properties.Resources.School_3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.lblDienThoai);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblMon);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblMaGV);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnHuongDan);
            this.Controls.Add(this.btnKeHoach);
            this.Controls.Add(this.btnDanhSachLop);
            this.Controls.Add(this.btnSuaThongTin);
            this.Controls.Add(this.btnSuaDangNhap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.ptbInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmGiaoVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý học sinh";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGiaoVien_FormClosing);
            this.Load += new System.EventHandler(this.FrmGiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSuaThongTin;
        private System.Windows.Forms.Button btnSuaDangNhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.PictureBox ptbInfo;
        private System.Windows.Forms.Button btnDanhSachLop;
        private System.Windows.Forms.Button btnKeHoach;
        private System.Windows.Forms.Button btnHuongDan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblMaGV;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblMon;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblDienThoai;
    }
}