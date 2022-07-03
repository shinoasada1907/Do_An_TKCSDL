using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Quan_ly
{
    public class DTO_Quan_Ly_Khach_hang
    {
        string _MaKH;
        string _TenKH;
        string _Gioitinh;
        DateTime _Ngaysinh;
        string _SDT;
        string _Diachi;

        public string MaKH
        {
            get
            {
                return _MaKH;
            }
            set
            {
                _MaKH = value;
            }
        }

        public string TenKH
        {
            get
            {
                return _TenKH;
            }
            set
            {
                _TenKH = value;
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

        public DTO_Quan_Ly_Khach_hang() { }

        public DTO_Quan_Ly_Khach_hang(string makh, string tenkh, string gioitinh, DateTime ngaysinh, string sdt, string diachi)
        {
            this.MaKH = makh;
            this.TenKH = tenkh;
            this.GioiTinh = gioitinh;
            this.Ngaysinh = ngaysinh;
            this.SDT = sdt;
            this.Diachi = diachi;
        }
    }
}
