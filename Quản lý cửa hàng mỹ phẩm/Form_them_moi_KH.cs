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
    public partial class Form_them_moi_KH : Form
    {
        string _tennv;
        BUS_Khach_hang khachhang = new BUS_Khach_hang();
        Form_chi_tiet_hoa_don cthd = new Form_chi_tiet_hoa_don();
        public string Tennv
        {
            get
            {
                return _tennv;
            }
            set
            {
                _tennv = value;
            }
        }
        public Form_them_moi_KH()
        {
            InitializeComponent();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_themkh_Click(object sender, EventArgs e)
        {
            if((khachhang.check_khachhang(txt_sdt.Text) == true))
            {
                MessageBox.Show("Khách hàng đã có trong danh sách");
                Form_chi_tiet_hoa_don cthd = new Form_chi_tiet_hoa_don();
                cthd.makh = txt_makh.Text;
                cthd.Tennv = this.Tennv;
                cthd.ShowDialog();
                this.Close();
            }
            else
            {
                if (txt_makh.Text != "" && txt_hoten.Text != "" && txt_diachi.Text != "" && txt_sdt.Text != "" && (rbn_nam.Checked == true || rbn_nu.Checked == true))
                {
                    DateTime ngaysinh = date_ngaysinh.Value;
                    DTO_Quan_Ly_Khach_hang dtoKH = new DTO_Quan_Ly_Khach_hang(txt_makh.Text, txt_hoten.Text, get_gioitinh(), ngaysinh, txt_sdt.Text, txt_diachi.Text);
                    if (khachhang.insert_KH(dtoKH))
                    {
                        MessageBox.Show("Thêm thành công");
                        Form_chi_tiet_hoa_don cthd = new Form_chi_tiet_hoa_don();
                        cthd.makh = txt_makh.Text;
                        cthd.Tennv = this.Tennv;
                        cthd.ShowDialog();
                        this.Close();
                        resettext();
                        txt_sdt.ResetText();
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
            //if (txt_makh.Text != "" && txt_hoten.Text != "" && txt_diachi.Text != "" && txt_sdt.Text != "" && (rbn_nam.Checked == true || rbn_nu.Checked == true))
            //{
            //    DateTime ngaysinh = date_ngaysinh.Value;
            //    DTO_Quan_Ly_Khach_hang dtoKH = new DTO_Quan_Ly_Khach_hang(txt_makh.Text, txt_hoten.Text, get_gioitinh(), ngaysinh, txt_sdt.Text, txt_diachi.Text);
            //    if (khachhang.insert_KH(dtoKH))
            //    {
            //        MessageBox.Show("Thêm thành công");
            //        resettext();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Thêm không thành công");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Xin điền đầy đủ thông tin");
            //}
        }

        public void resettext()
        {
            khachhang.get_KhachHang();
            txt_makh.ResetText();
            txt_hoten.ResetText();
            txt_diachi.ResetText();
            //txt_sdt.ResetText();
            rbn_nam.Checked = false;
            rbn_nu.Checked = false;
            date_ngaysinh.ResetText();
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

        private void txt_makh_Enter(object sender, EventArgs e)
        {
            resettext();
            string sokhcuoi = khachhang.get_makh_cuoi();
            string sokhmoi = (Convert.ToInt32(sokhcuoi.Substring(2)) + 1).ToString();
            if (Convert.ToInt32(sokhmoi) <= 9) txt_makh.Text = "KH0" + sokhmoi;
            else txt_makh.Text = "KH" + sokhmoi;
        }

        private void txt_sdt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (khachhang.check_khachhang(txt_sdt.Text) == true)
                {
                    txt_makh.Text = khachhang.getMaKHFromSDTKH(txt_sdt.Text);
                    txt_hoten.Text = khachhang.get_TenKhachHang(khachhang.getMaKHFromSDTKH(txt_sdt.Text));
                    txt_diachi.Text = khachhang.get_DiaChi(khachhang.getMaKHFromSDTKH(txt_sdt.Text));
                    date_ngaysinh.Value = khachhang.get_ngaysinh(khachhang.getMaKHFromSDTKH(txt_sdt.Text));
                    cthd.makh = khachhang.getMaKHFromSDTKH(txt_sdt.Text);
                    if (khachhang.get_gioitinh(khachhang.getMaKHFromSDTKH(txt_sdt.Text)) == "Nam")
                    {
                        rbn_nam.Checked = true;
                    }
                    else
                    {
                        rbn_nu.Checked = true;
                    }
                }
                else MessageBox.Show("Khách hàng mới");
            }
        }
    }
}
