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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();            
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            ActiveControl = pictureBox1;
        }

        private void TxtMaGV_Enter(object sender, EventArgs e)
        {
            txtMaGV.Clear();
            txtMaGV.ForeColor = Color.Black;
        }

        private void TxtMatKhau_Enter(object sender, EventArgs e)
        {
            txtMatKhau.Clear();
            txtMatKhau.ForeColor = Color.Black;
        }

        private void TxtMaGV_Leave(object sender, EventArgs e)
        {
            if (txtMaGV.Text == "")
            {
                txtMaGV.Text = "Mã giáo viên";
                txtMaGV.ForeColor = Color.LightGray;
            }
        }

        private void TxtMatKhau_Leave(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "")
            {
                txtMatKhau.Text = "Mật khẩu";
                txtMatKhau.ForeColor = Color.LightGray;
            }
        }

        private void TxtMaGV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32)
                e.Handled = true;
            else if (e.KeyChar != 13)
                e.Handled = false;
            else
                txtMatKhau.Focus();
        }

        private void TxtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32)
                e.Handled = true;
            else if (e.KeyChar != 13)
                e.Handled = false;
            else
                btnDangNhap.PerformClick();
        }

        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            BLGiaoVien quanLy = new BLGiaoVien();
            int n;

            bool canExecute = quanLy.layGiaoVien(txtMaGV.Text, txtMatKhau.Text, out n);

            if (canExecute)
            {
                if (n > 0)
                {
                    frmGiaoVien frmGiaoVien = new frmGiaoVien();                    
                    frmGiaoVien.MaGiaoVien = txtMaGV.Text;
                    if (txtMaGV.Text.Substring(0, 1) == "1")
                        frmGiaoVien.LaGiamHieu = false;
                    else
                        frmGiaoVien.LaGiamHieu = true;
                    frmGiaoVien.ShowDialog();

                    Close();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMatKhau.Clear();
                }
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtMaGV.Clear();
                txtMatKhau.Clear();

                txtMaGV.Focus();
            }
        }
    }
}
