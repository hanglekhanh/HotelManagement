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
        
        public string maPhong,maNV;
        public object UIParent
        {
            set;
            get;
        }
        
        public frmDatPhong()
        {
            InitializeComponent();
            maNV = "NV001";
           

        }
        
        private void frmDatPhong_Load(object sender, EventArgs e)
        {
            frmDSPhong form = new frmDSPhong();
            lbPhong.Text += maPhong;
            DateTime dt = DateTime.Now;
            txtNgayDat.Text = string.Format("{0:d/M/yyyy}",dt);
            cbGioiTinh.SelectedIndex = 0;
          
        }

        private void btCancel_Click(object sender, EventArgs e)
        {

            
            this.Close();
        }

        
        private void btOK_Click(object sender, EventArgs e)
        {
            DateTime NgayDat = DateTime.Now;
            DateTime NgaySinh = Convert.ToDateTime(txtNgaySinh.Text);
            Tam t = new Tam(maPhong, txtCMND.Text.ToString(), NgayDat, "NV001" , Convert.ToInt32(txtSoNguoi.Text));
            new TamBUS().Insert(t);
            Khach k = new Khach(txtCMND.Text, txtHoTen.Text, NgaySinh, cbGioiTinh.SelectedItem.ToString(), txtDiaChi.Text, txtDienThoai.Text);
            new KhachBUS().Insert(k);
            MessageBox.Show("Đặt Phòng Thành Công!");
            if (UIParent is frmDSPhong)
            {
                frmDSPhong frm = UIParent as frmDSPhong;
                frm.LoadData();
            }
            this.Close();
            
        }

        
    }
}
