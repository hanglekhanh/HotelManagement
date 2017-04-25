using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows;
using DevComponents.DotNetBar;
using QLKS.DTO;
using QLKS.BUS;

namespace QLKS
{
    public partial class frmLogin : Office2007Form
    {

        public static string user = "";
        public static string pass = "";
        public frmLogin()
        {
            InitializeComponent();
         
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            UserNametb.Text = "";
            PassTB.Text = "";
        }
        private void InfoBt_Click(object sender, EventArgs e)
        {
            frmInfo form = new frmInfo();
            form.ShowDialog();
        }
      
        public void LoginBT_Click(object sender, EventArgs e)
        {
            user = UserNametb.Text.ToString();
            pass = PassTB.Text.ToString();
            if (new NhanVienBUS().LoginChecking(UserNametb.Text.ToString(), PassTB.Text.ToString()))
            {
                Workstation form = new Workstation(this);
                form.Show();
                this.Hide();
            }
            else
            {
                frmLogin_Load(sender,e);
            }
        }

        private void ExitBT_Click(object sender, EventArgs e)
        {
            MessageBoxEx.EnableGlass = false;
            if (DevComponents.DotNetBar.MessageBoxEx.Show("Bạn có muón thoát", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
               
                Application.Exit();
            }
        }

        private void FrmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                LoginBT_Click(sender, e);
            }
        }

        

    }
}
