using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adp
{
    class clsDb
    {
        public static SqlConnection connectDb()
        {
            string strConn = @"Data Source=LILNEX\SQLEXPRESS;Initial Catalog=lilnx;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strConn);
            return conn;
            
        }

        public static void Ajouter(string nom)
        {
            string strcmd = "INSERT INTO stagiaire VALUES ('" + nom + "')";
            SqlCommand cmd = new SqlCommand(strcmd);
            SqlConnection conn = connectDb();
            cmd.Connection = conn;

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
           
        }


    }
}
