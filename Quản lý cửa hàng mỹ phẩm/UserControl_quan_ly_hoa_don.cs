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
    public partial class UserControl_quan_ly_hoa_don : UserControl
    {
        string _hotenNV;
        public string HotenNV
        {
            get
            {
                return _hotenNV;
            }
            set
            {
                _hotenNV = value;
            }
        }

        public UserControl_quan_ly_hoa_don()
        {
            InitializeComponent();
        }

        private void UserControl_quan_ly_hoa_don_Load(object sender, EventArgs e)
        {
            add_usercontrol();
            lock_usercontrol();
            panel_home.Controls[0].Visible = true; 
        }
        private void add_usercontrol()
        {
            UserControl_hoadon_khachhang kh = new UserControl_hoadon_khachhang();
            UserControl_hoadon_hoivien hv = new UserControl_hoadon_hoivien();
            hv.Hotennvlap = this.HotenNV;
            kh.Hotennvlap = this.HotenNV;
            panel_home.Controls.Add(kh);
            panel_home.Controls.Add(hv);
        }
        private void lock_usercontrol()
        {
            panel_home.Controls[0].Visible = false;
            panel_home.Controls[1].Visible = false;
            panel_home.Controls[2].Visible = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            lock_usercontrol();
            panel_home.Controls[1].Visible = true;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            lock_usercontrol();
            panel_home.Controls[2].Visible = true;
        }
    }
}
