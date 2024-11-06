using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DepartmentDAL
{
    public class DepartmentDAL : DatabaseAccess
    {
        //Them Bo Phan
        public static void InsertDepartment(Department deparment)
        {
            string query = "proc_insertDepartment";
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                SqlCommand command = new SqlCommand(query, con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ten", deparment.Ten);
                command.Parameters.AddWithValue("@moTa", deparment.MoTa);
                con.Open();
                command.ExecuteNonQuery();
            }
        }

        //Sua Bo Phan
        public static void UpdateDepartment(Department deparment)
        {
            string query = "proc_updateDepartment";
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                SqlCommand command = new SqlCommand(query, con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", deparment.Id);
                command.Parameters.AddWithValue("@ten", deparment.Ten);
                command.Parameters.AddWithValue("@moTa", deparment.MoTa);
                con.Open();
                command.ExecuteNonQuery();
            }
        }

        //Show Toan Bo Bo Phan
        public static List<Department> GetDepartmentList()
        {
            List<Department> list = new List<Department>();
            string query = "proc_getDepartmentList";
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new Department
                        {
                            Id = reader["id"].ToString(),
                            Ten = reader["ten"].ToString(),
                            MoTa = reader["moTa"].ToString()
                        });
                    }
                }
            }
            return list;
        }

        //Xoa Bo Phan
        public static void DeleteDepartment(string departmentId)
        {
            string query = "proc_deleteDepartment";
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                SqlCommand command = new SqlCommand(query, con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", departmentId);
                con.Open();
                command.ExecuteNonQuery();
            }
        }
        public static List<AcceptTaskPersonnel> LayQuanLiBoPhan(string idBoPhan)
        {
            List<AcceptTaskPersonnel> managers = new List<AcceptTaskPersonnel>();
            string query = "proc_LayQuanLiBoPhan";
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idBoPhan", idBoPhan);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    AcceptTaskPersonnel manager = new AcceptTaskPersonnel
                    {
                        Id = reader["Id"].ToString(),
                        Ten = reader["Ten"].ToString()
                    };
                    managers.Add(manager);
                }
            }

            return managers;
        }
    }
}
