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
    public partial class UserControl_Quan_Ly_San_Pham : UserControl
    {
        BUS_Voucher voucher = new BUS_Voucher();
        BUS_Loai_san_pham lsp = new BUS_Loai_san_pham();
        BUS_San_Pham BUS_SP = new BUS_San_Pham();
        public UserControl_Quan_Ly_San_Pham()
        {
            InitializeComponent();
        }

        private void btn_loai_san_pham_Click(object sender, EventArgs e)
        {
            Form_loai_san_pham fsp = new Form_loai_san_pham();
            fsp.ShowDialog();
        }

        private void btn_voucher_Click(object sender, EventArgs e)
        {
            Form_voucher fvc = new Form_voucher();
            fvc.ShowDialog();
        }

        private void UserControl_Quan_Ly_San_Pham_Load(object sender, EventArgs e)
        {
            dgv_sanpham.DataSource = BUS_SP.get_sanpham();
            //đổ dủ liệu vào combobox loại sản phẩm
            cmb_loaisp.DataSource = lsp.get_Tenloaisanpham();
            cmb_loaisp.ValueMember = "TenLoaiSP";
            cmb_loaisp.DisplayMember = "MaLoai";
            cmb_loaisp.ResetText();
            //đổ dữ liệu vào combobox voucher
            cm_voucher.DataSource = voucher.get_name_voucher();
            cm_voucher.ValueMember = "Ten_voucher";
            cm_voucher.DisplayMember = "Ma_voucher";
            cm_voucher.ResetText();
        }

        public void resettext()
        {
            BUS_SP.get_sanpham();
            txt_masp.ResetText();
            txt_tensp.ResetText();
            txt_giasp.ResetText();
            txt_hangsx.ResetText();
            txt_soluong.ResetText();
            cmb_loaisp.ResetText();
            cm_voucher.ResetText();
        }

        private void btn_themsp_Click(object sender, EventArgs e)
        {
            if(txt_masp.Text != "" && txt_tensp.Text != "" && txt_giasp.Text != "" && txt_hangsx.Text != "" && txt_soluong.Text != "" && cmb_loaisp.Text != "" && cm_voucher.Text != "")
            {
                string masp = txt_masp.Text;
                string tensp = txt_tensp.Text;
                string maloai = lsp.get_MaLoaiSP(cmb_loaisp.Text);
                string mavoucher = voucher.get_Mavoucher(cm_voucher.Text);
                decimal giaban = Convert.ToDecimal(txt_giasp.Text);
                int soluong = Convert.ToInt32(txt_soluong.Text);
                string thuonghieu = txt_hangsx.Text;
                DTO_San_Pham DTO_Sanpham = new DTO_San_Pham(masp, maloai, mavoucher, tensp, giaban, thuonghieu, soluong);
                if(BUS_SP.insert_sp(DTO_Sanpham))
                {
                    MessageBox.Show("Thêm thành công");
                    dgv_sanpham.DataSource = BUS_SP.get_sanpham();
                    resettext();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin nhập đủ thông tin!");
            }
        }

        private void dgv_sanpham_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgv_sanpham.SelectedRows[0];
            txt_masp.Text = row.Cells[0].Value.ToString();
            txt_tensp.Text = row.Cells[1].Value.ToString();
            cmb_loaisp.Text = row.Cells[2].Value.ToString();
            txt_giasp.Text = row.Cells[3].Value.ToString();
            txt_hangsx.Text = row.Cells[4].Value.ToString();
            txt_soluong.Text = row.Cells[5].Value.ToString();
            cm_voucher.Text = row.Cells[6].Value.ToString();
        }

        private void btn_suasp_Click(object sender, EventArgs e)
        {
            if(dgv_sanpham.SelectedRows.Count > 0)
            {
                if (txt_masp.Text != "" && txt_tensp.Text != "" && txt_giasp.Text != "" && txt_hangsx.Text != "" && txt_soluong.Text != "" && cmb_loaisp.Text != "" && cm_voucher.Text != "")
                {
                    string masp = txt_masp.Text;
                    string tensp = txt_tensp.Text;
                    string maloai = lsp.get_MaLoaiSP(cmb_loaisp.Text);
                    string mavoucher = voucher.get_Mavoucher(cm_voucher.Text);
                    decimal giaban = Convert.ToDecimal(txt_giasp.Text);
                    int soluong = Convert.ToInt32(txt_soluong.Text);
                    string thuonghieu = txt_hangsx.Text;
                    DTO_San_Pham DTO_Sanpham = new DTO_San_Pham(masp, maloai, mavoucher, tensp, giaban, thuonghieu, soluong);
                    if (BUS_SP.update_sp(DTO_Sanpham))
                    {
                        MessageBox.Show("Sửa thành công");
                        dgv_sanpham.DataSource = BUS_SP.get_sanpham();
                        resettext();
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Thiếu thông tin cần thiết");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần Sửa");
            }
        }

        private void btn_xoasp_Click(object sender, EventArgs e)
        {
            if (dgv_sanpham.SelectedRows.Count > 0)
            {
                if (txt_masp.Text != "" && txt_tensp.Text != "" && txt_giasp.Text != "" && txt_hangsx.Text != "" && txt_soluong.Text != "" && cmb_loaisp.Text != "" && cm_voucher.Text != "")
                {
                    string masp = txt_masp.Text;
                    string tensp = txt_tensp.Text;
                    string maloai = lsp.get_MaLoaiSP(cmb_loaisp.Text);
                    string mavoucher = voucher.get_Mavoucher(cm_voucher.Text);
                    decimal giaban = Convert.ToDecimal(txt_giasp.Text);
                    int soluong = Convert.ToInt32(txt_soluong.Text);
                    string thuonghieu = txt_hangsx.Text;
                    DTO_San_Pham DTO_Sanpham = new DTO_San_Pham(masp, maloai, mavoucher, tensp, giaban, thuonghieu, soluong);
                    if (BUS_SP.delete_sp(masp))
                    {
                        MessageBox.Show("Xóa thành công");
                        dgv_sanpham.DataSource = BUS_SP.get_sanpham();
                        resettext();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Thiếu thông tin cần thiết");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa");
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            resettext();
            dgv_sanpham.DataSource = BUS_SP.get_sanpham();
            cmb_loaisp.DataSource = lsp.get_Tenloaisanpham();
            cm_voucher.DataSource = voucher.get_name_voucher();
            resettext();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(cmb_loaisp.Text != "")
            {
                string maloai = lsp.get_MaLoaiSP(cmb_loaisp.Text);
                dgv_sanpham.DataSource = BUS_SP.search_maloaisp(maloai);
            }   
            if(txt_search.Text != "")
                dgv_sanpham.DataSource = BUS_SP.search_namesp(txt_search.Text);
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (txt_search.Text != "")
                resettext();
        }

        private void txt_masp_Enter(object sender, EventArgs e)
        {
            resettext();
            string sospcuoi = dgv_sanpham.Rows[dgv_sanpham.Rows.Count - 1].Cells[0].Value.ToString();
            string sospmoi = (Convert.ToInt32(sospcuoi.Substring(2)) + 1).ToString();
            if (Convert.ToInt32(sospmoi) <= 9) txt_masp.Text = "SP0" + sospmoi;
            else txt_masp.Text = "SP" + sospmoi;
        }
    }
}
