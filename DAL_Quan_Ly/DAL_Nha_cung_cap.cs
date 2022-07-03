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
    public class DAL_Nha_cung_cap:Connect_data
    {
        public DataTable get_AllNCC()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Nha_cung_cap", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        //Lấy mã NCC từ tên NCC
        public string get_MaNCC(string TenNCC)
        {
            cnn.Open();
            string sql = string.Format("select MaNCC from Nha_cung_cap where TenNCC = N'{0}'", TenNCC);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string MaNCC = dt.Rows[0].Field<string>(0);
            cnn.Close();
            return MaNCC;
        }
        //Lấy danh sách tên ncc
        public DataTable get_AllTenNCC()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select TenNCC from Nha_cung_cap", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        //Thêm NCC
        public bool insert_NCC(DTO_Nha_Cung_Cap ncc)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("INSERT_NCC", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNCC", ncc.MaNCC);
                cmd.Parameters.AddWithValue("@TenNCC", ncc.TenNCC);
                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                // Dong ket noi
                cnn.Close();
            }

            return false;
        }
        //Sửa NCC
        public bool update_NCC(DTO_Nha_Cung_Cap ncc)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE_NCC", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNCC", ncc.MaNCC);
                cmd.Parameters.AddWithValue("@TenNCC", ncc.TenNCC);
                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                // Dong ket noi
                cnn.Close();
            }

            return false;
        }
        //Xóa NCC
        public bool delete_NCC(string mancc)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("DELETE_NCC", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNCC", mancc);
                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                // Dong ket noi
                cnn.Close();
            }

            return false;
        }
        //Tìm kiếm NCC
        public DataTable search_NCC(string TenNCC)
        {
            cnn.Open();
            string sql = string.Format("select * from Nha_cung_cap where TenNCC = N'{0}'", TenNCC);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        //Lấy tên ncc từ mã ncc
        public string get_TenNCC(string mancc)
        {
            cnn.Open();
            string sql = string.Format("select TenNCC from Nha_cung_cap where MaNCC = '{0}'", mancc);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string tenncc = dt.Rows[0].Field<string>(0);
            cnn.Close();
            return tenncc;
        }
    }
}
