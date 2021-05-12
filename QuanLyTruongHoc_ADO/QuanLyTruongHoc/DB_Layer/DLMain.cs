using QuanLyTruongHoc.Objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTruongHoc.DB_Layer
{
    public class DLMain
    {
        private string connectionString = "Data Source = (local); Initial Catalog = QuanLyTruongHoc; " +
            "Integrated Security = True";
        private SqlConnection connection = null;
        private SqlDataAdapter dataAdapter = null;
        private SqlCommand command = null;        

        public DLMain()
        {
            connection = new SqlConnection(connectionString);
            command = connection.CreateCommand();
        }

        public DataSet executeQueryDataSet(string sqlString, CommandType type)
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
            connection.Open();

            command.CommandText = sqlString;
            command.CommandType = type;

            dataAdapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            return dataSet;
        }

        public bool myExecuteNonQuery(string sqlString, CommandType type)
        {
            bool canExecute;

            if (connection.State == ConnectionState.Open)
                connection.Close();
            connection.Open();            

            command.CommandText = sqlString;
            command.CommandType = type;            

            try
            {
                command.ExecuteNonQuery();
                canExecute = true;
            }
            catch
            {
                canExecute = false;
            }
            finally
            {
                connection.Close();
            }

            return canExecute;
        }

        public bool myExecuteScalar(string sqlString, CommandType type, out int n)
        {
            bool canExecute;

            if (connection.State == ConnectionState.Open)
                connection.Close();
            connection.Open();

            command.CommandText = sqlString;
            command.CommandType = type;

            try
            {
                n = Int32.Parse(command.ExecuteScalar().ToString());
                canExecute = true;
            }
            catch
            {
                n = -1;
                canExecute = false;
            }
            finally
            {
                connection.Close();
            }

            return canExecute;
        }

        public bool myExecuteReader(string sqlString, CommandType type, ref GiaoVien giaoVien)
        {
            bool canExecute;

            if (connection.State == ConnectionState.Open)
                connection.Close();
            connection.Open();

            command.CommandText = sqlString;
            command.CommandType = type;

            try
            {
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {                    
                    giaoVien.MaGV = reader.GetString(0);
                    giaoVien.HoTen = reader.GetString(1);
                    giaoVien.GioiTinh = reader.GetString(2);
                    giaoVien.NgaySinh = reader.GetDateTime(3);                    
                    giaoVien.DiaChi = reader.GetString(4);
                    giaoVien.DienThoai = reader.GetString(5);
                    giaoVien.Mon = reader.GetString(6);                    
                }

                canExecute = true;
            }
            catch
            {                
                canExecute = false;
            }
            finally
            {
                connection.Close();
            }

            return canExecute;
        }

        public bool myExecuteReader(string sqlString, CommandType type, ref List<Lop> lops)
        {
            bool canExecute;

            if (connection.State == ConnectionState.Open)
                connection.Close();
            connection.Open();

            command.CommandText = sqlString;
            command.CommandType = type;

            try
            {
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Lop lop = new Lop();
                    lop.TenLop = reader.GetString(0);
                    lops.Add(lop);
                }

                canExecute = true;
            }
            catch
            {
                canExecute = false;
            }
            finally
            {
                connection.Close();
            }

            return canExecute;
        }

        public bool myExecuteReader(string sqlString, CommandType type, ref List<GiaoVien> giaoViens)
        {
            bool canExecute;

            if (connection.State == ConnectionState.Open)
                connection.Close();
            connection.Open();

            command.CommandText = sqlString;
            command.CommandType = type;

            try
            {
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    GiaoVien giaoVien = new GiaoVien();
                    giaoVien.MaGV = reader.GetString(0);
                    giaoViens.Add(giaoVien);
                }

                canExecute = true;
            }
            catch
            {
                canExecute = false;
            }
            finally
            {
                connection.Close();
            }

            return canExecute;
        }
    }
}
