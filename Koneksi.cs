using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjectUAS
{
    internal class Koneksi
    {
        public SqlConnection GetConn()
        {
            SqlConnection Conn = new SqlConnection();
            // LAPTOP-1ASVQ1I3, LAPTOP-NI44V5SR
            Conn.ConnectionString = "Data Source = LAPTOP-1ASVQ1I3\\SQLEXPRESS; initial catalog=DB_Library; integrated security=true ";
            return Conn;
        }
    }
}
