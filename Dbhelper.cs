using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thorat_Hospital
{
    class Dbhelper
    {

        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();

        public Dbhelper()
        {


            con.ConnectionString = @"Data Source=.\MSSQLSERVER20;Initial Catalog=Thorat_Hospital;User ID=sa;Password=Sql123";
            con.Open();
            cmd.Connection = con;
        }


        public void Doadd(string sql)
        {
            try
            {
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }

        }


        public DataSet GetDataset(string sql)
        {
            cmd.CommandText = sql;
            DataSet ds = new DataSet();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ad.Fill(ds);
            return ds;
        }

        public SqlDataReader GetDataReader(string sql)
        {
            cmd.CommandText = sql;
            SqlDataReader rd = cmd.ExecuteReader();
            return rd;
        }

        public void Closeconnection()
        {
            con.Close();
        }
    }
}
