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
    public partial class Form_Trang_Chu : Form
    {
        string _TenTaiKhoan;
        string _QuyenNguoiDung;
        BUS_Tai_khoan taikhoan = new BUS_Tai_khoan();
        BUS_Nhan_vien nhanvien = new BUS_Nhan_vien();
        public Form_Trang_Chu()
        {
            InitializeComponent();
        }

        public string Tennguoidung
        {
            get
            {
                return _TenTaiKhoan;
            }
            set
            {
                _TenTaiKhoan = value;
            }
        }

        public string Quyennguoidung
        {
            get
            {
                return _QuyenNguoiDung;
            }
            set
            {
                _QuyenNguoiDung = value;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void show_form()
        {
            UserControl_Quan_Ly_San_Pham usp = new UserControl_Quan_Ly_San_Pham();
            UserControl_Quan_ly_Nhan_Vien unp = new UserControl_Quan_ly_Nhan_Vien();
            UserControl_Quan_Ly_Nguoi_Dung und = new UserControl_Quan_Ly_Nguoi_Dung();
            UserControl_quan_ly_hoa_don uhd = new UserControl_quan_ly_hoa_don();
            uhd.HotenNV = nhanvien.get_HoTenNhanVien(taikhoan.get_MaNVTaiKhoan(Tennguoidung));
            UserControl_quan_ly_nha_cung_cap ncc = new UserControl_quan_ly_nha_cung_cap();
            UserControl_Quan_Ly_Phieu_Nhap upn = new UserControl_Quan_Ly_Phieu_Nhap();
            upn.Hotennv = nhanvien.get_HoTenNhanVien(taikhoan.get_MaNVTaiKhoan(Tennguoidung));
            UserControl_Quan_Ly_Tai_Khoan utk = new UserControl_Quan_Ly_Tai_Khoan();
            UserControl_Bao_cao_thong_ke ubcbtk = new UserControl_Bao_cao_thong_ke();
            panelHome.Controls.Add(usp);
            panelHome.Controls.Add(unp);
            panelHome.Controls.Add(und);
            panelHome.Controls.Add(uhd);
            panelHome.Controls.Add(ncc);
            panelHome.Controls.Add(upn);
            panelHome.Controls.Add(utk);
            panelHome.Controls.Add(ubcbtk);
        }

        private void changecolor(int a, int b, int c)
        {
            panel_menu.BackColor = Color.FromArgb(a, b, c);
        }

        private void Lock_user_control()
        {
            panelHome.Controls[0].Visible = false;
            panelHome.Controls[1].Visible = false;
            panelHome.Controls[2].Visible = false;
            panelHome.Controls[3].Visible = false;
            panelHome.Controls[4].Visible = false;
            panelHome.Controls[5].Visible = false;
            panelHome.Controls[6].Visible = false;
            panelHome.Controls[7].Visible = false;
            panelHome.Controls[8].Visible = false;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            changecolor(249,179,179);//249, 179, 179
            Lock_user_control();
            panelHome.Controls[1].Visible = true;
        }

        private void Form_Trang_Chu_Load(object sender, EventArgs e)
        {
            lbl_thongtin.Text = Quyennguoidung + ": " + nhanvien.get_HoTenNhanVien(taikhoan.get_MaNVTaiKhoan(Tennguoidung));
            if (Quyennguoidung != "Quản lý")
            {
                btn_quan_ly_nhan_vien.Cursor = Cursors.No;
                btn_quan_ly_tai_khoan.Cursor = Cursors.No;
            }
            show_form();
            Lock_user_control();
            panelHome.Controls[0].Visible = true;
        }

        private void btn_quan_ly_nhan_vien_Click(object sender, EventArgs e)
        {
            if (Quyennguoidung == "Quản lý")
            {
                changecolor(249, 179, 179);
                Lock_user_control();
                panelHome.Controls[2].Visible = true;
            }
        }

        private void btn_quan_ly_nguoi_dung_Click(object sender, EventArgs e)
        {
            changecolor(249, 179, 179);
            Lock_user_control();
            panelHome.Controls[3].Visible = true;
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            panel_header.BackColor = Color.Ivory;
            panel_menu.BackColor = Color.Ivory;
            Lock_user_control();
            panelHome.Controls[0].Visible = true;
        }

        private void btn_quan_ly_hoa_don_Click(object sender, EventArgs e)
        {
            changecolor(249, 179, 179);
            Lock_user_control();
            panelHome.Controls[4].Visible = true;
        }

        private void btn_quan_ly_nha_cung_cap_Click(object sender, EventArgs e)
        {
            changecolor(249, 179, 179);
            Lock_user_control();
            panelHome.Controls[5].Visible = true;
        }

        private void btn_quan_ly_phieu_nhap_Click(object sender, EventArgs e)
        {
            changecolor(249, 179, 179);
            Lock_user_control();
            panelHome.Controls[6].Visible = true;
        }

        private void btn_quan_ly_tai_khoan_Click(object sender, EventArgs e)
        {
            if (Quyennguoidung == "Quản lý")
            {
                changecolor(249, 179, 179);
                Lock_user_control();
                panelHome.Controls[7].Visible = true;
            }
            //changecolor(249, 179, 179);
            //Lock_user_control();
            //panelHome.Controls[7].Visible = true;
        }

        private void btn_bao_cao_thong_ke_Click(object sender, EventArgs e)
        {
            changecolor(249, 179, 179);
            Lock_user_control();
            panelHome.Controls[8].Visible = true;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
