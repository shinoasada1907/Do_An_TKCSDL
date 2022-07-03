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
    public partial class Form_thong_tin_phieu_nhap : Form
    {
        string _maphieu;
        BUS_phieu_nhap_hang phn = new BUS_phieu_nhap_hang();
        BUS_Chi_tiet_phieu_nhap ctPN = new BUS_Chi_tiet_phieu_nhap();
        public string maphieu
        {
            get
            {
                return _maphieu;
            }
            set
            {
                _maphieu = value;
            }
        }
        public Form_thong_tin_phieu_nhap()
        {
            InitializeComponent();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_thong_tin_phieu_nhap_Load(object sender, EventArgs e)
        {
            dgv_thongtinPN.DataSource = ctPN.get_dgvCTPN(maphieu);
        }
    }
}
