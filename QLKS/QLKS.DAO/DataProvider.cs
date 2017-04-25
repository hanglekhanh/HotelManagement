using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLKS.DAO
{
    public class DataProvider
    {
        public const string _cnstr = @"Server = .; Database = QLKS; Integrated Security = true";
        private SqlConnection _cn;

        public SqlConnection CN
        {
            get { return _cn; }
            set { _cn = value; }
        }
        public string Get_cnstr()  
        {
            return _cnstr;
        }
        public DataProvider()
        {
            _cn = new SqlConnection(_cnstr);
        }
        
        public void Connect()
        {
            try
            {
                if (_cn != null && _cn.State == ConnectionState.Closed)
                    _cn.Open();
            }
            catch (SqlException ex)
            {
                
                throw ex;
            }
        }

        public void Disconnect()
        {
            try
            {
                if (_cn != null && _cn.State == ConnectionState.Open)
                    _cn.Close();
            }
            catch (SqlException ex)
            {
                
                throw ex;
            }
        }

        public SqlDataReader ExecuteReader(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, _cn);
            return (cmd.ExecuteReader());
        }

        public void ExecuteQuery(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, _cn);
            cmd.ExecuteNonQuery();
        }

        
    }
}
