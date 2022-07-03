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
    public partial class Form_thong_tin_voucher : Form
    {
        BUS_Voucher voucher = new BUS_Voucher();
        string _mavoucher;
        string _tenvoucher;
        string _tiengiam;
        public string mavoucher
        {
            get
            {
                return _mavoucher;
            }
            set
            {
                _mavoucher = value;
            }
        }
        public string tenvoucher
        {
            get
            {
                return _tenvoucher;
            }
            set
            {
                _tenvoucher = value;
            }
        }
        public string tiengiam
        {
            get
            {
                return _tiengiam;
            }
            set
            {
                _tiengiam = value;
            }
        }
        public Form_thong_tin_voucher()
        {
            InitializeComponent();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_thong_tin_voucher_Load(object sender, EventArgs e)
        {
            txt_mavoucher.Text = mavoucher;
            txt_tenvoucher.Text = tenvoucher;
            txt_tiengiam.Text = tiengiam;
        }
    }
}
