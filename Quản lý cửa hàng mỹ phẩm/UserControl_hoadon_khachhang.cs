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
    public partial class UserControl_hoadon_khachhang : UserControl
    {
        string _hotennv;
        decimal _tongtien = 0;
        BUS_hoa_don hoadon = new BUS_hoa_don();

        public string Hotennvlap
        {
            get
            {
                return _hotennv;
            }
            set
            {
                _hotennv = value;
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
        public UserControl_hoadon_khachhang()
        {
            InitializeComponent();
        }

        private void UserControl_hoadon_khachhang_Load(object sender, EventArgs e)
        {
            dgv_hoa_don.DataSource = hoadon.get_HoaDon_KH();
        }

        private void dgv_hoa_don_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form_Thong_tin_CTHD cthd = new Form_Thong_tin_CTHD();
            cthd.mahd = dgv_hoa_don.SelectedRows[0].Cells[0].Value.ToString();
            cthd.Ten = dgv_hoa_don.SelectedRows[0].Cells[2].Value.ToString();
            cthd.Tongtien = Convert.ToDecimal(dgv_hoa_don.SelectedRows[0].Cells[4].Value.ToString());
            cthd.ShowDialog();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            dgv_hoa_don.DataSource = hoadon.search_HoaDon_TenKH(txt_search.Text);
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            dgv_hoa_don.DataSource = hoadon.get_HoaDon_KH();
            txt_search.ResetText();
        }

        private void btn_lapHD_Click(object sender, EventArgs e)
        {
            Form_them_moi_KH themkh = new Form_them_moi_KH();
            themkh.Tennv = this.Hotennvlap;
            themkh.ShowDialog();
        }
    }
}
