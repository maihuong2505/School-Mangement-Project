using QuanLyTruongHoc.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTruongHoc.BS_Layer
{
    public class BLHocSinh
    {
        private DLMain database;        

        public BLHocSinh()
        {
            database = new DLMain();
        }

        public DataSet layHocSinh(string lop, string maGV)
        {
            string sqlString = "SELECT KQHocTap.MaHS, HoVaTen, GioiTinh, KT15P, KT1T, DiemThi, DiemTB\n" +
                "FROM KQHocTap INNER JOIN Hoc on KQHocTap.MaHS = Hoc.MaHS\n" +
                "              INNER JOIN HocSinh on KQHocTap.MaHS = HocSinh.MaHS\n" +
                "WHERE Lop = '" + lop + "' AND MaGV = '" + maGV + "'";                
            return database.executeQueryDataSet(sqlString, CommandType.Text);
        }

        public DataSet layHocSinh(string lop)
        {
            string sqlString = "SELECT HocSinh.MaHS, HoVaTen, GioiTinh, NgaySinh, DiaChi\n" +
                "FROM HocSinh INNER JOIN Hoc ON HocSinh.MaHS = Hoc.MaHS\n" +
                "WHERE Lop = '" + lop + "'";
            return database.executeQueryDataSet(sqlString, CommandType.Text);
        }

        public DataSet layHSTK(string ten, string lop)
        {
            string sqlString = "SELECT HocSinh.MaHS, HoVaTen, GioiTinh, NgaySinh, DiaChi\n" +
               "FROM HocSinh INNER JOIN Hoc ON HocSinh.MaHS = Hoc.MaHS\n" +
               "WHERE HoVaTen like N'%" + ten + "%'" + "and Lop = '" + lop + "'";
            return database.executeQueryDataSet(sqlString, CommandType.Text);
        }

        public DataSet layHSTK(string ten, string lop, string magv)
        {
            string sqlString = "SELECT KQHocTap.MaHS, HoVaTen, GioiTinh, KT15P, KT1T, DiemThi, DiemTB\n" +
                "FROM KQHocTap INNER JOIN Hoc on KQHocTap.MaHS = Hoc.MaHS\n" +
                "              INNER JOIN HocSinh on KQHocTap.MaHS = HocSinh.MaHS\n" +
                "WHERE HoVaTen like N'%" + ten + "%' AND Lop = '" + lop + "' AND MaGV = '" + magv + "'";
            return database.executeQueryDataSet(sqlString, CommandType.Text);
        }

        public bool kiemTraHocSinh(string maHS, out int n)
        {
            string sqlString = "SELECT COUNT(*)\n" +
                "FROM HocSinh\n" +
                "WHERE MaHS = '" + maHS + "'";
            return database.myExecuteScalar(sqlString, CommandType.Text, out n);
        }

        public bool themHocSinhVaoDanhSachLop(string maHS, string ten, string gioiTinh, DateTime ngaySinh, string diaChi, string lop)
        {
            string sqlString = "INSERT INTO HocSinh VALUES " +
                "('" + maHS + "', N'" + ten + "', N'" + gioiTinh + "', '" + ngaySinh.ToString() + "', N'" + diaChi + "')\n" +
                "INSERT INTO Hoc VALUES ('" + maHS + "', '" + lop + "')";
            return database.myExecuteNonQuery(sqlString, CommandType.Text);
        }

        public bool themHocSinhVaoKetQuaHocTap(string maHS, string maGV)
        {
            string sqlString = "INSERT INTO KQHocTap VALUES " +
                "('" + maHS + "', '" + maGV + "', -1, -1, -1, -1)";
            return database.myExecuteNonQuery(sqlString, CommandType.Text);
        }

        public bool suaHocSinh(string maHS, string ten, string gioiTinh, DateTime ngaySinh, string diaChi)
        {
            string sqlString = "UPDATE HocSinh\n" +
                "SET HoVaTen = N'" + ten + "', GioiTinh = N'" + gioiTinh +
                "', NgaySinh = '" + ngaySinh.ToString() + "', DiaChi = N'" + diaChi + "'\n" +
                "WHERE MaHS = '" + maHS + "'";
            return database.myExecuteNonQuery(sqlString, CommandType.Text);
        }

        public bool suaHocSinh(string maHS, string maGV, float diem15, float diem1T, float diemThi, float diemTB)
        {
            string sqlString = "UPDATE KQHocTap\n" +
                "SET KT15P = " + diem15 + ", KT1T = " + diem1T + ", DiemThi = " + diemThi + ", DiemTB = " + diemTB + "\n" +
                "WHERE MaHS = '" + maHS + "' AND MaGV = '" + maGV + "'";
            return database.myExecuteNonQuery(sqlString, CommandType.Text);
        }

        public bool xoaHocSinhKhoiDanhSachLop(string maHS)
        {
            string sqlString = "DELETE FROM Hoc\n" +
                "WHERE MaHS = '" + maHS + "'\n" +
                "DELETE FROM HocSinh\n" +
                "WHERE MaHS = '" + maHS + "'";
            return database.myExecuteNonQuery(sqlString, CommandType.Text);
        }

        public bool xoaHocSinhKhoiKetQuaHocTap(string maHS, string maGV)
        {
            string sqlString = "DELETE FROM KQHocTap\n" +
                "WHERE MaHS = '" + maHS + "' AND MaGV = '" + maGV + "'";
            return database.myExecuteNonQuery(sqlString, CommandType.Text);
        }
    }
}
