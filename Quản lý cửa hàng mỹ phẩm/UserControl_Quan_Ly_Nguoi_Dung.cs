using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_lý_cửa_hàng_mỹ_phẩm
{
    public partial class UserControl_Quan_Ly_Nguoi_Dung : UserControl
    {
        public UserControl_Quan_Ly_Nguoi_Dung()
        {
            InitializeComponent();
        }

        private void add_usercontrol()
        {
            UserControl_Khach_Hang kh = new UserControl_Khach_Hang();
            UserControl_hoi_vien hv = new UserControl_hoi_vien();
            panelKH_HV.Controls.Add(kh);
            panelKH_HV.Controls.Add(hv);
        }

        private void lock_usercontrol()
        {
            panelKH_HV.Controls[0].Visible = false;
            panelKH_HV.Controls[1].Visible = false;
            panelKH_HV.Controls[2].Visible = false;
        }

        private void btn_khach_hang_Click(object sender, EventArgs e)
        {
            lock_usercontrol();
            panelKH_HV.Controls[1].Visible = true;
        }

        private void UserControl_Quan_Ly_Nguoi_Dung_Load(object sender, EventArgs e)
        {
            add_usercontrol();
            lock_usercontrol();
            panelKH_HV.Controls[0].Visible = true;
        }

        private void btn_hoi_vien_Click(object sender, EventArgs e)
        {
            lock_usercontrol();
            panelKH_HV.Controls[2].Visible = true;
        }
    }
}
