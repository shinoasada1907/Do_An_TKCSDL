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
    public class BUS_Chi_tiet_phieu_nhap
    {
        DAL_Chi_tiet_phieu_nhap CTphieunhap = new DAL_Chi_tiet_phieu_nhap();
        public DataTable get_dgvCTPN(string maphieu) => CTphieunhap.get_dgvCTPN(maphieu);
        public DataTable get_CTPN() => CTphieunhap.get_CTPN();
        public bool insert_CTPN(DTO_Chi_tiet_phieu_nhap ctpn) => CTphieunhap.insert_CTPN(ctpn);
        public bool update_CTPN(DTO_Chi_tiet_phieu_nhap ctpn) => CTphieunhap.update_CTPN(ctpn);
        public bool delete_CTPN(DTO_Chi_tiet_phieu_nhap ctpn) => CTphieunhap.delete_CTPN(ctpn);
    }
}
