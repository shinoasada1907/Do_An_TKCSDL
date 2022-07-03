
namespace Quản_lý_cửa_hàng_mỹ_phẩm
{
    partial class Form_Theo_san_pham_thong_ke
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.MYPHAMDataSethoadon = new Quản_lý_cửa_hàng_mỹ_phẩm.MYPHAMDataSethoadon();
            this.San_PhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.San_PhamTableAdapter = new Quản_lý_cửa_hàng_mỹ_phẩm.MYPHAMDataSethoadonTableAdapters.San_PhamTableAdapter();
            this.Chi_Tiet_Hoa_DonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Chi_Tiet_Hoa_DonTableAdapter = new Quản_lý_cửa_hàng_mỹ_phẩm.MYPHAMDataSethoadonTableAdapters.Chi_Tiet_Hoa_DonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.MYPHAMDataSethoadon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.San_PhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chi_Tiet_Hoa_DonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetsanpham";
            reportDataSource1.Value = this.San_PhamBindingSource;
            reportDataSource2.Name = "DataSetchitiethoadon";
            reportDataSource2.Value = this.Chi_Tiet_Hoa_DonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Quản_lý_cửa_hàng_mỹ_phẩm.Report_doanh_thu_theoSP.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(868, 575);
            this.reportViewer1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(803, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MYPHAMDataSethoadon
            // 
            this.MYPHAMDataSethoadon.DataSetName = "MYPHAMDataSethoadon";
            this.MYPHAMDataSethoadon.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // Chi_Tiet_Hoa_DonBindingSource
            // 
            this.Chi_Tiet_Hoa_DonBindingSource.DataMember = "Chi_Tiet_Hoa_Don";
            this.Chi_Tiet_Hoa_DonBindingSource.DataSource = this.MYPHAMDataSethoadon;
            // 
            // Chi_Tiet_Hoa_DonTableAdapter
            // 
            this.Chi_Tiet_Hoa_DonTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Theo_san_pham_thong_ke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 575);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Theo_san_pham_thong_ke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Theo_san_pham_thong_ke";
            this.Load += new System.EventHandler(this.Form_Theo_san_pham_thong_ke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MYPHAMDataSethoadon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.San_PhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chi_Tiet_Hoa_DonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource San_PhamBindingSource;
        private MYPHAMDataSethoadon MYPHAMDataSethoadon;
        private System.Windows.Forms.BindingSource Chi_Tiet_Hoa_DonBindingSource;
        private MYPHAMDataSethoadonTableAdapters.San_PhamTableAdapter San_PhamTableAdapter;
        private MYPHAMDataSethoadonTableAdapters.Chi_Tiet_Hoa_DonTableAdapter Chi_Tiet_Hoa_DonTableAdapter;
    }
}