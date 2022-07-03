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
    public class BUS_The_hoi_vien
    {
        DAL_The_hoi_vien thehoivien = new DAL_The_hoi_vien();
        public DataTable get_theHV() => thehoivien.get_theHV();
        public DataTable get_TentheHV() => thehoivien.get_TentheHV();
        public decimal get_Giatienthe(string loaithe) => thehoivien.get_Giatienthe(loaithe);
        public decimal get_Giatiengiam(string loaithe) => thehoivien.get_Giatiengiam(loaithe);
        public bool insert_TheHV(DTO_The_Hoi_Vien thv) => thehoivien.insert_TheHV(thv);
        public bool update_TheHV(DTO_The_Hoi_Vien thv) => thehoivien.update_TheHV(thv);
        public bool delete_TheHV(string thv) => thehoivien.delete_TheHV(thv);
    }
}
