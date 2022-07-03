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
    public class DAL_phieu_nhap_hang:Connect_data
    {
        public DataTable get_AllPhieuNhap()
        {
            cnn.Open();
            string sql = string.Format("select a.MaPhieu, c.TenNCC, a.MaNV, b.HoTenNV, a.Ngaylap, a.Tongtien from Phieu_Nhap_hang a, Nhan_Vien b, Nha_cung_cap c where a.MaNV = b.MaNV and a.MaNCC = c. MaNCC");
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        public DataTable get_PhieuNhap(string MaPhieu)
        {
            cnn.Open();
            string sql = string.Format("select a.MaPhieu, c.TenNCC, a.MaNV, b.HoTenNV, a.Ngaylap, a.Tongtien from Phieu_Nhap_hang a, Nhan_Vien b, Nha_cung_cap c where a.MaNV = b.MaNV and a.MaNCC = c. MaNCC and a.MaPhieu = '{0}'", MaPhieu);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        public DataTable get_PhieuNhap_NCC(string tenncc)
        {
            cnn.Open();
            string sql = string.Format("select a.MaPhieu, c.TenNCC, a.MaNV, b.HoTenNV, a.Ngaylap, a.Tongtien from Phieu_Nhap_hang a, Nhan_Vien b, Nha_cung_cap c where a.MaNV = b.MaNV and a.MaNCC = c. MaNCC and c.TenNCC = N'{0}'", tenncc);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        public bool insert_PhieuNhap(DTO_Phieu_Nhap phieunhap)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("INSERT_PNH", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaPhieu", phieunhap.MaPhieu);
                cmd.Parameters.AddWithValue("@MaNV", phieunhap.MaNVNhap);
                cmd.Parameters.AddWithValue("@MaNCC", phieunhap.MaNCC);
                cmd.Parameters.AddWithValue("@Ngaylap", phieunhap.NgayNhap);
                cmd.Parameters.AddWithValue("@Tongtien", phieunhap.TongTien);
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
        public bool update_PhieuNhap(DTO_Phieu_Nhap maphieu)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE_PNH", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaPhieu", maphieu.MaPhieu);
                cmd.Parameters.AddWithValue("@MaNV", maphieu.MaNVNhap);
                cmd.Parameters.AddWithValue("@MaNCC", maphieu.MaNCC);
                cmd.Parameters.AddWithValue("@Ngaylap", maphieu.NgayNhap);
                cmd.Parameters.AddWithValue("@Tongtien", maphieu.TongTien);
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
        public bool update_Tongtien(string maphieu, decimal tongtien)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE_TONGTIEN", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaPhieu", maphieu);
                cmd.Parameters.AddWithValue("@Tongtien", tongtien);
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
