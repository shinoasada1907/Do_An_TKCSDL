
namespace Quản_lý_cửa_hàng_mỹ_phẩm
{
    partial class UserControl_hoi_vien
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_hoivien = new Guna.UI2.WinForms.Guna2DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_loaithe = new System.Windows.Forms.ComboBox();
            this.rbn_nu = new System.Windows.Forms.RadioButton();
            this.rbn_nam = new System.Windows.Forms.RadioButton();
            this.btn_xoa = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_sua = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_them = new Guna.UI2.WinForms.Guna2GradientButton();
            this.date_ngaylap = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.date_ngaysinh = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txt_sdt = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_hoten = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_mahv = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_refresh = new Guna.UI2.WinForms.Guna2Button();
            this.btn_search = new Guna.UI2.WinForms.Guna2Button();
            this.txt_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_the_hoi_vien = new Guna.UI2.WinForms.Guna2Button();
            this.mYPHAMDataSet3 = new Quản_lý_cửa_hàng_mỹ_phẩm.MYPHAMDataSet3();
            this.hoiVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoi_VienTableAdapter = new Quản_lý_cửa_hàng_mỹ_phẩm.MYPHAMDataSet3TableAdapters.Hoi_VienTableAdapter();
            this.mahv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaylap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoivien)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mYPHAMDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoiVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_hoivien
            // 
            this.dgv_hoivien.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgv_hoivien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_hoivien.BackgroundColor = System.Drawing.Color.White;
            this.dgv_hoivien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_hoivien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_hoivien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_hoivien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_hoivien.ColumnHeadersHeight = 40;
            this.dgv_hoivien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahv,
            this.ten,
            this.gioitinh,
            this.ngaysinh,
            this.loai,
            this.ngaylap,
            this.sdt});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_hoivien.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_hoivien.EnableHeadersVisualStyles = false;
            this.dgv_hoivien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_hoivien.Location = new System.Drawing.Point(12, 57);
            this.dgv_hoivien.Name = "dgv_hoivien";
            this.dgv_hoivien.ReadOnly = true;
            this.dgv_hoivien.RowHeadersVisible = false;
            this.dgv_hoivien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_hoivien.Size = new System.Drawing.Size(879, 332);
            this.dgv_hoivien.TabIndex = 0;
            this.dgv_hoivien.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_hoivien.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_hoivien.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_hoivien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_hoivien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_hoivien.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_hoivien.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_hoivien.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.SpringGreen;
            this.dgv_hoivien.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_hoivien.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_hoivien.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.dgv_hoivien.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_hoivien.ThemeStyle.HeaderStyle.Height = 40;
            this.dgv_hoivien.ThemeStyle.ReadOnly = true;
            this.dgv_hoivien.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_hoivien.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_hoivien.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_hoivien.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_hoivien.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_hoivien.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_hoivien.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_hoivien.Click += new System.EventHandler(this.dgv_hoivien_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_loaithe);
            this.groupBox1.Controls.Add(this.rbn_nu);
            this.groupBox1.Controls.Add(this.rbn_nam);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.date_ngaylap);
            this.groupBox1.Controls.Add(this.date_ngaysinh);
            this.groupBox1.Controls.Add(this.txt_sdt);
            this.groupBox1.Controls.Add(this.txt_hoten);
            this.groupBox1.Controls.Add(this.txt_mahv);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 395);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(879, 147);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hội viên";
            // 
            // cmb_loaithe
            // 
            this.cmb_loaithe.FormattingEnabled = true;
            this.cmb_loaithe.Location = new System.Drawing.Point(329, 111);
            this.cmb_loaithe.Name = "cmb_loaithe";
            this.cmb_loaithe.Size = new System.Drawing.Size(161, 25);
            this.cmb_loaithe.TabIndex = 18;
            // 
            // rbn_nu
            // 
            this.rbn_nu.AutoSize = true;
            this.rbn_nu.Location = new System.Drawing.Point(135, 112);
            this.rbn_nu.Name = "rbn_nu";
            this.rbn_nu.Size = new System.Drawing.Size(44, 21);
            this.rbn_nu.TabIndex = 17;
            this.rbn_nu.TabStop = true;
            this.rbn_nu.Text = "Nữ";
            this.rbn_nu.UseVisualStyleBackColor = true;
            // 
            // rbn_nam
            // 
            this.rbn_nam.AutoSize = true;
            this.rbn_nam.Location = new System.Drawing.Point(74, 112);
            this.rbn_nam.Name = "rbn_nam";
            this.rbn_nam.Size = new System.Drawing.Size(55, 21);
            this.rbn_nam.TabIndex = 16;
            this.rbn_nam.TabStop = true;
            this.rbn_nam.Text = "Nam";
            this.rbn_nam.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            this.btn_xoa.BorderRadius = 15;
            this.btn_xoa.CheckedState.Parent = this.btn_xoa;
            this.btn_xoa.CustomImages.Parent = this.btn_xoa;
            this.btn_xoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_xoa.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_xoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_xoa.DisabledState.Parent = this.btn_xoa;
            this.btn_xoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(238)))), ((int)(((byte)(148)))));
            this.btn_xoa.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(16)))), ((int)(((byte)(118)))));
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.White;
            this.btn_xoa.HoverState.Parent = this.btn_xoa;
            this.btn_xoa.Location = new System.Drawing.Point(796, 90);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.ShadowDecoration.Parent = this.btn_xoa;
            this.btn_xoa.Size = new System.Drawing.Size(65, 40);
            this.btn_xoa.TabIndex = 15;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BorderRadius = 15;
            this.btn_sua.CheckedState.Parent = this.btn_sua;
            this.btn_sua.CustomImages.Parent = this.btn_sua;
            this.btn_sua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_sua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_sua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_sua.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_sua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_sua.DisabledState.Parent = this.btn_sua;
            this.btn_sua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(238)))), ((int)(((byte)(148)))));
            this.btn_sua.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(16)))), ((int)(((byte)(118)))));
            this.btn_sua.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.Color.White;
            this.btn_sua.HoverState.Parent = this.btn_sua;
            this.btn_sua.Location = new System.Drawing.Point(692, 90);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.ShadowDecoration.Parent = this.btn_sua;
            this.btn_sua.Size = new System.Drawing.Size(65, 40);
            this.btn_sua.TabIndex = 14;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.BorderRadius = 15;
            this.btn_them.CheckedState.Parent = this.btn_them;
            this.btn_them.CustomImages.Parent = this.btn_them;
            this.btn_them.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_them.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_them.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_them.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_them.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_them.DisabledState.Parent = this.btn_them;
            this.btn_them.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(238)))), ((int)(((byte)(148)))));
            this.btn_them.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(16)))), ((int)(((byte)(118)))));
            this.btn_them.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.White;
            this.btn_them.HoverState.Parent = this.btn_them;
            this.btn_them.Location = new System.Drawing.Point(588, 90);
            this.btn_them.Name = "btn_them";
            this.btn_them.ShadowDecoration.Parent = this.btn_them;
            this.btn_them.Size = new System.Drawing.Size(65, 40);
            this.btn_them.TabIndex = 13;
            this.btn_them.Text = "Thêm";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // date_ngaylap
            // 
            this.date_ngaylap.Checked = true;
            this.date_ngaylap.CheckedState.Parent = this.date_ngaylap;
            this.date_ngaylap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.date_ngaylap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_ngaylap.HoverState.Parent = this.date_ngaylap;
            this.date_ngaylap.Location = new System.Drawing.Point(329, 65);
            this.date_ngaylap.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date_ngaylap.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date_ngaylap.Name = "date_ngaylap";
            this.date_ngaylap.ShadowDecoration.Parent = this.date_ngaylap;
            this.date_ngaylap.Size = new System.Drawing.Size(120, 25);
            this.date_ngaylap.TabIndex = 12;
            this.date_ngaylap.Value = new System.DateTime(2021, 12, 16, 20, 29, 26, 174);
            // 
            // date_ngaysinh
            // 
            this.date_ngaysinh.Checked = true;
            this.date_ngaysinh.CheckedState.Parent = this.date_ngaysinh;
            this.date_ngaysinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.date_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_ngaysinh.HoverState.Parent = this.date_ngaysinh;
            this.date_ngaysinh.Location = new System.Drawing.Point(329, 23);
            this.date_ngaysinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date_ngaysinh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date_ngaysinh.Name = "date_ngaysinh";
            this.date_ngaysinh.ShadowDecoration.Parent = this.date_ngaysinh;
            this.date_ngaysinh.Size = new System.Drawing.Size(120, 25);
            this.date_ngaysinh.TabIndex = 11;
            this.date_ngaysinh.Value = new System.DateTime(2021, 12, 16, 20, 29, 13, 759);
            // 
            // txt_sdt
            // 
            this.txt_sdt.BorderRadius = 10;
            this.txt_sdt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_sdt.DefaultText = "";
            this.txt_sdt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_sdt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_sdt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_sdt.DisabledState.Parent = this.txt_sdt;
            this.txt_sdt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_sdt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_sdt.FocusedState.Parent = this.txt_sdt;
            this.txt_sdt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_sdt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_sdt.HoverState.Parent = this.txt_sdt;
            this.txt_sdt.Location = new System.Drawing.Point(608, 23);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.PasswordChar = '\0';
            this.txt_sdt.PlaceholderText = "Enter Text";
            this.txt_sdt.SelectedText = "";
            this.txt_sdt.ShadowDecoration.Parent = this.txt_sdt;
            this.txt_sdt.Size = new System.Drawing.Size(175, 25);
            this.txt_sdt.TabIndex = 9;
            // 
            // txt_hoten
            // 
            this.txt_hoten.BorderRadius = 10;
            this.txt_hoten.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_hoten.DefaultText = "";
            this.txt_hoten.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_hoten.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_hoten.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_hoten.DisabledState.Parent = this.txt_hoten;
            this.txt_hoten.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_hoten.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_hoten.FocusedState.Parent = this.txt_hoten;
            this.txt_hoten.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_hoten.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_hoten.HoverState.Parent = this.txt_hoten;
            this.txt_hoten.Location = new System.Drawing.Point(74, 65);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.PasswordChar = '\0';
            this.txt_hoten.PlaceholderText = "Enter Text";
            this.txt_hoten.SelectedText = "";
            this.txt_hoten.ShadowDecoration.Parent = this.txt_hoten;
            this.txt_hoten.Size = new System.Drawing.Size(175, 25);
            this.txt_hoten.TabIndex = 8;
            // 
            // txt_mahv
            // 
            this.txt_mahv.BorderRadius = 10;
            this.txt_mahv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_mahv.DefaultText = "";
            this.txt_mahv.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_mahv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_mahv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_mahv.DisabledState.Parent = this.txt_mahv;
            this.txt_mahv.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_mahv.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_mahv.FocusedState.Parent = this.txt_mahv;
            this.txt_mahv.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_mahv.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_mahv.HoverState.Parent = this.txt_mahv;
            this.txt_mahv.Location = new System.Drawing.Point(74, 23);
            this.txt_mahv.Name = "txt_mahv";
            this.txt_mahv.PasswordChar = '\0';
            this.txt_mahv.PlaceholderText = "Enter Text";
            this.txt_mahv.SelectedText = "";
            this.txt_mahv.ShadowDecoration.Parent = this.txt_mahv;
            this.txt_mahv.Size = new System.Drawing.Size(175, 25);
            this.txt_mahv.TabIndex = 7;
            this.txt_mahv.Enter += new System.EventHandler(this.txt_mahv_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(532, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Số điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(269, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Loại thẻ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(269, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày lập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(269, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hội viên";
            // 
            // btn_refresh
            // 
            this.btn_refresh.BorderRadius = 15;
            this.btn_refresh.CheckedState.Parent = this.btn_refresh;
            this.btn_refresh.CustomImages.Parent = this.btn_refresh;
            this.btn_refresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_refresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_refresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_refresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_refresh.DisabledState.Parent = this.btn_refresh;
            this.btn_refresh.FillColor = System.Drawing.Color.LimeGreen;
            this.btn_refresh.FocusedColor = System.Drawing.Color.Transparent;
            this.btn_refresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.HoverState.Parent = this.btn_refresh;
            this.btn_refresh.Location = new System.Drawing.Point(266, 6);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.ShadowDecoration.Parent = this.btn_refresh;
            this.btn_refresh.Size = new System.Drawing.Size(81, 40);
            this.btn_refresh.TabIndex = 2;
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
            this.btn_search.FillColor = System.Drawing.Color.Transparent;
            this.btn_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.HoverState.Parent = this.btn_search;
            this.btn_search.Image = global::Quản_lý_cửa_hàng_mỹ_phẩm.Properties.Resources.loupe;
            this.btn_search.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_search.Location = new System.Drawing.Point(574, 6);
            this.btn_search.Name = "btn_search";
            this.btn_search.ShadowDecoration.Parent = this.btn_search;
            this.btn_search.Size = new System.Drawing.Size(40, 40);
            this.btn_search.TabIndex = 3;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_search.BorderRadius = 10;
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
            this.txt_search.Location = new System.Drawing.Point(368, 15);
            this.txt_search.Name = "txt_search";
            this.txt_search.PasswordChar = '\0';
            this.txt_search.PlaceholderText = "Enter Text";
            this.txt_search.SelectedText = "";
            this.txt_search.ShadowDecoration.Parent = this.txt_search;
            this.txt_search.Size = new System.Drawing.Size(200, 25);
            this.txt_search.TabIndex = 4;
            // 
            // btn_the_hoi_vien
            // 
            this.btn_the_hoi_vien.BorderRadius = 15;
            this.btn_the_hoi_vien.CheckedState.Parent = this.btn_the_hoi_vien;
            this.btn_the_hoi_vien.CustomImages.Parent = this.btn_the_hoi_vien;
            this.btn_the_hoi_vien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_the_hoi_vien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_the_hoi_vien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_the_hoi_vien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_the_hoi_vien.DisabledState.Parent = this.btn_the_hoi_vien;
            this.btn_the_hoi_vien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(238)))), ((int)(((byte)(58)))));
            this.btn_the_hoi_vien.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_the_hoi_vien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_the_hoi_vien.HoverState.FillColor = System.Drawing.Color.LimeGreen;
            this.btn_the_hoi_vien.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_the_hoi_vien.HoverState.Parent = this.btn_the_hoi_vien;
            this.btn_the_hoi_vien.Location = new System.Drawing.Point(21, 6);
            this.btn_the_hoi_vien.Name = "btn_the_hoi_vien";
            this.btn_the_hoi_vien.ShadowDecoration.Parent = this.btn_the_hoi_vien;
            this.btn_the_hoi_vien.Size = new System.Drawing.Size(102, 40);
            this.btn_the_hoi_vien.TabIndex = 5;
            this.btn_the_hoi_vien.Text = "Thẻ hội viên";
            this.btn_the_hoi_vien.Click += new System.EventHandler(this.btn_the_hoi_vien_Click);
            // 
            // mYPHAMDataSet3
            // 
            this.mYPHAMDataSet3.DataSetName = "MYPHAMDataSet3";
            this.mYPHAMDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hoiVienBindingSource
            // 
            this.hoiVienBindingSource.DataMember = "Hoi_Vien";
            this.hoiVienBindingSource.DataSource = this.mYPHAMDataSet3;
            // 
            // hoi_VienTableAdapter
            // 
            this.hoi_VienTableAdapter.ClearBeforeFill = true;
            // 
            // mahv
            // 
            this.mahv.DataPropertyName = "MaHV";
            this.mahv.HeaderText = "Mã hội viên";
            this.mahv.Name = "mahv";
            this.mahv.ReadOnly = true;
            this.mahv.Width = 76;
            // 
            // ten
            // 
            this.ten.DataPropertyName = "TenHV";
            this.ten.HeaderText = "Họ tên";
            this.ten.Name = "ten";
            this.ten.ReadOnly = true;
            this.ten.Width = 175;
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "GioiTinhHV";
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.ReadOnly = true;
            this.gioitinh.Width = 126;
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "NgaysinhHV";
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.ReadOnly = true;
            this.ngaysinh.Width = 125;
            // 
            // loai
            // 
            this.loai.DataPropertyName = "Loai_The";
            this.loai.HeaderText = "Loại thẻ";
            this.loai.Name = "loai";
            this.loai.ReadOnly = true;
            this.loai.Width = 126;
            // 
            // ngaylap
            // 
            this.ngaylap.DataPropertyName = "Ngay_lap_The";
            this.ngaylap.HeaderText = "Ngày lập";
            this.ngaylap.Name = "ngaylap";
            this.ngaylap.ReadOnly = true;
            this.ngaylap.Width = 125;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "SDT_HV";
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            this.sdt.Width = 126;
            // 
            // UserControl_hoi_vien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.btn_the_hoi_vien);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_hoivien);
            this.Name = "UserControl_hoi_vien";
            this.Size = new System.Drawing.Size(904, 545);
            this.Load += new System.EventHandler(this.UserControl_hoi_vien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoivien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mYPHAMDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoiVienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgv_hoivien;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Button btn_refresh;
        private Guna.UI2.WinForms.Guna2Button btn_search;
        private Guna.UI2.WinForms.Guna2TextBox txt_search;
        private System.Windows.Forms.RadioButton rbn_nu;
        private System.Windows.Forms.RadioButton rbn_nam;
        private Guna.UI2.WinForms.Guna2GradientButton btn_xoa;
        private Guna.UI2.WinForms.Guna2GradientButton btn_sua;
        private Guna.UI2.WinForms.Guna2GradientButton btn_them;
        private Guna.UI2.WinForms.Guna2DateTimePicker date_ngaylap;
        private Guna.UI2.WinForms.Guna2DateTimePicker date_ngaysinh;
        private Guna.UI2.WinForms.Guna2TextBox txt_sdt;
        private Guna.UI2.WinForms.Guna2TextBox txt_hoten;
        private Guna.UI2.WinForms.Guna2TextBox txt_mahv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_the_hoi_vien;
        private System.Windows.Forms.ComboBox cmb_loaithe;
        private MYPHAMDataSet3 mYPHAMDataSet3;
        private System.Windows.Forms.BindingSource hoiVienBindingSource;
        private MYPHAMDataSet3TableAdapters.Hoi_VienTableAdapter hoi_VienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylap;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
    }
}
