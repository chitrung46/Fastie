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
    public class SqlConnectionData
    {
        public static SqlConnection Connect()
        {
            string connectionString = @"Data Source=CHITRUNG-LAPTOP\TRUNG_SQL;Initial Catalog=FASTIE;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            return conn;
        }
    }
    public class DatabaseAccess
    {
        public DatabaseAccess () { }

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

        #region //Bộ phận
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
        #endregion

        #region //Chức vụ

        //Them Chuc Vu
        public static void InsertPosition(Position position)
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
        public static List<Position> GetPositionList()
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
        public static void UpdatePosition(Position position)
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
        public static void DeletePosition(string positionId)
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
        }

        #endregion

        #region //Nhân sự
        //Them Nhan Su
        public static void InsertPersonnel(Personnel personnel) 
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

        public static List<Personnel> GetPersonnelList() {
            return null;
        }

        public static void DeletePersonnel(string id) { }
        public static void UpdatePersonnel(Personnel personnel) { }
        #endregion
    }
}
