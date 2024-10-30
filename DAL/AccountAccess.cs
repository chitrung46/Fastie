using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
    public class AccountAccess
    {
        public string checkLogin(Account acc)
        {
            return DatabaseAccess.checkLoginDTO(acc);
        }

        public List<Account> GetAllAccounts()
        {
            return DatabaseAccess.GetAllAccounts();
        }


        public bool UpdateAccount(string tenDangNhap, string matKhau)
        {
            return DatabaseAccess.UpdateAccount(tenDangNhap, matKhau);
        }

        public Account GetAccountByEmail(string email)
        {
            return DatabaseAccess.GetAccountByEmail(email);
        }

        public bool UpdatePassword(string email, string newPassword)
        {
            return DatabaseAccess.UpdatePassword(email, newPassword);
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
