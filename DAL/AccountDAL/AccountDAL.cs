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
            try
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
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return 1;
        }

        public int CapNhatTaiKhoan(Account taiKhoan)
        {
            try
            {
                string query = "proc_CapNhatTaiKhoan";
         
                using (SqlConnection con = SqlConnectionData.Connect())
                {
                    SqlCommand command = new SqlCommand(query, con);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@tenDangNhap", taiKhoan.TenDangNhap);
                    command.Parameters.AddWithValue("@matKhau", taiKhoan.MatKhau);
                    command.Parameters.AddWithValue("@idTaiKhoan", taiKhoan.Id);

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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return 1;
        }

        public int CapNhatTrangThaiTaiKhoan(string idTaiKhoan)
        {
            try
            {
                string query = "proc_CapNhatTrangThaiTaiKhoan";
                using (SqlConnection con = SqlConnectionData.Connect())
                {
                    SqlCommand command = new SqlCommand(query, con);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idTaiKhoan", idTaiKhoan);

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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return 1;
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
                            string email = reader["Email"].ToString();
                            string soDienThoai = reader["SoDienThoai"].ToString();
                            string tenDangNhap = reader["TenDangNhap"].ToString();
                            string matKhau = reader["MatKhau"].ToString();
                            string idTaiKhoan = reader["IdTaiKhoan"].ToString();
                            string idNhanSu = reader["IdNhanSu"].ToString();
                            string idBoPhan = reader["IdBoPhan"].ToString();
                            string idChucVu = reader["IdChucVu"].ToString();
                            Account account = new Account(tenNhanSu, tenBoPhan, tenChucVu, trangThai, email, soDienThoai, tenDangNhap, matKhau, idTaiKhoan, idNhanSu, idBoPhan, idChucVu);
                            danhSachTaiKhoan.Add(account);
                        }
                    }
                }

                return danhSachTaiKhoan;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public int VoHieuHoaTaiKhoan(string idTaiKhoan)
        {
            try
            {
                string query = "proc_VoHieuHoaTaiKhoan";
                using (SqlConnection con = SqlConnectionData.Connect())
                {
                    SqlCommand command = new SqlCommand(query, con);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idTaiKhoan", idTaiKhoan);

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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return 1;
        }
    }
}
