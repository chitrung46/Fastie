using DAL;
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
    public class TaskAccess : DatabaseAccess
    {
        public string GetProgressNameById(string progressId)
        {
            string progressName = string.Empty;
            string query = "proc_layTrangThaiTienDo";

            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@ProgressId", progressId);
                    progressName = command.ExecuteScalar()?.ToString();
                }
            }

            return progressName;
        }


        // Cập nhật trạng thái công việc
        public void capNhatTrangThaiCongViec(string congViecID, string newStatusId)
        {
            string query = "proc_capNhatTrangThai";

            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@CongViecID", congViecID);
                    command.Parameters.AddWithValue("@NewStatusId", newStatusId);
                    command.ExecuteNonQuery();
                }
            }
        }
        public List<TaskInfo> layCongViecTheoID(string accountId)
        {
            List<TaskInfo> tasks = new List<TaskInfo>();
            string query = "proc_layCongViecDuaTrenIDTK";

            try
            {
                using (SqlConnection con = SqlConnectionData.Connect())
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@AccountId", accountId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                tasks.Add(new TaskInfo
                                {
                                    Id = reader["id"].ToString(),
                                    Ten = reader["ten"].ToString(),
                                    MoTa = reader["moTa"].ToString(),
                                    ThoiGianGiaoViec = reader["thoiGianGiaoViec"] as DateTime?,
                                    ThoiGianHoanThanh = reader["thoiGianHoanThanh"] as DateTime?,
                                    ThoiHanHoanThanh = reader["thoiHanHoanThanh"] as DateTime?,
                                    GhiChu = reader["ghiChu"].ToString(),
                                    IdTaiKhoanGiaoViec = reader["idTaiKhoanGiaoViec"].ToString(),
                                    IdBoPhanGiaoViec = reader["idBoPhanGiaoViec"].ToString(),
                                    IdLoaiCongViec = reader["idLoaiCongViec"].ToString(),
                                    IdTienDoCongViec = reader["idTienDoCongViec"].ToString(),
                                    IdLichSuMacDinh = reader["idLichSuMacDinh"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy danh sách công việc theo ID tài khoản: " + ex.Message);
            }

            return tasks;
        }

        public void giaoViecChoTaiKhoan(string accountId, string taskId)
        {
            string query = "proc_GanCongViecVaoTaiKhoan"; 

            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@AccountId", accountId);
                    command.Parameters.AddWithValue("@TaskId", taskId);
                    command.ExecuteNonQuery();
                }
            }
        }



        public List<TaskInfo> nhanCongViecChuaDuocGiaoTuTaiKhoan(string accountId)
        {
            List<TaskInfo> tasks = new List<TaskInfo>();
            string query = "proc_layCongViecTuTKChuDuocNhan";

            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@AccountId", accountId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tasks.Add(new TaskInfo
                            {
                                Id = reader["id"].ToString(),
                                Ten = reader["ten"].ToString(),
                                MoTa = reader["moTa"].ToString(),
                                ThoiGianGiaoViec = reader["thoiGianGiaoViec"] as DateTime?,
                                ThoiGianHoanThanh = reader["thoiGianHoanThanh"] as DateTime?,
                                ThoiHanHoanThanh = reader["thoiHanHoanThanh"] as DateTime?,
                                GhiChu = reader["ghiChu"].ToString(),
                                IdTienDoCongViec = reader["idTienDoCongViec"].ToString(),
                                TenNhanSuGiaoViec = reader["TenNhanSuGiaoViec"].ToString()
                            });
                        }
                    }
                }
            }

            return tasks;
        }


        public List<TaskInfo> nhanNhiemVuDuocGiaoTuTaiKhoan(string accountId)
        {
            List<TaskInfo> tasks = new List<TaskInfo>();
            string query = "proc_layCongViecDuocGiao";

            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@AccountId", accountId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tasks.Add(new TaskInfo
                            {
                                Id = reader["id"].ToString(),
                                Ten = reader["ten"].ToString(),
                                MoTa = reader["moTa"].ToString(),
                                ThoiGianGiaoViec = reader["thoiGianGiaoViec"] as DateTime?,
                                ThoiGianHoanThanh = reader["thoiGianHoanThanh"] as DateTime?,
                                ThoiHanHoanThanh = reader["thoiHanHoanThanh"] as DateTime?,
                                GhiChu = reader["ghiChu"].ToString(),
                                IdTienDoCongViec = reader["idTienDoCongViec"].ToString(),
                                TenNhanSuGiaoViec = reader["TenNhanSuGiaoViec"].ToString()
                            });
                        }
                    }
                }
            }

            return tasks;
        }
    }

}
