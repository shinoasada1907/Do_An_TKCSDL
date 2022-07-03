
namespace Quản_lý_cửa_hàng_mỹ_phẩm
{
    partial class Form_thong_tin_voucher
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_mavoucher = new System.Windows.Forms.TextBox();
            this.txt_tenvoucher = new System.Windows.Forms.TextBox();
            this.txt_tiengiam = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(282, 51);
            this.panel1.TabIndex = 1;
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_thoat.BorderRadius = 15;
            this.btn_thoat.CheckedState.Parent = this.btn_thoat;
            this.btn_thoat.CustomImages.Parent = this.btn_thoat;
            this.btn_thoat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_thoat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_thoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_thoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_thoat.DisabledState.Parent = this.btn_thoat;
            this.btn_thoat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btn_thoat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_thoat.ForeColor = System.Drawing.Color.White;
            this.btn_thoat.HoverState.Parent = this.btn_thoat;
            this.btn_thoat.Image = global::Quản_lý_cửa_hàng_mỹ_phẩm.Properties.Resources.cancel_button;
            this.btn_thoat.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_thoat.Location = new System.Drawing.Point(240, 9);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.ShadowDecoration.Parent = this.btn_thoat;
            this.btn_thoat.Size = new System.Drawing.Size(30, 30);
            this.btn_thoat.TabIndex = 1;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin voucher";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tiền giảm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tên voucher";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mã voucher";
            // 
            // txt_mavoucher
            // 
            this.txt_mavoucher.Location = new System.Drawing.Point(98, 57);
            this.txt_mavoucher.Name = "txt_mavoucher";
            this.txt_mavoucher.ReadOnly = true;
            this.txt_mavoucher.Size = new System.Drawing.Size(169, 20);
            this.txt_mavoucher.TabIndex = 14;
            // 
            // txt_tenvoucher
            // 
            this.txt_tenvoucher.Location = new System.Drawing.Point(98, 87);
            this.txt_tenvoucher.Name = "txt_tenvoucher";
            this.txt_tenvoucher.ReadOnly = true;
            this.txt_tenvoucher.Size = new System.Drawing.Size(169, 20);
            this.txt_tenvoucher.TabIndex = 15;
            // 
            // txt_tiengiam
            // 
            this.txt_tiengiam.Location = new System.Drawing.Point(98, 119);
            this.txt_tiengiam.Name = "txt_tiengiam";
            this.txt_tiengiam.ReadOnly = true;
            this.txt_tiengiam.Size = new System.Drawing.Size(169, 20);
            this.txt_tiengiam.TabIndex = 16;
            // 
            // Form_thong_tin_voucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 159);
            this.Controls.Add(this.txt_tiengiam);
            this.Controls.Add(this.txt_tenvoucher);
            this.Controls.Add(this.txt_mavoucher);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_thong_tin_voucher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_thong_tin_voucher";
            this.Load += new System.EventHandler(this.Form_thong_tin_voucher_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btn_thoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_mavoucher;
        private System.Windows.Forms.TextBox txt_tenvoucher;
        private System.Windows.Forms.TextBox txt_tiengiam;
    }
}