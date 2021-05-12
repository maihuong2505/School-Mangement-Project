using QuanLyTruongHoc.IF_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongHoc
{
    public partial class frmBegin : Form
    {
        public frmBegin()
        {
            InitializeComponent();

            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            label.ForeColor = Color.Red;
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            label.ForeColor = Color.White;
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            label.ForeColor = Color.Black;
        }

        private void BtnDN_Click(object sender, EventArgs e)
        {
            frmDangNhap frmDangNhap = new frmDangNhap();            
            frmDangNhap.ShowDialog();
        }

        private void FrmBegin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                e.Cancel = true;
        }
    }
}
