using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.LoginDAL
{
    public class GetInFoLoginDAL
    {
        public string[] LayTenNhanSuVaBoPhan(string idTaiKhoan)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("proc_layThongTinBoPhanVaNhanSu", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idTaiKhoan", idTaiKhoan);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new string[]
                    {
                        reader["TenNhanSu"].ToString(),
                        reader["TenBoPhan"].ToString()
                    };
                }
                else
                {
                    return new string[] { "Không tìm thấy dữ liệu", "Không tìm thấy dữ liệu" };
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy tên nhân sự và bộ phận: " + ex.Message);
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

    }
}
