using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_Quan_Ly;
using DTO_Quan_ly;


namespace BUS_Quan_Ly
{
    public class BUS_San_Pham
    {
        DAL_San_Pham DAL_SP = new DAL_San_Pham();
        public DataTable get_sanpham()
        {
            return DAL_SP.get_sanpham();
        }
        public string get_masp(string tensp)
        {
            return DAL_SP.get_masp(tensp);
        }
        public DataTable get_thongtinsanpham(string masp)
        {
            return DAL_SP.get_thongtinsanpham(masp);
        }
        public bool insert_sp(DTO_San_Pham sp)
        {
            return DAL_SP.insert_sp(sp);
        }
        public bool delete_sp(string sp)
        {
            return DAL_SP.delete_sp(sp);
        }
        public bool update_sp(DTO_San_Pham sp)
        {
            return DAL_SP.update_sp(sp);
        }
        public DataTable search_namesp(string sp)
        {
            return DAL_SP.search_namesp(sp);
        }
        public DataTable get_AllMaSP()
        {
            return DAL_SP.get_AllMaSP();
        }
        public bool check_MaSP(string masp)
        {
            return DAL_SP.check_MaSP(masp);
        }
        public DataTable update_mavoucher(string masp)
        {
            return DAL_SP.update_mavoucher(masp);
        }
        public DataTable search_maloaisp(string maloai)
        {
            return DAL_SP.search_maloaisp(maloai);
        }
        public string get_tensp(string masp) => DAL_SP.get_tensp(masp);
        public string get_tenvoucher(string tensp) => DAL_SP.get_tenvoucher(tensp);
        public decimal get_giatien(string masp) => DAL_SP.get_giatien(masp);
    }
}
