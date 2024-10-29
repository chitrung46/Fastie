using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using DTO;


namespace DAL
{
    public static class SqlConnectionData
    {
        private static readonly string connectionString = @"Data Source=CHITRUNG-LAPTOP\TRUNG_SQL;Initial Catalog=FASTIE;Integrated Security=True";

        public static SqlConnection Connect()
        {
            return new SqlConnection(connectionString);
        }
    }

    public class DatabaseAccess
    {
        // Kiểm tra đăng nhập
        public static string checkLoginDTO(Account acc)
        {
            string user = null;
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("proc_checkLogin", conn);
            command.CommandType = CommandType.StoredProcedure;
            
            command.Parameters.AddWithValue("@tenDangNhap", acc.TenDangNhap);
            command.Parameters.AddWithValue("@matKhau", acc.MatKhau);

            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    user = reader.ToString();
                }
                reader.Close();
                conn.Close();
            }
            else
            {
                return "Email hoặc mật khẩu không chính xác!";
            }

            return user;
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

        // Thêm tài khoản mới
        public static string InsertAccount(string tenDangNhap, string matKhau)
        {
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                SqlCommand cmd = new SqlCommand("proc_insertAccount", conn)
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

        // Xóa tài khoản
        public static bool DeleteAccount(string tenDangNhap, string matKhau)
        {
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                SqlCommand cmd = new SqlCommand("proc_deleteAccount", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@tenDangNhap", tenDangNhap);
                cmd.Parameters.AddWithValue("@matKhau", matKhau);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        // Cập nhật tài khoản
        public static bool UpdateAccount(string tenDangNhap, string matKhau)
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
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        // Lấy tài khoản theo email
        public static Account GetAccountByEmail(string email)
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
        public static bool UpdatePassword(string email, string newPassword)
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
    }
}

