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
    public partial class Form_the_hoi_vien : Form
    {
        BUS_The_hoi_vien thehoivien = new BUS_The_hoi_vien();
        public Form_the_hoi_vien()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_the_hoi_vien_Load(object sender, EventArgs e)
        {
            dgv_thehoivien.DataSource = thehoivien.get_theHV();
            resettext();
        }

        private void resettext()
        {
            thehoivien.get_theHV();
            txt_loaithe.ResetText();
            txt_giathe.ResetText();
            txt_uudai.ResetText();
            txt_hanthe.ResetText();
        }

        private void dgv_thehoivien_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgv_thehoivien.SelectedRows[0];
            txt_loaithe.Text = row.Cells[0].Value.ToString();
            txt_giathe.Text = row.Cells[1].Value.ToString();
            txt_uudai.Text = row.Cells[2].Value.ToString();
            txt_hanthe.Text = row.Cells[3].Value.ToString();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if(txt_loaithe.Text != "" && txt_giathe.Text != "" && txt_uudai.Text != "" && txt_hanthe.Text != "")
            {
                string loaithe = txt_loaithe.Text;
                decimal giathe = Convert.ToDecimal(txt_giathe.Text);
                decimal uudai = Convert.ToDecimal(txt_uudai.Text);
                int hanthe = Convert.ToInt32(txt_hanthe.Text);
                DTO_The_Hoi_Vien THV = new DTO_The_Hoi_Vien(loaithe, giathe, uudai, hanthe);
                if (thehoivien.insert_TheHV(THV))
                {
                    MessageBox.Show("Thêm thành công");
                    dgv_thehoivien.DataSource = thehoivien.get_theHV();
                    resettext();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin điền đầy đủ thông tin");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if(dgv_thehoivien.SelectedRows.Count > 0)
            {
                if (txt_loaithe.Text != "" && txt_giathe.Text != "" && txt_uudai.Text != "" && txt_hanthe.Text != "")
                {
                    DTO_The_Hoi_Vien THV = new DTO_The_Hoi_Vien(txt_loaithe.Text, Convert.ToDecimal(txt_giathe.Text), Convert.ToDecimal(txt_uudai.Text), Convert.ToInt32(txt_hanthe.Text));
                    if (thehoivien.update_TheHV(THV))
                    {
                        MessageBox.Show("Sửa thành công");
                        dgv_thehoivien.DataSource = thehoivien.get_theHV();
                        resettext();
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Xin điền đầy đủ thông tin");
                }
            }    
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if(dgv_thehoivien.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv_thehoivien.SelectedRows[0];
                string maloai = row.Cells[0].Value.ToString();
                if(thehoivien.delete_TheHV(maloai))
                {
                    MessageBox.Show("Xóa thành công");
                    dgv_thehoivien.DataSource = thehoivien.get_theHV();
                    resettext();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy chọn loại thẻ cần xóa");
            }  
        }
    }
}
