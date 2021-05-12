using QuanLyTruongHoc.BS_Layer;
using QuanLyTruongHoc.DB_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongHoc.IF_Layer
{
    public partial class frmGiaoVien : Form
    {
        private string maGiaoVien;
        private bool laGiamHieu;

        public string MaGiaoVien { get => maGiaoVien; set => maGiaoVien = value; }
        public bool LaGiamHieu { get => laGiamHieu; set => laGiamHieu = value; }

        public frmGiaoVien()
        {
            InitializeComponent();
        }

        private void layThongTinCaNhan()
        {
            BLGiaoVien giaoVien = new BLGiaoVien();
            GiaoVien thongTin = new GiaoVien();

            bool canExecute = giaoVien.layThongTinGiaoVien(MaGiaoVien, ref thongTin);

            if (canExecute)
            {
                lblHoTen.Text = thongTin.HoTen;
                lblGioiTinh.Text = thongTin.GioiTinh;
                lblNgaySinh.Text = thongTin.NgaySinh.ToShortDateString();
                lblDiaChi.Text = thongTin.DiaChi;
                lblDienThoai.Text = thongTin.SoDT;
                lblMon.Text = thongTin.MonGiangDay;
                lblMaGV.Text = MaGiaoVien;
            }
            else
            {
                MessageBox.Show("Không lấy được thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmGiaoVien_Load(object sender, EventArgs e)
        {
            layThongTinCaNhan();
        }

        private void BtnSuaDangNhap_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frmDoiMatKhau = new frmDoiMatKhau();
            frmDoiMatKhau.MaGiaoVien = MaGiaoVien;
            frmDoiMatKhau.ShowDialog();
        }

        private void BtnSuaThongTin_Click(object sender, EventArgs e)
        {
            frmDoiThongTin frmDoiThongTin = new frmDoiThongTin();

            frmDoiThongTin.HoTen = lblHoTen.Text;
            frmDoiThongTin.NgaySinh = lblNgaySinh.Text;
            frmDoiThongTin.GioiTinh = lblGioiTinh.Text;
            frmDoiThongTin.MaGV = lblMaGV.Text;
            frmDoiThongTin.Mon = lblMon.Text;
            frmDoiThongTin.DiaChi = lblDiaChi.Text;
            frmDoiThongTin.DienThoai = lblDienThoai.Text;

            frmDoiThongTin.ShowDialog();

            layThongTinCaNhan();
        }

        private void BtnDanhSachLop_Click(object sender, EventArgs e)
        {
            if (!LaGiamHieu)
            {
                frmQuanLyDiemHS frmQuanLy = new frmQuanLyDiemHS();
                frmQuanLy.MaGiaoVien = MaGiaoVien;
                frmQuanLy.ShowDialog();
            }
            else
            {
                frmQuanLyDSHS frmQuanLy = new frmQuanLyDSHS();
                frmQuanLy.ShowDialog();
            }
        }

        private void BtnKeHoach_Click(object sender, EventArgs e)
        {
            frmKeHoach frmKeHoach = new frmKeHoach();
            frmKeHoach.ShowDialog();
        }

        private void BtnHuongDan_Click(object sender, EventArgs e)
        {
            frmHuongDan frmHuongDan = new frmHuongDan();
            frmHuongDan.ShowDialog();
        }

        private void BtnDangXuat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmGiaoVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
