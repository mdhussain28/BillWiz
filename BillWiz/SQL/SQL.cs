using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BillWiz.SQL
{
    internal class SQL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["BillWiz"].ConnectionString;
        SqlConnection con = new SqlConnection(myconnstrng);

        #region Select Method
        public DataTable GetDataTable(string sql)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(sql, con);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                    con.Close();
            return dt;
        }
        
        public DataTable GetDataTable(string query, string parameterName, object parameterValue)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue(parameterName, parameterValue);

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                    con.Close();
            return dt;
        }
        #endregion

        #region Insert Query
        public void SetDataTable(string sql)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            int exr = cmd.ExecuteNonQuery();
            con.Close();
        }
        #endregion
    }
}
