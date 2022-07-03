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
    public class DAL_San_Pham:Connect_data
    {
        public DataTable get_sanpham()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select a.MaSP, a.TenSP, b.TenLoaiSP,a.GiaSP, a.Hang_SX, a.SLTon, c.Ten_voucher from San_Pham a, Loai_San_Pham b, voucher c where a.MaLoai = b.MaLoai and a.Ma_voucher = c.Ma_voucher", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        //lấy mã sả phẩm
        public string get_masp(string tensp)
        {
            cnn.Open();
            string sql = string.Format("SELECT MaSP FROM San_Pham WHERE TenSP = N'{0}'", tensp);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string MaSP = dt.Rows[0].Field<string>(0);
            cnn.Close();
            return MaSP;
        }
        public string get_tensp(string masp)
        {
            cnn.Open();
            string sql = string.Format("SELECT TenSP FROM San_Pham WHERE MaSP = '{0}'", masp);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string MaSP = dt.Rows[0].Field<string>(0);
            cnn.Close();
            return MaSP;
        }
        public string get_tenvoucher(string tensp)
        {
            cnn.Open();
            string sql = string.Format("select b.Ten_voucher from San_Pham a, voucher b where a.Ma_voucher = b.Ma_voucher and a.TenSP = N'{0}'", tensp);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string tenvoucher = dt.Rows[0].Field<string>(0);
            cnn.Close();
            return tenvoucher;
        }
        public decimal get_giatien(string masp)
        {
            cnn.Open();
            string sql = string.Format("select GiaSP from San_Pham where MaSP = '{0}'", masp);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
           decimal giatien = dt.Rows[0].Field<decimal>(0);
            cnn.Close();
            return giatien;
        }

        //lấy thông tin sản phẩm
        public DataTable get_thongtinsanpham(string masp)
        {
            cnn.Open();
            string sql = string.Format("SELECT * FROM San_Pham WHERE MaSP = '{0}'", masp);
            SqlDataAdapter da = new SqlDataAdapter(sql,cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        public bool insert_sp(DTO_San_Pham sp)
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand($"INSERT_SP", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaSP", sp.MaSP);
                cmd.Parameters.AddWithValue("@MaLoai", sp.MaLoai);
                cmd.Parameters.AddWithValue("@Ma_voucher", sp.Ma_voucher);
                cmd.Parameters.AddWithValue("@TenSP", sp.TenSP);
                cmd.Parameters.AddWithValue("@GiaSP", sp.GiaBan);
                cmd.Parameters.AddWithValue("@ThuongHieu", sp.Thuong_Hieu);
                cmd.Parameters.AddWithValue("@SlTon", sp.SLTon);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                cnn.Close();
            }
            return false;
        }

        public bool delete_sp(string masp)
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("DELETE_SP", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaSP", masp);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                cnn.Close();
            }
            return false;
        }

        public bool update_sp(DTO_San_Pham sp)
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE_SP", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaSP", sp.MaSP);
                cmd.Parameters.AddWithValue("@MaLoai", sp.MaLoai);
                cmd.Parameters.AddWithValue("@Ma_voucher", sp.Ma_voucher);
                cmd.Parameters.AddWithValue("@TenSP", sp.TenSP);
                cmd.Parameters.AddWithValue("@GiaSP", sp.GiaBan);
                cmd.Parameters.AddWithValue("@ThuongHieu", sp.Thuong_Hieu);
                cmd.Parameters.AddWithValue("@SlTon", sp.SLTon);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                cnn.Close();
            }
            return false;
        }

        //tìm kiếm sản phẩm
        public DataTable search_namesp(string tensp)
        {
            cnn.Open();
            string sql = string.Format("SELECT a.MaSP, a.TenSP, b.TenLoaiSP,a.GiaSP, a.Hang_SX, a.SLTon, c.Ten_voucher FROM San_Pham a, Loai_San_Pham b, voucher c WHERE a.MaLoai = b.MaLoai and a.Ma_voucher = c.Ma_voucher AND a.TenSP = N'{0}'", tensp);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        //tìm kiếm theo mã loại sản phẩm
        public DataTable search_maloaisp(string maloai)
        {
            cnn.Open();
            string sql = string.Format("SELECT a.MaSP, a.TenSP, b.TenLoaiSP,a.GiaSP, a.Hang_SX, a.SLTon, c.Ten_voucher FROM San_Pham a, Loai_San_Pham b, voucher c WHERE a.MaLoai = b.MaLoai and a.Ma_voucher = c.Ma_voucher AND a.MaLoai = '{0}'", maloai);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        //lấy tất cả mã sản phẩm
        public DataTable get_AllMaSP()
        {
            cnn.Open();
            string sql = string.Format("select MaSP from San_Pham");
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        //kiếm tra mã sản phẩm
        public bool check_MaSP(string masp)
        {
            cnn.Open();
            string sql = string.Format("select MaSP from San_Pham where MaSP ='{0}'", masp);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            if (dt.Rows.Count > 0) return true;
            else return false;
        }

        //update mã voucher
        public DataTable update_mavoucher(string mavoucher)
        {
            cnn.Open();
            string sql = string.Format("update San_Pham set Ma_voucher = 'NO' where Ma_voucher = '{0}'", mavoucher);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
    }
}
