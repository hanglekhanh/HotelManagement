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
    public partial class frmTraTien : Office2007Form
    {

        public double tongtien = 0;
        public frmTraTien(double _tongtien)
        {
            InitializeComponent();
            tongtien = _tongtien;
        }

        private void frmTraTien_Load(object sender, EventArgs e)
        {

            TBTongTien.Text = tongtien.ToString("#,##0") + " VND" ;
            
        }

        private void TBTienKhach_TextChanged(object sender, EventArgs e)
        {

           
           
        }

        private void TBTienKhach_KeyPress(object sender, KeyPressEventArgs e)
        {
            int i = e.KeyChar;
            if (char.IsNumber(e.KeyChar) || (Char.IsControl(e.KeyChar) && TBTienKhach.Text!=""))
            {
                
            }
            else
            {
                MessageBox.Show("Chỉ nhập số");
                e.Handled = true;
           
            }
        }

        private void BTOK_Click(object sender, EventArgs e)
        {
            if (TBTienKhach.Text != "0" || TBTienKhach.Text != null)
            {
                if (Convert.ToDouble(TBTienKhach.Text) >= tongtien)
                {
                    MessageBox.Show("Số tiền phải thối lại là : " + (Convert.ToDouble(TBTienKhach.Text) - tongtien).ToString("#,##0") + " VND");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Số tiền khách đưa không đủ ");
                }
            }
            

        }
    }
}
