using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_Quan_ly;
using BUS_Quan_Ly;

namespace Quản_lý_cửa_hàng_mỹ_phẩm
{
    public partial class Form_chi_tiet_hoa_don : Form
    {
        string _tennv;
        decimal _tongtien = 0;
        decimal _tiengiam = 0;
        string _sdt;
        BUS_Nhan_vien nhanvien = new BUS_Nhan_vien();
        BUS_hoa_don hoadon = new BUS_hoa_don();
        BUS_San_Pham sanpham = new BUS_San_Pham();
        BUS_Voucher voucher = new BUS_Voucher();
        BUS_Chi_tiet_hoa_don cthd = new BUS_Chi_tiet_hoa_don();
        BUS_Khach_hang khahhang = new BUS_Khach_hang();
        public string Tennv
        {
            get
            {
                return _tennv;
            }
            set
            {
                _tennv = value;
            }
        }
        public decimal Tongtien
        {
            get
            {
                return _tongtien;
            }
            set
            {
                _tongtien = value;
            }
        }
        public decimal Tiengiam
        {
            get
            {
                return _tiengiam;
            }
            set
            {
                _tiengiam = value;
            }
        }
        public string makh
        {
            get
            {
                return _sdt;
            }
            set
            {
                _sdt = value;
            }
        }
        public Form_chi_tiet_hoa_don()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_mahd_Enter(object sender, EventArgs e)
        {
            string socuoihd = hoadon.get_mahd_cuoi();
            string somoihd = (Convert.ToInt32(socuoihd.Substring(2)) + 1).ToString();
            if (Convert.ToInt32(somoihd) <= 9) txt_mahd.Text = "HD0" + somoihd;
            else txt_mahd.Text = "HD" + somoihd;
            txt_manv.Text = nhanvien.get_Manv(this.Tennv);
            txt_ngaylap.Text = DateTime.Today.ToString("MM/dd/yyyy");
            txt_makh.Text = this.makh;
        }

        private void resettext()
        {
            txt_masp.ResetText();
            txt_tensp.ResetText();
            txt_thanhtien.ResetText();
            txt_voucher.ResetText();
            txt_soluong.ResetText();
        }

        private void Form_chi_tiet_hoa_don_Load(object sender, EventArgs e)
        {
            resettext();
        }

        private void txt_masp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_tensp.Text = sanpham.get_tensp(txt_masp.Text);
                txt_voucher.Text = sanpham.get_tenvoucher(txt_tensp.Text);
            }
        }

        private void txt_soluong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_thanhtien.Text = (sanpham.get_giatien(txt_masp.Text) * Convert.ToInt32(txt_soluong.Text)).ToString();
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            DateTime ngaylap = Convert.ToDateTime(txt_ngaylap.Text);
            string tensp = txt_tensp.Text;
            string KM = txt_voucher.Text;
            decimal tiengiam = ((voucher.get_TienKM(voucher.get_Mavoucher(txt_voucher.Text)) / 100) * sanpham.get_giatien(txt_masp.Text) * Convert.ToInt32(txt_soluong.Text));
            decimal thanhtien = Convert.ToDecimal(txt_thanhtien.Text) - tiengiam;
            int soluong = Convert.ToInt32(value: txt_soluong.Text);
            this.dgv_chitiethd.Rows.Add(tensp, KM, soluong, thanhtien);
            this.Tongtien += thanhtien;
            txt_tongtien.Text = this.Tongtien.ToString();
            resettext();
        }

        private void btn_xoasp_Click(object sender, EventArgs e)
        {
            this.Tongtien = 0;
            txt_tongtien.ResetText();
            dgv_chitiethd.Rows.Clear();
        }

        private void btn_laphd_Click(object sender, EventArgs e)
        {
            string mahd = txt_mahd.Text;
            string makh = txt_makh.Text;
            string manv = txt_manv.Text;
            DateTime ngaylap = Convert.ToDateTime(txt_ngaylap.Text);
            decimal tongtien = Convert.ToDecimal(txt_tongtien.Text);
            DTO_Hoa_Don laphd = new DTO_Hoa_Don(mahd, makh, manv, ngaylap, tongtien);
            if (hoadon.insert_HoaDon_khachang(laphd))
            {
                foreach (DataGridViewRow row in dgv_chitiethd.Rows)
                {
                    string masp = sanpham.get_masp(row.Cells[0].Value.ToString());
                    string mavoucher = row.Cells[1].Value.ToString();
                    int soluong = Convert.ToInt32(row.Cells[2].Value.ToString());
                    decimal thanhtien = Convert.ToDecimal(row.Cells[3].Value.ToString());
                    DTO_chi_tiet_hoa_don themhd = new DTO_chi_tiet_hoa_don(mahd, masp, mavoucher, soluong, thanhtien);
                    cthd.insert_CTHD(themhd);
                }
                MessageBox.Show("Lập hóa đơn thành công");

            }
            else MessageBox.Show("Lập hóa đơn không thành công");
            resettext();
            txt_mahd.ResetText();
            txt_tongtien.ResetText();
            dgv_chitiethd.Rows.Clear();
        }
    }
}
