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
    public class BLLop
    {
        private DLMain database;        

        public BLLop()
        {
            database = new DLMain();
        }

        public bool layDanhSachGiaoVien(string lop, ref List<GiaoVien> giaoViens)
        {
            string sqlString = "SELECT MaGV\n" +
                "FROM GiangDay\n" +
                "WHERE Lop = '" + lop + "'";
            return database.myExecuteReader(sqlString, CommandType.Text, ref giaoViens);
        }
    }
}
