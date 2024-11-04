using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    /***SSSSSSSSSSSSSSSSOOOOOOOOOOOOOOOOOOSSSSSSSSSSSSSSSS/ ***/



    public class SqlConnectionData
    {
        public static SqlConnection Connect()
        {
            string connectionString = @"Data Source=HA-VY;Initial Catalog=FASTIE;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            return conn;
        }
    }
    public class DatabaseAccess
    {
        public DatabaseAccess() { }

        public DataTable ExecuteQuery(string queryOrProcName, SqlParameter[] parameters = null, bool isStoredProc = false)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = SqlConnectionData.Connect())
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(queryOrProcName, con))
                    {
                        if (isStoredProc)
                        {
                            cmd.CommandType = CommandType.StoredProcedure;  // Nếu là Stored Procedure
                        }
                        else
                        {
                            cmd.CommandType = CommandType.Text;  // Nếu là câu truy vấn thông thường
                        }

                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);  // Thêm các tham số nếu có
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);  // Điền dữ liệu vào DataTable
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error executing query: " + ex.Message);
            }
            return dt;  // Trả về DataTable kết quả
        }
    }
}
