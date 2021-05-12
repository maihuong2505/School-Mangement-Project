using QuanLyTruongHoc.BS_Layer;
using QuanLyTruongHoc.DB_Layer;
using QuanLyTruongHoc.Reports;
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
    public partial class frmQuanLyDiemHS : Form
    {
        #region Properties and Global variables
        private string maGiaoVien;
        private DataTable danhSachHocSinh;
        private BLHocSinh hocSinh;

        public string MaGiaoVien { get => maGiaoVien; set => maGiaoVien = value; }        
        #endregion

        #region Constructor
        public frmQuanLyDiemHS()
        {
            InitializeComponent();
            hocSinh = new BLHocSinh();
        }
        #endregion

        #region Methods
        private void layDanhSachLop()
        {
            BLGiaoVien giaoVien = new BLGiaoVien();
            List<GiangDay> lops = new List<GiangDay>();

            bool canExecute = giaoVien.layDanhSachLop(MaGiaoVien, ref lops);

            if (canExecute)
            {
                for (int i = 0; i < lops.Count; i++)
                {
                    cbbLop.Items.Add(lops[i].Lop.ToString());
                }
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void layDanhSachHocSinh()
        {
            if (cbbLop.Text == "")
                return;
            try
            {
                danhSachHocSinh = new DataTable();
                danhSachHocSinh.Clear();
                DataSet dataSet = hocSinh.layHocSinh(cbbLop.Text, MaGiaoVien);
                danhSachHocSinh = dataSet.Tables[0];
                dgvHocSinh.DataSource = danhSachHocSinh;
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void layDSHSTheoTuKhoa()
        {
            if (cbbLop.Text == "")
                return;
            try
            {
                danhSachHocSinh = new DataTable();
                danhSachHocSinh.Clear();
                DataSet dataSet = hocSinh.layHSTK(txtTimKiem.Text, cbbLop.Text, MaGiaoVien);
                danhSachHocSinh = dataSet.Tables[0];
                dgvHocSinh.DataSource = danhSachHocSinh;
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reload()
        {
            layDanhSachHocSinh();

            lblMaHS.Text = "";
            lblTen.Text = "";
            chkNu.Checked = false;
            txtDiem15.Clear();
            txtDiem1T.Clear();
            txtDiemThi.Clear();
            lblTB.Text = "";            

            chkNu.Enabled = false;
            txtDiem15.Enabled = false;
            txtDiem1T.Enabled = false;
            txtDiemThi.Enabled = false;

            btnChinhSua.Enabled = true;
            btnCapNhat.Enabled = false;
            btnHuy.Enabled = false;
        }
        #endregion

        #region Events
        private void FrmQuanLy_Load(object sender, EventArgs e)
        {
            layDanhSachLop();

            chkNu.Enabled = false;
            txtDiem15.Enabled = false;
            txtDiem1T.Enabled = false;
            txtDiemThi.Enabled = false;

            btnCapNhat.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void CbbLop_TextChanged(object sender, EventArgs e)
        {
            reload();
        }

        private void DgvHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int r = dgvHocSinh.CurrentCell.RowIndex;
                lblMaHS.Text = dgvHocSinh.Rows[r].Cells[0].Value.ToString();
                lblTen.Text = dgvHocSinh.Rows[r].Cells[1].Value.ToString();
                if (dgvHocSinh.Rows[r].Cells[2].Value.ToString() == "Nữ")
                {
                    chkNu.Checked = true;
                }
                else
                {
                    chkNu.Checked = false;
                }
                txtDiem15.Text = dgvHocSinh.Rows[r].Cells[3].Value.ToString();
                txtDiem1T.Text = dgvHocSinh.Rows[r].Cells[4].Value.ToString();
                txtDiemThi.Text = dgvHocSinh.Rows[r].Cells[5].Value.ToString();
                lblTB.Text = dgvHocSinh.Rows[r].Cells[6].Value.ToString();
            }
            catch
            {
                return;
            }
        }

        private void TxtDiem15_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != 46)
                e.Handled = true;
            else if (Char.IsDigit(e.KeyChar) || e.KeyChar == 46)
                e.Handled = false;
            else if (e.KeyChar == 13)
                txtDiem1T.Focus();
        }

        private void TxtDiem1T_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != 46)
                e.Handled = true;
            else if (Char.IsDigit(e.KeyChar) || e.KeyChar == 46)
                e.Handled = false;
            else if (e.KeyChar == 13)
                txtDiemThi.Focus();
        }

        private void TxtDiemThi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != 46)
                e.Handled = true;
            else if (Char.IsDigit(e.KeyChar) || e.KeyChar == 46)
                e.Handled = false;
        }

        private void TxtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnTim.PerformClick();
        }

        private void TxtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
                reload();
        }

        private void BtnChinhSua_Click(object sender, EventArgs e)
        {
            if (dgvHocSinh.DataSource == null)
                return;

            txtDiem15.Focus();

            txtDiem15.Enabled = true;
            txtDiem1T.Enabled = true;
            txtDiemThi.Enabled = true;

            btnChinhSua.Enabled = false;
            btnHuy.Enabled = true;
            btnCapNhat.Enabled = true;
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            reload();
        }

        private void BtnCapNhat_Click(object sender, EventArgs e)
        {
            if (lblMaHS.Text == "")
                return;

            if (MessageBox.Show("Bạn chắc chắn muốn cập nhật thông tin?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            double diem15, diem1T, diemThi, diemTB;
            if (!double.TryParse(txtDiem15.Text, out diem15))
            {
                MessageBox.Show("Điểm 15 phút không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiem15.Focus();
                return;
            }
            if (!double.TryParse(txtDiem1T.Text, out diem1T))
            {
                MessageBox.Show("Điểm 1 tiết không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiem1T.Focus();
                return;
            }
            if (!double.TryParse(txtDiemThi.Text, out diemThi))
            {
                MessageBox.Show("Điểm thi không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiemThi.Focus();
                return;
            }
            diemTB = Math.Round((diem15 + diem1T * 2 + diemThi * 3) / 6, 1);

            bool canExecute = hocSinh.suaHocSinh(lblMaHS.Text, MaGiaoVien, diem15, diem1T, diemThi, diemTB);

            if (canExecute)
            {
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            reload();
        }

        private void BtnTim_Click(object sender, EventArgs e)
        {
            layDSHSTheoTuKhoa();
        }
        #endregion
    }
}
