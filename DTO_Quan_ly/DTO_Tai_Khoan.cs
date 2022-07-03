using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Quan_ly
{
    public class DTO_Tai_Khoan
    {
        string _TenTaiKhoan;
        string _MatKhau;
        string _MaNV;
        string _MaQuyen;

        public string TenTaiKhoan
        {
            get
            {
                return _TenTaiKhoan;
            }
            set
            {
                _TenTaiKhoan = value;
            }
        }
        public string MatKhau
        {
            get
            {
                return _MatKhau;
            }
            set
            {
                _MatKhau = value;
            }
        }
        public string MaNV
        {
            get
            {
                return _MaNV;
            }
            set
            {
                _MaNV = value;
            }
        }
        public string MaQuyen
        {
            get
            {
                return _MaQuyen;
            }
            set
            {
                _MaQuyen = value;
            }
        }
        public DTO_Tai_Khoan()
        {

        }
        public DTO_Tai_Khoan(string tentaikhoan, string matkhau, string manv, string maquyen)
        {
            this.TenTaiKhoan = tentaikhoan;
            this.MatKhau = matkhau;
            this.MaNV = manv;
            this.MaQuyen = maquyen;
        }
    }
}
