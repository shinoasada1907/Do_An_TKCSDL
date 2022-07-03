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
    public class DAL_Loai_San_Pham:Connect_data
    {
        public DataTable get_Loaisanpham()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Loai_San_Pham", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        //Lấy tên loại từ mã loại
        public string get_TenLoaiSP(string MaLoai)
        {
            cnn.Open();
            string sql = string.Format("select TenLoaiSP from Loai_San_Pham where MaLoai = '{0}'", MaLoai);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string TenLoai = dt.Rows[0].Field<string>(0);
            cnn.Close();
            return TenLoai;

        }
        //Lấy mã loại từ tên loại
        public string get_MaLoaiSP(string TenLoai)
        {
            cnn.Open();
            string sql = string.Format("select MaLoai from Loai_San_Pham where TenLoaiSP = N'{0}'", TenLoai);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string MaLoai = dt.Rows[0].Field<string>(0);
            cnn.Close();
            return MaLoai;
        }
        //Thêm loại sản phẩm
        public bool insert_LoaiSP(DTO_Loai_san_pham loai)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("INSERT_LSP", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaLoai", loai.MaLoai);
                cmd.Parameters.AddWithValue("@TenLoai", loai.TenLoai);
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
        //xóa loại sản phẩm
        public bool delete_LoaiSP(DTO_Loai_san_pham loai)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("DELETE_LSP", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaLoai", loai.MaLoai);
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

        //cập nhật loại sản phẩm
        public bool update_LoaiSP(DTO_Loai_san_pham loai)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE_LSP", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaLoai", loai.MaLoai);
                cmd.Parameters.AddWithValue("@TenLoai", loai.TenLoai);
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
        public DataTable get_Tenloaisanpham()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select TenLoaiSP from Loai_San_Pham", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
    }
}
