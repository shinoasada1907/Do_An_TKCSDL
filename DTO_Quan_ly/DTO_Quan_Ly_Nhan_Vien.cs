using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Quan_ly
{
    public class DTO_Quan_Ly_Nhan_Vien
    {
        private string _MaNV;
        private string _TenNV;
        private DateTime _Ngaysinh;
        private string _Gioitinh;
        private string _Chucvu;
        private string _SDT;
        private string _Diachi;
        private decimal _LuongNV;

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

        public string TenNV
        {
            get
            {
                return _TenNV;
            }
            set
            {
                _TenNV = value;
            }
        }

        public DateTime Ngaysinh
        {
            get
            {
                return _Ngaysinh;
            }
            set
            {
                _Ngaysinh = value;
            }
        }

        public string GioiTinh
        {
            get
            {
                return _Gioitinh;
            }
            set
            {
                _Gioitinh = value;
            }
        }

        public string ChucVu
        {
            get
            {
                return _Chucvu;
            }
            set
            {
                _Chucvu = value;
            }
        }

        public string SDT
        {
            get
            {
                return _SDT;
            }
            set
            {
                _SDT = value;
            }
        }

        public string Diachi
        {
            get
            {
                return _Diachi;
            }
            set
            {
                _Diachi = value;
            }
        }

        public decimal LuongNV
        {
            get
            {
                return _LuongNV;
            }
            set
            {
                _LuongNV = value;
            }
        }

        public DTO_Quan_Ly_Nhan_Vien() { }

        public DTO_Quan_Ly_Nhan_Vien(string manv, string tennv, DateTime ngaysinh, string gioitinh, string chucvu, string sdt,string diachi, decimal luongnv)
        {
            this.MaNV = manv;
            this.TenNV = tennv;
            this.Ngaysinh = ngaysinh;
            this.GioiTinh = gioitinh;
            this.ChucVu = chucvu;
            this.SDT = sdt;
            this.Diachi = diachi;
            this.LuongNV = luongnv;
        }
    }
}
