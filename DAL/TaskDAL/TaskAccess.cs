using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Task;

namespace DAL
{
    public class TaskAccess : DatabaseAccess
    {
        /***
        public List<TaskInfo> GetTaskListDAL()
        {
            List<TaskInfo> list = DatabaseAccess.GetTasksFromDatabase();
            return list;
        }***/
        public static List<TaskInfo> GetTasksFromDatabase()
        {
            List<TaskInfo> tasks = new List<TaskInfo>();
            string query = "proc_getTask";

            try
            {
                using (SqlConnection con = SqlConnectionData.Connect())
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.CommandType = CommandType.StoredProcedure;

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
                Console.WriteLine("Lỗi khi lấy dữ liệu công việc: " + ex.Message);
            }

            return tasks;
        }

        public static List<TaskWithPersonel> GetTaskWithPersonnel()
        {
            List<TaskWithPersonel> taskList = new List<TaskWithPersonel>();
            string query = "proc_getTaskWithPersonel";

            try
            {
                using (SqlConnection con = SqlConnectionData.Connect())
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                taskList.Add(new TaskWithPersonel
                                {
                                    CongViecID = reader["CongViecID"].ToString(),
                                    TenCongViec = reader["TenCongViec"].ToString(),
                                    MoTaCongViec = reader["MoTaCongViec"].ToString(),
                                    ThoiGianGiaoViec = reader["thoiGianGiaoViec"] as DateTime?,
                                    ThoiGianHoanThanh = reader["thoiGianHoanThanh"] as DateTime?,
                                    ThoiHanHoanThanh = reader["thoiHanHoanThanh"] as DateTime?,
                                    GhiChu = reader["ghiChu"].ToString(),
                                    TenBoPhan = reader["TenBoPhan"].ToString(),
                                    TenLoaiCongViec = reader["TenLoaiCongViec"].ToString(),
                                    TenTienDoCongViec = reader["TenTienDoCongViec"].ToString(),
                                    TenNhanSuGiaoViec = reader["TenNhanSuGiaoViec"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy dữ liệu công việc với thông tin nhân sự: " + ex.Message);
            }

            return taskList;
        }

        public static void UpdateTaskStatus(string congViecID, string newStatus)
        {
            string query = "UPDATE CongViec SET ghiChu = @NewStatus WHERE id = @CongViecID";

            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@CongViecID", congViecID);
                    command.Parameters.AddWithValue("@NewStatus", newStatus);
                    command.ExecuteNonQuery();
                }
            }
        }





    }

}
