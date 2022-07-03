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
    public partial class Form_loai_san_pham : Form
    {
        BUS_Loai_san_pham loai = new BUS_Loai_san_pham();
        public Form_loai_san_pham()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_loai_san_pham_Load(object sender, EventArgs e)
        {
            dgv_loai_san_pham.DataSource = loai.get_Loaisanpham();
        }

        public void resettext()
        {
            loai.get_Loaisanpham();
            txt_maloai.ResetText();
            txt_tenloai.ResetText();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_maloai.Text != "" && txt_tenloai.Text != "")
            {
                string maloai = txt_maloai.Text;
                string tenloai = txt_tenloai.Text;
                DTO_Loai_san_pham loaisp = new DTO_Loai_san_pham(maloai, tenloai);
                if (loai.insert_LoaiSP(loaisp))
                {
                    MessageBox.Show("Thêm thành công");
                    dgv_loai_san_pham.DataSource = loai.get_Loaisanpham();
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

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if(dgv_loai_san_pham.SelectedRows.Count > 0)
            {
                if (txt_maloai.Text != "" && txt_tenloai.Text != "")
                {
                    string maloai = txt_maloai.Text;
                    string tenloai = txt_tenloai.Text;
                    DTO_Loai_san_pham loaisp = new DTO_Loai_san_pham(maloai, tenloai);
                    if (loai.delete_LoaiSP(loaisp))
                    {
                        MessageBox.Show("Xóa thành công");
                        dgv_loai_san_pham.DataSource = loai.get_Loaisanpham();
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
                MessageBox.Show("Xin chọn loại sản phẩm cần xóa");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (dgv_loai_san_pham.SelectedRows.Count > 0)
            {
                if (txt_maloai.Text != "" && txt_tenloai.Text != "")
                {
                    string maloai = txt_maloai.Text;
                    string tenloai = txt_tenloai.Text;
                    DTO_Loai_san_pham loaisp = new DTO_Loai_san_pham(maloai, tenloai);
                    if (loai.update_LoaiSP(loaisp))
                    {
                        MessageBox.Show("Sửa thành công");
                        dgv_loai_san_pham.DataSource = loai.get_Loaisanpham();
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
                MessageBox.Show("Xin chọn loại sản phẩm cần sửa");
            }
        }

        private void dgv_loai_san_pham_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgv_loai_san_pham.SelectedRows[0];
            txt_maloai.Text = row.Cells[0].Value.ToString();
            txt_tenloai.Text = row.Cells[1].Value.ToString();
        }
    }
}
