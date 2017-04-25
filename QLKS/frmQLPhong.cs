using DevComponents.DotNetBar;
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
namespace QLKS
{
    public partial class frmQLPhong : Office2007Form
    {
        public Form _preForm;
        public frmQLPhong()
        {
            InitializeComponent();
        }
        public frmQLPhong(Form preForm):this()
        {
            _preForm = preForm;
        }
        private void LoadData()
        {
            gV.DataSource = new PhongBUS().LoadData();
        }

        private void frmQLPhong_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void gV_SelectionChanged(object sender, EventArgs e)
        {
            if(gV.CurrentRow!=null)
            {
                tbMaPhong.Text = gV.CurrentRow.Cells["MaPhong"].Value.ToString();
                tbSoGiuong.Text = gV.CurrentRow.Cells["SoGiuong"].Value.ToString();
                tbGiaNgay.Text = gV.CurrentRow.Cells["GiaTien"].Value.ToString();
                if (gV.CurrentRow.Cells["Loai"].Value.ToString() == "Thường")
                    cbLoai.SelectedIndex = 0;
                else cbLoai.SelectedIndex = 1;
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            Phong p = new Phong(tbMaPhong.Text, cbLoai.SelectedItem.ToString(), Convert.ToInt32(tbSoGiuong.Text), Convert.ToDouble(tbGiaNgay.Text));
            new PhongBUS().Update(p);
            LoadData();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            _preForm.Show();
            this.Close();
        }

        private void frmQLPhong_FormClosed(object sender, FormClosedEventArgs e)
        {
            _preForm.Show();
        }
    }
}
