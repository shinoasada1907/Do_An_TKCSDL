using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Quan_ly
{
    public class DTO_Hoa_Don
    {
        string _MaHD;
        string _MaKH;
        string _MaNVLap;
        int _MaHV;
        DateTime _NgayLap;
        decimal _TongTien;
        /*=======GETTER/SETTER=======*/
        public string MaHD
        {
            get
            {
                return _MaHD;
            }
            set
            {
                _MaHD = value;
            }
        }
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
        public string MaNVLap
        {
            get
            {
                return _MaNVLap;
            }
            set
            {
                _MaNVLap = value;
            }
        }
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
        public DateTime NgayLap
        {
            get
            {
                return _NgayLap;
            }
            set
            {
                _NgayLap = value;
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
        public DTO_Hoa_Don()
        {

        }
        public DTO_Hoa_Don(string mahd, string manvlap,int mahv, DateTime ngaylap, decimal tongtien)
        {
            this.MaHD = mahd;
            this.MaNVLap = manvlap;
            this.MaHV = mahv;
            this.NgayLap = ngaylap;
            this.TongTien = tongtien;
        }
        public DTO_Hoa_Don(string mahd,string makh, string manvlap, DateTime ngaylap, decimal tongtien)
        {
            this.MaHD = mahd;
            this.MaKH = makh;
            this.MaNVLap = manvlap;
            this.NgayLap = ngaylap;
            this.TongTien = tongtien;
        }
    }
}
