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
    public partial class UserControl_quan_ly_nha_cung_cap : UserControl
    {
        BUS_Nha_cung_cap nhacungcap = new BUS_Nha_cung_cap();
        public UserControl_quan_ly_nha_cung_cap()
        {
            InitializeComponent();
        }

        private void UserControl_quan_ly_nha_cung_cap_Load(object sender, EventArgs e)
        {
            dgv_nhacungcap.DataSource = nhacungcap.get_AllNCC();
            resettext();
        }

        private void resettext()
        {
            nhacungcap.get_AllNCC();
            txt_mancc.ResetText();
            txt_tenncc.ResetText();
            txt_search.ResetText();
        }

        private void dgv_nhacungcap_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgv_nhacungcap.SelectedRows[0];
            txt_mancc.Text = row.Cells[0].Value.ToString();
            txt_tenncc.Text = row.Cells[1].Value.ToString();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if(txt_mancc.Text != "" && txt_tenncc.Text != "")
            {
                DTO_Nha_Cung_Cap dtoncc = new DTO_Nha_Cung_Cap(txt_mancc.Text, txt_tenncc.Text);
                if (nhacungcap.insert_NCC(dtoncc))
                {
                    MessageBox.Show("Thêm thành công");
                    dgv_nhacungcap.DataSource = nhacungcap.get_AllNCC();
                    resettext();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin điều đầy đủ thông tin");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if(dgv_nhacungcap.SelectedRows.Count > 0)
            {
                if (txt_mancc.Text != "" && txt_tenncc.Text != "")
                {
                    DTO_Nha_Cung_Cap dtoncc = new DTO_Nha_Cung_Cap(txt_mancc.Text, txt_tenncc.Text);
                    if (nhacungcap.update_NCC(dtoncc))
                    {
                        MessageBox.Show("Sửa thành công");
                        dgv_nhacungcap.DataSource = nhacungcap.get_AllNCC();
                        resettext();
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Xin điều đầy đủ thông tin");
                }
            }    
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if(dgv_nhacungcap.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv_nhacungcap.SelectedRows[0];
                string mancc = row.Cells[0].Value.ToString();
                if (nhacungcap.delete_NCC(mancc))
                {
                    MessageBox.Show("Xóa thành công");
                    dgv_nhacungcap.DataSource = nhacungcap.get_AllNCC();
                    resettext();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }
            } 
            else
            {
                MessageBox.Show("Xin hãy chọn nhân viên muốn xóa");
            }    
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            dgv_nhacungcap.DataSource = nhacungcap.search_NCC(txt_search.Text);
            txt_search.ResetText();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            dgv_nhacungcap.DataSource = nhacungcap.get_AllNCC();
            resettext();
        }
    }
}
