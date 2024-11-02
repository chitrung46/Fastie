using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Net.Mail;
using System.Net;

namespace DAL
{
    public static class SqlConnectionData
    {
        private static readonly string connectionString = @"Data Source=DESKTOP-G1KLLU0;Initial Catalog=FASTIE;Integrated Security=True;";

        public static SqlConnection Connect()
        {
            return new SqlConnection(connectionString);
        }
    }

    public class DatabaseAccess
    {
        //For account login
        public static string[] checkLoginDTO(Account acc)
        {
            string[] user = new string[4];
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("proc_checkLogin", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@tendangnhap", acc.TenDangNhap);
            command.Parameters.AddWithValue("@matkhau", acc.MatKhau);

            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    user[0] = reader["id"].ToString();
                    user[1] = reader["idNhanSu"].ToString();
                    user[2] = reader["idBoPhan"].ToString();
                    user[3] = reader["idChucVu"].ToString();
                }
                reader.Close();
                conn.Close();
            }
            else
            {
                return new string[] { "Email hoặc mật khẩu không chính xác!" };
            }

            return user;
        }
        

        //Check permission for accessing
        public static bool checkPermission(string accountId, string permissionId)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("proc_checkPermissionAccess", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idTaiKhoan", accountId);
                cmd.Parameters.AddWithValue("@idQuyen", permissionId);
                return (int)cmd.ExecuteScalar() == 1 ? true : false;

            } catch(Exception ex)
            {
                throw new Exception("Lỗi khi kiểm tra quyền: " + ex.Message);
            }
        }






        // Lấy tất cả tài khoản
        public static List<Account> GetAllAccounts()
        {
            List<Account> accounts = new List<Account>();
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                SqlCommand cmd = new SqlCommand("proc_getAllAccount", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Account account = new Account(
                        reader["id"].ToString(),
                        reader["Tên đăng nhập"].ToString(),
                        reader["Mật khẩu"].ToString(),
                        Convert.ToDateTime(reader["Thời gian khởi tạo"]),
                        reader["Thời gian cập nhật"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(reader["Thời gian cập nhật"]),
                        reader["Trạng thái"].ToString()
                    );
                    accounts.Add(account);
                }
            }
            return accounts;
        }

        // Cập nhật tài khoản
        public bool UpdateAccount(string tenDangNhap, string matKhau)
        {
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                SqlCommand cmd = new SqlCommand("proc_updateAccount", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@tenDangNhap", tenDangNhap);
                cmd.Parameters.AddWithValue("@matKhau", matKhau);

                conn.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    return "Tài khoản đã được thêm thành công.";
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 50000) // Kiểm tra mã lỗi của RAISERROR
                        return ex.Message;
                    throw;
                }
            }
        }

        // Lấy tài khoản theo email
        public Account GetAccountByEmail(string email)
        {
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                SqlCommand cmd = new SqlCommand("proc_getAccountByEmail", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@Email", email);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new Account(
                        reader["id"].ToString(),
                        reader["tenDangNhap"].ToString(),
                        reader["matKhau"].ToString(),
                        DateTime.MinValue,
                        DateTime.MinValue,
                        reader["email"].ToString()
                    );
                }
                return null;
            }
        }

        // Cập nhật mật khẩu theo email
        public bool UpdatePassword(string email, string newPassword)
        {
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                SqlCommand cmd = new SqlCommand("proc_updatePassword", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@NewPassword", newPassword);
                cmd.Parameters.AddWithValue("@Email", email);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        // Gửi mail để lấy lại mật khẩu
        public bool GuiMailLayLaiMatKhau(string email, string matKhauMail)
        {
            Nhansu nhanSu = GetNhanSuByEmail(email);
            if (nhanSu == null)
            {
                SqlCommand cmd = new SqlCommand("proc_getAccountByEmail", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@Email", email);

                MailMessage mail = new MailMessage
                {
                    From = new MailAddress(from),
                    Subject = "Gửi lại mật khẩu",
                    Body = content
                };
                mail.To.Add(to);

                if (reader.Read())
                {
                    return new Account(
                        reader["id"].ToString(),
                        reader["tenDangNhap"].ToString(),
                        reader["matKhau"].ToString(),
                        DateTime.MinValue,
                        DateTime.MinValue,
                        reader["email"].ToString()
                    );
                }
                return null;
            }
        }

        // Lấy thông tin nhân sự theo email
        public Nhansu GetNhanSuByEmail(string email)
        {
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                SqlCommand cmd = new SqlCommand("proc_updatePassword", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@NewPassword", newPassword);
                cmd.Parameters.AddWithValue("@Email", email);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new Nhansu(
                        reader["id"].ToString(),
                        reader["ten"].ToString(),
                        reader["email"].ToString(),
                        reader["gioiTinh"].ToString(),
                        Convert.ToDateTime(reader["ngaySinh"]),
                        Convert.ToDateTime(reader["ngayVaoLam"]),
                        reader["sdt"].ToString()
                    );
                }
                return null;
            }
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

        public static void DeletePersonnel(string id) 
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
        }
        public static void UpdatePersonnel(Personnel personnel)
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
        #endregion
    }
}
