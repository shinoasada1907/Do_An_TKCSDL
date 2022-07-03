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
    public class DAL_Hoa_Don:Connect_data
    {
        public DataTable get_HoaDon_KH()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select a.MaHD, b.HoTenNV, c.TenKH, a.Ngay_lap_HD, a.Tongtien  from Hoa_Don a, Nhan_Vien b, Khach_Hang c where a.MaNV = b.MaNV and a.MaKH = c.MaKH", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        public DataTable get_HoaDon_HV()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select a.MaHD, b.HoTenNV, c.TenHV, a.Ngay_lap_HD, a.Tongtien  from Hoa_Don a, Nhan_Vien b, Hoi_Vien c where a.MaNV = b.MaNV and a.MaHV = c.MaHV", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        //Thêm hóa đơn
        public bool insert_HoaDon_hoivien(DTO_Hoa_Don hoadon)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("INSERT_HD_HV", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaHD", hoadon.MaHD);
                cmd.Parameters.AddWithValue("@MaNV", hoadon.MaNVLap);
                cmd.Parameters.AddWithValue("@MaHV", hoadon.MaHV);
                cmd.Parameters.AddWithValue("@Ngay_lap_HD", hoadon.NgayLap);
                cmd.Parameters.AddWithValue("@Tongtien", hoadon.TongTien);
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
        public bool insert_HoaDon_khachhang(DTO_Hoa_Don hoadon)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("INSERT_HD_KH", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaHD", hoadon.MaHD);
                cmd.Parameters.AddWithValue("@MaKH", hoadon.MaKH);
                cmd.Parameters.AddWithValue("@MaNV", hoadon.MaNVLap);
                cmd.Parameters.AddWithValue("@Ngay_lap_HD", hoadon.NgayLap);
                cmd.Parameters.AddWithValue("@Tongtien", hoadon.TongTien);
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
        //tìm kiếm theo số điện thoại là hội viên
        public DataTable search_HoaDon_TenHV(string tenhv)
        {
            cnn.Open();
            string sql = string.Format("select a.MaHD, b.HoTenNV, c.TenHV, a.Ngay_lap_HD, a.Tongtien  from Hoa_Don a, Nhan_Vien b, Hoi_Vien c where a.MaNV = b.MaNV and a.MaHV = c.MaHV and c.TenHV = N'{0}'", tenhv);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        public DataTable search_HoaDon_TenKH(string tenkh)
        {
            cnn.Open();
            string sql = string.Format("select a.MaHD, b.HoTenNV, c.TenKH, a.Ngay_lap_HD, a.Tongtien  from Hoa_Don a, Nhan_Vien b, Khach_Hang c where a.MaNV = b.MaNV and a.MaKH = c.MaKH and c.MaKH = N'{0}'", tenkh);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        public string get_mahd_cuoi()
        {
            cnn.Open();
            string sql = string.Format("SELECT TOP 1 MaHD FROM Hoa_Don ORDER BY MaHD DESC ");
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string mahd = dt.Rows[0].Field<string>(0);
            cnn.Close();
            return mahd;
        }
    }
}
