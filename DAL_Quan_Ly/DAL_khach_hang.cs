using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO_Quan_ly;

namespace DAL_Quan_Ly
{
    public class DAL_khach_hang:Connect_data
    {
        public DataTable get_KhachHang()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Khach_Hang", cnn);
            DataTable dtKhachHang = new DataTable();
            da.Fill(dtKhachHang);
            cnn.Close();
            return dtKhachHang;
        }
        public DataTable get_thontin_KhachHang(string name)
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter($"select * from Khach_Hang where TenKH = N'{name}'", cnn);
            DataTable dtKhachHang = new DataTable();
            da.Fill(dtKhachHang);
            cnn.Close();
            return dtKhachHang;
        }
        //Lấy họ tên khách hàng
        public string get_TenKhachHang(string MaKH)
        {
            cnn.Open();
            string sqlFind = string.Format($"select TenKH from Khach_Hang where MaKH = '{MaKH}'");
            SqlDataAdapter da = new SqlDataAdapter(sqlFind, cnn);
            DataTable dtTenKH = new DataTable();
            da.Fill(dtTenKH);
            string HoTenKH = dtTenKH.Rows[0].Field<string>(0);
            cnn.Close();
            return HoTenKH;
        }
        public string get_makh(string tenkh)
        {
            cnn.Open();
            string sqlFind = string.Format($"select MaKH from Khach_Hang where TenKH= N'{tenkh}'");
            SqlDataAdapter da = new SqlDataAdapter(sqlFind, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string makh = dt.Rows[0].Field<string>(0);
            cnn.Close();
            return makh;
        }
        //Lấy sđt khách hàng
        public string get_SDTKH(string MaKH)
        {
            cnn.Open();
            string sqlFind = string.Format("select SDTKH from Khach_Hang where MaKH = '{0}'", MaKH);
            SqlDataAdapter da = new SqlDataAdapter(sqlFind, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string SDTKH = dt.Rows[0].Field<string>(0);
            cnn.Close();
            return SDTKH;
        }
        //Lấy địa chỉ khách hàng
        public string get_DiaChi(string MaKH)
        {
            cnn.Open();
            string sqlFind = string.Format("select DiachiKH from Khach_Hang where MaKH = '{0}'", MaKH);
            SqlDataAdapter da = new SqlDataAdapter(sqlFind, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string DiaChi = dt.Rows[0].Field<string>(0);
            cnn.Close();
            return DiaChi;
        }
        //Lấy Mã KH from SDTKH
        public string getMaKHFromSDTKH(string SDTKH)
        {
            cnn.Open();
            string sqlFind = string.Format("select MaKH from Khach_Hang where SDTKH = '{0}'", SDTKH);
            SqlDataAdapter da = new SqlDataAdapter(sqlFind, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string MaKH = dt.Rows[0].Field<string>(0);
            cnn.Close();
            return MaKH;
        }
        //thêm khách hàng
        public bool insert_KH(DTO_Quan_Ly_Khach_hang kh)
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("INSERT_KH", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MAKH", kh.MaKH);
                cmd.Parameters.AddWithValue("@TENKH", kh.TenKH);
                cmd.Parameters.AddWithValue("@GIOITINH", kh.GioiTinh);
                cmd.Parameters.AddWithValue("@NGAYSINH", kh.Ngaysinh);
                cmd.Parameters.AddWithValue("@SDTKH", kh.SDT);
                cmd.Parameters.AddWithValue("@DIACHIKH", kh.Diachi);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Loi {e}");
            }
            finally
            {
                cnn.Close();
            }
            return false;
        }
        //xóa khách hàng
        public bool delete_KH(string makh)
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("DELETE_KH", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MAKH", makh);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Loi {e}");
            }
            finally
            {
                cnn.Close();
            }
            return false;
        }
        //update khách hàng
        public bool update_KH(DTO_Quan_Ly_Khach_hang kh)
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE_KH", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MAKH", kh.MaKH);
                cmd.Parameters.AddWithValue("@TENKH", kh.TenKH);
                cmd.Parameters.AddWithValue("@GIOITINH", kh.GioiTinh);
                cmd.Parameters.AddWithValue("@NGAYSINH", kh.Ngaysinh);
                cmd.Parameters.AddWithValue("@SDTKH", kh.SDT);
                cmd.Parameters.AddWithValue("@DIACHIKH", kh.Diachi);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Loi {e}");
            }
            finally
            {
                cnn.Close();
            }
            return false;
        }
        //lấy số điện thoại khách hàng theo số điện thoại
        public DataTable get_SDT(string SDT)
        {
            cnn.Open();
            string sqlFind = string.Format("select * from Khach_Hang where SDTKH = '{0}'", SDT);
            SqlDataAdapter da = new SqlDataAdapter(sqlFind, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        public string get_makh_cuoi()
        {
            cnn.Open();
            string sql = string.Format("SELECT TOP 1 MaKH FROM Khach_Hang ORDER BY MaKH DESC ");
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string mahd = dt.Rows[0].Field<string>(0);
            cnn.Close();
            return mahd;
        }

        public string get_gioitinh(string makh)
        {
            cnn.Open();
            string sql = string.Format("select GioiTinh from Khach_Hang where MaKH = '{0}'",makh);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string gioitinh = dt.Rows[0].Field<string>(0);
            cnn.Close();
            return gioitinh;
        }

        public DateTime get_ngaysinh(string makh)
        {
            cnn.Open();
            string sql = string.Format("select Ngaysinh from Khach_Hang where MaKH = '{0}'",makh);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DateTime ngaysinh = dt.Rows[0].Field<DateTime>(0);
            cnn.Close();
            return ngaysinh;
        }

        public bool check_khachhang(string sdt)
        {
            cnn.Open();
            string sql = string.Format("select MaKH from Khach_Hang where SDTKH ='{0}'", sdt);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            if (dt.Rows.Count > 0) return true;
            else return false;
        }
    }
}
