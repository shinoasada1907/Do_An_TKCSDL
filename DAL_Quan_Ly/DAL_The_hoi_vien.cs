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
    public class DAL_The_hoi_vien:Connect_data
    {
        //lấy thẻ hội viên
        public DataTable get_theHV()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from The_Hoi_Vien", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        //tên thẻ hội viên
        public DataTable get_TentheHV()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select Loai_The from The_Hoi_Vien", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        //lấy giá tiền theo loại thẻ
        public decimal get_Giatienthe(string loaithe)
        {
            cnn.Open();
            string sql = string.Format("select Gia_The from The_Hoi_Vien where Loai_The = N'{0}'", loaithe);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            decimal giathe = dt.Rows[0].Field<decimal>(0);
            cnn.Close();
            return giathe;
        }
        //lấy giá tiền giảm theo loại thẻ
        public decimal get_Giatiengiam(string loaithe)
        {
            cnn.Open();
            string sql = string.Format("select Tien_Giam from The_Hoi_Vien where Loai_The = N'{0}'", loaithe);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            decimal tiengiam = dt.Rows[0].Field<decimal>(0);
            cnn.Close();
            return tiengiam;
        }
        //thêm loại thẻ 
        public bool insert_TheHV(DTO_The_Hoi_Vien thv)
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("INSERT_THV", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@LOAITHE", thv.Loaithe);
                cmd.Parameters.AddWithValue("@GIATHE", thv.Giathe);
                cmd.Parameters.AddWithValue("@TIENGIAM", thv.Khuyenmaithe);
                cmd.Parameters.AddWithValue("@THOIGIANTHE", thv.Thoigianthe);
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
        //update thẻ hội viên
        public bool update_TheHV(DTO_The_Hoi_Vien thv)
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE_THV", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@LOAITHE", thv.Loaithe);
                cmd.Parameters.AddWithValue("@GIATHE", thv.Giathe);
                cmd.Parameters.AddWithValue("@TIENGIAM", thv.Khuyenmaithe);
                cmd.Parameters.AddWithValue("@THOIGIANTHE", thv.Thoigianthe);
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
        //xóa thẻ hội viên
        public bool delete_TheHV(string loaithe)
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("DELETE_THV", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@LOAITHE", loaithe);
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
    }
}
