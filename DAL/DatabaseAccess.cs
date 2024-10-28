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
            string connectionString = @"Data Source=HA-VY;Initial Catalog=FASTIE;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
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

        //Them Bo Phan
        public static void InsertDepartment(BoPhanDTO boPhan)
        {
            string query = "proc_insertDepartment";
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                SqlCommand command = new SqlCommand(query, con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Ten", boPhan.Ten);
                command.Parameters.AddWithValue("@MoTa", boPhan.MoTa);
                con.Open();
                command.ExecuteNonQuery();
            }
        }

        //Sua Bo Phan
        public static void EditDepartment(BoPhanDTO boPhan)
        {
            string query = "proc_editDepartment";
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                SqlCommand command = new SqlCommand(query, con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", boPhan.Id);
                command.Parameters.AddWithValue("@ten", boPhan.Ten);
                command.Parameters.AddWithValue("@moTa", boPhan.MoTa);
                con.Open();
                command.ExecuteNonQuery();
            }
        }

        //Show Toan Bo Bo Phan
        public static List<BoPhanDTO> GetDepartmentList() 
        {
            List<BoPhanDTO> list = new List<BoPhanDTO>();
            string query = "proc_getDepartmentList";
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new BoPhanDTO
                        {
                            Id = reader["Id"].ToString(),
                            Ten = reader["Ten"].ToString(),
                            MoTa = reader["MoTa"].ToString()
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
                command.Parameters.AddWithValue("@Id", departmentId);
                con.Open();
                command.ExecuteNonQuery();
            }
        }

        //Them Chuc Vu
        public static void InsertPosition(ChucVuDTO chucVu)
        {
            string query = "proc_insertPosition";
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                SqlCommand command = new SqlCommand(query, con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Ten", chucVu.Ten);
                command.Parameters.AddWithValue("@MoTa", chucVu.MoTa);
                con.Open();
                command.ExecuteNonQuery();
            }
        }

        
        //Show Toan Bo Chuc Vu
        public static List<ChucVuDTO> GetPositionList()
        {
            List<ChucVuDTO> list = new List<ChucVuDTO>();
            string query = "proc_getPositionList";
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new ChucVuDTO
                        {
                            Id = reader["Id"].ToString(),
                            Ten = reader["Ten"].ToString(),
                            MoTa = reader["MoTa"].ToString()
                        });
                    }
                }
            }
            return list;
        }
        //Sua Chuc Vu
        public static void EditPosition(ChucVuDTO chucVu)
        {
            string query = "proc_editPosition";
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                SqlCommand command = new SqlCommand(query, con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", chucVu.Id);
                command.Parameters.AddWithValue("@ten", chucVu.Ten);
                command.Parameters.AddWithValue("@moTa", chucVu.MoTa);
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
                command.Parameters.AddWithValue("@Id", positionId);
                con.Open();
                command.ExecuteNonQuery();
            }
        }



        //Them Nhan Su
        public static void InsertPersonnel(NhanSuDTO nhanSu) 
        {
            string query = "proc_insertPersonnel";
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                SqlCommand command = new SqlCommand(query, con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Ten", nhanSu.Ten);
                command.Parameters.AddWithValue("@Email", nhanSu.Email);
                command.Parameters.AddWithValue("@GioiTinh", nhanSu.GioiTinh);
                command.Parameters.AddWithValue("@NgaySinh", nhanSu.NgaySinh);
                command.Parameters.AddWithValue("@NgayVaoLam", nhanSu.NgayVaoLam);
                command.Parameters.AddWithValue("@Sdt", nhanSu.Sdt);
                con.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
