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
    public partial class frmKeHoach : Form
    {
        public frmKeHoach()
        {
            InitializeComponent();
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog odl = new OpenFileDialog();
            odl.Title = "Chọn Đề Cương Chi Tiết";
            odl.InitialDirectory = @"C:\Program Files";
            odl.Filter = "All files(*.*) | *.*| exe files(*.exe) | *.exe| doc(*.doc)| *.doc";
            odl.FilterIndex = 1;
            odl.RestoreDirectory = true;
            if (odl.ShowDialog() == DialogResult.OK)
            {
                rtxtShow.Text = odl.FileName;
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
