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
    public class DAL_Hoi_Vien:Connect_data
    {
        //lấy bảng hội viên
        public DataTable get_Hoivien()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Hoi_Vien", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        //lấy thông tin hội viên bằng mã
        public DataTable get_thongtinHV(string tenhv)
        {
            cnn.Open();
            string sql = string.Format("select * from Hoi_Vien where TenHV = N'{0}'", tenhv);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        public DataTable get_thongtin_theHV(string theHV)
        {
            cnn.Open();
            string sql = string.Format("select * from Hoi_Vien where Loai_The = N'{0}'", theHV);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        //lấy mã hội viên từ tên hội viên
        public DataTable get_MaHV(string tenhv)
        {
            cnn.Open();
            string sql = string.Format("select MaHV from Hoi_Vien where TenHV = N'{0}'", tenhv);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        public string get_tenhv(string mahv)
        {
            cnn.Open();
            string sql = string.Format("select TenHV from Hoi_Vien where MaHV = '{0}'", mahv);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string tenhv = dt.Rows[0].Field<string>(0);
            cnn.Close();
            return tenhv;
        }
        //thêm hội viên
        public bool insert_HV(DTO_Hoi_Vien hv)
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("INSERT_HV", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MAHV", hv.MaHV);
                cmd.Parameters.AddWithValue("@lOAITHE", hv.Loai_The);
                cmd.Parameters.AddWithValue("@TENHV", hv.TenHV);
                cmd.Parameters.AddWithValue("@GIOITINH", hv.GioiTinh);
                cmd.Parameters.AddWithValue("@NGAYSINH", hv.Ngaysinh);
                cmd.Parameters.AddWithValue("@NGAYLAPTHE", hv.NgayLapThe);
                cmd.Parameters.AddWithValue("@SDTHV", hv.SDT);
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
        //xóa hội viên
        public bool delete_HV(string hv)
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("DELETE_HV", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MAHV", hv);
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
        //sửa hội viên
        public bool update_HV(DTO_Hoi_Vien hv)
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE_HV", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MAHV", hv.MaHV);
                cmd.Parameters.AddWithValue("@lOAITHE", hv.Loai_The);
                cmd.Parameters.AddWithValue("@TENHV", hv.TenHV);
                cmd.Parameters.AddWithValue("@GIOITINH", hv.GioiTinh);
                cmd.Parameters.AddWithValue("@NGAYSINH", hv.Ngaysinh);
                cmd.Parameters.AddWithValue("@NGAYLAPTHE", hv.NgayLapThe);
                cmd.Parameters.AddWithValue("@SDTHV", hv.SDT);
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
        //lấy số điện thoại hộ viên
        public string get_SDTHV(string SDT)
        {
            cnn.Open();
            string sqlFind = string.Format("select SDT_HV from Hoi_Vien where SDT_HV = '{0}'", SDT);
            SqlDataAdapter da = new SqlDataAdapter(sqlFind, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string SDTKH = dt.Rows[0].Field<string>(0);
            cnn.Close();
            return SDTKH;
        }
        public DataTable get_thong_tinHV(string SDT)
        {
            cnn.Open();
            string sql = string.Format("select * from Hoi_Vien where SDT_HV = '{0}'", SDT);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        public decimal get_tiengiam(int mahv)
        {
            cnn.Open();
            string sqlFind = string.Format("select b.Tien_Giam from Hoi_Vien a, The_Hoi_Vien b where a.Loai_The = b. Loai_The and a.MaHV = {0}", mahv);
            SqlDataAdapter da = new SqlDataAdapter(sqlFind, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            decimal tiengiam = dt.Rows[0].Field<decimal>(0);
            cnn.Close();
            return tiengiam;
        }
    }
}
