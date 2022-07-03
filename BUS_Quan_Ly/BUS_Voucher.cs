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
    public class BUS_Voucher
    {
        DAL_Voucher v = new DAL_Voucher();
        public DataTable get_voucher() => v.get_voucher();
        public string get_Tenvoucher(string mavoucher) => v.get_Tenvoucher(mavoucher);
        public string get_Mavoucher(string tenvoucher) => v.get_Mavoucher(tenvoucher);
        public bool insert_voucher(DTO_Voucher voucher) => v.insert_voucher(voucher);
        public bool delete_voucher(DTO_Voucher voucher) => v.delete_voucher(voucher);
        public bool update_voucher(DTO_Voucher voucher) => v.update_voucher(voucher);
        public DataTable get_name_voucher() => v.get_name_voucher();
        public decimal get_TienKM(string mavoucher) => v.get_TienKM(mavoucher);

    }
}
