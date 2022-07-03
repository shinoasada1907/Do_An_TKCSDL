
namespace Quản_lý_cửa_hàng_mỹ_phẩm
{
    partial class FormInPhieuNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MYPHAMDataSethoadon = new Quản_lý_cửa_hàng_mỹ_phẩm.MYPHAMDataSethoadon();
            this.Chi_Tiet_Hoa_DonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Chi_Tiet_Hoa_DonTableAdapter = new Quản_lý_cửa_hàng_mỹ_phẩm.MYPHAMDataSethoadonTableAdapters.Chi_Tiet_Hoa_DonTableAdapter();
            this.San_PhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.San_PhamTableAdapter = new Quản_lý_cửa_hàng_mỹ_phẩm.MYPHAMDataSethoadonTableAdapters.San_PhamTableAdapter();
            this.Nha_cung_capBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Nha_cung_capTableAdapter = new Quản_lý_cửa_hàng_mỹ_phẩm.MYPHAMDataSethoadonTableAdapters.Nha_cung_capTableAdapter();
            this.Chi_Tiet_Phieu_NhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Chi_Tiet_Phieu_NhapTableAdapter = new Quản_lý_cửa_hàng_mỹ_phẩm.MYPHAMDataSethoadonTableAdapters.Chi_Tiet_Phieu_NhapTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.MYPHAMDataSethoadon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chi_Tiet_Hoa_DonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.San_PhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nha_cung_capBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chi_Tiet_Phieu_NhapBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetNCC";
            reportDataSource1.Value = this.Nha_cung_capBindingSource;
            reportDataSource2.Name = "DataSetSanPham";
            reportDataSource2.Value = this.San_PhamBindingSource;
            reportDataSource3.Name = "DataSetInPhieuNhap";
            reportDataSource3.Value = this.Chi_Tiet_Phieu_NhapBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Quản_lý_cửa_hàng_mỹ_phẩm.Report_nhap_hang.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(637, 525);
            this.reportViewer1.TabIndex = 0;
            // 
            // MYPHAMDataSethoadon
            // 
            this.MYPHAMDataSethoadon.DataSetName = "MYPHAMDataSethoadon";
            this.MYPHAMDataSethoadon.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Chi_Tiet_Hoa_DonBindingSource
            // 
            this.Chi_Tiet_Hoa_DonBindingSource.DataMember = "Chi_Tiet_Hoa_Don";
            this.Chi_Tiet_Hoa_DonBindingSource.DataSource = this.MYPHAMDataSethoadon;
            // 
            // Chi_Tiet_Hoa_DonTableAdapter
            // 
            this.Chi_Tiet_Hoa_DonTableAdapter.ClearBeforeFill = true;
            // 
            // San_PhamBindingSource
            // 
            this.San_PhamBindingSource.DataMember = "San_Pham";
            this.San_PhamBindingSource.DataSource = this.MYPHAMDataSethoadon;
            // 
            // San_PhamTableAdapter
            // 
            this.San_PhamTableAdapter.ClearBeforeFill = true;
            // 
            // Nha_cung_capBindingSource
            // 
            this.Nha_cung_capBindingSource.DataMember = "Nha_cung_cap";
            this.Nha_cung_capBindingSource.DataSource = this.MYPHAMDataSethoadon;
            // 
            // Nha_cung_capTableAdapter
            // 
            this.Nha_cung_capTableAdapter.ClearBeforeFill = true;
            // 
            // Chi_Tiet_Phieu_NhapBindingSource
            // 
            this.Chi_Tiet_Phieu_NhapBindingSource.DataMember = "Chi_Tiet_Phieu_Nhap";
            this.Chi_Tiet_Phieu_NhapBindingSource.DataSource = this.MYPHAMDataSethoadon;
            // 
            // Chi_Tiet_Phieu_NhapTableAdapter
            // 
            this.Chi_Tiet_Phieu_NhapTableAdapter.ClearBeforeFill = true;
            // 
            // FormInPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 525);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormInPhieuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInPhieuNhap";
            this.Load += new System.EventHandler(this.FormInPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MYPHAMDataSethoadon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chi_Tiet_Hoa_DonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.San_PhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nha_cung_capBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chi_Tiet_Phieu_NhapBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Chi_Tiet_Hoa_DonBindingSource;
        private MYPHAMDataSethoadon MYPHAMDataSethoadon;
        private System.Windows.Forms.BindingSource San_PhamBindingSource;
        private System.Windows.Forms.BindingSource Nha_cung_capBindingSource;
        private MYPHAMDataSethoadonTableAdapters.Chi_Tiet_Hoa_DonTableAdapter Chi_Tiet_Hoa_DonTableAdapter;
        private MYPHAMDataSethoadonTableAdapters.San_PhamTableAdapter San_PhamTableAdapter;
        private MYPHAMDataSethoadonTableAdapters.Nha_cung_capTableAdapter Nha_cung_capTableAdapter;
        private System.Windows.Forms.BindingSource Chi_Tiet_Phieu_NhapBindingSource;
        private MYPHAMDataSethoadonTableAdapters.Chi_Tiet_Phieu_NhapTableAdapter Chi_Tiet_Phieu_NhapTableAdapter;
    }
}