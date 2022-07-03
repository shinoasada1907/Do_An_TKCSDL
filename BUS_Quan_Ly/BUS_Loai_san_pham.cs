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
    public class BUS_Loai_san_pham
    {
        DAL_Loai_San_Pham loaisp = new DAL_Loai_San_Pham();
        public DataTable get_Loaisanpham() => loaisp.get_Loaisanpham();
        public string get_TenLoaiSP(string MaLoai) => loaisp.get_TenLoaiSP(MaLoai);
        public string get_MaLoaiSP(string TenLoai) => loaisp.get_MaLoaiSP(TenLoai);
        public bool insert_LoaiSP(DTO_Loai_san_pham loai) => loaisp.insert_LoaiSP(loai);
        public bool delete_LoaiSP(DTO_Loai_san_pham loai) => loaisp.delete_LoaiSP(loai);
        public bool update_LoaiSP(DTO_Loai_san_pham loai) => loaisp.update_LoaiSP(loai);
        public DataTable get_Tenloaisanpham() => loaisp.get_Tenloaisanpham();
    }
}
