
namespace Quản_lý_cửa_hàng_mỹ_phẩm
{
    partial class UserControl_Quan_Ly_Tai_Khoan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_taikhoan = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_chucvu = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_quyen = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_manv = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_matkhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_taikhoan = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tennv = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_taotk = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_xoatk = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_suatk = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txt_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_search = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_refresh = new Guna.UI2.WinForms.Guna2Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_taikhoan)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(904, 54);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Tài Khoản";
            // 
            // dgv_taikhoan
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_taikhoan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_taikhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_taikhoan.BackgroundColor = System.Drawing.Color.White;
            this.dgv_taikhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_taikhoan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_taikhoan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_taikhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_taikhoan.ColumnHeadersHeight = 40;
            this.dgv_taikhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_taikhoan.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_taikhoan.EnableHeadersVisualStyles = false;
            this.dgv_taikhoan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_taikhoan.Location = new System.Drawing.Point(59, 229);
            this.dgv_taikhoan.Name = "dgv_taikhoan";
            this.dgv_taikhoan.ReadOnly = true;
            this.dgv_taikhoan.RowHeadersVisible = false;
            this.dgv_taikhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_taikhoan.Size = new System.Drawing.Size(782, 328);
            this.dgv_taikhoan.TabIndex = 3;
            this.dgv_taikhoan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_taikhoan.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_taikhoan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_taikhoan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_taikhoan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_taikhoan.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_taikhoan.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_taikhoan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Lime;
            this.dgv_taikhoan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_taikhoan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_taikhoan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dgv_taikhoan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_taikhoan.ThemeStyle.HeaderStyle.Height = 40;
            this.dgv_taikhoan.ThemeStyle.ReadOnly = true;
            this.dgv_taikhoan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_taikhoan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_taikhoan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_taikhoan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_taikhoan.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_taikhoan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_taikhoan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_taikhoan.Click += new System.EventHandler(this.dgv_taikhoan_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "username";
            this.Column1.HeaderText = "Tên tài khoản";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "passwords";
            this.Column2.HeaderText = "Mật khẩu";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TenQuyen";
            this.Column3.HeaderText = "Quyền hạn";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "HoTenNV";
            this.Column4.HeaderText = "Người sở hữu";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Chucvu";
            this.Column5.HeaderText = "Chức vụ";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_chucvu);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmb_quyen);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmb_manv);
            this.panel1.Controls.Add(this.txt_matkhau);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_taikhoan);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_tennv);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 163);
            this.panel1.TabIndex = 4;
            // 
            // txt_chucvu
            // 
            this.txt_chucvu.BorderRadius = 10;
            this.txt_chucvu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_chucvu.DefaultText = "";
            this.txt_chucvu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_chucvu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_chucvu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_chucvu.DisabledState.Parent = this.txt_chucvu;
            this.txt_chucvu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_chucvu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_chucvu.FocusedState.Parent = this.txt_chucvu;
            this.txt_chucvu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_chucvu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_chucvu.HoverState.Parent = this.txt_chucvu;
            this.txt_chucvu.Location = new System.Drawing.Point(348, 107);
            this.txt_chucvu.Name = "txt_chucvu";
            this.txt_chucvu.PasswordChar = '\0';
            this.txt_chucvu.PlaceholderText = "Enter Text";
            this.txt_chucvu.SelectedText = "";
            this.txt_chucvu.ShadowDecoration.Parent = this.txt_chucvu;
            this.txt_chucvu.Size = new System.Drawing.Size(150, 25);
            this.txt_chucvu.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(269, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Chức vụ";
            // 
            // cmb_quyen
            // 
            this.cmb_quyen.AutoRoundedCorners = true;
            this.cmb_quyen.BackColor = System.Drawing.Color.Transparent;
            this.cmb_quyen.BorderRadius = 17;
            this.cmb_quyen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_quyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_quyen.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_quyen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_quyen.FocusedState.Parent = this.cmb_quyen;
            this.cmb_quyen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_quyen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_quyen.HoverState.Parent = this.cmb_quyen;
            this.cmb_quyen.ItemHeight = 30;
            this.cmb_quyen.ItemsAppearance.Parent = this.cmb_quyen;
            this.cmb_quyen.Location = new System.Drawing.Point(92, 107);
            this.cmb_quyen.Name = "cmb_quyen";
            this.cmb_quyen.ShadowDecoration.Parent = this.cmb_quyen;
            this.cmb_quyen.Size = new System.Drawing.Size(150, 36);
            this.cmb_quyen.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Quyên hạn";
            // 
            // cmb_manv
            // 
            this.cmb_manv.AutoRoundedCorners = true;
            this.cmb_manv.BackColor = System.Drawing.Color.Transparent;
            this.cmb_manv.BorderRadius = 17;
            this.cmb_manv.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_manv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_manv.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_manv.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_manv.FocusedState.Parent = this.cmb_manv;
            this.cmb_manv.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_manv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_manv.HoverState.Parent = this.cmb_manv;
            this.cmb_manv.ItemHeight = 30;
            this.cmb_manv.ItemsAppearance.Parent = this.cmb_manv;
            this.cmb_manv.Location = new System.Drawing.Point(92, 5);
            this.cmb_manv.Name = "cmb_manv";
            this.cmb_manv.ShadowDecoration.Parent = this.cmb_manv;
            this.cmb_manv.Size = new System.Drawing.Size(150, 36);
            this.cmb_manv.TabIndex = 8;
            this.cmb_manv.SelectionChangeCommitted += new System.EventHandler(this.cmb_manv_SelectionChangeCommitted);
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.BorderRadius = 10;
            this.txt_matkhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_matkhau.DefaultText = "";
            this.txt_matkhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_matkhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_matkhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_matkhau.DisabledState.Parent = this.txt_matkhau;
            this.txt_matkhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_matkhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_matkhau.FocusedState.Parent = this.txt_matkhau;
            this.txt_matkhau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_matkhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_matkhau.HoverState.Parent = this.txt_matkhau;
            this.txt_matkhau.Location = new System.Drawing.Point(348, 63);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.PasswordChar = '\0';
            this.txt_matkhau.PlaceholderText = "Enter Text";
            this.txt_matkhau.SelectedText = "";
            this.txt_matkhau.ShadowDecoration.Parent = this.txt_matkhau;
            this.txt_matkhau.Size = new System.Drawing.Size(150, 25);
            this.txt_matkhau.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(261, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mật khẩu";
            // 
            // txt_taikhoan
            // 
            this.txt_taikhoan.BorderRadius = 10;
            this.txt_taikhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_taikhoan.DefaultText = "";
            this.txt_taikhoan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_taikhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_taikhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_taikhoan.DisabledState.Parent = this.txt_taikhoan;
            this.txt_taikhoan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_taikhoan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_taikhoan.FocusedState.Parent = this.txt_taikhoan;
            this.txt_taikhoan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_taikhoan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_taikhoan.HoverState.Parent = this.txt_taikhoan;
            this.txt_taikhoan.Location = new System.Drawing.Point(92, 63);
            this.txt_taikhoan.Name = "txt_taikhoan";
            this.txt_taikhoan.PasswordChar = '\0';
            this.txt_taikhoan.PlaceholderText = "Enter Text";
            this.txt_taikhoan.SelectedText = "";
            this.txt_taikhoan.ShadowDecoration.Parent = this.txt_taikhoan;
            this.txt_taikhoan.Size = new System.Drawing.Size(150, 25);
            this.txt_taikhoan.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên tài khoản";
            // 
            // txt_tennv
            // 
            this.txt_tennv.BorderRadius = 10;
            this.txt_tennv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tennv.DefaultText = "";
            this.txt_tennv.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_tennv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_tennv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tennv.DisabledState.Parent = this.txt_tennv;
            this.txt_tennv.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tennv.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tennv.FocusedState.Parent = this.txt_tennv;
            this.txt_tennv.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_tennv.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tennv.HoverState.Parent = this.txt_tennv;
            this.txt_tennv.Location = new System.Drawing.Point(348, 10);
            this.txt_tennv.Name = "txt_tennv";
            this.txt_tennv.PasswordChar = '\0';
            this.txt_tennv.PlaceholderText = "Enter Text";
            this.txt_tennv.SelectedText = "";
            this.txt_tennv.ShadowDecoration.Parent = this.txt_tennv;
            this.txt_tennv.Size = new System.Drawing.Size(150, 25);
            this.txt_tennv.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(261, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã nhân viên";
            // 
            // btn_taotk
            // 
            this.btn_taotk.BorderRadius = 15;
            this.btn_taotk.CheckedState.Parent = this.btn_taotk;
            this.btn_taotk.CustomImages.Parent = this.btn_taotk;
            this.btn_taotk.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_taotk.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_taotk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_taotk.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_taotk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_taotk.DisabledState.Parent = this.btn_taotk;
            this.btn_taotk.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_taotk.ForeColor = System.Drawing.Color.White;
            this.btn_taotk.HoverState.Parent = this.btn_taotk;
            this.btn_taotk.Location = new System.Drawing.Point(540, 75);
            this.btn_taotk.Name = "btn_taotk";
            this.btn_taotk.ShadowDecoration.Parent = this.btn_taotk;
            this.btn_taotk.Size = new System.Drawing.Size(85, 40);
            this.btn_taotk.TabIndex = 5;
            this.btn_taotk.Text = "Thêm";
            this.btn_taotk.Click += new System.EventHandler(this.btn_taotk_Click);
            // 
            // btn_xoatk
            // 
            this.btn_xoatk.BorderRadius = 15;
            this.btn_xoatk.CheckedState.Parent = this.btn_xoatk;
            this.btn_xoatk.CustomImages.Parent = this.btn_xoatk;
            this.btn_xoatk.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoatk.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoatk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_xoatk.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_xoatk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_xoatk.DisabledState.Parent = this.btn_xoatk;
            this.btn_xoatk.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoatk.ForeColor = System.Drawing.Color.White;
            this.btn_xoatk.HoverState.Parent = this.btn_xoatk;
            this.btn_xoatk.Location = new System.Drawing.Point(670, 75);
            this.btn_xoatk.Name = "btn_xoatk";
            this.btn_xoatk.ShadowDecoration.Parent = this.btn_xoatk;
            this.btn_xoatk.Size = new System.Drawing.Size(85, 40);
            this.btn_xoatk.TabIndex = 6;
            this.btn_xoatk.Text = "Xóa";
            this.btn_xoatk.Click += new System.EventHandler(this.btn_xoatk_Click);
            // 
            // btn_suatk
            // 
            this.btn_suatk.BorderRadius = 15;
            this.btn_suatk.CheckedState.Parent = this.btn_suatk;
            this.btn_suatk.CustomImages.Parent = this.btn_suatk;
            this.btn_suatk.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_suatk.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_suatk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_suatk.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_suatk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_suatk.DisabledState.Parent = this.btn_suatk;
            this.btn_suatk.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suatk.ForeColor = System.Drawing.Color.White;
            this.btn_suatk.HoverState.Parent = this.btn_suatk;
            this.btn_suatk.Location = new System.Drawing.Point(800, 75);
            this.btn_suatk.Name = "btn_suatk";
            this.btn_suatk.ShadowDecoration.Parent = this.btn_suatk;
            this.btn_suatk.Size = new System.Drawing.Size(85, 40);
            this.btn_suatk.TabIndex = 7;
            this.btn_suatk.Text = "Sửa";
            this.btn_suatk.Click += new System.EventHandler(this.btn_suatk_Click);
            // 
            // txt_search
            // 
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
            this.txt_search.Location = new System.Drawing.Point(543, 143);
            this.txt_search.Name = "txt_search";
            this.txt_search.PasswordChar = '\0';
            this.txt_search.PlaceholderText = "Enter Text";
            this.txt_search.SelectedText = "";
            this.txt_search.ShadowDecoration.Parent = this.txt_search;
            this.txt_search.Size = new System.Drawing.Size(200, 30);
            this.txt_search.TabIndex = 8;
            // 
            // btn_search
            // 
            this.btn_search.BorderRadius = 15;
            this.btn_search.CheckedState.Parent = this.btn_search;
            this.btn_search.CustomImages.Parent = this.btn_search;
            this.btn_search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_search.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_search.DisabledState.Parent = this.btn_search;
            this.btn_search.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.HoverState.Parent = this.btn_search;
            this.btn_search.Location = new System.Drawing.Point(756, 137);
            this.btn_search.Name = "btn_search";
            this.btn_search.ShadowDecoration.Parent = this.btn_search;
            this.btn_search.Size = new System.Drawing.Size(85, 40);
            this.btn_search.TabIndex = 9;
            this.btn_search.Text = "Search";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
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
            this.btn_refresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_refresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.HoverState.Parent = this.btn_refresh;
            this.btn_refresh.Image = global::Quản_lý_cửa_hàng_mỹ_phẩm.Properties.Resources.refresh;
            this.btn_refresh.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_refresh.Location = new System.Drawing.Point(540, 177);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.ShadowDecoration.Parent = this.btn_refresh;
            this.btn_refresh.Size = new System.Drawing.Size(40, 40);
            this.btn_refresh.TabIndex = 10;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // UserControl_Quan_Ly_Tai_Khoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_suatk);
            this.Controls.Add(this.btn_xoatk);
            this.Controls.Add(this.btn_taotk);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_taikhoan);
            this.Controls.Add(this.panel2);
            this.Name = "UserControl_Quan_Ly_Tai_Khoan";
            this.Size = new System.Drawing.Size(904, 599);
            this.Load += new System.EventHandler(this.UserControl_Quan_Ly_Tai_Khoan_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_taikhoan)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_taikhoan;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txt_chucvu;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_quyen;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_manv;
        private Guna.UI2.WinForms.Guna2TextBox txt_matkhau;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txt_taikhoan;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txt_tennv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2GradientButton btn_taotk;
        private Guna.UI2.WinForms.Guna2GradientButton btn_xoatk;
        private Guna.UI2.WinForms.Guna2GradientButton btn_suatk;
        private Guna.UI2.WinForms.Guna2TextBox txt_search;
        private Guna.UI2.WinForms.Guna2GradientButton btn_search;
        private Guna.UI2.WinForms.Guna2Button btn_refresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
