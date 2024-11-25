using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace DAL
{
    public class PersonnelDAL:DatabaseAccess
    {
        public void InsertPersonnel(Personnel personnel)
        {
            string query = "proc_insertPersonnel";
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                SqlCommand command = new SqlCommand(query, con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ten", personnel.Ten);
                command.Parameters.AddWithValue("@email", personnel.Email);
                command.Parameters.AddWithValue("@gioiTinh", personnel.GioiTinh);
                command.Parameters.AddWithValue("@ngaySinh", personnel.NgaySinh);
                command.Parameters.AddWithValue("@ngayVaoLam", personnel.NgayVaoLam);
                command.Parameters.AddWithValue("@sdt", personnel.Sdt);
                con.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<Personnel> GetPersonnelList()
        {
            List<Personnel> list = new List<Personnel>();
            string query = "proc_getPersonnelList";
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new Personnel
                        {
                            Id = reader["id"].ToString(),
                            Ten = reader["ten"].ToString(),
                            Email = reader["email"].ToString(),
                            GioiTinh = reader["gioiTinh"].ToString(),
                            NgaySinh = reader.GetDateTime(reader.GetOrdinal("ngaySinh")),
                            NgayVaoLam = reader.GetDateTime(reader.GetOrdinal("ngayVaoLam")),
                            Sdt = reader["sdt"].ToString()
                        });
                    }
                }
            }
            return list;
        }

        public bool DeletePersonnel(string id)
        {
            string query = "proc_deletePersonnel";
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                SqlCommand command = new SqlCommand(query, con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", id);
                con.Open();
                command.ExecuteNonQuery();
            }
            return true;
        }
        public void UpdatePersonnel(Personnel personnel)
        {
            string query = "proc_updatePersonnel";
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                SqlCommand command = new SqlCommand(query, con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", personnel.Id);
                command.Parameters.AddWithValue("@ten", personnel.Ten);
                command.Parameters.AddWithValue("@email", personnel.Email);
                command.Parameters.AddWithValue("@gioiTinh", personnel.GioiTinh);
                command.Parameters.AddWithValue("@ngaySinh", personnel.NgaySinh);
                command.Parameters.AddWithValue("@ngayVaoLam", personnel.NgayVaoLam);
                command.Parameters.AddWithValue("@sdt", personnel.Sdt);
                con.Open();
                command.ExecuteNonQuery();
            }
        }

        //Tim kiem nhan su
        public List<Personnel> TimKiemNhanSu(string searchValue)
        {
            List<Personnel> list = new List<Personnel>();
            string query = "proc_TimKiemNhanSu";
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
                        list.Add(new Personnel
                        {
                            Id = reader["id"].ToString(),
                            Ten = reader["ten"].ToString(),
                            Email = reader["email"].ToString(),
                            GioiTinh = reader["gioiTinh"].ToString(),
                            NgaySinh = reader.GetDateTime(reader.GetOrdinal("ngaySinh")),
                            NgayVaoLam = reader.GetDateTime(reader.GetOrdinal("ngayVaoLam")),
                            Sdt = reader["sdt"].ToString()
                        });
                    }
                }
            }
            return list;
        }
    }
}


