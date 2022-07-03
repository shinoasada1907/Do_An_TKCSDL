
namespace Quản_lý_cửa_hàng_mỹ_phẩm
{
    partial class Form_them_moi_KH
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_thoat = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_diachi = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_sdt = new Guna.UI2.WinForms.Guna2TextBox();
            this.date_ngaysinh = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.rbn_nu = new System.Windows.Forms.RadioButton();
            this.rbn_nam = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_hoten = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_makh = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_themkh = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.panel1.Controls.Add(this.btn_thoat);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 48);
            this.panel1.TabIndex = 2;
            // 
            // btn_thoat
            // 
            this.btn_thoat.BorderRadius = 20;
            this.btn_thoat.CheckedState.Parent = this.btn_thoat;
            this.btn_thoat.CustomImages.Parent = this.btn_thoat;
            this.btn_thoat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_thoat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_thoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_thoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_thoat.DisabledState.Parent = this.btn_thoat;
            this.btn_thoat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_thoat.ForeColor = System.Drawing.Color.White;
            this.btn_thoat.HoverState.Parent = this.btn_thoat;
            this.btn_thoat.Image = global::Quản_lý_cửa_hàng_mỹ_phẩm.Properties.Resources.cancel_button;
            this.btn_thoat.Location = new System.Drawing.Point(216, 5);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.ShadowDecoration.Parent = this.btn_thoat;
            this.btn_thoat.Size = new System.Drawing.Size(40, 40);
            this.btn_thoat.TabIndex = 1;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm khách hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_diachi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_sdt);
            this.groupBox1.Controls.Add(this.date_ngaysinh);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rbn_nu);
            this.groupBox1.Controls.Add(this.rbn_nam);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_hoten);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_makh);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 306);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Địa chỉ";
            // 
            // txt_diachi
            // 
            this.txt_diachi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_diachi.DefaultText = "";
            this.txt_diachi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_diachi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_diachi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_diachi.DisabledState.Parent = this.txt_diachi;
            this.txt_diachi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_diachi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_diachi.FocusedState.Parent = this.txt_diachi;
            this.txt_diachi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_diachi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_diachi.HoverState.Parent = this.txt_diachi;
            this.txt_diachi.Location = new System.Drawing.Point(73, 267);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.PasswordChar = '\0';
            this.txt_diachi.PlaceholderText = "Enter Text";
            this.txt_diachi.SelectedText = "";
            this.txt_diachi.ShadowDecoration.Parent = this.txt_diachi;
            this.txt_diachi.Size = new System.Drawing.Size(157, 25);
            this.txt_diachi.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Số điện thoại";
            // 
            // txt_sdt
            // 
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
            this.txt_sdt.Location = new System.Drawing.Point(91, 216);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.PasswordChar = '\0';
            this.txt_sdt.PlaceholderText = "Enter Text";
            this.txt_sdt.SelectedText = "";
            this.txt_sdt.ShadowDecoration.Parent = this.txt_sdt;
            this.txt_sdt.Size = new System.Drawing.Size(139, 25);
            this.txt_sdt.TabIndex = 11;
            this.txt_sdt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_sdt_KeyDown);
            // 
            // date_ngaysinh
            // 
            this.date_ngaysinh.Checked = true;
            this.date_ngaysinh.CheckedState.Parent = this.date_ngaysinh;
            this.date_ngaysinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.date_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_ngaysinh.HoverState.Parent = this.date_ngaysinh;
            this.date_ngaysinh.Location = new System.Drawing.Point(73, 166);
            this.date_ngaysinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date_ngaysinh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date_ngaysinh.Name = "date_ngaysinh";
            this.date_ngaysinh.ShadowDecoration.Parent = this.date_ngaysinh;
            this.date_ngaysinh.Size = new System.Drawing.Size(157, 25);
            this.date_ngaysinh.TabIndex = 10;
            this.date_ngaysinh.Value = new System.DateTime(2021, 12, 15, 22, 1, 8, 471);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ngày sinh";
            // 
            // rbn_nu
            // 
            this.rbn_nu.AutoSize = true;
            this.rbn_nu.Location = new System.Drawing.Point(149, 130);
            this.rbn_nu.Name = "rbn_nu";
            this.rbn_nu.Size = new System.Drawing.Size(41, 19);
            this.rbn_nu.TabIndex = 7;
            this.rbn_nu.TabStop = true;
            this.rbn_nu.Text = "Nữ";
            this.rbn_nu.UseVisualStyleBackColor = true;
            // 
            // rbn_nam
            // 
            this.rbn_nam.AutoSize = true;
            this.rbn_nam.Location = new System.Drawing.Point(78, 128);
            this.rbn_nam.Name = "rbn_nam";
            this.rbn_nam.Size = new System.Drawing.Size(52, 19);
            this.rbn_nam.TabIndex = 6;
            this.rbn_nam.TabStop = true;
            this.rbn_nam.Text = "Nam";
            this.rbn_nam.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Họ tên";
            // 
            // txt_hoten
            // 
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
            this.txt_hoten.Location = new System.Drawing.Point(73, 78);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.PasswordChar = '\0';
            this.txt_hoten.PlaceholderText = "Enter Text";
            this.txt_hoten.SelectedText = "";
            this.txt_hoten.ShadowDecoration.Parent = this.txt_hoten;
            this.txt_hoten.Size = new System.Drawing.Size(157, 25);
            this.txt_hoten.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Mã khách";
            // 
            // txt_makh
            // 
            this.txt_makh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_makh.DefaultText = "";
            this.txt_makh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_makh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_makh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_makh.DisabledState.Parent = this.txt_makh;
            this.txt_makh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_makh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_makh.FocusedState.Parent = this.txt_makh;
            this.txt_makh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_makh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_makh.HoverState.Parent = this.txt_makh;
            this.txt_makh.Location = new System.Drawing.Point(73, 28);
            this.txt_makh.Name = "txt_makh";
            this.txt_makh.PasswordChar = '\0';
            this.txt_makh.PlaceholderText = "Enter Text";
            this.txt_makh.SelectedText = "";
            this.txt_makh.ShadowDecoration.Parent = this.txt_makh;
            this.txt_makh.Size = new System.Drawing.Size(157, 25);
            this.txt_makh.TabIndex = 0;
            this.txt_makh.Enter += new System.EventHandler(this.txt_makh_Enter);
            // 
            // btn_themkh
            // 
            this.btn_themkh.BorderRadius = 10;
            this.btn_themkh.CheckedState.Parent = this.btn_themkh;
            this.btn_themkh.CustomImages.Parent = this.btn_themkh;
            this.btn_themkh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_themkh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_themkh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_themkh.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_themkh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_themkh.DisabledState.Parent = this.btn_themkh;
            this.btn_themkh.FillColor = System.Drawing.Color.DarkTurquoise;
            this.btn_themkh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_themkh.ForeColor = System.Drawing.Color.White;
            this.btn_themkh.HoverState.Parent = this.btn_themkh;
            this.btn_themkh.Location = new System.Drawing.Point(69, 366);
            this.btn_themkh.Name = "btn_themkh";
            this.btn_themkh.ShadowDecoration.Parent = this.btn_themkh;
            this.btn_themkh.Size = new System.Drawing.Size(133, 40);
            this.btn_themkh.TabIndex = 5;
            this.btn_themkh.Text = "Thêm khách hàng";
            this.btn_themkh.Click += new System.EventHandler(this.btn_themkh_Click);
            // 
            // Form_them_moi_KH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 415);
            this.Controls.Add(this.btn_themkh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_them_moi_KH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_them_moi_KH";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btn_thoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txt_diachi;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txt_sdt;
        private Guna.UI2.WinForms.Guna2DateTimePicker date_ngaysinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbn_nu;
        private System.Windows.Forms.RadioButton rbn_nam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txt_hoten;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txt_makh;
        private Guna.UI2.WinForms.Guna2GradientButton btn_themkh;
    }
}