using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_Quan_Ly;
using DTO_Quan_ly;

namespace Quản_lý_cửa_hàng_mỹ_phẩm
{
    public partial class UserControl_Quan_Ly_Phieu_Nhap : UserControl
    {
        string _hotennv;
        decimal _tongtien = 0;
        BUS_phieu_nhap_hang phieunhap = new BUS_phieu_nhap_hang();
        BUS_Nha_cung_cap NCC = new BUS_Nha_cung_cap();
        BUS_Nhan_vien nhanvien = new BUS_Nhan_vien();
        
        public string Hotennv
        {
            get
            {
                return _hotennv;
            }
            set
            {
                _hotennv = value;
            }
        }
        public decimal Tongtien
        {
            get
            {
                return _tongtien;
            }
            set
            {
                _tongtien = value;
            }
        }
        public UserControl_Quan_Ly_Phieu_Nhap()
        {
            InitializeComponent();
        }

        private void btn_them_san_pham_Click(object sender, EventArgs e)
        {
            if (txt_maphieu.Text != "" && txt_manv.Text != "" && date_ngalap.Text != "" && txt_tennv.Text != "" && cmb_ncc.Text != "")
            {
                string maphieu = txt_maphieu.Text;
                string manv = txt_manv.Text;
                string mancc = NCC.get_MaNCC(cmb_ncc.Text);
                DateTime ngaylap = date_ngalap.Value;
                decimal tongtien = this.Tongtien;
                DTO_Phieu_Nhap PHN = new DTO_Phieu_Nhap(maphieu, manv, mancc, ngaylap, tongtien);
                if (phieunhap.insert_PhieuNhap(PHN))
                {
                    MessageBox.Show("Thêm thành công");
                    dgv_phieu_nhap.DataSource = phieunhap.get_AllPhieuNhap();
                    Form_chi_tiet_phieu_nhap fctpn = new Form_chi_tiet_phieu_nhap();
                    fctpn.Tenncc = cmb_ncc.Text;
                    fctpn.maphieunhap = txt_maphieu.Text;
                    fctpn.ShowDialog();
                    resettext();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin điền đầy đủ thôn tin cần thêm");
            }
        }

        private void dgv_phieu_nhap_DoubleClick(object sender, EventArgs e)
        {
            Form_thong_tin_phieu_nhap fttpn = new Form_thong_tin_phieu_nhap();
            fttpn.maphieu = dgv_phieu_nhap.SelectedRows[0].Cells[0].Value.ToString();
            fttpn.ShowDialog();
        }

        private void UserControl_Quan_Ly_Phieu_Nhap_Load(object sender, EventArgs e)
        {
            dgv_phieu_nhap.DataSource = phieunhap.get_AllPhieuNhap();
            cmb_ncc.DataSource = NCC.get_AllTenNCC();
            cmb_ncc.ValueMember = "TenNCC";
            cmb_ncc.DisplayMember = "MaNCC";
            resettext();
        }

        private void resettext()
        {
            phieunhap.get_AllPhieuNhap();
            txt_manv.ResetText();
            txt_maphieu.ResetText();
            date_ngalap.ResetText();
            txt_search.ResetText();
            txt_tennv.ResetText();
            cmb_ncc.ResetText();
        }

        private void txt_maphieu_Enter(object sender, EventArgs e)
        {
            resettext();
            string sopcuoi = dgv_phieu_nhap.Rows[dgv_phieu_nhap.Rows.Count - 1].Cells[0].Value.ToString();
            string sopmoi = (Convert.ToInt32(sopcuoi.Substring(2)) + 1).ToString();
            if (Convert.ToInt32(sopmoi) <= 9) txt_maphieu.Text = "PN0" + sopmoi;
            else txt_maphieu.Text = "PN" + sopmoi;
            date_ngalap.Value = DateTime.Today;
            txt_tennv.Text = this.Hotennv;
            txt_manv.Text = nhanvien.search_nameNhanVien(this.Hotennv).Rows[0].Field<string>(0);
        }

        private void dgv_phieu_nhap_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgv_phieu_nhap.SelectedRows[0];
            txt_maphieu.Text = row.Cells[0].Value.ToString();
            cmb_ncc.Text = row.Cells[1].Value.ToString();
            txt_manv.Text = row.Cells[2].Value.ToString();
            txt_tennv.Text = row.Cells[3].Value.ToString();
            date_ngalap.Value = Convert.ToDateTime(row.Cells[4].Value.ToString());
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            cmb_ncc.DataSource = NCC.get_AllTenNCC();
            cmb_ncc.ValueMember = "TenNCC";
            cmb_ncc.DisplayMember = "MaNCC";
            dgv_phieu_nhap.DataSource = phieunhap.get_AllPhieuNhap();
            resettext();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if(cmb_ncc.Text != "")
            {
                dgv_phieu_nhap.DataSource = phieunhap.get_PhieuNhap_NCC(cmb_ncc.Text);
                resettext();
            }    
            if(txt_search.Text != "")
            {
                dgv_phieu_nhap.DataSource = phieunhap.get_PhieuNhap(txt_search.Text);
                resettext();
            }    
        }

        private void btn_suaphieu_Click(object sender, EventArgs e)
        {
            if (dgv_phieu_nhap.SelectedRows.Count > 0)
            {
                if (txt_maphieu.Text != "" && txt_manv.Text != "" && date_ngalap.Text != "" && txt_tennv.Text != "" && cmb_ncc.Text != "")
                {
                    string maphieu = txt_maphieu.Text;
                    string manv = txt_manv.Text;
                    string mancc = NCC.get_MaNCC(cmb_ncc.Text);
                    DateTime ngaylap = date_ngalap.Value;
                    decimal tongtien = this.Tongtien;
                    DTO_Phieu_Nhap PHN = new DTO_Phieu_Nhap(maphieu, manv, mancc, ngaylap, tongtien);
                    if (phieunhap.update_PhieuNhap(PHN))
                    {
                        MessageBox.Show("Sửa thành công");
                        dgv_phieu_nhap.DataSource = phieunhap.get_AllPhieuNhap();
                        resettext();
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Xin điền đầy đủ thôn tin cần sửa");
                }
            }
            else
            {
                MessageBox.Show("Xin chọn hóa đơn cần sửa");
            }
        }
    }
}
