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
    public partial class frmTinhTien : Office2007Form
    {
        private string _maPhong;
        public double totalday;
        public double tongtienphong = 0;
        string user = frmLogin.user.ToString();
        public double tongtien =0;
        
        public frmTinhTien()
        {
            InitializeComponent();
        }

        public frmTinhTien(string maPhong):this()
        {
            _maPhong = maPhong;
        }

        private void Form_TinhTien_Load(object sender, EventArgs e)
        {
            lbMaPhong.Text = _maPhong;
            LoadData();
        }

        private void ADDBT_Click(object sender, EventArgs e)
        {
            double DonGiaSP = new SanPhamPhuThuBUS().GetDonGia(SPPhuThu.SelectedItem.ToString());
            string[] row = new string[] { SPPhuThu.SelectedItem.ToString(), DonGiaSP.ToString("#,##0"), SLTB.Text.ToString(), (DonGiaSP * Convert.ToDouble(SLTB.Text)).ToString("#,##0") };
            ListSP.Rows.Add(row);
            LoadData();

            

        }

        private void btIn_Click(object sender, EventArgs e)
        {
            int i = 0;
            DateTime ngayDat = new TamBUS().GetDate(_maPhong);
            int songuoi = new TamBUS().GetSoNguoi(_maPhong);
            LichSuThuePhong ls = new LichSuThuePhong(_maPhong, LBCMND.Text, ngayDat, DateTime.Now, user,songuoi , Convert.ToDouble(tongtienphong), CapNhatTongDonGiaSP(),tongtien);
            new LichSuThuePhongBUS().Insert(ls);
            new TamBUS().Delete(_maPhong);
            frmTraTien frmtratien = new frmTraTien(tongtien);
            frmtratien.ShowDialog();
            while (i < Convert.ToInt32(ListSP.Rows.Count))
              {
                  string masp = new SanPhamPhuThuBUS().getcode(ListSP.Rows[i].Cells[0].Value.ToString());
                  LichSuBanSP ls1 = new LichSuBanSP(masp, DateTime.Now, ListSP.Rows[i].Cells[0].Value.ToString(), Convert.ToInt32(ListSP.Rows[i].Cells[2].Value),Convert.ToDouble(ListSP.Rows[i].Cells[1].Value),Convert.ToDouble(ListSP.Rows[i].Cells[3].Value));
                  new LichSuBanSPBUS().Insert(ls1);
                  i++;
             
              }
            // string masp = new SanPhamPhuThuBUS().getcode(SPPhuThu.SelectedItem.ToString());
         //   LichSuBanSP ls1 = new LichSuBanSP(masp,DateTime.Now,SPPhuThu.SelectedItem.ToString())
            this.Close();
        }
        public void LoadData()//tongtienphong = số ngày * đơn giá phòng
        {

            tongtienphong = 0;
            List<string> sp = new SanPhamPhuThuBUS().GetName();
            SPPhuThu.DataSource = sp;
            
            DateTime dt = DateTime.Now;
            LBNgayTra.Text = string.Format("{0:dd/MM/yyyy}", dt);
            string CMND = new TamBUS().GetCMND(_maPhong);
            LBCMND.Text = CMND;
            LBHoTen.Text = new KhachBUS().GetFullName(CMND);
            DateTime d = new TamBUS().GetDate(_maPhong);

            LBNgayDat.Text = string.Format("{0:dd/MM/yyyy}", d);
            TimeSpan t = DateTime.Now.Date - d.Date;
            totalday = t.TotalDays;
            if (totalday == 0)
                totalday = 1;
            LBSoNgay.Text = totalday.ToString();
            double gia = new PhongBUS().GetGiaNgay(_maPhong);
            tongtienphong = Convert.ToDouble(totalday) * gia;
            LBTongTien.Text = (tongtienphong + CapNhatTongDonGiaSP()).ToString("#,##0") + " VND";// Tổng tiền sản phẩm + tiền ngày ở đây nè !! 
            tongtien = tongtienphong + CapNhatTongDonGiaSP();

        }
        private double DonGiaCuoiCung()// hàm lấy đơn giá dòng cuối cùng 
        {
            int rowCount = Convert.ToInt32(ListSP.Rows.Count) - 2;
            string GiaSP = "0";
            GiaSP = ListSP.Rows[rowCount].Cells["TongCong"].Value.ToString();
            return Convert.ToInt32(GiaSP);

        }
        private double CapNhatTongDonGiaSP()// hàm này để lấy ra tổng tiền sản phẩm 
        {

            int rowCount = Convert.ToInt32(ListSP.Rows.Count);
            double tong = 0;

            string GiaSP = "0";
            for (int i = 0; i < rowCount; i++)
            {
                GiaSP = ListSP.Rows[i].Cells["TongCong"].Value.ToString();
                tong += Convert.ToDouble(GiaSP);

            }
            return tong;


        }
        private void BTXoa_Click(object sender, EventArgs e)
        {
            if (ListSP.Rows.Count != 0)
            {
                ListSP.Rows.Remove(ListSP.SelectedRows[0]);
                LoadData();
            }
        }

        private void frmTinhTien_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
        public double GetTongTien()
        {
            return tongtien;
        }

    }
}
