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

        public string InsertAccount(string tenDangNhap, string matKhau)
        {
            return DatabaseAccess.InsertAccount(tenDangNhap, matKhau);
        }

        public bool DeleteAccount(string tenDangNhap, string matKhau)
        {
            return DatabaseAccess.DeleteAccount(tenDangNhap, matKhau);
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
                string query = @"
            SELECT NS.id, NS.ten, NS.email, NS.gioiTinh, NS.ngaySinh, NS.ngayVaoLam, NS.sdt
            FROM NhanSu NS
            WHERE NS.email = @Email";

                SqlCommand cmd = new SqlCommand(query, conn);
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
