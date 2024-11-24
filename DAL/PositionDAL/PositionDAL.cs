using DTO;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PositionDAL:DatabaseAccess
    {
        //Them Chuc Vu
        public void InsertPosition(Position position)
        {
            string query = "proc_insertPosition";
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                SqlCommand command = new SqlCommand(query, con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ten", position.Ten);
                command.Parameters.AddWithValue("@moTa", position.MoTa);
                con.Open();
                command.ExecuteNonQuery();
            }
        }


        //Show Toan Bo Chuc Vu
        public List<Position> GetPositionList()
        {
            List<Position> list = new List<Position>();
            string query = "proc_getPositionList";
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new Position
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
        //Sua Chuc Vu
        public void UpdatePosition(Position position)
        {
            string query = "proc_updatePosition";
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                SqlCommand command = new SqlCommand(query, con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", position.Id);
                command.Parameters.AddWithValue("@ten", position.Ten);
                command.Parameters.AddWithValue("@moTa", position.MoTa);
                con.Open();
                command.ExecuteNonQuery();
            }
        }
        //Xoa Chuc Vu
        public bool DeletePosition(string positionId)
        {
            string query = "proc_deletePosition";
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                SqlCommand command = new SqlCommand(query, con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", positionId);
                con.Open();
                command.ExecuteNonQuery();
            }
            return true;
        }

        //Tìm kiếm chức vụ
        public List<Position> TimKiemChucVu(string searchValue)
        {
            List<Position> list = new List<Position>();
            string query = "proc_TimKiemChucVu";
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
                        list.Add(new Position
                        {
                            Id = reader["IdChucVu"].ToString(),
                            Ten = reader["TenChucVu"].ToString(),
                            MoTa = reader["MoTa"].ToString()
                        });
                    }
                }
            }
            return list;
        }
    }
}
