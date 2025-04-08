using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SmartStock.DAL
{
    public class DatabaseHelper
    {

        private readonly string connectionStrings;

        public DatabaseHelper()
        {
            connectionStrings = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
        }

        public DataTable ExecuteSp(string SpName,SqlParameter[] prm=null)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionStrings))
            using(SqlCommand cmd=new SqlCommand(SpName, con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                if (prm != null)
                    cmd.Parameters.AddRange(prm);

                    con.Open();
                    using(SqlDataReader reader=cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                    
            }

            return dt;
        }



        public int NonExecutableSp(string SpName,SqlParameter[] prm = null)
        {
            int rowsAffected = 0;

            using (SqlConnection con = new SqlConnection(connectionStrings))
            using(SqlCommand cmd=new SqlCommand(SpName, con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                if(prm!=null)
                {
                    cmd.Parameters.AddRange(prm);
                }

                con.Open();
                rowsAffected = cmd.ExecuteNonQuery();
            }

            return rowsAffected;
        }




    }
}
