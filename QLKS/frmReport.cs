using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using DevComponents.DotNetBar;

namespace QLKS
{
    public partial class frmReport : Office2007Form
    {
        public Form _preForm;
        public const string _cnstr = @"Server = .; Database = QLKS; Integrated Security = true";
        private SqlConnection _cn; 
        private DataSet _ds;
        private SqlDataAdapter _da;
        private SqlCommandBuilder _cb;

        public frmReport()
        {
            InitializeComponent();
        }

        public frmReport(Form preForm):this()
        {
            _preForm = preForm;
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.LichSuThuePhong' table. You can move, or remove it, as needed. 
            dateTimeInput4.Value = DateTime.Today;
            dateTimeInput3.Value = DateTime.Today;
            dateTimeInput2.Value = DateTime.Today;
            dateTimeInput1.Value = DateTime.Today;
        }
        private DataSet GetDataSet(string sql)
        {
            try
            {
                _cn = new SqlConnection(_cnstr);
                _da = new SqlDataAdapter(sql, _cn);
                _cb = new SqlCommandBuilder();
                _ds = new DataSet();
                _da.Fill(_ds);
                return _ds;
            }
            catch (SqlException ex)
            {
                
                throw ex;
            }
           
        }
        private void dateTimeInput2_Click(object sender, EventArgs e)
        {

        }

        private void labelX3_Click(object sender, EventArgs e)
        {

        }

        private void btIn_Click(object sender, EventArgs e)
        {
           
        }

        private void dateTimeInput2_Click_1(object sender, EventArgs e)
        {

        }


        private void frmReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            _preForm.Show();
        }

        private void btIn_Click_1(object sender, EventArgs e)
        {
            string Date1 = dateTimeInput1.Value.ToString("yyyy-MM-dd") + " 00:00:00";
            string Date2 = dateTimeInput2.Value.ToString("yyyy-MM-dd") + " 23:59:59";
            string sql = "Select ls.*, k.HoTen From LichSuThuePhong ls, Khach k Where k.CMND = ls.CMND and NgayTra >= '" + Date1 + "' and NgayTra <='" + Date2 + "'";
            DataSet ds = GetDataSet(sql);
            ReportDataSource rds = new ReportDataSource("dsRptLSThuePhong", ds.Tables[0]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.ReportPath = @"..\QLKS\rptLSThuePhong.rdlc";
            reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }

        private void btIn2_Click(object sender, EventArgs e)
        {
            string Date1 = dateTimeInput3.Value.ToString("yyyy-MM-dd") + " 00:00:00";
            string Date2 = dateTimeInput4.Value.ToString("yyyy-MM-dd") + " 23:59:59";
            string sql = "Select * From LichSuBanSP Where NgayBan >= '"+Date1+"' and NgayBan <= '"+Date2+"'";
            DataSet ds = GetDataSet(sql);
            ReportDataSource rds = new ReportDataSource("dsRptLSBanSP", ds.Tables[0]);
            reportViewer2.LocalReport.DataSources.Clear();
            reportViewer2.LocalReport.DataSources.Add(rds);
            reportViewer2.LocalReport.ReportPath = @"..\QLKS\rptLSBanSP.rdlc";
            reportViewer2.LocalReport.Refresh();
            this.reportViewer2.RefreshReport();
        }

        private void dateTimeInput2_ValueChanged_1(object sender, EventArgs e)
        {
            if (dateTimeInput2.Value > DateTime.Today)
                dateTimeInput2.Value = DateTime.Today;
            else if (dateTimeInput2.Value < dateTimeInput1.Value)
                dateTimeInput1.Value = dateTimeInput2.Value;
        }

        private void dateTimeInput1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimeInput1.Value > dateTimeInput2.Value)
                dateTimeInput1.Value = dateTimeInput2.Value;
        }

        private void dateTimeInput3_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimeInput3.Value > dateTimeInput4.Value)
                dateTimeInput3.Value = dateTimeInput4.Value;
        }

        private void dateTimeInput4_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimeInput4.Value > DateTime.Today)
                dateTimeInput4.Value = DateTime.Today;
            else if (dateTimeInput4.Value < dateTimeInput3.Value)
                dateTimeInput3.Value = dateTimeInput4.Value;
        }
    }
}
