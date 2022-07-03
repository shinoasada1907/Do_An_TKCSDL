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
    public class DAL_Voucher:Connect_data
    {
        //Lấy voucher
        public DataTable get_voucher()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from voucher", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        //lấy tên voucher với mã voucher
        public string get_Tenvoucher(string mavoucher)
        {
            cnn.Open();
            string sql = string.Format("select Ten_voucher from voucher where Ma_voucher = '{0}'", mavoucher);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string tenvoucher = dt.Rows[0].Field<string>(0);
            cnn.Close();
            return tenvoucher;
        }
        //lấy mã từ tên
        public string get_Mavoucher(string tenvoucher)
        {
            cnn.Open();
            string sql = string.Format("select Ma_voucher from voucher where Ten_voucher = N'{0}'", tenvoucher);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string mavoucher = dt.Rows[0].Field<string>(0);
            cnn.Close();
            return mavoucher;
        }
        //thêm voucher
        public bool insert_voucher(DTO_Voucher voucher)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("INSERT_VOUCHER", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MAVOUCHER", voucher.Ma_voucher);
                cmd.Parameters.AddWithValue("@TENVOUCHER", voucher.Ten_voucher);
                cmd.Parameters.AddWithValue("@GiatriKM", voucher.Tiengiam);
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

        //xóa voucher
        public bool delete_voucher(DTO_Voucher voucher)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("DELETE_VOUCHER", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MAVOUCHER", voucher.Ma_voucher);
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

        //update voucher
        public bool update_voucher(DTO_Voucher voucher)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE_VOUCHER", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MAVOUCHER", voucher.Ma_voucher);
                cmd.Parameters.AddWithValue("@TENVOUCHER", voucher.Ten_voucher);
                cmd.Parameters.AddWithValue("@GiatriKM", voucher.Tiengiam);
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
        public DataTable get_name_voucher()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select Ten_voucher from voucher", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        public decimal get_TienKM(string mavoucher)
        {
            cnn.Open();
            string sql = string.Format("select GiatriKM from voucher where Ma_voucher = '{0}'", mavoucher);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            decimal tienkm = dt.Rows[0].Field<decimal>(0);
            cnn.Close();
            return tienkm;
        }
    }
}
