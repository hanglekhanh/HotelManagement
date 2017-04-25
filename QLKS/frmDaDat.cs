using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using QLKS.BUS;
using QLKS.DTO;


namespace QLKS
{
    public partial class frmDaDat : Office2007Form
    {
        private string _maPhong;
        public frmDaDat()
        {	
            InitializeComponent();
        }
        public frmDaDat(string maPhong):this()
        {
            _maPhong = maPhong;
            lbMaPhong.Text = _maPhong;
        }

        public void LoadData()
        {
            Tam t = new TamBUS().RoomInfo(_maPhong);
            lbMaPhong.Text = t.MaPhong;
            lbCMND.Text = t.CMND;
            lbHoTen.Text = new KhachBUS().GetFullName(t.CMND);
            DateTime dt = t.NgayDat;
            lbNgayDat.Text = string.Format("{0:dd/MM/yyyy}", dt);
            lbSoNguoi.Text = t.SoNguoi.ToString();
        }

        private void Form_DaDat_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        #region Button
        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btTraPhong_Click(object sender, EventArgs e)
        {
            frmTinhTien frm = new frmTinhTien(_maPhong);
            frm.ShowDialog();
            Close();
        }

        private void btHuyPhong_Click(object sender, EventArgs e)
        {
            Form_XacNhanAd frm = new Form_XacNhanAd(_maPhong);
            frm.ShowDialog();
            Close();
        }
        #endregion

    }
}
