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
    public class BUS_Nha_cung_cap
    {
        DAL_Nha_cung_cap nhacungcap = new DAL_Nha_cung_cap();
        public DataTable get_AllNCC() => nhacungcap.get_AllNCC();
        public string get_MaNCC(string TenNCC) => nhacungcap.get_MaNCC(TenNCC);
        public DataTable get_AllTenNCC() => nhacungcap.get_AllTenNCC();
        public bool insert_NCC(DTO_Nha_Cung_Cap ncc) => nhacungcap.insert_NCC(ncc);
        public bool update_NCC(DTO_Nha_Cung_Cap ncc) => nhacungcap.update_NCC(ncc);
        public bool delete_NCC(string ncc) => nhacungcap.delete_NCC(ncc);
        public DataTable search_NCC(string TenNCC) => nhacungcap.search_NCC(TenNCC);
        public string get_TenNCC(string mancc) => nhacungcap.get_TenNCC(mancc);
    }
}
