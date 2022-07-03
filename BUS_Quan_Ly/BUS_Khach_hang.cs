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
    public class BUS_Khach_hang
    {
        DAL_khach_hang khachhang = new DAL_khach_hang();
        public DataTable get_KhachHang() => khachhang.get_KhachHang();
        public string get_TenKhachHang(string MaKH) => khachhang.get_TenKhachHang(MaKH);
        public string get_SDTKH(string MaKH) => khachhang.get_SDTKH(MaKH);
        public string get_DiaChi(string MaKH) => khachhang.get_DiaChi(MaKH);
        public string getMaKHFromSDTKH(string SDTKH) => khachhang.getMaKHFromSDTKH(SDTKH);
        public bool insert_KH(DTO_Quan_Ly_Khach_hang kh) => khachhang.insert_KH(kh);
        public bool delete_KH(string kh) => khachhang.delete_KH(kh);
        public bool update_KH(DTO_Quan_Ly_Khach_hang kh) => khachhang.update_KH(kh);
        public DataTable get_SDT(string SDT) => khachhang.get_SDT(SDT);
        public DataTable get_thontin_KhachHang(string name) => khachhang.get_thontin_KhachHang(name);
        public string get_makh_cuoi() => khachhang.get_makh_cuoi();
        public string get_makh(string tenkh) => khachhang.get_makh(tenkh);
        public bool check_khachhang(string sdt) => khachhang.check_khachhang(sdt);
        public string get_gioitinh(string makh) => khachhang.get_gioitinh(makh);
        public DateTime get_ngaysinh(string makh) => khachhang.get_ngaysinh(makh);
    }
}
