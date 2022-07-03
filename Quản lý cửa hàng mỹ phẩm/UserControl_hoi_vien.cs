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
    public partial class UserControl_hoi_vien : UserControl
    {
        BUS_hoi_vien hoivien = new BUS_hoi_vien();
        BUS_The_hoi_vien theHV = new BUS_The_hoi_vien();
        public UserControl_hoi_vien()
        {
            InitializeComponent();
        }

        private void btn_the_hoi_vien_Click(object sender, EventArgs e)
        {
            Form_the_hoi_vien fthv = new Form_the_hoi_vien();
            fthv.ShowDialog();
        }

        private void UserControl_hoi_vien_Load(object sender, EventArgs e)
        {
            dgv_hoivien.DataSource = hoivien.get_Hoivien();

            cmb_loaithe.DataSource = theHV.get_TentheHV();
            cmb_loaithe.ValueMember = "Loai_The";
            cmb_loaithe.DisplayMember = "Loai_The";
            resettext();
        }

        private void resettext()
        {
            hoivien.get_Hoivien();
            cmb_loaithe.ResetText();
            txt_mahv.ResetText();
            txt_hoten.ResetText();
            txt_sdt.ResetText();
            txt_search.ResetText();
            rbn_nam.Checked = false;
            rbn_nu.Checked = false;
            date_ngaylap.ResetText();
            date_ngaysinh.ResetText();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            resettext();
            dgv_hoivien.DataSource = hoivien.get_Hoivien();
        }

        public bool IsNumber(string Value)
        {
            foreach (Char c in Value)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if(IsNumber(txt_search.Text) == true)
            {
                dgv_hoivien.DataSource = hoivien.get_thong_tinHV(txt_search.Text);
                txt_search.ResetText();
            }
            else
            {
                dgv_hoivien.DataSource = hoivien.get_thongtinHV(txt_search.Text);
                txt_sdt.ResetText();
            }
            if(cmb_loaithe.Text != "")
            {
                dgv_hoivien.DataSource = hoivien.get_thongtin_theHV(cmb_loaithe.Text);
                resettext();
            }    
            //if(txt_search.Text != "")
            //{
            //    dgv_hoivien.DataSource = hoivien.get_thongtinHV(txt_search.Text);
            //    txt_search.ResetText();
            //}
            //if(txt_sdt.Text != "")
            //{
            //    dgv_hoivien.DataSource = hoivien.get_thong_tinHV(txt_sdt.Text);
            //    txt_sdt.ResetText();
            //}    
        }
        //check giới tính
        public string get_gioitinh()
        {
            if (rbn_nam.Checked == true)
                return "Nam";
            else
                return "Nữ";
        }

        //đặt giới tính cho nút radio
        private void setRadioGioiTinh(string gt)
        {
            if (gt == "Nam")
            {
                rbn_nam.Checked = true;
                rbn_nu.Checked = false;
            }
            else
            {
                rbn_nam.Checked = false;
                rbn_nu.Checked = true;
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_mahv.Text != "" && txt_hoten.Text != "" && txt_sdt.Text != "" && cmb_loaithe.Text != "" && (rbn_nam.Checked == true || rbn_nu.Checked == true))
            {
                DateTime ngaysinh = date_ngaysinh.Value;
                DateTime ngaylap = date_ngaylap.Value;
                DTO_Hoi_Vien HV = new DTO_Hoi_Vien(Convert.ToInt32(txt_mahv.Text), cmb_loaithe.Text, txt_hoten.Text, get_gioitinh(), ngaysinh, ngaylap, txt_sdt.Text);
                if (hoivien.insert_HV(HV))
                {
                    MessageBox.Show("Thêm thành công");
                    dgv_hoivien.DataSource = hoivien.get_Hoivien();
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
            if(dgv_hoivien.SelectedRows.Count > 0)
            {
                if (txt_mahv.Text != "" && txt_hoten.Text != "" && txt_sdt.Text != "" && cmb_loaithe.Text != "" && (rbn_nam.Checked == true || rbn_nu.Checked == true))
                {
                    DateTime ngaysinh = date_ngaysinh.Value;
                    DateTime ngaylap = date_ngaylap.Value;
                    DTO_Hoi_Vien HV = new DTO_Hoi_Vien(Convert.ToInt32(txt_mahv.Text), cmb_loaithe.Text, txt_hoten.Text, get_gioitinh(), ngaysinh, ngaylap, txt_sdt.Text);
                    if (hoivien.update_HV(HV))
                    {
                        MessageBox.Show("Thêm thành công");
                        dgv_hoivien.DataSource = hoivien.get_Hoivien();
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
            else
            {
                MessageBox.Show("Hãy chọn nhân viên muốn xóa");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (dgv_hoivien.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv_hoivien.SelectedRows[0];
                string mahv = row.Cells[0].Value.ToString();
                // Them
                if (hoivien.delete_HV(mahv))
                {
                    MessageBox.Show("Xóa thành công");
                    dgv_hoivien.DataSource = hoivien.get_Hoivien();
                    resettext();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn nhân viên muốn xóa");
            }
        }

        private void dgv_hoivien_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgv_hoivien.SelectedRows[0];
            txt_mahv.Text = row.Cells[0].Value.ToString();
            cmb_loaithe.Text = row.Cells[1].Value.ToString();
            txt_hoten.Text = row.Cells[2].Value.ToString();
            setRadioGioiTinh(row.Cells[3].Value.ToString());
            date_ngaysinh.Value = Convert.ToDateTime(row.Cells[4].Value.ToString());
            date_ngaylap.Value = Convert.ToDateTime(row.Cells[5].Value.ToString());
            txt_sdt.Text = row.Cells[6].Value.ToString();
        }

        private void txt_mahv_Enter(object sender, EventArgs e)
        {
            resettext();
            string sohvcuoi = dgv_hoivien.Rows[dgv_hoivien.Rows.Count - 1].Cells[0].Value.ToString();
            int socuoi = Convert.ToInt32(sohvcuoi) + 1;
            txt_mahv.Text = socuoi.ToString();
        }
    }
}
