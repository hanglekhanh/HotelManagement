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
    public partial class Workstation : Office2007Form
    {
        public Workstation()
        {
            InitializeComponent();
        }

        private string _maNV;
        Form _loginForm;

        public Workstation(string maNV, Form loginForm):this()
        {
            _maNV = maNV;
            _loginForm = loginForm;
        }
        
        private void Workstation_Load(object sender, EventArgs e)
        {
            lbName.Text += new NhanVienBUS().GetFullName(_maNV);
            if(_maNV != "AD001" && _maNV != "ad001")
            {
                ThongKeBT.Enabled = false;
                QLNVBT.Enabled = false;
                btPhuThu.Enabled = false;
                btQLPhong.Enabled = false;
            }
        }

        

        private void DangXuatBT_Click(object sender, EventArgs e)
        {
            _loginForm.Show();
            Hide();
        }

        private void DSPhongBT_Click(object sender, EventArgs e)
        {
            frmDSPhong frm = new frmDSPhong(_maNV, this);
            frm.Show();
            this.Hide();
        }

        private void QLNVBT_Click(object sender, EventArgs e)
        {
            frmQLNhanVien frm = new frmQLNhanVien(this);
            frm.Show();
            this.Hide();
        }

        private void Workstation_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void DoiMKBT_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau();
            frm.ShowDialog();
        }

        private void TimKhachBT_Click(object sender, EventArgs e)
        {
            frmTimKhach frm = new frmTimKhach();
            frm.ShowDialog();
        }

        private void ThongKeBT_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport(this);
            frm.Show();
            this.Hide();
        }

        private void btQLPhong_Click(object sender, EventArgs e)
        {
            frmQLPhong frm = new frmQLPhong(this);
            frm.Show();
            this.Hide();
        }

        private void btPhuThu_Click(object sender, EventArgs e)
        {
            frmSanPhamPhuThu frm = new frmSanPhamPhuThu(this);
            frm.Show();
            this.Hide();
        }



    }
}
