using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_Quan_Ly;
using DTO_Quan_ly;

namespace Quản_lý_cửa_hàng_mỹ_phẩm
{
    public partial class Form_chi_tiet_phieu_nhap : Form
    {
        string _maphieu;
        decimal _tongtien;
        string _tenncc;
        BUS_Chi_tiet_phieu_nhap phieu = new BUS_Chi_tiet_phieu_nhap();
        BUS_Loai_san_pham lsp = new BUS_Loai_san_pham();
        BUS_Voucher voucher = new BUS_Voucher();
        BUS_San_Pham sanpham = new BUS_San_Pham();
        BUS_phieu_nhap_hang phieunhap = new BUS_phieu_nhap_hang();
        public string maphieunhap
        {
            get
            {
                return _maphieu;
            }
            set
            {
                _maphieu = value;
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
        public string Tenncc
        {
            get
            {
                return _tenncc;
            }
            set
            {
                _tenncc = value;
            }
        }

        public Form_chi_tiet_phieu_nhap()
        {
            InitializeComponent();
        }

        private void Form_chi_tiet_phieu_nhap_Load(object sender, EventArgs e)
        {
            txt_maphieunhap.Text = maphieunhap;
            txt_maphieunhap.ReadOnly = true;

            //đổ dủ liệu vào combobox loại sản phẩm
            cmb_loaisp.DataSource = lsp.get_Tenloaisanpham();
            cmb_loaisp.ValueMember = "TenLoaiSP";
            cmb_loaisp.DisplayMember = "MaLoai";
            cmb_loaisp.ResetText();
            //đổ dữ liệu vào combobox voucher
            cmb_voucher.DataSource = voucher.get_name_voucher();
            cmb_voucher.ValueMember = "Ten_voucher";
            cmb_voucher.DisplayMember = "Ma_voucher";
            cmb_voucher.ResetText();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resttext()
        {
            phieu.get_dgvCTPN(txt_maphieunhap.Text);
            txt_masp.ResetText();
            txt_giagoc.ResetText();
            txt_soluong.ResetText();
            txt_tensp.ResetText();
            txt_thanhtien.ResetText();
            cmb_loaisp.ResetText();
            cmb_voucher.ResetText();
            txt_Thuonghieu.ResetText();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if(txt_masp.Text != "" && txt_masp.Text != "" && txt_soluong.Text != "" && txt_giagoc.Text != "" && cmb_loaisp.Text != "")
            {
                string maphieu = txt_maphieunhap.Text;
                string masp = txt_masp.Text;
                string tensp = txt_tensp.Text;
                decimal giagoc = Convert.ToDecimal(txt_giagoc.Text);
                decimal thanhtien = Convert.ToDecimal(txt_thanhtien.Text);
                int soluong = Convert.ToInt32(txt_soluong.Text);
                string maloaisp = lsp.get_MaLoaiSP(cmb_loaisp.Text);
                string mavoucher = voucher.get_Mavoucher(cmb_voucher.Text);
                string thuonghieu = txt_Thuonghieu.Text;

                if(sanpham.check_MaSP(masp) == false)
                {
                    DTO_San_Pham dto_sp = new DTO_San_Pham(masp, maloaisp, mavoucher, tensp, 0, thuonghieu, 0);
                    sanpham.insert_sp(dto_sp);  
                }
                this.dgv_chitietphieunhap.Rows.Add(tensp, cmb_loaisp.Text, giagoc, soluong, thanhtien);
                this.Tongtien += thanhtien;
                txt_tongtien.Text = this.Tongtien.ToString();
                resttext();
            }  
            else
            {
                MessageBox.Show("Xin nhập đầy đủ");
            }
        }

        private void txt_soluong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                txt_thanhtien.Text = (Convert.ToDecimal(txt_giagoc.Text) * Convert.ToInt32(txt_soluong.Text)).ToString();
            }
        }

        private void txt_masp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (sanpham.check_MaSP(txt_masp.Text))
                {
                    string loaisp = sanpham.get_thongtinsanpham(txt_masp.Text).Rows[0].Field<string>(1);
                    cmb_loaisp.Text = lsp.get_TenLoaiSP(loaisp);
                    string ma_voucher = sanpham.get_thongtinsanpham(txt_masp.Text).Rows[0].Field<string>(2);
                    cmb_voucher.Text = voucher.get_Tenvoucher(ma_voucher);
                    txt_tensp.Text = sanpham.get_thongtinsanpham(txt_masp.Text).Rows[0].Field<string>(3);
                    txt_Thuonghieu.Text = sanpham.get_thongtinsanpham(txt_masp.Text).Rows[0].Field<string>(5);
                }
                else
                {
                    MessageBox.Show("Sản phẩm mới!");
                }
            }
        }

        private void btn_lapphieu_Click(object sender, EventArgs e)
        {
            string maphieu = txt_maphieunhap.Text;
            foreach(DataGridViewRow row in dgv_chitietphieunhap.Rows)
            {
                string masp = sanpham.get_masp(row.Cells[0].Value.ToString());
                string maloai = lsp.get_MaLoaiSP(row.Cells[1].Value.ToString());
                decimal giagoc = Convert.ToDecimal(row.Cells[2].Value.ToString());
                int soluong = Convert.ToInt32(row.Cells[3].Value.ToString());
                decimal thanhtien = Convert.ToDecimal(row.Cells[4].Value.ToString());
                DTO_Chi_tiet_phieu_nhap CTPN = new DTO_Chi_tiet_phieu_nhap(maphieu,masp,maloai,giagoc,soluong,thanhtien);
                phieu.insert_CTPN(CTPN);
            }
            MessageBox.Show("Lập phiếu thành công");
            phieunhap.update_Tongtien(maphieu, this.Tongtien);
        }

        private void btn_inphieu_Click(object sender, EventArgs e)
        {
            FormInPhieuNhap phieunhap = new FormInPhieuNhap(txt_maphieunhap.Text,this.Tenncc);
            phieunhap.ShowDialog();
        }
    }
}
