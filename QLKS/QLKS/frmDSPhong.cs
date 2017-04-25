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
        int phongTrong,phongVip;
        
        public frmDSPhong()
        {
            InitializeComponent();
            phongTrong = 15;
            phongVip = 3;
            
            
        }

        public  void frmDSPhong_Load(object sender, EventArgs e)
        {
            
            LoadData();
            
        }

        public  void LoadData()
        {
            List<Tam> list = new TamBUS().LoadData();
            int vip = 0;
            if (list != null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    string btname = list[i].MaPhong;
                    if (Convert.ToInt32(btname) % 10 == 5)
                        vip++;

                    foreach (Control ct in this.Controls)
                        if (ct.Name == "bt"+btname)
                            ct.BackColor = Color.Red;
                    this.Invalidate();
                }
            }
            lbEmpty.Text = (phongTrong - list.Count).ToString();
            lbReserve.Text = list.Count.ToString();
            lbVIP.Text = (phongVip - vip).ToString();
           
         }

        private void bt101_Click(object sender, EventArgs e)
        {  
            Button bt = (Button)sender;
            if (bt.BackColor == Color.White || bt.BackColor == Color.Yellow)
            {

                frmDatPhong frm = new frmDatPhong();
                frm.UIParent = this;
                frm.maPhong = bt.Text;
                frm.ShowDialog();

            }
            else
            {
            }

        }

        

        
    }
}
