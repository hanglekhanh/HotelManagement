using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class frmDaDat : Form
    {
        public string _maPhong;
        public frmDaDat()
        {
	
            InitializeComponent();
        }
        public frmDaDat(string maPhong):this()
        {
            _maPhong = maPhong;
            lbMaPhong.Text = _maPhong;
        }

        private void Form_DaDat_Load(object sender, EventArgs e)
        {

        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btTraPhong_Click(object sender, EventArgs e)
        {
            frmTinhTien frm = new frmTinhTien(_maPhong);
            frm.ShowDialog();
        }

        private void btHuyPhong_Click(object sender, EventArgs e)
        {
            Form_XacNhanAd frm = new Form_XacNhanAd();
            frm.ShowDialog();
        }

              
    }
}
