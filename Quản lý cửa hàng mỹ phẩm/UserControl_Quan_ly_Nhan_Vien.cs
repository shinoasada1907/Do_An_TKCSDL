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
    public partial class UserControl_Quan_ly_Nhan_Vien : UserControl
    {
        BUS_Nhan_vien nhanvien = new BUS_Nhan_vien();
        public UserControl_Quan_ly_Nhan_Vien()
        {
            InitializeComponent();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if(txt_manv.Text != "" && txt_hoten.Text != "" && txt_diachi.Text != "" && (rbn_nam.Checked == true || rbn_nu.Checked == true) && txt_chucvu.Text != "" && txt_luong.Text != "" && txt_sdt.Text !="")
            {
                string manv = txt_manv.Text;
                string hoten = txt_hoten.Text;
                string diachi = txt_diachi.Text;
                string chucvu = txt_chucvu.Text;
                decimal luong = Convert.ToDecimal(txt_luong.Text);
                string sdt= txt_sdt.Text;
                DateTime ngaysinh = date_ngaysinh.Value;
                DTO_Quan_Ly_Nhan_Vien DTONV = new DTO_Quan_Ly_Nhan_Vien(manv, hoten, ngaysinh, get_gioitinh(), chucvu, sdt, diachi, luong);
                if(nhanvien.insert_NhanVien(DTONV))
                {
                    MessageBox.Show("Thêm thành công");
                    dgv_nhanvien.DataSource = nhanvien.getNhanVien();
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

        private void UserControl_Quan_ly_Nhan_Vien_Load(object sender, EventArgs e)
        {
            dgv_nhanvien.DataSource = nhanvien.getNhanVien();
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

        private void dgv_nhanvien_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgv_nhanvien.SelectedRows[0];
            txt_manv.Text = row.Cells[0].Value.ToString();
            txt_hoten.Text = row.Cells[1].Value.ToString();
            date_ngaysinh.Value = Convert.ToDateTime(row.Cells[2].Value.ToString());
            setRadioGioiTinh(row.Cells[3].Value.ToString());
            txt_chucvu.Text = row.Cells[4].Value.ToString();
            txt_sdt.Text = row.Cells[5].Value.ToString();
            txt_diachi.Text = row.Cells[6].Value.ToString();
            txt_luong.Text = row.Cells[7].Value.ToString();
        }

        public void resettext()
        {
            dgv_nhanvien.DataSource = nhanvien.getNhanVien();
            txt_manv.ResetText();
            txt_hoten.ResetText();
            date_ngaysinh.ResetText();
            rbn_nam.Checked = false;
            rbn_nu.Checked = false;
            txt_diachi.ResetText();
            txt_sdt.ResetText();
            txt_chucvu.ResetText();
            txt_luong.ResetText();
            txt_search.ResetText();
        }

        private void txt_manv_Enter(object sender, EventArgs e)
        {
            resettext();
            string sonvcuoi = dgv_nhanvien.Rows[dgv_nhanvien.Rows.Count - 1].Cells[0].Value.ToString();
            string sonvmoi = (Convert.ToInt32(sonvcuoi.Substring(2)) + 1).ToString();
            if (Convert.ToInt32(sonvmoi) <= 9) txt_manv.Text = "NV0" + sonvmoi;
            else txt_manv.Text = "NV" + sonvmoi;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if(dgv_nhanvien.SelectedRows.Count > 0)
            {
                if (txt_manv.Text != "" && txt_hoten.Text != "" && txt_diachi.Text != "" && (rbn_nam.Checked == true || rbn_nu.Checked == true) && txt_chucvu.Text != "" && txt_luong.Text != "" && txt_sdt.Text != "")
                {
                    string manv = txt_manv.Text;
                    string hoten = txt_hoten.Text;
                    string diachi = txt_diachi.Text;
                    string chucvu = txt_chucvu.Text;
                    decimal luong = Convert.ToDecimal(txt_luong.Text);
                    string sdt = txt_sdt.Text;
                    DateTime ngaysinh = date_ngaysinh.Value;
                    DTO_Quan_Ly_Nhan_Vien DTONV = new DTO_Quan_Ly_Nhan_Vien(manv, hoten, ngaysinh, get_gioitinh(), chucvu, sdt, diachi, luong);
                    if (nhanvien.update_NhanVien(DTONV))
                    {
                        MessageBox.Show("Sửa thành công");
                        dgv_nhanvien.DataSource = nhanvien.getNhanVien();
                        resettext();
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Xin hãy chọn nhân viên cần sửa");
                }
            }    
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (dgv_nhanvien.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv_nhanvien.SelectedRows[0];
                string MaNV = row.Cells[0].Value.ToString();
                // Them
                if (nhanvien.delete_NhanVien(MaNV))
                {
                    MessageBox.Show("Xóa thành công");
                    dgv_nhanvien.DataSource = nhanvien.getNhanVien(); // refresh datagridview
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

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            resettext();
            dgv_nhanvien.DataSource = nhanvien.getNhanVien();
            resettext();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            dgv_nhanvien.DataSource = nhanvien.search_nameNhanVien(txt_search.Text);
        }
    }
}
