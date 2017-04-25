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
    public partial class frmTinhTien : Form
    {
        public string _maPhong;
        public frmTinhTien()
        {
            InitializeComponent();
        }

        public frmTinhTien(string maPhong):this()
        {
            _maPhong = maPhong;
            lbMaPhong.Text = maPhong;
        }

        private void Form_TinhTien_Load(object sender, EventArgs e)
        {

        }
    }
}
