using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using QLKS.DTO;
using QLKS.BUS;

namespace QLKS
{
    public partial class frmDatPhong : Office2007Form
    {

        public string maPhong;
        private string _maNV;
        public object UIParent
        {
            set;
            get;
        }
        
        public frmDatPhong()
        {
            InitializeComponent();
        }
        
        public frmDatPhong(string maNV):this()
        {
            _maNV = maNV;
        }
        private void frmDatPhong_Load(object sender, EventArgs e)
        {
            frmDSPhong form = new frmDSPhong();
            lbPhong.Text += maPhong;
            DateTime dt = DateTime.Now;
            txtNgayDat.Text = string.Format("{0:dd/MM/yyyy}",dt);
            cbGioiTinh.SelectedIndex = 0;
          
        }

        private void btCancel_Click(object sender, EventArgs e)
        {

            
            this.Close();
        }

        
        private void btOK_Click(object sender, EventArgs e)
        {
            DateTime NgayDat = DateTime.Now;
            DateTime date = DateTime.Parse(txtNgaySinh.Text);
            Khach k = new Khach(txtCMND.Text, txtHoTen.Text, date, cbGioiTinh.SelectedItem.ToString(), txtDiaChi.Text, txtDienThoai.Text);
            new KhachBUS().Insert(k);
            Tam t = new Tam(maPhong, txtCMND.Text, NgayDat, _maNV, Convert.ToInt32(txtSoNguoi.Text));
            new TamBUS().Insert(t);

            this.Close();
            
        }

        
    }
}
