using QuanLyTruongHoc.DB_Layer;
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
        private QuanLyTruongHocDataContext quanLyTruongHoc;
        private bool canExecute;        

        public BLLop()
        {
            quanLyTruongHoc = new QuanLyTruongHocDataContext();
        }

        public bool layDanhSachGiaoVien(string lop, ref List<GiangDay> giaoViens)
        {            
            try
            {
                var query = (from giaoVien in quanLyTruongHoc.GiangDays
                             where giaoVien.Lop == lop
                             select giaoVien).ToList();

                if (query != null)
                {
                    giaoViens = query;
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
