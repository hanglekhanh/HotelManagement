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
    public partial class frmDSPhong : Office2007Form
    {
        int phongTrong = 15,phongVip = 3;
        private Form _preForm;
        private string _maNV;
        public frmDSPhong()
        {
            InitializeComponent();
        }

        public frmDSPhong(string maNV,Form preForm):this()
        {
            _preForm = preForm;
            _maNV = maNV;
        }

        public  void frmDSPhong_Load(object sender, EventArgs e)
        {
            
            LoadData();
            
        }

        public  void LoadData()
        {
            List<Tam> listTam = new TamBUS().LoadData();
            List<Phong> listPhong = new PhongBUS().LoadData();
            int vip = 0;

            for (int i = 0; i < listPhong.Count; i++ )
            {
                string maPhong = listPhong[i].MaPhong;
                foreach(Control ct in this.Controls)
                {
                    if(ct.Name.Contains(maPhong))
                    {
                        if (Convert.ToInt32(maPhong) % 10 == 5)
                            ct.BackColor = Color.Yellow;
                        else
                            ct.BackColor = Color.White;
                        break;
                    }
                }
            }

            if (listTam != null)
            {
                for (int i = 0; i < listTam.Count; i++)
                {
                    string btname = listTam[i].MaPhong;
                    if (Convert.ToInt32(btname) % 10 == 5)
                        vip++;

                    foreach (Control ct in this.Controls)
                    {
                        if (ct.Name == "bt" + btname)
                        {
                            ct.BackColor = Color.Red;
                            break;
                        }
                    }   
                }
            }
            this.Invalidate();

            lbEmpty.Text = (phongTrong - listTam.Count).ToString();
            lbReserve.Text = listTam.Count.ToString();
            lbVIP.Text = (phongVip - vip).ToString();
           
         }

        private void bt101_Click(object sender, EventArgs e)
        {  
            Button bt = (Button)sender;
            if (bt.BackColor == Color.White || bt.BackColor == Color.Yellow)
            {

                frmDatPhong frm = new frmDatPhong(_maNV);
                frm.UIParent = this;
                frm.maPhong = bt.Text;
                frm.ShowDialog();
            }
            else
            {
                frmDaDat frm = new frmDaDat(bt.Text);
                frm.ShowDialog();
            }
            LoadData();
        }

        private void frmDSPhong_FormClosed(object sender, FormClosedEventArgs e)
        {
            _preForm.Show();
        }

        
    }
}
