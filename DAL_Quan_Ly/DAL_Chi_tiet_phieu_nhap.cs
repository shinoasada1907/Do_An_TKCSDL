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
    public class DAL_Chi_tiet_phieu_nhap:Connect_data
    {
        public DataTable get_dgvCTPN(string maphieu)
        {
            cnn.Open();
            string sql = string.Format("select b.TenSP, c.TenLoaiSP, a.Gia_Goc, a.SLNhap, a.Thanhtien from Chi_Tiet_Phieu_Nhap a, San_Pham b, Loai_San_Pham c where a.MaSP = b.MaSP and a.MaLoai = c.MaLoai and a.MaPhieu = '{0}'", maphieu);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        public DataTable get_CTPN()
        {
            cnn.Open();
            string sql = string.Format("select * from Chi_Tiet_Phieu_Nhap");
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        public bool insert_CTPN(DTO_Chi_tiet_phieu_nhap ctpn)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("INSERT_CTPN", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaPhieu", ctpn.MaPhieu);
                cmd.Parameters.AddWithValue("@MaSP", ctpn.MaSP);
                cmd.Parameters.AddWithValue("@MaLoai", ctpn.MaLoai);
                cmd.Parameters.AddWithValue("@Gia_Goc", ctpn.GiaGoc);
                cmd.Parameters.AddWithValue("@SLNhap", ctpn.SLNhap);
                cmd.Parameters.AddWithValue("@Thanhtien", ctpn.ThanhTien);
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
        public bool update_CTPN(DTO_Chi_tiet_phieu_nhap ctpn)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE_CTPN", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaPhieu", ctpn.MaPhieu);
                cmd.Parameters.AddWithValue("@MaSP", ctpn.MaSP);
                cmd.Parameters.AddWithValue("@MaLoai", ctpn.MaLoai);
                cmd.Parameters.AddWithValue("@Gia_Goc", ctpn.GiaGoc);
                cmd.Parameters.AddWithValue("@SLNhap", ctpn.SLNhap);
                cmd.Parameters.AddWithValue("@Thanhtien", ctpn.ThanhTien);
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
        public bool delete_CTPN(DTO_Chi_tiet_phieu_nhap ctpn)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("DELETE_CTPN", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaPhieu", ctpn.MaPhieu);
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
    }
}
