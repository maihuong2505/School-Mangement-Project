using QuanLyTruongHoc.BS_Layer;
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
    public partial class frmDoiThongTin : Form
    {
        private string hoTen, ngaySinh, gioiTinh, maGV, mon, diaChi, dienThoai;
        private bool huyCapNhat;

        public string HoTen { get => hoTen; set => hoTen = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string MaGV { get => maGV; set => maGV = value; }
        public string Mon { get => mon; set => mon = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string DienThoai { get => dienThoai; set => dienThoai = value; }        

        public frmDoiThongTin()
        {
            InitializeComponent();
        }

        public void hienThongTin()
        {
            lblHoTen.Text = HoTen;
            lblNgaySinh.Text = NgaySinh;
            lblGioiTinh.Text = GioiTinh;
            lblMaGV.Text = MaGV;
            lblMon.Text = Mon;

            txtDiaChi.Text = DiaChi;
            txtDienThoai.Text = DienThoai;
        }

        private void FrmDoiThongTin_Load(object sender, EventArgs e)
        {
            hienThongTin();
        }

        private void TxtDiaChi_Leave(object sender, EventArgs e)
        {
            if (txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập địa chỉ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
            }
        }

        private void TxtDienThoai_Leave(object sender, EventArgs e)
        {
            if (txtDienThoai.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDienThoai.Focus();
            }
        }

        private void TxtDiaChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtDienThoai.Focus();
        }

        private void TxtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
            else if (e.KeyChar == 13)
            {
                if (txtDienThoai.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn phải nhập số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDienThoai.Focus();
                }
                else
                    btnLuu.PerformClick();
            }
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn cập nhật thông tin?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BLGiaoVien giaoVien = new BLGiaoVien();
                bool canExecute = giaoVien.capNhatThongTinGiaoVien(lblMaGV.Text, txtDiaChi.Text, txtDienThoai.Text);

                if (canExecute)
                {
                    MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    huyCapNhat = false;
                    Close();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }            
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            huyCapNhat = true;
            Close();
        }

        private void FrmDoiThongTin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!huyCapNhat)
                return;
            if (MessageBox.Show("Bạn muốn hủy cập nhật?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
