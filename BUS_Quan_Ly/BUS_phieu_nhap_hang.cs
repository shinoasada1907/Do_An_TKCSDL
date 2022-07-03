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
    public class BUS_phieu_nhap_hang
    {
        DAL_phieu_nhap_hang phieunhaphang = new DAL_phieu_nhap_hang();
        public DataTable get_AllPhieuNhap() => phieunhaphang.get_AllPhieuNhap();
        public DataTable get_PhieuNhap(string MaPhieu) => phieunhaphang.get_PhieuNhap(MaPhieu);
        public bool insert_PhieuNhap(DTO_Phieu_Nhap phieunhap) => phieunhaphang.insert_PhieuNhap(phieunhap);
        public bool update_PhieuNhap(DTO_Phieu_Nhap maphieu) => phieunhaphang.update_PhieuNhap(maphieu);
        public DataTable get_PhieuNhap_NCC(string tenncc) => phieunhaphang.get_PhieuNhap_NCC(tenncc);
        public bool update_Tongtien(string maphieu, decimal tongtien) => phieunhaphang.update_Tongtien(maphieu, tongtien);
    }
}
