using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Quan_ly
{
    public class DTO_Voucher
    {
        string _Ma_voucher;
        string _Ten_voucher;
        decimal _Tiengiam;

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
        public string Ten_voucher
        {
            get
            {
                return _Ten_voucher;
            }
            set
            {
                _Ten_voucher = value;
            }
        }
        public decimal Tiengiam
        {
            get
            {
                return _Tiengiam;
            }
            set
            {
                _Tiengiam = value;
            }
        }

        public DTO_Voucher() { }
        public DTO_Voucher(string Ma_voucher, string Ten_voucher, decimal tienkm)
        {
            this.Ma_voucher = Ma_voucher;
            this.Ten_voucher = Ten_voucher;
            this.Tiengiam = tienkm;
        }
    }
}
