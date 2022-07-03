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
    public partial class Form_voucher : Form
    {
        BUS_Voucher voucher = new BUS_Voucher();
        
        public Form_voucher()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_thong_tin_voucher_DoubleClick(object sender, EventArgs e)
        {
            Form_thong_tin_voucher fttvoucher = new Form_thong_tin_voucher();
            fttvoucher.mavoucher = txt_mavoucher.Text;
            fttvoucher.tenvoucher = txt_tenvoucher.Text;
            fttvoucher.tiengiam = txt_tiengiam.Text;
            fttvoucher.ShowDialog();
        }

        public void resettext()
        {
            voucher.get_voucher();
            txt_mavoucher.ResetText();
            txt_tenvoucher.ResetText();
            txt_tiengiam.ResetText();
        }

        private void Form_voucher_Load(object sender, EventArgs e)
        {
            dgv_thong_tin_voucher.DataSource = voucher.get_voucher();
            resettext();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_mavoucher.Text != "" && txt_tenvoucher.Text != "" && txt_tiengiam.Text != "")
            {
                string mavoucher = txt_mavoucher.Text;
                string tenvoucher = txt_tenvoucher.Text;
                decimal tiengiam = Convert.ToDecimal(txt_tiengiam.Text);
                DTO_Voucher DTO_voucher = new DTO_Voucher(mavoucher, tenvoucher, tiengiam);
                if (voucher.insert_voucher(DTO_voucher))
                {
                    MessageBox.Show("Thêm thành công");
                    dgv_thong_tin_voucher.DataSource = voucher.get_voucher();
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
            if(dgv_thong_tin_voucher.SelectedRows.Count > 0)
            {
                if (txt_mavoucher.Text != "" && txt_tenvoucher.Text != "" && txt_tiengiam.Text != "")
                {
                    string mavoucher = txt_mavoucher.Text;
                    string tenvoucher = txt_tenvoucher.Text;
                    decimal tiengiam = Convert.ToDecimal(txt_tiengiam.Text);
                    DTO_Voucher DTO_voucher = new DTO_Voucher(mavoucher, tenvoucher, tiengiam);
                    if (voucher.delete_voucher(DTO_voucher))
                    {
                        MessageBox.Show("Xóa thành công");
                        dgv_thong_tin_voucher.DataSource = voucher.get_voucher();
                        resettext();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Thiếu thông tin!");
                }
            }
            else
            {
                MessageBox.Show("Xin chọn voucher cần xóa");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (dgv_thong_tin_voucher.SelectedRows.Count > 0)
            {
                if (txt_mavoucher.Text != "" && txt_tenvoucher.Text != "" && txt_tiengiam.Text != "")
                {
                    string mavoucher = txt_mavoucher.Text;
                    string tenvoucher = txt_tenvoucher.Text;
                    decimal tiengiam = Convert.ToDecimal(txt_tiengiam.Text);
                    DTO_Voucher DTO_voucher = new DTO_Voucher(mavoucher, tenvoucher, tiengiam);
                    if (voucher.update_voucher(DTO_voucher))
                    {
                        MessageBox.Show("Sửa thành công");
                        dgv_thong_tin_voucher.DataSource = voucher.get_voucher();
                        resettext();
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Thiếu thông tin!");
                }
            }
            else
            {
                MessageBox.Show("Xin chọn voucher cần sửa");
            }
        }

        private void dgv_thong_tin_voucher_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgv_thong_tin_voucher.SelectedRows[0];
            txt_mavoucher.Text = row.Cells[0].Value.ToString();
            txt_tenvoucher.Text = row.Cells[1].Value.ToString();
            txt_tiengiam.Text = voucher.get_TienKM(txt_mavoucher.Text).ToString();
        }
    }
}
