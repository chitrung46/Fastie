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
        public int ThemTaiKhoan(Account taiKhoan)
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

                // Thêm tham số để nhận giá trị trả về
                SqlParameter returnValue = new SqlParameter();
                returnValue.Direction = ParameterDirection.ReturnValue;
                command.Parameters.Add(returnValue);

                con.Open();
                command.ExecuteNonQuery();

                // Lấy giá trị trả về
                return (int)returnValue.Value;
            }
        }

        public List<Account> LayDanhSachTaiKhoan()
        {
            try
            {
                string query = "proc_LayDanhSachTaiKhoan";
                List<Account> danhSachTaiKhoan = new List<Account>();

                using (SqlConnection con = SqlConnectionData.Connect())
                {
                    SqlCommand command = new SqlCommand(query, con);
                    command.CommandType = CommandType.StoredProcedure;
                    con.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string tenNhanSu = reader["TenNhanSu"].ToString();
                            string tenBoPhan = reader["TenBoPhan"].ToString();
                            string tenChucVu = reader["TenChucVu"].ToString();
                            string trangThai = reader["TrangThai"].ToString();

                            Account account = new Account(tenNhanSu, tenBoPhan, tenChucVu, trangThai);
                            danhSachTaiKhoan.Add(account);
                        }
                    }
                }

                return danhSachTaiKhoan;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách tài khoản: " + ex.Message, ex);
            }
        }


    }
}
