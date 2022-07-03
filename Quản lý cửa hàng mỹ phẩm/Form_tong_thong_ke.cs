using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace Quản_lý_cửa_hàng_mỹ_phẩm
{
    public partial class Form_tong_thong_ke : Form
    {
        int date1, date2, loai;
        public Form_tong_thong_ke()
        {
            InitializeComponent();
        }

        private void Form_tong_thong_ke_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=SINONSAMA\TIENNT;Initial Catalog=MYPHAM;Persist Security Info=True;User ID=sa;Password=tiennt1907");
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            if (loai == 1)
            {
                da = new SqlDataAdapter("Select * From Hoa_Don Where MONTH(Ngay_lap_HD) = '" + date1 + "' AND YEAR(Ngay_lap_HD) = '" + date2 + "'", cnn);
            }
            else if (loai == 2)
            {
                da = new SqlDataAdapter("Select * From Hoa_Don Where DATEPART(QUARTER, Ngay_lap_HD) = '" + date1 + "' AND YEAR(Ngay_lap_HD) = '" + date2 + "'", cnn);
            }
            else if (loai == 3)
            {
                da = new SqlDataAdapter("Select * From Hoa_Don Where YEAR(Ngay_lap_HD) >= '" + date1 + "' AND YEAR(Ngay_lap_HD) <= '" + date2 + "'", cnn);
            }
            else if (loai == 4)
            {
                da = new SqlDataAdapter("Select * From Hoa_Don", cnn);
            }
            DataTable dt = new DataTable("DataSethoadon");
            da.Fill(dt);
            cnn.Close();
            ReportDataSource rds = new ReportDataSource("DataSethoadon", dt);
            this.report_tongthe.LocalReport.DataSources.Clear();
            this.report_tongthe.LocalReport.DataSources.Add(rds);
            this.report_tongthe.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public Form_tong_thong_ke(int gt1, int gt2, int loaichon) : this()
        {
            date1 = gt1;
            date2 = gt2;
            loai = loaichon;
        }
    }
}
