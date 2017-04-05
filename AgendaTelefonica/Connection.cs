using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AgendaTelefonica.Properties;

namespace AgendaTelefonica
{
    class Connection
    {
        private static string getDatabaseConnectionString()
        {
            string db = AgendaTelefonica.Properties.Settings.Default.AgendaTelefonicaConnectionString;
            return db;
        }
        public static SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection(getDatabaseConnectionString());
            con.Open();
            return con;
        }
    }
}
