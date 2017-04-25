using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKS.BUS;
using QLKS.DTO;
using DevComponents.DotNetBar;
namespace QLKS
{
    public partial class Form_XacNhanAd : Office2007Form
    {
        private string _maPhong;
        public Form_XacNhanAd()
        {
            InitializeComponent();
        }

        public Form_XacNhanAd(string maPhong):this()
        {
            _maPhong = maPhong;
        }

        private void Form_XacNhanAd_Load(object sender, EventArgs e)
        {

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if(new NhanVienBUS().IsAdmin(tbUserName.Text,tbPass.Text))
            {
                new TamBUS().CancelRoom(_maPhong);
                this.Close();
            }
            else
            {
                tbUserName.Clear();
                tbPass.Clear();
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                btLogin_Click(sender, e);
        }
    }
}
