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
    public class DAL_Chi_tiet_hoa_don:Connect_data
    {
        //chi tiết hóa dơn với mã hóa đơn
        public DataTable get_CTHD(string MaHD)
        {
            cnn.Open();
            string sql = string.Format("select b.TenSP, a.Ma_voucher, b.GiaSP, a.SLMua, a.Thanhtien from Chi_Tiet_Hoa_Don a, San_Pham b where MaHD = '{0}' and a.MaSP = b.MaSP", MaHD);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        public bool insert_CTHD(DTO_chi_tiet_hoa_don cthd)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("INSERT_CTHD", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaHD", cthd.MaHD);
                cmd.Parameters.AddWithValue("@MaSP", cthd.MaSP);
                cmd.Parameters.AddWithValue("@Ma_voucher", cthd.Mavoucher);
                cmd.Parameters.AddWithValue("@SLMua", cthd.SLMua);
                cmd.Parameters.AddWithValue("@Thanhtien", cthd.ThanhTien);
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
        public bool update_CTHD(DTO_chi_tiet_hoa_don cthd)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE_CTHD", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaHD", cthd.MaHD);
                cmd.Parameters.AddWithValue("@MaSP", cthd.MaSP);
                cmd.Parameters.AddWithValue("@Ma_voucher", cthd.Mavoucher);
                cmd.Parameters.AddWithValue("@SLMua", cthd.SLMua);
                cmd.Parameters.AddWithValue("@Thanhtien", cthd.ThanhTien);
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
        public bool delete_CTHD(DTO_chi_tiet_hoa_don cthd)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("INSERT_CTHD", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaHD", cthd.MaHD);
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
        public DataTable update_voucher_HD(string mavoucher)
        {
            cnn.Open();
            string sql = string.Format("update Chi_Tiet_Hoa_Don set Ma_voucher = 'NO' where Ma_voucher = '{0}'", mavoucher);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
    }
}
