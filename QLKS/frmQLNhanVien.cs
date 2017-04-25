using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLKS.BUS;
using QLKS.DTO;
using System.Globalization;
using DevComponents.DotNetBar;

namespace QLKS
{
    public partial class frmQLNhanVien : Office2007Form
    {
        public Form _preForm;
        public frmQLNhanVien()
        {
            InitializeComponent();
        }

        public frmQLNhanVien(Form preForm):this()
        {
            _preForm = preForm;
        }
        public void LoadData()
        {
            List<NhanVien> list = new NhanVienBUS().LoadData();
            gV.DataSource = list;
        }

        private void frmQLNhanVien_Load(object sender, EventArgs e)
        {
            cbGioiTinh.SelectedIndex = 0;
            LoadData();
            
        }

        private void gV_SelectionChanged(object sender, EventArgs e)
        {
            if(gV.CurrentRow!=null)
            {
                tbMaNV.Text = gV.CurrentRow.Cells["MaNV"].Value.ToString();
                tbHo.Text = gV.CurrentRow.Cells["Ho"].Value.ToString();
                tbTen.Text = gV.CurrentRow.Cells["Ten"].Value.ToString();
                tbNgaySinh.Text = string.Format("{0:dd/MM/yyyy}",gV.CurrentRow.Cells["NgaySinh"].Value);
                cbGioiTinh.SelectedValue = gV.CurrentRow.Cells["GioiTinh"].Value.ToString();
                tbDienThoai.Text = gV.CurrentRow.Cells["DienThoai"].Value.ToString();
                tbDiaChi.Text = gV.CurrentRow.Cells["DiaChi"].Value.ToString();             
                tbChucVu.Text = gV.CurrentRow.Cells["ChucVu"].Value.ToString();
                tbMatKhau.Text = gV.CurrentRow.Cells["MatKhau"].Value.ToString();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.ParseExact(tbNgaySinh.Text, new string[] { "dd/MM/yyyy" }, CultureInfo.CurrentCulture, DateTimeStyles.AllowWhiteSpaces);
            string date2 = string.Format("{0: MM/dd/yyyy}", date);
            NhanVien nv = new NhanVien(tbMaNV.Text, tbHo.Text, tbTen.Text, Convert.ToDateTime(date2), cbGioiTinh.SelectedItem.ToString(), tbDienThoai.Text, tbDiaChi.Text, tbChucVu.Text, tbMatKhau.Text);
            new NhanVienBUS().Insert(nv);
            LoadData();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            new NhanVienBUS().Delete(tbMaNV.Text);
            LoadData();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.ParseExact(tbNgaySinh.Text, new string[] { "dd/MM/yyyy" }, CultureInfo.CurrentCulture, DateTimeStyles.AllowWhiteSpaces);
            string date2 = string.Format("{0: MM/dd/yyyy}", date);
            NhanVien nv = new NhanVien(tbMaNV.Text, tbHo.Text, tbTen.Text, Convert.ToDateTime(date2), cbGioiTinh.SelectedItem.ToString(), tbDienThoai.Text, tbDiaChi.Text, tbChucVu.Text, tbMatKhau.Text);
            new NhanVienBUS().Update(nv);
            LoadData();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmQLNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            _preForm.Show();
        }
    }
}
