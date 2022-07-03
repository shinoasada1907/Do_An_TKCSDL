using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Quan_ly
{
    public class DTO_Quan_ly_tai_khoan
    {
        string _Tentaikhoan;
        string _Matkhau;
        string _MaNV;
        string _MaPhanQuyen;

        public string Tentaikhoan
        {
            get
            {
                return _Tentaikhoan;
            }
            set
            {
                _Tentaikhoan = value;
            }
        }

        public string Matkhau
        {
            get
            {
                return _Matkhau;
            }
            set
            {
                _Matkhau = value;
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
        public string Maphanquyen
        {
            get
            {
                return _MaPhanQuyen;
            }
            set
            {
                _MaPhanQuyen = value;
            }
        }

        public DTO_Quan_ly_tai_khoan()
        { }

        public DTO_Quan_ly_tai_khoan(string tentaikhoan, string matkhau, string manv, string maphanquyen)
        {
            this.Tentaikhoan = tentaikhoan;
            this.Matkhau = matkhau;
            this.MaNV = manv;
            this.Maphanquyen = maphanquyen;
        }
    }
}
