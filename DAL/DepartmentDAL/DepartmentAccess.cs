using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DepartmentAccess
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
    }
}
