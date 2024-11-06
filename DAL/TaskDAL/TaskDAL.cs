using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.TaskDTO;
using DTO;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace DAL.TaskDAL
{
    public class TaskDAL:DatabaseAccess
    {
        public static List<TaskType> LayDanhSachLoaiCongViec()
        {
            List<TaskType> danhSachLoaiCongViec = new List<TaskType>();
            string query = "proc_LayDanhSachLoaiCongViec";
            try
            {
                using (SqlConnection con = SqlConnectionData.Connect())
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.CommandType = CommandType.StoredProcedure; // Đặt kiểu lệnh là Stored Procedure

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                danhSachLoaiCongViec.Add(new TaskType
                                {
                                    Id = reader["id"].ToString(),
                                    Ten = reader["ten"].ToString(),
                                    MoTa = reader["moTa"].ToString(),
                                });
                            }
                        }
                    }
                    //danhSachLoaiCongViec.Add(loaiCongViec);
                }
                //con.Close();
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Lỗi khi lấy dữ liệu danh sách loại công việc: " + ex.Message);
            }
            return danhSachLoaiCongViec;
        }

        public static bool ThemCongViecGiaoViec(TaskInfo task) 
        {
            string query = "proc_themCongViec";
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCongViec", task.Id);
                cmd.Parameters.AddWithValue("@ten", task.Ten);
                cmd.Parameters.AddWithValue("@moTa", task.MoTa);
                cmd.Parameters.AddWithValue("@thoiGianGiaoViec", task.ThoiGianGiaoViec);
                cmd.Parameters.AddWithValue("@thoiHanHoanThanh", task.ThoiHanHoanThanh);
                cmd.Parameters.AddWithValue("@ghiChu", task.GhiChu);
                cmd.Parameters.AddWithValue("@idTaiKhoanGiaoViec", task.IdTaiKhoanGiaoViec);
                cmd.Parameters.AddWithValue("@idBoPhanGiaoViec", task.IdBoPhanGiaoViec);
                cmd.Parameters.AddWithValue("@idLoaiCongViec", task.IdLoaiCongViec);
                cmd.Parameters.AddWithValue("@idTienDoCongViec", task.IdTienDoCongViec);
                cmd.Parameters.AddWithValue("@idHanhDong", "HD003");
                cmd.Parameters.AddWithValue("@idLichSuMacDinh", task.IdLichSuMacDinh);
                conn.Open();
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Công việc đã được thêm thành công!", "Thông báo");
                return true;
            }
        }

        public static string TaoCongViecId (string idLoaiCongViec, string idBoPhan)
        {
            string query = "proc_taoCongViecId";
            string idCongViec = "";
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idLoaiCongViec", idLoaiCongViec); // Thay giá trị phù hợp
                cmd.Parameters.AddWithValue("@idBoPhan", idBoPhan);
                SqlParameter generatedIdParam = new SqlParameter("@generatedId", SqlDbType.VarChar, 20)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(generatedIdParam);
                cmd.ExecuteNonQuery();
                idCongViec = generatedIdParam.Value.ToString();
                conn.Close();
            }
            return idCongViec;
        }
        public static string TaoLichSuId()
        {
            string query = "proc_taoLichSuId";
            string idLichSu = "";
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter generatedIdParam = new SqlParameter("@generatedId", SqlDbType.VarChar, 14)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(generatedIdParam);
                cmd.ExecuteNonQuery();
                idLichSu = generatedIdParam.Value.ToString();
                conn.Close();
            }
            return idLichSu;
        }
        public static string LayIdLoaiCongViecTuTen(string tenLoaiCongViec)
        {
            string query = "proc_layIdLoaiCongViecTuTen";
            string idLoaiCongViec = "";
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tenLoaiCongViec", tenLoaiCongViec);
                SqlParameter generatedIdParam = new SqlParameter("@generatedId", SqlDbType.VarChar, 6)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(generatedIdParam);
                cmd.ExecuteNonQuery();
                idLoaiCongViec = generatedIdParam.Value.ToString();
                conn.Close();
            }
            return idLoaiCongViec;
        }

        public static bool LuuBoPhanNhanViec(string idBoPhanNhanViec, string idCongViec) 
        {
            string query = "proc_luuBoPhanNhanViec";
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idBoPhanNhanViec", idBoPhanNhanViec);
                cmd.Parameters.AddWithValue("@idCongViec", idCongViec);
                conn.Open();
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Công việc đã được thêm thành công!", "Thông báo");
                return true;
            }
        }

        public static bool LuuTaiKhoanNhanViec(string idTaiKhoanNhanViec, string idCongViec)
        {
            string query = "proc_luuTaiKhoanNhanViec";
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idTaiKhoanNhanViec", idTaiKhoanNhanViec);
                cmd.Parameters.AddWithValue("@idCongViec", idCongViec);
                conn.Open();
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Công việc đã được thêm thành công!", "Thông báo");
                return true;
            }
        }
    }
}
