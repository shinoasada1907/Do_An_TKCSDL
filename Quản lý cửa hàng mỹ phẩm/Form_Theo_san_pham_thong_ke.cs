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
    public partial class Form_Theo_san_pham_thong_ke : Form
    {
        int date1, date2, loai;
        public Form_Theo_san_pham_thong_ke()
        {
            InitializeComponent();
        }

        private void Form_Theo_san_pham_thong_ke_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=SINONSAMA\TIENNT;Initial Catalog=MYPHAM;Persist Security Info=True;User ID=sa;Password=tiennt1907");
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlDataAdapter da2 = new SqlDataAdapter();
            if (loai == 1)
            {
                da = new SqlDataAdapter("Select DISTINCT San_Pham.MaSP, San_Pham.TenSP, San_Pham.MALOAI, San_Pham.Ma_voucher, San_Pham.GiaSP, San_Pham.SLTON, San_Pham.Hang_SX" +
                    " From San_Pham, Chi_Tiet_Hoa_Don, Hoa_Don Where San_Pham.MASP = Chi_Tiet_Hoa_Don.MASP" +
                    " And Chi_Tiet_Hoa_Don.MAHD = Hoa_Don.MAHD And MONTH(Hoa_Don.Ngay_lap_HD) = '" + date1 + "' " +
                    "AND YEAR(Hoa_Don.Ngay_lap_HD) = '" + date2 + "'", cnn);
                da2 = new SqlDataAdapter("Select DISTINCT Chi_Tiet_Hoa_Don.MAHD, Chi_Tiet_Hoa_Don.MASP, Chi_Tiet_Hoa_Don.SLMUA, Chi_Tiet_Hoa_Don.Ma_voucher, Chi_Tiet_Hoa_Don.THANHTIEN" +
                    " From San_Pham, Chi_Tiet_Hoa_Don, Hoa_Don Where San_Pham.MASP = Chi_Tiet_Hoa_Don.MASP" +
                    " And Chi_Tiet_Hoa_Don.MAHD = Hoa_Don.MAHD And MONTH(Hoa_Don.Ngay_lap_HD) = '" + date1 + "' " +
                    "AND YEAR(Hoa_Don.Ngay_lap_HD) = '" + date2 + "'", cnn);
            }
            else if (loai == 2)
            {
                da = new SqlDataAdapter("Select DISTINCT San_Pham.MaSP, San_Pham.TenSP, San_Pham.MALOAI, San_Pham.Ma_voucher, San_Pham.GiaSP, San_Pham.SLTON, San_Pham.Hang_SX" +
                    " From San_Pham, Chi_Tiet_Hoa_Don, Hoa_Don Where San_Pham.MASP = Chi_Tiet_Hoa_Don.MASP" +
                    " And Chi_Tiet_Hoa_Don.MAHD = Hoa_Don.MAHD And DATEPART(QUARTER, Hoa_Don.Ngay_lap_HD) = '" + date1 + "' " +
                    "AND YEAR(Hoa_Don.Ngay_lap_HD) = '" + date2 + "'", cnn);
                da2 = new SqlDataAdapter("Select DISTINCT Chi_Tiet_Hoa_Don.MAHD, Chi_Tiet_Hoa_Don.MASP, Chi_Tiet_Hoa_Don.SLMUA, Chi_Tiet_Hoa_Don.Ma_voucher, Chi_Tiet_Hoa_Don.THANHTIEN" +
                    " From San_Pham, Chi_Tiet_Hoa_Don, Hoa_Don Where San_Pham.MASP = Chi_Tiet_Hoa_Don.MASP" +
                    " And Chi_Tiet_Hoa_Don.MAHD = Hoa_Don.MAHD And DATEPART(QUARTER, Hoa_Don.Ngay_lap_HD) = '" + date1 + "' " +
                    "AND YEAR(Hoa_Don.Ngay_lap_HD) = '" + date2 + "'", cnn);
            }
            else if (loai == 3)
            {
                da = new SqlDataAdapter("Select DISTINCT San_Pham.MaSP, San_Pham.TenSP, San_Pham.MALOAI, San_Pham.Ma_voucher, San_Pham.GiaSP, San_Pham.SLTON, San_Pham.Hang_SX" +
                    " From San_Pham, Chi_Tiet_Hoa_Don, Hoa_Don Where San_Pham.MASP = Chi_Tiet_Hoa_Don.MASP" +
                    " And Chi_Tiet_Hoa_Don.MAHD = Hoa_Don.MAHD And YEAR(Hoa_Don.Ngay_lap_HD) = '" + date1 + "' " +
                    "AND YEAR(Hoa_Don.Ngay_lap_HD) = '" + date2 + "'", cnn);
                da2 = new SqlDataAdapter("Select DISTINCT Chi_Tiet_Hoa_Don.MAHD, Chi_Tiet_Hoa_Don.MASP, Chi_Tiet_Hoa_Don.SLMUA, Chi_Tiet_Hoa_Don.Ma_voucher, Chi_Tiet_Hoa_Don.THANHTIEN" +
                    " From San_Pham, Chi_Tiet_Hoa_Don, Hoa_Don Where San_Pham.MASP = Chi_Tiet_Hoa_Don.MASP" +
                    " And Chi_Tiet_Hoa_Don.MAHD = Hoa_Don.MAHD And YEAR(Hoa_Don.Ngay_lap_HD) = '" + date1 + "' " +
                    "AND YEAR(Hoa_Don.Ngay_lap_HD) = '" + date2 + "'", cnn);
            }
            else if (loai == 4)
            {
                da = new SqlDataAdapter("Select * From San_Pham", cnn);
                da2 = new SqlDataAdapter("Select * From Chi_Tiet_Hoa_Don", cnn);
            }
            DataTable dt = new DataTable("DataSetsanpham");
            da.Fill(dt);
            DataTable dt2 = new DataTable("DataSetchitiethoadon");
            da2.Fill(dt2);
            cnn.Close();
            ReportDataSource rds = new ReportDataSource("DataSetsanpham", dt);
            ReportDataSource rds2 = new ReportDataSource("DataSetchitiethoadon", dt2);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.DataSources.Add(rds2);
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public Form_Theo_san_pham_thong_ke(int gt1, int gt2, int loaichon) : this()
        {
            date1 = gt1;
            date2 = gt2;
            loai = loaichon;
        }
    }
}
