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
        public void InsertDepartment(Department deparment)
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
        public void UpdateDepartment(Department deparment)
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
        public List<Department> GetDepartmentList()
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
        public void DeleteDepartment(string departmentId)
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
        public List<AcceptTaskPersonnel> LayQuanLiBoPhan(string idBoPhan)
        {
            List<AcceptTaskPersonnel> managers = new List<AcceptTaskPersonnel>();
            string query = "proc_layQuanLiBoPhan";
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

        public List<AcceptTaskPersonnel> LayNhanSuBoPhan(string idBoPhan)
        {
            List<AcceptTaskPersonnel> managers = new List<AcceptTaskPersonnel>();
            string query = "proc_layNhanSuBoPhan";
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

        //Tìm kiếm bộ phận
        public List<Department> TimKiemBoPhan(string searchValue)
        {
            List<Department> list = new List<Department>();
            string query = "proc_TimKiemBoPhan";
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@tenTimKiem", searchValue);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new Department
                        {
                            Id = reader["IdBoPhan"].ToString(),
                            Ten = reader["TenBoPhan"].ToString(),
                            MoTa = reader["MoTa"].ToString()
                        });
                    }
                }
            }
            return list;
        }   
    }
}
