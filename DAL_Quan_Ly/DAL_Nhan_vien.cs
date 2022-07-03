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
    public class DAL_Nhan_vien:Connect_data
    {
        public DataTable getNhanVien()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Nhan_Vien", cnn);
            DataTable dtNhanVien = new DataTable();
            da.Fill(dtNhanVien);
            cnn.Close();
            return dtNhanVien;
        }
        public DataTable get_AllManv()
        {
            cnn.Open();
            string sqlFind = string.Format("select MaNV  from Nhan_Vien");
            SqlDataAdapter da = new SqlDataAdapter(sqlFind, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        public bool insert_NhanVien(DTO_Quan_Ly_Nhan_Vien nv)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("INSERT_NV", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNV", nv.MaNV);
                cmd.Parameters.AddWithValue("@HoTenNV", nv.TenNV);
                cmd.Parameters.AddWithValue("@Ngaysinh", nv.Ngaysinh);
                cmd.Parameters.AddWithValue("@GioiTinhNV", nv.GioiTinh);
                cmd.Parameters.AddWithValue("@Chucvu", nv.ChucVu);
                cmd.Parameters.AddWithValue("@SDTNV", nv.SDT);
                cmd.Parameters.AddWithValue("@DiachiNV", nv.Diachi);
                cmd.Parameters.AddWithValue("@LuongNV", nv.LuongNV);
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
        public bool update_NhanVien(DTO_Quan_Ly_Nhan_Vien nv)
        {
            try
            {
                // Ket noi
                cnn.Open();
                // Query string
                SqlCommand cmd = new SqlCommand("UPDATE_NV", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNV", nv.MaNV);
                cmd.Parameters.AddWithValue("@HoTenNV", nv.TenNV);
                cmd.Parameters.AddWithValue("@Ngaysinh", nv.Ngaysinh);
                cmd.Parameters.AddWithValue("@GioiTinhNV", nv.GioiTinh);
                cmd.Parameters.AddWithValue("@Chucvu", nv.ChucVu);
                cmd.Parameters.AddWithValue("@SDTNV", nv.SDT);
                cmd.Parameters.AddWithValue("@DiachiNV", nv.Diachi);
                cmd.Parameters.AddWithValue("@LuongNV", nv.LuongNV);
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
        public bool update_ChucvuNhanVien(string manv, string chucvu)
        {
            try
            {
                // Ket noi
                cnn.Open();
                // Query string
                SqlCommand cmd = new SqlCommand("UPDATE_ChucvuNV", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNV", manv);
                cmd.Parameters.AddWithValue("@Chucvu", chucvu);
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
        public bool delete_NhanVien(string MANV)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("DELETE_NV", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNV", MANV);
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
        public DataTable find_nameNhanVien(string HoTenNV)
        {
            cnn.Open();
            string sqlFind = string.Format("select * from Nhan_Vien where HoTenNV = N'{0}'", HoTenNV);
            SqlDataAdapter da = new SqlDataAdapter(sqlFind, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        //Lấy họ tên nhân viên
        public string get_HoTenNhanVien(string MaNV)
        {
            cnn.Open();
            string sql = string.Format("select HoTenNV from Nhan_Vien where MaNV = '{0}'", MaNV);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string HoTenNV = dt.Rows[0].Field<string>(0);
            cnn.Close();
            return HoTenNV;
        }

        //Lấy chức vụ nhân viên
        public string get_ChucVu(string MaNV)
        {
            cnn.Open();
            string sqlFind = string.Format("select Chucvu from Nhan_Vien where MaNV = '{0}'", MaNV);
            SqlDataAdapter da = new SqlDataAdapter(sqlFind, cnn);
            DataTable dtChucVu = new DataTable();
            da.Fill(dtChucVu);
            string ChucVu = dtChucVu.Rows[0].Field<string>(0);
            cnn.Close();
            return ChucVu;
        }

        public string get_Manv(string tennv)
        {
            cnn.Open();
            string sqlFind = string.Format("select MaNV  from Nhan_Vien where HoTenNV = N'{0}'", tennv);
            SqlDataAdapter da = new SqlDataAdapter(sqlFind, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string manv = dt.Rows[0].Field<string>(0);
            cnn.Close();
            return manv;
        }

        //Lấy danh sách Mã Nhân Viên chưa có tài khoản
        public DataTable get_MaNVChuaCoTaiKhoan()
        {
            cnn.Open();
            string sqlFind = string.Format("select MaNV from Nhan_Vien except select MaNV from Tai_Khoan");
            SqlDataAdapter da = new SqlDataAdapter(sqlFind, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
    }
}
