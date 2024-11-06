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
    public class ResetPasswordDAL
    {
        // Lấy tất cả tài khoản
        public static List<Account> GetListAllAccount()
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

        public static Personnel GetPersonnelByEmail(string email)
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
                    return new Personnel
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
