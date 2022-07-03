
namespace Quản_lý_cửa_hàng_mỹ_phẩm
{
    partial class UserControl_hoadon_khachhang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_lapHD = new Guna.UI2.WinForms.Guna2Button();
            this.btn_refresh = new Guna.UI2.WinForms.Guna2Button();
            this.btn_search = new Guna.UI2.WinForms.Guna2Button();
            this.dgv_hoa_don = new Guna.UI2.WinForms.Guna2DataGridView();
            this.mahd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoa_don)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_lapHD
            // 
            this.btn_lapHD.BorderRadius = 10;
            this.btn_lapHD.CheckedState.Parent = this.btn_lapHD;
            this.btn_lapHD.CustomImages.Parent = this.btn_lapHD;
            this.btn_lapHD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_lapHD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_lapHD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_lapHD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_lapHD.DisabledState.Parent = this.btn_lapHD;
            this.btn_lapHD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(153)))));
            this.btn_lapHD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_lapHD.ForeColor = System.Drawing.Color.Black;
            this.btn_lapHD.HoverState.Parent = this.btn_lapHD;
            this.btn_lapHD.Location = new System.Drawing.Point(790, 28);
            this.btn_lapHD.Name = "btn_lapHD";
            this.btn_lapHD.ShadowDecoration.Parent = this.btn_lapHD;
            this.btn_lapHD.Size = new System.Drawing.Size(98, 30);
            this.btn_lapHD.TabIndex = 11;
            this.btn_lapHD.Text = "Lập hóa đơn";
            this.btn_lapHD.Click += new System.EventHandler(this.btn_lapHD_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BorderRadius = 10;
            this.btn_refresh.CheckedState.Parent = this.btn_refresh;
            this.btn_refresh.CustomImages.Parent = this.btn_refresh;
            this.btn_refresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_refresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_refresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_refresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_refresh.DisabledState.Parent = this.btn_refresh;
            this.btn_refresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btn_refresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.HoverState.Parent = this.btn_refresh;
            this.btn_refresh.Location = new System.Drawing.Point(641, 28);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.ShadowDecoration.Parent = this.btn_refresh;
            this.btn_refresh.Size = new System.Drawing.Size(82, 30);
            this.btn_refresh.TabIndex = 10;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_search
            // 
            this.btn_search.BorderRadius = 10;
            this.btn_search.CheckedState.Parent = this.btn_search;
            this.btn_search.CustomImages.Parent = this.btn_search;
            this.btn_search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_search.DisabledState.Parent = this.btn_search;
            this.btn_search.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.HoverState.Parent = this.btn_search;
            this.btn_search.Location = new System.Drawing.Point(535, 28);
            this.btn_search.Name = "btn_search";
            this.btn_search.ShadowDecoration.Parent = this.btn_search;
            this.btn_search.Size = new System.Drawing.Size(82, 30);
            this.btn_search.TabIndex = 9;
            this.btn_search.Text = "Search";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dgv_hoa_don
            // 
            this.dgv_hoa_don.AllowUserToAddRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dgv_hoa_don.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_hoa_don.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_hoa_don.BackgroundColor = System.Drawing.Color.White;
            this.dgv_hoa_don.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_hoa_don.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_hoa_don.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_hoa_don.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_hoa_don.ColumnHeadersHeight = 40;
            this.dgv_hoa_don.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahd,
            this.Column3,
            this.Column1,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_hoa_don.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_hoa_don.EnableHeadersVisualStyles = false;
            this.dgv_hoa_don.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_hoa_don.Location = new System.Drawing.Point(16, 64);
            this.dgv_hoa_don.Name = "dgv_hoa_don";
            this.dgv_hoa_don.ReadOnly = true;
            this.dgv_hoa_don.RowHeadersVisible = false;
            this.dgv_hoa_don.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_hoa_don.Size = new System.Drawing.Size(872, 455);
            this.dgv_hoa_don.TabIndex = 7;
            this.dgv_hoa_don.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_hoa_don.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_hoa_don.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_hoa_don.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_hoa_don.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_hoa_don.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_hoa_don.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_hoa_don.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.dgv_hoa_don.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_hoa_don.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_hoa_don.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_hoa_don.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_hoa_don.ThemeStyle.HeaderStyle.Height = 40;
            this.dgv_hoa_don.ThemeStyle.ReadOnly = true;
            this.dgv_hoa_don.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_hoa_don.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_hoa_don.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_hoa_don.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_hoa_don.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_hoa_don.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_hoa_don.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_hoa_don.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hoa_don_CellContentDoubleClick);
            // 
            // mahd
            // 
            this.mahd.DataPropertyName = "MaHD";
            this.mahd.HeaderText = "Mã hóa đơn";
            this.mahd.Name = "mahd";
            this.mahd.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "HoTenNV";
            this.Column3.HeaderText = "Nhân viên";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TenKH";
            this.Column1.HeaderText = "Khách hàng";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Ngay_lap_HD";
            this.Column4.HeaderText = "Ngày lập";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Tongtien";
            this.Column5.HeaderText = "Tổng tiền";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // txt_search
            // 
            this.txt_search.BorderRadius = 15;
            this.txt_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search.DefaultText = "";
            this.txt_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search.DisabledState.Parent = this.txt_search;
            this.txt_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search.FocusedState.Parent = this.txt_search;
            this.txt_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search.HoverState.Parent = this.txt_search;
            this.txt_search.IconLeft = global::Quản_lý_cửa_hàng_mỹ_phẩm.Properties.Resources.loupe;
            this.txt_search.Location = new System.Drawing.Point(329, 28);
            this.txt_search.Name = "txt_search";
            this.txt_search.PasswordChar = '\0';
            this.txt_search.PlaceholderText = "Enter Text";
            this.txt_search.SelectedText = "";
            this.txt_search.ShadowDecoration.Parent = this.txt_search;
            this.txt_search.Size = new System.Drawing.Size(200, 30);
            this.txt_search.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Khách hàng";
            // 
            // UserControl_hoadon_khachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_lapHD);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.dgv_hoa_don);
            this.Name = "UserControl_hoadon_khachhang";
            this.Size = new System.Drawing.Size(904, 545);
            this.Load += new System.EventHandler(this.UserControl_hoadon_khachhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoa_don)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_lapHD;
        private Guna.UI2.WinForms.Guna2Button btn_refresh;
        private Guna.UI2.WinForms.Guna2Button btn_search;
        private Guna.UI2.WinForms.Guna2TextBox txt_search;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_hoa_don;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
