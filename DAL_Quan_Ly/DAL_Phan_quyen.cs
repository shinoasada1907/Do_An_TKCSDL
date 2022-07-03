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
    public class DAL_Phan_quyen:Connect_data
    {
        public string get_MaQuyen(string TenQuyen)
        {
            cnn.Open();
            string sql = string.Format("select MaPhanQuyen from Phan_Quyen where TenQuyen = N'{0}'", TenQuyen);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string MaQuyen = dt.Rows[0].Field<string>(0);
            cnn.Close();
            return MaQuyen;

        }
        public string get_TenQuyen(string MaQuyen)
        {
            cnn.Open();
            string sql = string.Format("select TenQuyen from Phan_Quyen where MaPhanQuyen = '{0}'", MaQuyen);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string TenQuyen = dt.Rows[0].Field<string>(0);
            cnn.Close();
            return TenQuyen;

        }
        public DataTable get_AllMaQuyen()
        {
            cnn.Open();
            string sql = string.Format("select MaPhanQuyen from Phan_Quyen");
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dtAllMaQuyen = new DataTable();
            da.Fill(dtAllMaQuyen);
            cnn.Close();
            return dtAllMaQuyen;
        }
        public DataTable get_AllTenQuyen()
        {
            cnn.Open();
            string sql = string.Format("select TenQuyen from Phan_Quyen");
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dtAllTenQuyen = new DataTable();
            da.Fill(dtAllTenQuyen);
            cnn.Close();
            return dtAllTenQuyen;
        }
    }
}
