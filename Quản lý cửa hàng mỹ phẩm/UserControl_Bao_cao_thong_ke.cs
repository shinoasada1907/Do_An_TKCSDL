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
    public partial class UserControl_Bao_cao_thong_ke : UserControl
    {
        int gt1 = 0, gt2 = 0, loaichon = 0;
        public UserControl_Bao_cao_thong_ke()
        {
            InitializeComponent();
        }

        private void UserControl_Bao_cao_thong_ke_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_tong_the_Click(object sender, EventArgs e)
        {
            if (radioThang.Checked == true)
            {
                gt1 = Convert.ToInt32(cbbThang.Text);
                gt2 = Convert.ToInt32(cbbNam.Text);
                loaichon = 1;
            }
            else if (radioQuy.Checked == true)
            {
                gt1 = Convert.ToInt32(cbbQuy.Text);
                gt2 = Convert.ToInt32(cbbNam.Text);
                loaichon = 2;
            }
            else if (radioNam.Checked == true)
            {
                gt1 = Convert.ToInt32(txtNam1.Text);
                gt2 = Convert.ToInt32(txtNam2.Text);
                loaichon = 3;
            }
            else if (radioTatCa.Checked == true)
            {
                gt1 = 0;
                gt2 = 0;
                loaichon = 4;
            }
            Form_tong_thong_ke tong = new Form_tong_thong_ke(gt1, gt2, loaichon);
            tong.ShowDialog();
        }

        private void btn_theo_san_pham_Click(object sender, EventArgs e)
        {
            if (radioThang.Checked == true)
            {
                gt1 = Convert.ToInt32(cbbThang.Text);
                gt2 = Convert.ToInt32(cbbNam.Text);
                loaichon = 1;
            }
            else if (radioQuy.Checked == true)
            {
                gt1 = Convert.ToInt32(cbbQuy.Text);
                gt2 = Convert.ToInt32(cbbNam.Text);
                loaichon = 2;
            }
            else if (radioNam.Checked == true)
            {
                gt1 = Convert.ToInt32(txtNam1.Text);
                gt2 = Convert.ToInt32(txtNam2.Text);
                loaichon = 3;
            }
            else if (radioTatCa.Checked == true)
            {
                gt1 = 0;
                gt2 = 0;
                loaichon = 4;
            }
            Form_Theo_san_pham_thong_ke sanpham = new Form_Theo_san_pham_thong_ke(gt1,gt2,loaichon);
            sanpham.ShowDialog();
        }
    }
}
