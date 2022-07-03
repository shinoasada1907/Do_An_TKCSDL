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
    public partial class Form1 : Form
    {
        BUS_Tai_khoan taikhoan = new BUS_Tai_khoan();
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (cbb_quyen_login.Text != "" && txt_username.Text != "" && txt_password.Text != "")
            {
                if (taikhoan.checkTaiKhoan(txt_username.Text, txt_password.Text, cbb_quyen_login.Text) == true)
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    Form_Trang_Chu f = new Form_Trang_Chu();
                    f.Tennguoidung = txt_username.Text;
                    f.Quyennguoidung = cbb_quyen_login.Text;
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu xin đăng nhập lại");
                }
            }
            else
            {
                MessageBox.Show("Bạn nhập thiếu xin nhập đầy đủ");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
