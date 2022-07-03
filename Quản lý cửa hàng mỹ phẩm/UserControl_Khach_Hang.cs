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
    public partial class UserControl_Khach_Hang : UserControl
    {
        BUS_Khach_hang khachhang = new BUS_Khach_hang();
        public UserControl_Khach_Hang()
        {
            InitializeComponent();
        }

        private void UserControl_Khach_Hang_Load(object sender, EventArgs e)
        {
            dgv_khach_hang.DataSource = khachhang.get_KhachHang();
            resettext();
        }

        public void resettext()
        {
            khachhang.get_KhachHang();
            txt_makh.ResetText();
            txt_hoten.ResetText();
            txt_diachi.ResetText();
            txt_sdt.ResetText();
            rbn_nam.Checked = false;
            rbn_nu.Checked = false;
            date_ngaysinh.ResetText();
            txt_search.ResetText();
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
            if (txt_makh.Text != "" && txt_hoten.Text != "" && txt_diachi.Text != "" && txt_sdt.Text != "" && (rbn_nam.Checked == true || rbn_nu.Checked == true))
            {
                DateTime ngaysinh = date_ngaysinh.Value;
                DTO_Quan_Ly_Khach_hang dtoKH = new DTO_Quan_Ly_Khach_hang(txt_makh.Text, txt_hoten.Text, get_gioitinh(), ngaysinh, txt_sdt.Text, txt_diachi.Text);
                if (khachhang.insert_KH(dtoKH))
                {
                    MessageBox.Show("Thêm thành công");
                    dgv_khach_hang.DataSource = khachhang.get_KhachHang();
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

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (dgv_khach_hang.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv_khach_hang.SelectedRows[0];
                string makh = row.Cells[0].Value.ToString();
                // Them
                if (khachhang.delete_KH(makh))
                {
                    MessageBox.Show("Xóa thành công");
                    dgv_khach_hang.DataSource = khachhang.get_KhachHang(); // refresh datagridview
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

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txt_makh.Text != "" && txt_hoten.Text != "" && txt_diachi.Text != "" && txt_sdt.Text != "" && (rbn_nam.Checked == true || rbn_nu.Checked == true))
            {
                DateTime ngaysinh = date_ngaysinh.Value;
                DTO_Quan_Ly_Khach_hang dtoKH = new DTO_Quan_Ly_Khach_hang(txt_makh.Text, txt_hoten.Text, get_gioitinh(), ngaysinh, txt_sdt.Text, txt_diachi.Text);
                if (khachhang.update_KH(dtoKH))
                {
                    MessageBox.Show("Sửa thành công");
                    dgv_khach_hang.DataSource = khachhang.get_KhachHang();
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

        private void txt_makh_Enter(object sender, EventArgs e)
        {
            resettext();
            string sokhcuoi = dgv_khach_hang.Rows[dgv_khach_hang.Rows.Count - 1].Cells[0].Value.ToString();
            string sokhmoi = (Convert.ToInt32(sokhcuoi.Substring(2)) + 1).ToString();
            if (Convert.ToInt32(sokhmoi) <= 9) txt_makh.Text = "KH0" + sokhmoi;
            else txt_makh.Text = "KH" + sokhmoi;
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            resettext();
            dgv_khach_hang.DataSource = khachhang.get_KhachHang();
            resettext();
        }

        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
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
                dgv_khach_hang.DataSource = khachhang.get_SDT(txt_search.Text);
            }    
            else
            {
                dgv_khach_hang.DataSource = khachhang.get_thontin_KhachHang(txt_search.Text);
            }    
        }

        private void dgv_khach_hang_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgv_khach_hang.SelectedRows[0];
            txt_makh.Text = row.Cells[0].Value.ToString();
            txt_hoten.Text = row.Cells[1].Value.ToString();
            setRadioGioiTinh(row.Cells[2].Value.ToString());
            date_ngaysinh.Value = Convert.ToDateTime(row.Cells[3].Value.ToString());
            txt_sdt.Text = row.Cells[4].Value.ToString();
            txt_diachi.Text = row.Cells[5].Value.ToString();
        }
    }
}
