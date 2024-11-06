using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.LoginDAL
{
    
    
    public class LoginDAL:DatabaseAccess
    {
        public static string[] checkLogin(Account acc)
        {
            string[] user = new string[5];
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
                    user[4] = reader["trangThai"].ToString();
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
    }
}

