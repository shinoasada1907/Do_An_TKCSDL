using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_Quan_Ly;
using DTO_Quan_ly;

namespace BUS_Quan_Ly
{
    public class BUS_Phan_quyen
    {
        DAL_Phan_quyen phanquyen = new DAL_Phan_quyen();
        public string get_MaQuyen(string TenQuyen) => phanquyen.get_MaQuyen(TenQuyen);
        public string get_TenQuyen(string MaQuyen) => phanquyen.get_TenQuyen(MaQuyen);
        public DataTable get_AllMaQuyen() => phanquyen.get_AllMaQuyen();
        public DataTable get_AllTenQuyen() => phanquyen.get_AllTenQuyen();
    }
}
