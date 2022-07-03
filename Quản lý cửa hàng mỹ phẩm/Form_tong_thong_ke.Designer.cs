
namespace Quản_lý_cửa_hàng_mỹ_phẩm
{
    partial class Form_tong_thong_ke
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
            this.Hoa_DonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MYPHAMDataSethoadon = new Quản_lý_cửa_hàng_mỹ_phẩm.MYPHAMDataSethoadon();
            this.report_tongthe = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.Hoa_DonTableAdapter = new Quản_lý_cửa_hàng_mỹ_phẩm.MYPHAMDataSethoadonTableAdapters.Hoa_DonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Hoa_DonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MYPHAMDataSethoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // Hoa_DonBindingSource
            // 
            this.Hoa_DonBindingSource.DataMember = "Hoa_Don";
            this.Hoa_DonBindingSource.DataSource = this.MYPHAMDataSethoadon;
            // 
            // MYPHAMDataSethoadon
            // 
            this.MYPHAMDataSethoadon.DataSetName = "MYPHAMDataSethoadon";
            this.MYPHAMDataSethoadon.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // report_tongthe
            // 
            this.report_tongthe.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSethoadon";
            reportDataSource1.Value = this.Hoa_DonBindingSource;
            this.report_tongthe.LocalReport.DataSources.Add(reportDataSource1);
            this.report_tongthe.LocalReport.ReportEmbeddedResource = "Quản_lý_cửa_hàng_mỹ_phẩm.Report_doanh_thu_tong_the.rdlc";
            this.report_tongthe.Location = new System.Drawing.Point(0, 0);
            this.report_tongthe.Name = "report_tongthe";
            this.report_tongthe.ServerReport.BearerToken = null;
            this.report_tongthe.Size = new System.Drawing.Size(884, 556);
            this.report_tongthe.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(824, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 21);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Hoa_DonTableAdapter
            // 
            this.Hoa_DonTableAdapter.ClearBeforeFill = true;
            // 
            // Form_tong_thong_ke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 556);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.report_tongthe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_tong_thong_ke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_tong_thong_ke";
            this.Load += new System.EventHandler(this.Form_tong_thong_ke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Hoa_DonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MYPHAMDataSethoadon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer report_tongthe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource Hoa_DonBindingSource;
        private MYPHAMDataSethoadon MYPHAMDataSethoadon;
        private MYPHAMDataSethoadonTableAdapters.Hoa_DonTableAdapter Hoa_DonTableAdapter;
    }
}