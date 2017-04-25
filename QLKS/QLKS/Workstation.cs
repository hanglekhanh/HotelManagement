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

        private Form _preForm;
        public Workstation(Form preForm):this()
        {
            _preForm = preForm;
        }
        
        private void Workstation_Load(object sender, EventArgs e)
        {
            //ThongKeBT.Enabled = false;
            //QLNVBT.Enabled = false;
            //Class1 k = new Class1();
            //NameLB.Text = k.getid();
            //if (k.getid() == "admin")
            //{
            //    ThongKeBT.Enabled = true;
            //    QLNVBT.Enabled = true;
            //}
            frmLogin frm = (frmLogin)_preForm;
            NameLB.Text = new NhanVienBUS().GetFullName(frm.UserNametb.Text);
            string left = frm.UserNametb.Text.ToString().Substring(0, 2);
            if (left == "AD")
            {
                ThongKeBT.Enabled = true;
                QLNVBT.Enabled = true;
            }
            else
            {
                ThongKeBT.Enabled = false;
                QLNVBT.Enabled = false;
            }
        }

        

        private void DangXuatBT_Click(object sender, EventArgs e)
        {
            MessageBoxEx.EnableGlass = false;
            if (DevComponents.DotNetBar.MessageBoxEx.Show("Bạn có muốn quay lại nơi đăng nhập", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                frmLogin frm = new frmLogin();
                frm.Show();
            }
            this.Close();

            
           
        }

        private void DSPhongBT_Click(object sender, EventArgs e)
        {
            frmDSPhong frm = new frmDSPhong();
            frm.Show();
            this.Hide();
        }

        private void Workstation_FormClosed(object sender, FormClosedEventArgs e)
        {
          
          

        }

        private void DoiMKBT_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau();
            frm.Show();
        }
    }
}
