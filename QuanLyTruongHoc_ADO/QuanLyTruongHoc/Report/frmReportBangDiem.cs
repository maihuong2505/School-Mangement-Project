using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongHoc.Reports
{
    public partial class frmReportBangDiem : Form
    {
        /*SELECT HocSinh.MaHS, HoVaTen, HocSinh.GioiTinh, Lop, KQHocTap.MaGV, MonGiangDay, DiemTB
          FROM HocSinh INNER JOIN Hoc ON HocSinh.MaHS = Hoc.MaHS
                       INNER JOIN KQHocTap ON HocSinh.MaHS = KQHocTap.MaHS
                  	   INNER JOIN GiaoVien ON KQHocTap.MaGV = GiaoVien.MaGV*/

        public frmReportBangDiem()
        {
            InitializeComponent();
        }

        private void FrmReportDiemHS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTH_DataSet.BangDiem' table. You can move, or remove it, as needed.
            this.bangDiemTableAdapter.Fill(this.qLTH_DataSet.BangDiem);
            this.reportViewer1.RefreshReport();
        }
    }
}
