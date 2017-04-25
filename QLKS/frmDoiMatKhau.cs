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
    public partial class frmDoiMatKhau : Office2007Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void DoiMKBT_Click(object sender, EventArgs e)
        {
            if(DevComponents.DotNetBar.MessageBoxEx.Show("Bạn có chắc chắn đổi mật khẩu","Thông Báo",MessageBoxButtons.OKCancel)==DialogResult.OK)
            {
                if (frmLogin.pass == MatKhauOldTB.Text.ToString())
                {
                    if ((MatKhauNewTB.Text.ToString() == MatKhauCfTB.Text.ToString()) && (MatKhauNewTB.Text.ToString() != null))
                    {
                        if (new NhanVienBUS().UpdatePass(frmLogin.user, MatKhauNewTB.Text.ToString()))
                            if(DevComponents.DotNetBar.MessageBoxEx.Show("Cập nhật mật khẩu thành công ", "Thông Báo")==DialogResult.OK)
                             this.Dispose();
                    }
                    else if (MatKhauNewTB.ToString() == null)
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Mật khẩu mới của bạn chưa điền vào :v ", "Thông Báo");
                    }
                    else if (MatKhauNewTB.Text.ToString() != MatKhauCfTB.Text.ToString())
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Mật khẩu xác nhận không đúng ", "Thông Báo");
                    }
                    else
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Cập nhật thất bại", "Thông Báo");
                    }
                }
                else
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("mật khẩu không đúng", "thông báo");
                }
             }
           
        }

        private void CancelBT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
