using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Quan_ly
{
    public class DTO_The_Hoi_Vien
    {
        string _Loaithe;
        decimal _Giathe;
        decimal _khuyenmaithe;
        int _Thoigianthe;

        public string Loaithe
        {
            get
            {
                return _Loaithe;
            }
            set
            {
                _Loaithe = value;
            }
        }
        public decimal Giathe
        {
            get
            {
                return _Giathe;
            }
            set
            {
                _Giathe = value;
            }
        }
        public decimal Khuyenmaithe
        {
            get
            {
                return _khuyenmaithe;
            }
            set
            {
                _khuyenmaithe = value;
            }
        }
        public int Thoigianthe
        {
            get
            {
                return _Thoigianthe;
            }
            set
            {
                _Thoigianthe = value;
            }
        }

        public DTO_The_Hoi_Vien() { }

        public DTO_The_Hoi_Vien(string loaithe, decimal giathe, decimal khuyenmai, int thoigianthe)
        {
            this.Loaithe = loaithe;
            this.Giathe = giathe;
            this.Khuyenmaithe = khuyenmai;
            this.Thoigianthe = thoigianthe;
        }
    }
}
