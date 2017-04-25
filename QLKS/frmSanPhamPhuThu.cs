using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using QLKS.BUS;
using QLKS.DTO;

namespace QLKS
{
    public partial class frmSanPhamPhuThu : Form
    {
        public Form _preForm;
        public frmSanPhamPhuThu()
        {
            InitializeComponent();
        }
        public frmSanPhamPhuThu(Form preForm):this()
        {
            _preForm = preForm;
        }

        public void LoadData()
        {
            gV.DataSource = new SanPhamPhuThuBUS().LoadData();
        }
        private void frmSanPhamPhuThu_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void gV_SelectionChanged(object sender, EventArgs e)
        {
            if(gV.CurrentRow != null)
            {
                tbMaSP.Text = gV.CurrentRow.Cells["MaSP"].Value.ToString();
                tbTenSP.Text = gV.CurrentRow.Cells["TenSP"].Value.ToString();
                tbDonViTinh.Text = gV.CurrentRow.Cells["DonViTinh"].Value.ToString();
                tbDonGia.Text = gV.CurrentRow.Cells["DonGia"].Value.ToString();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            SanPhamPhuThu sp = new SanPhamPhuThu(tbMaSP.Text, tbTenSP.Text, tbDonViTinh.Text, Convert.ToDouble(tbDonGia.Text));
            new SanPhamPhuThuBUS().Insert(sp);
            LoadData();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            SanPhamPhuThu sp = new SanPhamPhuThu(tbMaSP.Text, tbTenSP.Text, tbDonViTinh.Text, Convert.ToDouble(tbDonGia.Text));
            new SanPhamPhuThuBUS().Update(sp);
            LoadData();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            new SanPhamPhuThuBUS().Delete(tbMaSP.Text);
            LoadData();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            _preForm.Show();
        }

        private void frmSanPhamPhuThu_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }
    }
}
