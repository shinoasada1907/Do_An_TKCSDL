using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Quan_ly
{
    public class DTO_Hoi_Vien
    {
        int _MaHV;
        string _Loai_The;
        string _TenHV;
        string _Gioitinh;
        DateTime _ngaysinh;
        DateTime _ngay_lap;
        string _SDT;

        public int MaHV
        {
            get
            {
                return _MaHV;
            }
            set
            {
                _MaHV = value;
            }
        }
        public string Loai_The
        {
            get
            {
                return _Loai_The;
            }
            set
            {
                _Loai_The = value;
            }
        }
        public string TenHV
        {
            get
            {
                return _TenHV;
            }
            set
            {
                _TenHV = value;
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
                return _ngaysinh;
            }
            set
            {
                _ngaysinh = value;
            }
        }
        public DateTime NgayLapThe
        {
            get
            {
                return _ngay_lap;
            }
            set
            {
                _ngay_lap = value;
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

        public DTO_Hoi_Vien() { }
        public DTO_Hoi_Vien(int mahv, string loaithe, string tenhv, string gioitinh, DateTime ngaysinh, DateTime ngaylap, string sdt)
        {
            this.MaHV = mahv;
            this.Loai_The = loaithe;
            this.TenHV = tenhv;
            this.GioiTinh = gioitinh;
            this.Ngaysinh = ngaysinh;
            this.NgayLapThe = ngaylap;
            this.SDT = sdt;
        }
    }
}
