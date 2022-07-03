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
    public partial class Form_Thong_tin_CTHD : Form
    {
        string _mahd;
        decimal _tongtien = 0;
        string _ten;
        BUS_Chi_tiet_hoa_don hoadon = new BUS_Chi_tiet_hoa_don();
        public Form_Thong_tin_CTHD()
        {
            InitializeComponent();
        }

        public string mahd
        {
            get
            {
                return _mahd;
            }
            set
            {
                _mahd = value;
            }
        }

        public decimal Tongtien
        {
            get
            {
                return _tongtien;
            }
            set
            {
                _tongtien = value;
            }
        }

        public string Ten
        {
            get
            {
                return _ten;
            }
            set
            {
                _ten = value;
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Thong_tin_CTHD_Load(object sender, EventArgs e)
        {
            dgv_chitiethd.DataSource = hoadon.get_CTHD(mahd);
            txt_hoten.Text = Ten;
            txt_mahd.Text = mahd;
            txt_tongtien.Text = Tongtien.ToString();
        }
    }
}
