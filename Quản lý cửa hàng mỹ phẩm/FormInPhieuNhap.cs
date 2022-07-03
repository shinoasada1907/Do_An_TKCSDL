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
using DTO_Quan_ly;

namespace Quản_lý_cửa_hàng_mỹ_phẩm
{
    public partial class FormInPhieuNhap : Form
    {
        string mapn;
        string tenncc;
        public FormInPhieuNhap()
        {
            InitializeComponent();
        }
        public FormInPhieuNhap(string mapn, string tenncc) : this()
        {
            this.mapn = mapn;
            this.tenncc = tenncc;
        }
        public List<DTO_Nha_Cung_Cap> GetNCC()
        {
            List<DTO_Nha_Cung_Cap> dtoncc = new List<DTO_Nha_Cung_Cap>();
            DTO_Nha_Cung_Cap temp = new DTO_Nha_Cung_Cap("NCC00", tenncc);
            dtoncc.Add(temp);
            return dtoncc;
        }

        private void FormInPhieuNhap_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'MYPHAMDataSethoadon.Nha_cung_cap' table. You can move, or remove it, as needed.
            //this.Nha_cung_capTableAdapter.Fill(this.MYPHAMDataSethoadon.Nha_cung_cap);
            //// TODO: This line of code loads data into the 'MYPHAMDataSethoadon.San_Pham' table. You can move, or remove it, as needed.
            //this.San_PhamTableAdapter.Fill(this.MYPHAMDataSethoadon.San_Pham);
            //// TODO: This line of code loads data into the 'MYPHAMDataSethoadon.Chi_Tiet_Phieu_Nhap' table. You can move, or remove it, as needed.
            //this.Chi_Tiet_Phieu_NhapTableAdapter.Fill(this.MYPHAMDataSethoadon.Chi_Tiet_Phieu_Nhap);
            List<DTO_Nha_Cung_Cap> dtoncc = GetNCC();
            SqlConnection cnn = new SqlConnection(@"Data Source=SINONSAMA\TIENNT;Initial Catalog=MYPHAM;Persist Security Info=True;User ID=sa;Password=tiennt1907");
            cnn.Open();
            string sqlctpn = string.Format("Select * From Chi_Tiet_Phieu_Nhap Where MaPhieu = '{0}'", this.mapn);
            SqlDataAdapter da1 = new SqlDataAdapter(sqlctpn, cnn);
            DataTable dt1 = new DataTable("DataSetInPhieuNhap");
            da1.Fill(dt1);
            string sqlsp = string.Format("Select * From San_Pham");
            SqlDataAdapter da2 = new SqlDataAdapter(sqlsp, cnn);
            DataTable dt2 = new DataTable("DataSetSanPham");
            da2.Fill(dt2);
            cnn.Close();
            ReportDataSource rds1 = new ReportDataSource("DataSetInPhieuNhap", dt1);
            ReportDataSource rds2 = new ReportDataSource("DataSetSanPham", dt2);
            ReportDataSource rds3 = new ReportDataSource("DataSetNCC", dtoncc);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds1);
            this.reportViewer1.LocalReport.DataSources.Add(rds2);
            this.reportViewer1.LocalReport.DataSources.Add(rds3);
            this.reportViewer1.RefreshReport();
        }
    }
}
