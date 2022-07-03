using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Quan_ly
{
    public class DTO_Loai_san_pham
    {
        private string _MaLoai;
        private string _TenLoai;
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
        public string TenLoai
        {
            get
            {
                return _TenLoai;
            }
            set
            {
                _TenLoai = value;
            }
        }
        public DTO_Loai_san_pham()
        {

        }
        public DTO_Loai_san_pham(string maloai, string tenloai)
        {
            this.MaLoai = maloai;
            this.TenLoai = tenloai;
        }
    }
}
