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
        private static readonly string connectionString = @"Data Source=ANH-QUAN;Initial Catalog=FASTIE;Integrated Security=True;TrustServerCertificate=True";

        public static SqlConnection Connect()
        {
            return new SqlConnection(connectionString);
        }
    }

    public class DatabaseAccess
    {
        // Kiểm tra đăng nhập
        public string CheckLoginDTO(Account acc)
        {
            string user = null;
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                SqlCommand command = new SqlCommand("proc_checkLogin", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@tenDangNhap", acc.TenDangNhap);
                command.Parameters.AddWithValue("@matKhau", acc.MatKhau);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    user = reader["tenDangNhap"].ToString();
                }
                else
                {
                    return "Email hoặc mật khẩu không chính xác!";
                }
            }
            return user;
        }

        // Lấy tất cả tài khoản
        public List<Account> GetAllAccounts()
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
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
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
                return false;
            }

            try
            {
                string from = "anhquan20041452@gmail.com"; // Email gửi
                string pass = matKhauMail;                // Mật khẩu ứng dụng email gửi
                string to = nhanSu.Email;                 // Email người nhận
                string content = $"Hi {nhanSu.Ten}, mật khẩu của bạn là: ..."; // Nội dung

                MailMessage mail = new MailMessage
                {
                    From = new MailAddress(from),
                    Subject = "Gửi lại mật khẩu",
                    Body = content
                };
                mail.To.Add(to);

                SmtpClient smtp = new SmtpClient("smtp.gmail.com")
                {
                    EnableSsl = true,
                    Port = 587,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new NetworkCredential(from, pass)
                };

                smtp.Send(mail);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Lấy thông tin nhân sự theo email
        public Nhansu GetNhanSuByEmail(string email)
        {
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                SqlCommand cmd = new SqlCommand("proc_GetNhanSuByEmail", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
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
    }
}



/*
namespace DAL
{
    public static class SqlConnectionData
    {
        private static readonly string connectionString = @"Data Source=ANH-QUAN;Initial Catalog=FASTIE;Integrated Security=True;TrustServerCertificate=True";

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
        public Nhansu GetNhanSuByEmail(string email)
        {
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                string procedureName = "proc_GetNhanSuByEmail";

                SqlCommand cmd = new SqlCommand(procedureName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Email", email);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new Nhansu
                    (
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
    }
}

*/