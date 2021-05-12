using QuanLyTruongHoc.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTruongHoc.BS_Layer
{
    public class BLHocSinh
    {
        private QuanLyTruongHocDataContext quanLyTruongHoc;
        private bool canExecute;        

        public BLHocSinh()
        {
            quanLyTruongHoc = new QuanLyTruongHocDataContext();
        }

        private void addColumn(ref DataTable dataTable, int n)
        {
            for (int i = 0; i < n; i++)
                dataTable.Columns.Add("");
        }

        public DataSet layHocSinh(string lop, string maGV)
        {
            DataSet dataSet = new DataSet();

            var query = from ketQua in quanLyTruongHoc.KQHocTaps
                        join hoc in quanLyTruongHoc.Hocs on ketQua.MaHS equals hoc.MaHS
                        join hocSinh in quanLyTruongHoc.HocSinhs on ketQua.MaHS equals hocSinh.MaHS
                        where hoc.Lop == lop && ketQua.MaGV == maGV
                        select new { ketQua.MaHS, hocSinh.HoVaTen, hocSinh.GioiTinh, ketQua.KT15P, ketQua.KT1T, ketQua.DiemThi, ketQua.DiemTB };

            DataTable dataTable = new DataTable();
            addColumn(ref dataTable, 7);
            foreach (var item in query)
                dataTable.Rows.Add(item.MaHS, item.HoVaTen, item.GioiTinh, item.KT15P, item.KT1T, item.DiemThi, item.DiemTB);

            dataSet.Tables.Add(dataTable);
            return dataSet;            
        }

        public DataSet layHocSinh(string lop)
        {
            DataSet dataSet = new DataSet();

            var query = from hocSinh in quanLyTruongHoc.HocSinhs
                        join hoc in quanLyTruongHoc.Hocs on hocSinh.MaHS equals hoc.MaHS
                        where hoc.Lop == lop
                        select new { hocSinh.MaHS, hocSinh.HoVaTen, hocSinh.GioiTinh, hocSinh.NgaySinh, hocSinh.DiaChi };

            DataTable dataTable = new DataTable();
            addColumn(ref dataTable, 5);
            foreach (var item in query)
                dataTable.Rows.Add(item.MaHS, item.HoVaTen, item.GioiTinh, item.NgaySinh.ToShortDateString(), item.DiaChi);

            dataSet.Tables.Add(dataTable);
            return dataSet;
        }

        public DataSet layHSTK(string ten, string lop, string magv)
        {
            DataSet dataSet = new DataSet();

            var query = from ketQua in quanLyTruongHoc.KQHocTaps
                        join hoc in quanLyTruongHoc.Hocs on ketQua.MaHS equals hoc.MaHS
                        join hocSinh in quanLyTruongHoc.HocSinhs on ketQua.MaHS equals hocSinh.MaHS
                        where hocSinh.HoVaTen.Contains(ten) && hoc.Lop == lop && ketQua.MaGV == magv
                        select new { ketQua.MaHS, hocSinh.HoVaTen, hocSinh.GioiTinh, ketQua.KT15P, ketQua.KT1T, ketQua.DiemThi, ketQua.DiemTB };

            DataTable dataTable = new DataTable();
            addColumn(ref dataTable, 7);
            foreach (var item in query)
                dataTable.Rows.Add(item.MaHS, item.HoVaTen, item.GioiTinh, item.KT15P, item.KT1T, item.DiemThi, item.DiemTB);

            dataSet.Tables.Add(dataTable);
            return dataSet;            
        }

        public DataSet layHSTK(string ten, string lop)
        {
            DataSet dataSet = new DataSet();

            var query = from hocSinh in quanLyTruongHoc.HocSinhs
                        join hoc in quanLyTruongHoc.Hocs on hocSinh.MaHS equals hoc.MaHS
                        where hocSinh.HoVaTen.Contains(ten) && hoc.Lop == lop
                        select new { hocSinh.MaHS, hocSinh.HoVaTen, hocSinh.GioiTinh, hocSinh.NgaySinh, hocSinh.DiaChi };

            DataTable dataTable = new DataTable();
            addColumn(ref dataTable, 5);
            foreach (var item in query)
                dataTable.Rows.Add(item.MaHS, item.HoVaTen, item.GioiTinh, item.NgaySinh.ToShortDateString(), item.DiaChi);

            dataSet.Tables.Add(dataTable);
            return dataSet;            
        }

        public bool kiemTraHocSinh(string maHS, out int n)
        {
            try
            {
                var query = (from hocSinh in quanLyTruongHoc.HocSinhs
                             where hocSinh.MaHS == maHS
                             select hocSinh).SingleOrDefault();

                if (query != null)
                {
                    n = 1;
                }
                else
                {
                    n = 0;
                }

                canExecute = true;
            }
            catch
            {
                n = 0;
                canExecute = false;
            }

            return canExecute;            
        }

        public bool themHocSinhVaoDanhSachLop(string maHS, string ten, string gioiTinh, DateTime ngaySinh, string diaChi, string lop)
        {
            try
            {
                HocSinh hocSinh = new HocSinh();

                hocSinh.MaHS = maHS;
                hocSinh.HoVaTen = ten;
                hocSinh.GioiTinh = gioiTinh;
                hocSinh.NgaySinh = ngaySinh;
                hocSinh.DiaChi = diaChi;

                quanLyTruongHoc.HocSinhs.InsertOnSubmit(hocSinh);
                quanLyTruongHoc.HocSinhs.Context.SubmitChanges();

                Hoc hoc = new Hoc();

                hoc.MaHS = maHS;
                hoc.Lop = lop;

                quanLyTruongHoc.Hocs.InsertOnSubmit(hoc);
                quanLyTruongHoc.Hocs.Context.SubmitChanges();

                canExecute = true;
            }
            catch
            {
                canExecute = false;
            }

            return canExecute;            
        }

        public bool themHocSinhVaoKetQuaHocTap(string maHS, string maGV)
        {
            try
            {
                KQHocTap ketQua = new KQHocTap();

                ketQua.MaHS = maHS;
                ketQua.MaGV = maGV;
                ketQua.KT15P = -1;
                ketQua.KT1T = -1;
                ketQua.DiemThi = -1;
                ketQua.DiemTB = -1;

                quanLyTruongHoc.KQHocTaps.InsertOnSubmit(ketQua);
                quanLyTruongHoc.KQHocTaps.Context.SubmitChanges();

                canExecute = true;
            }
            catch
            {
                canExecute = false;
            }

            return canExecute;            
        }

        public bool suaHocSinh(string maHS, string ten, string gioiTinh, DateTime ngaySinh, string diaChi)
        {
            try
            {
                var query = (from hocSinh in quanLyTruongHoc.HocSinhs
                             where hocSinh.MaHS == maHS
                             select hocSinh).SingleOrDefault();

                if (query != null)
                {
                    query.HoVaTen = ten;
                    query.GioiTinh = gioiTinh;
                    query.NgaySinh = ngaySinh;
                    query.DiaChi = diaChi;

                    quanLyTruongHoc.SubmitChanges();
                }

                canExecute = true;
            }
            catch
            {
                canExecute = false;
            }

            return canExecute;            
        }

        public bool suaHocSinh(string maHS, string maGV, double diem15, double diem1T, double diemThi, double diemTB)
        {
            try
            {
                var query = (from ketQua in quanLyTruongHoc.KQHocTaps
                             where ketQua.MaHS == maHS && ketQua.MaGV == maGV
                             select ketQua).SingleOrDefault();

                if (query != null)
                {
                    query.KT15P = diem15;
                    query.KT1T = diem1T;
                    query.DiemThi = diemThi;
                    query.DiemTB = diemTB;

                    quanLyTruongHoc.SubmitChanges();
                }

                canExecute = true;
            }
            catch
            {
                canExecute = false;
            }

            return canExecute;            
        }

        public bool xoaHocSinhKhoiDanhSachLop(string maHS)
        {
            try
            {
                var query1 = from hoc in quanLyTruongHoc.Hocs
                            where hoc.MaHS == maHS
                            select hoc;

                quanLyTruongHoc.Hocs.DeleteAllOnSubmit(query1);
                quanLyTruongHoc.SubmitChanges();

                var query2 = from hocSinh in quanLyTruongHoc.HocSinhs
                            where hocSinh.MaHS == maHS
                            select hocSinh;

                quanLyTruongHoc.HocSinhs.DeleteAllOnSubmit(query2);
                quanLyTruongHoc.SubmitChanges();

                canExecute = true;
            }
            catch
            {
                canExecute = false;
            }

            return canExecute;            
        }

        public bool xoaHocSinhKhoiKetQuaHocTap(string maHS, string maGV)
        {
            try
            {
                var query = from ketQua in quanLyTruongHoc.KQHocTaps
                            where ketQua.MaHS == maHS && ketQua.MaGV == maGV
                            select ketQua;

                quanLyTruongHoc.KQHocTaps.DeleteAllOnSubmit(query);
                quanLyTruongHoc.SubmitChanges();

                canExecute = true;
            }
            catch
            {
                canExecute = false;
            }

            return canExecute;            
        }
    }
}
