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
    public class BUS_Nhan_vien
    {
        DAL_Nhan_vien nhanvien = new DAL_Nhan_vien();
        public DataTable getNhanVien() => nhanvien.getNhanVien();
        public bool insert_NhanVien(DTO_Quan_Ly_Nhan_Vien nv) => nhanvien.insert_NhanVien(nv);
        public bool update_NhanVien(DTO_Quan_Ly_Nhan_Vien nv) => nhanvien.update_NhanVien(nv);
        public bool delete_NhanVien(string MANV) => nhanvien.delete_NhanVien(MANV);
        public DataTable search_nameNhanVien(string HoTenNV) => nhanvien.find_nameNhanVien(HoTenNV);
        public string get_HoTenNhanVien(string MaNV) => nhanvien.get_HoTenNhanVien(MaNV);
        public string get_ChucVu(string MaNV) => nhanvien.get_ChucVu(MaNV);
        public DataTable get_MaNVChuaCoTaiKhoan() => nhanvien.get_MaNVChuaCoTaiKhoan();
        public string get_Manv(string tennv) => nhanvien.get_Manv(tennv);
        public DataTable get_AllManv() => nhanvien.get_AllManv();
        public bool update_ChucvuNhanVien(string manv, string chucvu) => nhanvien.update_ChucvuNhanVien(manv, chucvu);
    }
}
