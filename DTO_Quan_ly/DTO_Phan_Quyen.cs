using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Quan_ly
{
    public class DTO_Phan_Quyen
    {
        private string _MaQuyen;
        private string _TenQuyen;

        public string MaQuyen
        {
            get
            {
                return _MaQuyen;
            }
            set
            {
                _MaQuyen = value;
            }
        }
        public string TenQuyen
        {
            get
            {
                return _TenQuyen;
            }
            set
            {
                _TenQuyen = value;
            }
        }
        public DTO_Phan_Quyen()
        {

        }
        public DTO_Phan_Quyen(string maquyen, string tenquyen)
        {
            this.MaQuyen = maquyen;
            this.TenQuyen = tenquyen;
        }
    }
}
