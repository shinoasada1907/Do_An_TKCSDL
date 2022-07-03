using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Quan_ly
{
    public class DTO_chi_tiet_hoa_don
    {
        string _MaHD;
        string _MaSP;
        string _Ma_voucher;
        int _SLMua;
        decimal _ThanhTien;

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
        public string Mavoucher
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
        public int SLMua
        {
            get
            {
                return _SLMua;
            }
            set
            {
                _SLMua = value;
            }
        }
        public decimal ThanhTien
        {
            get
            {
                return _ThanhTien;
            }
            set
            {
                _ThanhTien = value;
            }
        }
        public DTO_chi_tiet_hoa_don()
        {

        }
        public DTO_chi_tiet_hoa_don(string mahd, string masp, string makhuyenmai, int slmua, decimal thanhtien)
        {
            this.MaHD = mahd;
            this.MaSP = masp;
            this.Mavoucher = makhuyenmai;
            this.SLMua = slmua;
            this.ThanhTien = thanhtien;
        }
    }
}
