using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class SqlConnectionData
    {
        private static readonly string connectionString = @"Data Source=DESKTOP-G1KLLU0;Initial Catalog=FASTIE;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public static SqlConnection Connect()
        {
            return new SqlConnection(connectionString);
        }
    }
    public class DatabaseAccess
    {
        public DatabaseAccess() { }

    }
}
