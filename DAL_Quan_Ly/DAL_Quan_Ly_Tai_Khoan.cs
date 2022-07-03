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
    public class DAL_Quan_Ly_Tai_Khoan: Connect_data
    {
        //kiểm tra quyền của tài khoản
        public bool checkTaiKhoan(string TenTaiKhoan, string MatKhau, string NguoiDung)
        {
            if (NguoiDung == "Nhân viên")
            {
                cnn.Open();
                string sql = string.Format("select * from Tai_Khoan where username = '{0}' and passwords = '{1}' and MaPhanquyen = 'Nhanvien'", TenTaiKhoan, MatKhau);
                SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cnn.Close();
                if (dt.Rows.Count > 0) return true;
                else return false;
            }
            else
            {
                cnn.Open();
                string sql = string.Format("select * from Tai_Khoan where username = '{0}' and passwords = '{1}' and MaPhanquyen = 'Quanly'", TenTaiKhoan, MatKhau);
                SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cnn.Close();
                if (dt.Rows.Count > 0) return true;
                else return false;
            }
        }
        //Lấy mã nhân viên của tài khoản
        public string get_MaNVTaiKhoan(string TenTaiKhoan)
        {
            cnn.Open();
            string sql = string.Format("select MaNV from Tai_Khoan where username = '{0}'", TenTaiKhoan);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string manv = dt.Rows[0].Field<string>(0);
            cnn.Close();
            return manv;
        }

        //Lấy danh sách tài khoản
        public DataTable get_AllTaiKhoan()
        {
            cnn.Open();
            string sql = string.Format("select a.username, a.passwords, b.TenQuyen, c.HoTenNV, c.Chucvu from Tai_Khoan a, Phan_Quyen b, Nhan_Vien c where a.MaNV = c.MaNV and a.MaPhanquyen = b.MaPhanQuyen");
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        //Lấy tên tài khoản từ mã nhân viên
        public string get_TenTaiKhoan_MaNV(string MaNV)
        {
            cnn.Open();
            string sql = string.Format("select username from Tai_Khoan where MaNV = '{0}'", MaNV);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string tentaikhoan = dt.Rows[0].Field<string>(0);
            cnn.Close();
            return tentaikhoan;
        }
        //Lấy tên phân quyền từ tên tài khoản
        public string get_PhanQuyen_TenTaiKhoan(string TenTaiKhoan)
        {
            cnn.Open();
            string sql = string.Format("select b.TenQuyen from Tai_Khoan a, Phan_Quyen b where a.MaPhanquyen = b.MaPhanQuyen and username = '{0}'", TenTaiKhoan);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string tenquyen = dt.Rows[0].Field<string>(0);
            cnn.Close();
            return tenquyen;
        }
        //Lấy mật khẩu từ tên tài khoản
        public string get_MatKhau_TenTaiKhoan(string TenTaiKhoan)
        {
            cnn.Open();
            string sql = string.Format("select passwords from Tai_Khoan where username = '{0}'", TenTaiKhoan);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string matkhau = dt.Rows[0].Field<string>(0);
            cnn.Close();
            return matkhau;
        }
        //Lấy tất cả mã nhân viên
        public DataTable get_AllMaNV_TaiKhoan()
        {
            cnn.Open();
            string sql = string.Format("select MaNV from Tai_Khoan");
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        //thêm tài khoản
        public bool insert_TaiKhoan(DTO_Tai_Khoan tk)
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("INSERT_TK", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@USERNAME", tk.TenTaiKhoan);
                cmd.Parameters.AddWithValue("@PASS", tk.MatKhau);
                cmd.Parameters.AddWithValue("@MANV", tk.MaNV);
                cmd.Parameters.AddWithValue("@MAQUYEN", tk.MaQuyen);
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
        //xóa tài khoản
        public bool update_TaiKhoan(DTO_Tai_Khoan tk)
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE_TK", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@USERNAME", tk.TenTaiKhoan);
                cmd.Parameters.AddWithValue("@PASS", tk.MatKhau);
                cmd.Parameters.AddWithValue("@MANV", tk.MaNV);
                cmd.Parameters.AddWithValue("@MAQUYEN", tk.MaQuyen);
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
        //xóa tài khoản
        public bool delete_TaiKhoan(string username)
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("DELETE_TK", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@USERNAME", username);
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
        //tìm kiếm tài khoản theo tên
        public DataTable search_TaiKhoan(string TenTaiKhoan)
        {
            cnn.Open();
            string sql = string.Format("select * from Tai_Khoan where username = '{0}'", TenTaiKhoan);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        public DataTable search_TaiKhoan_fromManv(string manv)
        {
            cnn.Open();
            string sql = string.Format("select a.username, a.passwords, b.TenQuyen, c.HoTenNV, c.Chucvu from Tai_Khoan a, Phan_Quyen b, Nhan_Vien c where a.MaNV = c.MaNV and a.MaPhanquyen = b.MaPhanQuyen and a.MaNV = '{0}'", manv);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
    }
}
