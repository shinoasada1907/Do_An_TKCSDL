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
    public class BUS_hoa_don
    {
        DAL_Hoa_Don hoadon = new DAL_Hoa_Don();
        public DataTable get_HoaDon_KH() => hoadon.get_HoaDon_KH();
        public DataTable get_HoaDon_HV() => hoadon.get_HoaDon_HV();
        public bool insert_HoaDon_hoivien(DTO_Hoa_Don hd) => hoadon.insert_HoaDon_hoivien(hd);
        public bool insert_HoaDon_khachang(DTO_Hoa_Don hd) => hoadon.insert_HoaDon_khachhang(hd);
        public DataTable search_HoaDon_TenHV(string tenhv) => hoadon.search_HoaDon_TenHV(tenhv);
        public string get_mahd_cuoi() => hoadon.get_mahd_cuoi();
        public DataTable search_HoaDon_TenKH(string tenkh) => hoadon.search_HoaDon_TenKH(tenkh);
    }
}
