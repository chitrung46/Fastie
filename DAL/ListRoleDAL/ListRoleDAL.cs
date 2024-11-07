using DTO;
using DTO.ListRoleDTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ListRoleDAL
{
    public class ListRoleDAL
    {
        public static class SqlConnectionData
        {
            private static readonly string connectionString = @"Data Source=ANH-QUAN;Initial Catalog=FASTIE;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            public static SqlConnection Connect()
            {
                return new SqlConnection(connectionString);
            }
        }
        public static List<ListRole> LayDanhSachQuyen()
        {
            SqlConnection conn = SqlConnectionData.Connect();
            List<ListRole> listRoleList = new List<ListRole>();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("proc_layDanhSachTenQuyen", conn);
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ListRole listRole = new ListRole
                    {
                        Id = reader["id"].ToString(),
                        TenQuyen = reader["ten"].ToString(),
                        IdQuyenCha = reader["idQuyenCha"].ToString()
                    };

                    listRoleList.Add(listRole);
                }
                return listRoleList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
