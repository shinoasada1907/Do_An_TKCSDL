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
    public partial class UserControl_Quan_Ly_Tai_Khoan : UserControl
    {
        BUS_Tai_khoan taikhoan = new BUS_Tai_khoan();
        BUS_Nhan_vien nhanvien = new BUS_Nhan_vien();
        BUS_Phan_quyen phanquyen = new BUS_Phan_quyen();
        public UserControl_Quan_Ly_Tai_Khoan()
        {
            InitializeComponent();
        }

        private void UserControl_Quan_Ly_Tai_Khoan_Load(object sender, EventArgs e)
        {
            dgv_taikhoan.DataSource = taikhoan.get_AllTaiKhoan();

            cmb_manv.DataSource = nhanvien.get_MaNVChuaCoTaiKhoan();
            cmb_manv.DisplayMember = "MaNV";
            cmb_manv.SelectedItem = null;

            cmb_quyen.DataSource = phanquyen.get_AllTenQuyen();
            cmb_quyen.DisplayMember = "TenQuyen";
            cmb_quyen.SelectedItem = null;
        }

        private void resettext()
        {
            taikhoan.get_AllTaiKhoan();
            txt_tennv.ResetText();
            txt_taikhoan.ResetText();
            txt_matkhau.ResetText();
            txt_chucvu.ResetText();
            txt_search.ResetText();
        }

        private void cmb_manv_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //this.cmb_manv.GetItemText(this.cmb_manv.SelectedItem) (1 cách khác lấy giá trị khi chọn  trong combobox)
            txt_tennv.Text = nhanvien.get_HoTenNhanVien(cmb_manv.Text);
            txt_chucvu.Text = nhanvien.get_ChucVu(cmb_manv.Text);
        }

        private void dgv_taikhoan_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgv_taikhoan.SelectedRows[0];
            txt_taikhoan.Text = row.Cells[0].Value.ToString();
            txt_matkhau.Text = row.Cells[1].Value.ToString();
            cmb_quyen.Text = row.Cells[2].Value.ToString();
            txt_tennv.Text = row.Cells[3].Value.ToString();
            txt_chucvu.Text = row.Cells[4].Value.ToString();
            cmb_manv.DataSource = nhanvien.get_AllManv();
            cmb_manv.Text = nhanvien.get_Manv(row.Cells[3].Value.ToString());
        }

        private void btn_taotk_Click(object sender, EventArgs e)
        {
            if (cmb_manv.Text != "" && txt_taikhoan.Text != "" && txt_matkhau.Text != "" && cmb_quyen.Text != "")
            {
                string MaQuyen = phanquyen.get_MaQuyen(this.cmb_quyen.GetItemText(this.cmb_quyen.SelectedItem));
                DTO_Tai_Khoan dtotk = new DTO_Tai_Khoan(txt_taikhoan.Text, txt_matkhau.Text, cmb_manv.Text, MaQuyen);
                if (taikhoan.insert_TaiKhoan(dtotk))
                {
                    MessageBox.Show("Thêm tài khoản thành công!");
                    dgv_taikhoan.DataSource = taikhoan.get_AllTaiKhoan();
                    cmb_manv.SelectedItem = null;
                    cmb_quyen.SelectedItem = null;
                    resettext();
                }
                else MessageBox.Show("Thêm tài khoản không thành công!");
            }
            else MessageBox.Show("Bạn hãy nhập đầy đủ!");
        }

        private void btn_xoatk_Click(object sender, EventArgs e)
        {
            if (dgv_taikhoan.SelectedRows.Count > 0)
            {
                string username = dgv_taikhoan.SelectedRows[0].Cells[0].Value.ToString();
                if (taikhoan.delete_TaiKhoan(username))
                {
                    MessageBox.Show("Xóa tài khoản thành công!");
                    dgv_taikhoan.DataSource = taikhoan.get_AllTaiKhoan();
                    cmb_manv.DataSource = nhanvien.get_MaNVChuaCoTaiKhoan();
                    cmb_manv.SelectedItem = null;
                    cmb_quyen.SelectedItem = null;
                    resettext();
                }
                else MessageBox.Show("Xóa tài khoản không thành công!");
            }
            else MessageBox.Show("Xin hãy chọn tài khoản cần xóa");
        }

        private void btn_suatk_Click(object sender, EventArgs e)
        {
            if (dgv_taikhoan.SelectedRows.Count > 0)
            {
                if (cmb_manv.Text != "" && txt_taikhoan.Text != "" && txt_matkhau.Text != "" && cmb_quyen.Text != "")
                {
                    string MaQuyen = phanquyen.get_MaQuyen(this.cmb_quyen.GetItemText(this.cmb_quyen.SelectedItem));
                    DTO_Tai_Khoan dtotk = new DTO_Tai_Khoan(txt_taikhoan.Text, txt_matkhau.Text, cmb_manv.Text, MaQuyen);
                    nhanvien.update_ChucvuNhanVien(cmb_manv.Text, txt_chucvu.Text);
                    if (taikhoan.update_TaiKhoan(dtotk))
                    {
                        MessageBox.Show("Sửa tài khoản thành công!");
                        dgv_taikhoan.DataSource = taikhoan.get_AllTaiKhoan();
                        cmb_manv.DataSource = nhanvien.get_MaNVChuaCoTaiKhoan();
                        cmb_manv.SelectedItem = null;
                        cmb_quyen.SelectedItem = null;
                        resettext();
                    }
                    else MessageBox.Show("Sửa tài khoản không thành công!");
                }
                else MessageBox.Show("Bạn hãy nhập đầy đủ!");
            }
            else MessageBox.Show("Xin hãy chọn tài khoản");

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            dgv_taikhoan.DataSource = taikhoan.get_AllTaiKhoan();
            cmb_manv.DataSource = nhanvien.get_MaNVChuaCoTaiKhoan();
            cmb_manv.SelectedItem = null;
            cmb_quyen.SelectedItem = null;
            resettext();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if(txt_search.Text != "")
            {
                dgv_taikhoan.DataSource = taikhoan.search_TaiKhoan_fromManv(txt_search.Text);
            }    
        }
    }
}
