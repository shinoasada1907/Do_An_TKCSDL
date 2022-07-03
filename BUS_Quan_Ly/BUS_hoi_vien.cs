using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO_Quan_ly;
using DAL_Quan_Ly;

namespace BUS_Quan_Ly
{
    public class BUS_hoi_vien
    {
        DAL_Hoi_Vien hoivien = new DAL_Hoi_Vien();
        public DataTable get_Hoivien() => hoivien.get_Hoivien();
        public DataTable get_thongtinHV(string mahv) => hoivien.get_thongtinHV(mahv);
        public DataTable get_MaHV(string tenhv) => hoivien.get_MaHV(tenhv);
        public bool insert_HV(DTO_Hoi_Vien hv) => hoivien.insert_HV(hv);
        public bool delete_HV(string hv) => hoivien.delete_HV(hv);
        public bool update_HV(DTO_Hoi_Vien hv) => hoivien.update_HV(hv);
        public string get_SDTHV(string SDT) => hoivien.get_SDTHV(SDT);
        public DataTable get_thongtin_theHV(string theHV) => hoivien.get_thongtin_theHV(theHV);
        public DataTable get_thong_tinHV(string SDT) => hoivien.get_thong_tinHV(SDT);
        public decimal get_tiengiam(int mahv) => hoivien.get_tiengiam(mahv);
        public string get_tenhv(string mahv) => hoivien.get_tenhv(mahv);
    }
}
