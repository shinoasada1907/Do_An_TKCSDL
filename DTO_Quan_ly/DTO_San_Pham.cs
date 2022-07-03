using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Quan_ly
{
    public class DTO_San_Pham
    {
        string _MaSP;
        string _TenSP;
        string _MaLoai;
        string _Ma_voucher;
        decimal _GiaBan;
        string _thuonghieu;
        int _SLTon;

        public string MaSP
        {
            get
            {
                return _MaSP;
            }
            set
            {
                _MaSP = value;
            }
        }
        public string TenSP
        {
            get
            {
                return _TenSP;
            }
            set
            {
                _TenSP = value;
            }
        }
        public string MaLoai
        {
            get
            {
                return _MaLoai;
            }
            set
            {
                _MaLoai = value;
            }
        }
        public string Ma_voucher
        {
            get
            {
                return _Ma_voucher;
            }
            set
            {
                _Ma_voucher = value;
            }
        }
        public decimal GiaBan
        {
            get
            {
                return _GiaBan;
            }
            set
            {
                _GiaBan = value;
            }
        }
        public string Thuong_Hieu
        {
            get
            {
                return _thuonghieu;
            }
            set
            {
                _thuonghieu = value;
            }
        }
        public int SLTon
        {
            get
            {
                return _SLTon;
            }
            set
            {
                _SLTon = value;
            }
        }
        public DTO_San_Pham()
        {

        }
        public DTO_San_Pham(string masp, string maloai, string mavoucher, string tensp, decimal giaban, string thuonghieu, int slton)
        {
            this.MaSP = masp;
            this.MaLoai = maloai;
            this.Ma_voucher = mavoucher;
            this.TenSP = tensp;
            this.GiaBan = giaban;
            this.Thuong_Hieu = thuonghieu;
            this.SLTon = slton;
        }
    }
}
