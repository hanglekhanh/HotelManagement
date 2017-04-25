using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLKS.BUS;
using QLKS.DTO;
using DevComponents.DotNetBar;


namespace QLKS
{
    public partial class frmTimKhach : Office2007Form
    {
        public frmTimKhach()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            List<Khach> list = new KhachBUS().Find(tbTenKhach.Text);
            gvKhach.DataSource = list;
        }

        private void frmTimKhach_Load(object sender, EventArgs e)
        {
            
        }

        private void tbTenKhach_TextChanged(object sender, EventArgs e)
        {
            if (tbTenKhach.Text != "")
                LoadData();
            else
                gvKhach.DataSource = null;
        }
    }
}
