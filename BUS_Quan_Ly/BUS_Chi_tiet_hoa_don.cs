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
    public class BUS_Chi_tiet_hoa_don
    {
        DAL_Chi_tiet_hoa_don cthd = new DAL_Chi_tiet_hoa_don();
        public DataTable get_CTHD(string MaHD) => cthd.get_CTHD(MaHD);
        public bool insert_CTHD(DTO_chi_tiet_hoa_don chitietHD) => cthd.insert_CTHD(chitietHD);
        public bool update_CTHD(DTO_chi_tiet_hoa_don chitietHD) => cthd.update_CTHD(chitietHD);
        public bool delete_CTHD(DTO_chi_tiet_hoa_don chitietHD) => cthd.delete_CTHD(chitietHD);
        public DataTable update_voucher_HD(string mavoucher) => cthd.update_voucher_HD(mavoucher);
    }
}
