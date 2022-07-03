using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Quan_ly
{
    public class DTO_Phieu_Nhap
    {
        string _MaPhieu;
        string _MaNVNhap;
        string _MaNCC;
        DateTime _NgayNhap;
        decimal _TongTien;

        public string MaPhieu
        {
            get
            {
                return _MaPhieu;
            }
            set
            {
                _MaPhieu = value;
            }
        }
        public string MaNVNhap
        {
            get
            {
                return _MaNVNhap;
            }
            set
            {
                _MaNVNhap = value;
            }
        }
        public string MaNCC
        {
            get
            {
                return _MaNCC;
            }
            set
            {
                _MaNCC = value;
            }
        }
        
        public DateTime NgayNhap
        {
            get
            {
                return _NgayNhap;
            }
            set
            {
                _NgayNhap = value;
            }
        }
        public decimal TongTien
        {
            get
            {
                return _TongTien;
            }
            set
            {
                _TongTien = value;
            }
        }
        public DTO_Phieu_Nhap()
        {

        }
        public DTO_Phieu_Nhap(string maphieu, string manvlap, string mancc, DateTime ngaylap, decimal tongtien)
        {
            this.MaPhieu = maphieu;
            this.MaNCC = mancc;
            this.MaNVNhap = manvlap;
            this.NgayNhap = ngaylap;
            this.TongTien = tongtien;
        }
    }
}
