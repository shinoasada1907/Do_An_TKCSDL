using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Quan_ly
{
    public class DTO_Nha_Cung_Cap
    {
        private string _MaNCC;
        private string _TenNCC;

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
        public string TenNCC
        {
            get
            {
                return _TenNCC;
            }
            set
            {
                _TenNCC = value;
            }
        }
        public DTO_Nha_Cung_Cap()
        {

        }
        public DTO_Nha_Cung_Cap(string mancc, string tenncc)
        {
            this.MaNCC = mancc;
            this.TenNCC = tenncc;
        }
    }
}
