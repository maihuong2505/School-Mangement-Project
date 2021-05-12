using QuanLyTruongHoc.DB_Layer;
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
        private QuanLyTruongHocDataContext quanLyTruongHoc;
        private bool canExecute;        

        public BLGiaoVien()
        {
            quanLyTruongHoc = new QuanLyTruongHocDataContext();
        }

        public bool layGiaoVien(string maGiaoVien, string matKhau, out int n)
        {            
            try
            {                
                var query = (from giaoVien in quanLyTruongHoc.DangNhaps
                             where giaoVien.MaGV == maGiaoVien && giaoVien.MatKhau == matKhau
                             select giaoVien).SingleOrDefault();

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

        public bool layThongTinGiaoVien(string maGiaoVien, ref GiaoVien thongTinGiaoVien)
        {            
            try
            {
                var query = (from giaoVien in quanLyTruongHoc.GiaoViens
                             where giaoVien.MaGV == maGiaoVien
                             select giaoVien).SingleOrDefault();

                if (query != null)
                {
                    thongTinGiaoVien = query;
                }                

                canExecute = true;
            }
            catch
            {
                canExecute = false;
            }

            return canExecute;            
        }

        public bool capNhatThongTinGiaoVien(string maGiaoVien, string diaChi, string dienThoai)
        {
            try
            {
                var query = (from giaoVien in quanLyTruongHoc.GiaoViens
                             where giaoVien.MaGV == maGiaoVien
                             select giaoVien).SingleOrDefault();

                if (query != null)
                {
                    query.DiaChi = diaChi;
                    query.SoDT = dienThoai;

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

        public bool capNhatMatKhau(string maGiaoVien, string matKhau)
        {
            try
            {
                var query = (from giaoVien in quanLyTruongHoc.DangNhaps
                             where giaoVien.MaGV == maGiaoVien
                             select giaoVien).SingleOrDefault();

                if (query != null)
                {
                    query.MatKhau = matKhau;

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

        public bool layDanhSachLop(string maGiaoVien, ref List<GiangDay> lops)
        {
            try
            {
                var query = (from lop in quanLyTruongHoc.GiangDays
                             where lop.MaGV == maGiaoVien
                             select lop).ToList();

                if (query != null)
                {
                    lops = query;
                }
                
                canExecute = true;
            }
            catch
            {
                canExecute = false;
            }

            return canExecute;
        }

        public bool layDanhSachLop(ref List<LopHoc> lops)
        {
            try
            {
                var query = (from lop in quanLyTruongHoc.LopHocs
                             select lop).ToList();

                if (query != null)
                {
                    lops = query;
                }

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
