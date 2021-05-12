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
    public partial class frmQuanLyDSHS : Form
    {
        #region Global variables
        private DataTable danhSachHocSinh;
        private BLHocSinh hocSinh;        
        private bool them;
        #endregion

        #region Constructor
        public frmQuanLyDSHS()
        {
            InitializeComponent();
            hocSinh = new BLHocSinh();
        }
        #endregion

        #region Methods
        private void layDanhSachLop()
        {
            BLGiaoVien giaoVien = new BLGiaoVien();
            List<LopHoc> lops = new List<LopHoc>();

            bool canExecute = giaoVien.layDanhSachLop(ref lops);

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

        private bool layDanhSachGiaoVien(ref List<GiangDay> giaoViens)
        {
            BLLop lop = new BLLop();
            return lop.layDanhSachGiaoVien(cbbLop.Text, ref giaoViens);
        }

        private void layDanhSachHocSinh()
        {
            if (cbbLop.Text == "")
                return;
            try
            {
                danhSachHocSinh = new DataTable();
                danhSachHocSinh.Clear();
                DataSet dataSet = hocSinh.layHocSinh(cbbLop.Text.Trim());
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
                DataSet dataSet = hocSinh.layHSTK(txtTimKiem.Text, cbbLop.Text);
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

            txtMaHS.Clear();
            txtTen.Clear();
            chkNu.Checked = false;
            dtpNgaySinh.Value = DateTime.Today;
            txtDiaChi.Clear();

            txtMaHS.Enabled = false;
            txtTen.Enabled = false;
            chkNu.Enabled = false;
            dtpNgaySinh.Enabled = false;
            txtDiaChi.Enabled = false;

            cbbLop.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = false;
            btnCapNhat.Enabled = false;
        }
        #endregion

        #region Events
        private void FrmQuanLyDSHS_Load(object sender, EventArgs e)
        {
            layDanhSachLop();

            txtMaHS.Enabled = false;
            txtTen.Enabled = false;
            chkNu.Enabled = false;
            dtpNgaySinh.Value = DateTime.Today;
            dtpNgaySinh.Enabled = false;
            txtDiaChi.Enabled = false;
            
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
                txtMaHS.Text = dgvHocSinh.Rows[r].Cells[0].Value.ToString().Trim();
                txtTen.Text = dgvHocSinh.Rows[r].Cells[1].Value.ToString();
                if (dgvHocSinh.Rows[r].Cells[2].Value.ToString() == "Nữ")
                {
                    chkNu.Checked = true;
                }
                else
                {
                    chkNu.Checked = false;
                }
                if (dgvHocSinh.Rows[r].Cells[3].Value.ToString() != "")
                {
                    dtpNgaySinh.Value = DateTime.Parse(dgvHocSinh.Rows[r].Cells[3].Value.ToString());
                }
                else
                {
                    dtpNgaySinh.Value = DateTime.Today;
                }
                txtDiaChi.Text = dgvHocSinh.Rows[r].Cells[4].Value.ToString();
            }
            catch
            {
                return;
            }
        }

        private void TxtMaHS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
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

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (dgvHocSinh.DataSource == null)
                return;

            them = true;

            txtMaHS.Enabled = true;
            txtTen.Enabled = true;
            chkNu.Enabled = true;            
            dtpNgaySinh.Enabled = true;
            txtDiaChi.Enabled = true;

            txtMaHS.Clear();
            txtTen.Clear();
            chkNu.Checked = false;
            dtpNgaySinh.Value = DateTime.Today;
            txtDiaChi.Clear();

            txtMaHS.Focus();
            
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnCapNhat.Enabled = true;
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (dgvHocSinh.DataSource == null)
                return;

            them = false;

            txtMaHS.Enabled = false;
            txtTen.Enabled = true;
            chkNu.Enabled = true;            
            dtpNgaySinh.Enabled = true;
            txtDiaChi.Enabled = true;

            txtMaHS.Focus();

            
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnCapNhat.Enabled = true;
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (dgvHocSinh.DataSource == null)
                return;

            if (txtMaHS.Text == "")
                return;

            if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                List<GiangDay> giaoViens = new List<GiangDay>();
                bool canExecute = layDanhSachGiaoVien(ref giaoViens);                

                if (canExecute)
                {
                    for (int i = 0; i < giaoViens.Count; i++)
                    {
                        canExecute = hocSinh.xoaHocSinhKhoiKetQuaHocTap(txtMaHS.Text, giaoViens[i].MaGV);

                        if (!canExecute)
                        {
                            MessageBox.Show("Có lỗi xảy ra!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    canExecute = hocSinh.xoaHocSinhKhoiDanhSachLop(txtMaHS.Text);

                    if (canExecute)
                    {                        
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                reload();
            }
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            reload();
        }

        private void BtnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtMaHS.Text == "")
                return;

            if (MessageBox.Show("Bạn chắc chắn muốn cập nhật thông tin?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            if (them)
            {                
                if (txtMaHS.Text.Length != 6)
                {
                    MessageBox.Show("Mã học sinh phải có 6 chữ số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool canExecute = hocSinh.kiemTraHocSinh(txtMaHS.Text, out int n);

                if (canExecute)
                {
                    if (n > 0)
                    {
                        MessageBox.Show("Mã học sinh này đã tồn tại. Mời bạn nhập mã khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMaHS.Focus();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string gioiTinh;

                if (chkNu.Checked)
                    gioiTinh = "Nữ";
                else
                    gioiTinh = "Nam";

                canExecute = hocSinh.themHocSinhVaoDanhSachLop(txtMaHS.Text, txtTen.Text, gioiTinh, dtpNgaySinh.Value, txtDiaChi.Text, cbbLop.Text);

                if (canExecute)
                {
                    List<GiangDay> giaoViens = new List<GiangDay>();
                    canExecute = layDanhSachGiaoVien(ref giaoViens);

                    if (canExecute)
                    {
                        for (int i = 0; i < giaoViens.Count; i++)
                        {
                            canExecute = hocSinh.themHocSinhVaoKetQuaHocTap(txtMaHS.Text, giaoViens[i].MaGV);

                            if (!canExecute)
                            {
                                MessageBox.Show("Có lỗi xảy ra!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                reload();
            }
            else
            {
                string gioiTinh;

                if (chkNu.Checked)
                    gioiTinh = "Nữ";
                else
                    gioiTinh = "Nam";

                bool canExecute = hocSinh.suaHocSinh(txtMaHS.Text, txtTen.Text, gioiTinh, dtpNgaySinh.Value, txtDiaChi.Text);

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
        }

        private void BtnTim_Click(object sender, EventArgs e)
        {
            layDSHSTheoTuKhoa();
        }

        private void BtnBaoCao_Click(object sender, EventArgs e)
        {
            frmReportBangDiem frmReport = new frmReportBangDiem();
            frmReport.ShowDialog();
        }
        #endregion
    }
}
