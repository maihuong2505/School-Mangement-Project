using QuanLyTruongHoc.DB_Layer;
using QuanLyTruongHoc.Objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTruongHoc.BS_Layer
{
    public class BLGiaoVien
    {
        private DLMain database;        

        public BLGiaoVien()
        {
            database = new DLMain();
        }

        public bool layGiaoVien(string maGiaoVien, string matKhau, out int n)
        {
            string sqlString = "SELECT COUNT(*)\n" +
                "FROM DangNhap INNER JOIN GiaoVien ON DangNhap.MaGV = GiaoVien.MaGV\n" +
                "WHERE DangNhap.MaGV = '" + maGiaoVien + "' AND MatKhau = '" + matKhau + "'";
            return database.myExecuteScalar(sqlString, CommandType.Text, out n);
        }

        public bool layThongTinGiaoVien(string maGiaoVien, ref GiaoVien giaoVien)
        {
            string sqlString;            
            sqlString = "SELECT *\n" +
                "FROM GiaoVien\n" +
                "WHERE MaGV = '" + maGiaoVien + "'";
            return database.myExecuteReader(sqlString, CommandType.Text, ref giaoVien);
        }

        public bool capNhatThongTinGiaoVien(string maGiaoVien, string diaChi, string dienThoai)
        {
            string sqlString = "UPDATE GiaoVien\n" +
                "SET DiaChi = N'" + diaChi + "', SoDT = '" + dienThoai + "'\n" +
                "WHERE MaGV = '" + maGiaoVien + "'";
            return database.myExecuteNonQuery(sqlString, CommandType.Text);
        }

        public bool capNhatMatKhau(string maGiaoVien, string matKhau)
        {
            string sqlString = "UPDATE DangNhap\n" +
                "SET MatKhau = '" + matKhau + "'\n" +
                "WHERE MaGV = '" + maGiaoVien + "'";
            return database.myExecuteNonQuery(sqlString, CommandType.Text);
        }

        public bool layDanhSachLop(string maGiaoVien, ref List<Lop> lops)
        {                        
            string sqlString = "SELECT Lop\n" +
                    "FROM GiangDay\n" +
                    "WHERE MaGV = '" + maGiaoVien + "'";            
            return database.myExecuteReader(sqlString, CommandType.Text, ref lops);
        }

        public bool layDanhSachLop(ref List<Lop> lops)
        {
            string sqlString = "SELECT Lop\n" +
                    "FROM LopHoc";
            return database.myExecuteReader(sqlString, CommandType.Text, ref lops);
        }
    }
}
