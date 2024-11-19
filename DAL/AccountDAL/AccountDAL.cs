using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AccountDAL : DatabaseAccess
    {
        public bool ThemTaiKhoan(Account taiKhoan)
        {
            string query = "proc_insertAccount";
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                SqlCommand command = new SqlCommand(query, con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@tenDangNhap", taiKhoan.TenDangNhap);
                command.Parameters.AddWithValue("@matKhau", taiKhoan.MatKhau);
                command.Parameters.AddWithValue("@idBoPhan", taiKhoan.IdBoPhan);
                command.Parameters.AddWithValue("@idChucVu", taiKhoan.IdChucVu);
                command.Parameters.AddWithValue("@idNhanSu", taiKhoan.IdNhanSu);
                con.Open();
                command.ExecuteNonQuery();
            }
            return true;
        }
    }
}
