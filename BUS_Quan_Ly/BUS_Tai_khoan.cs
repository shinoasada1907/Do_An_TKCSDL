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
    public class BUS_Tai_khoan
    {
        DAL_Quan_Ly_Tai_Khoan taikhoan = new DAL_Quan_Ly_Tai_Khoan();
        public bool checkTaiKhoan(string TenTaiKhoan, string MatKhau, string NguoiDung) => taikhoan.checkTaiKhoan(TenTaiKhoan, MatKhau, NguoiDung);
        public string get_MaNVTaiKhoan(string TenTaiKhoan) => taikhoan.get_MaNVTaiKhoan(TenTaiKhoan);
        public DataTable get_AllTaiKhoan() => taikhoan.get_AllTaiKhoan();
        public string get_TenTaiKhoan_MaNV(string MaNV) => taikhoan.get_TenTaiKhoan_MaNV(MaNV);
        public string get_PhanQuyen_TenTaiKhoan(string TenTaiKhoan) => taikhoan.get_PhanQuyen_TenTaiKhoan(TenTaiKhoan);
        public string get_MatKhau_TenTaiKhoan(string TenTaiKhoan) => taikhoan.get_MatKhau_TenTaiKhoan(TenTaiKhoan);
        public DataTable get_AllMaNV_TaiKhoan() => taikhoan.get_AllMaNV_TaiKhoan();
        public bool insert_TaiKhoan(DTO_Tai_Khoan tk) => taikhoan.insert_TaiKhoan(tk);
        public bool update_TaiKhoan(DTO_Tai_Khoan tk) => taikhoan.update_TaiKhoan(tk);
        public bool delete_TaiKhoan(string username) => taikhoan.delete_TaiKhoan(username);
        public DataTable search_TaiKhoan(string TenTaiKhoan) => taikhoan.search_TaiKhoan(TenTaiKhoan);
        public DataTable search_TaiKhoan_fromManv(string manv) => taikhoan.search_TaiKhoan_fromManv(manv);
    }
}
