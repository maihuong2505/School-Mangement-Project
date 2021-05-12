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
    public partial class frmDoiMatKhau : Form
    {
        private string maGiaoVien;
        private bool huyCapNhat;

        public string MaGiaoVien { get => maGiaoVien; set => maGiaoVien = value; }        

        public frmDoiMatKhau()
        {
            InitializeComponent();            
        }

        private void FrmDoiMatKhau_Load(object sender, EventArgs e)
        {
            ActiveControl = label1;
        }

        private void TxtOldPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32)
                e.Handled = true;
            else if (e.KeyChar != 13)
                e.Handled = false;
            else
                txtNewPass.Focus();
        }

        private void TxtNewPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32)
                e.Handled = true;
            else if (e.KeyChar != 13)
                e.Handled = false;
            else
                txtReNewPass.Focus();
        }

        private void TxtReNewPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32)
                e.Handled = true;
            else if (e.KeyChar != 13)
                e.Handled = false;
            else
                btnAcc.PerformClick();
        }

        private void BtnAcc_Click(object sender, EventArgs e)
        {
            if (txtOldPass.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu cũ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtOldPass.Focus();
                return;
            }
            if (txtNewPass.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNewPass.Focus();
                return;
            }
            if (txtNewPass.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 kí tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNewPass.Clear();
                txtNewPass.Focus();
                return;
            }
            if (txtNewPass.Text.Equals(txtOldPass.Text))
            {
                MessageBox.Show("Mật khẩu mới phải khác mật khẩu cũ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNewPass.Clear();
                txtNewPass.Focus();
                return;
            }

            BLGiaoVien giaoVien = new BLGiaoVien();
            int n;
            bool canExecute = giaoVien.layGiaoVien(MaGiaoVien, txtOldPass.Text, out n);

            if (canExecute)
            {
                if (n == 0)
                {
                    MessageBox.Show("Mật khẩu cũ chưa đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtOldPass.Focus();
                }
                else if (txtNewPass.Text.Equals(txtReNewPass.Text))
                {
                    if (MessageBox.Show("Bạn chắc chắn muốn đổi mật khẩu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        canExecute = giaoVien.capNhatMatKhau(MaGiaoVien, txtReNewPass.Text);

                        if (canExecute)
                        {
                            MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            huyCapNhat = false;
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Có lỗi xảy ra!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            txtOldPass.Clear();
                            txtNewPass.Clear();
                            txtReNewPass.Clear();

                            label1.Focus();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu mới không trùng khớp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    txtNewPass.Clear();
                    txtReNewPass.Clear();

                    txtNewPass.Focus();
                }
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtOldPass.Clear();
                txtNewPass.Clear();
                txtReNewPass.Clear();

                label1.Focus();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            huyCapNhat = true;
            Close();
        }

        private void FrmDoiMatKhau_FormClosing(object sender, FormClosingEventArgs e)
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
