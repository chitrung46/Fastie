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
        public List<TaskInfo> nhanCongViecChuaDuocGiaoTuTaiKhoan(string idBoPhan, string accountId)
        {
            List<TaskInfo> tasks = new List<TaskInfo>();
            string query = "proc_layCongViecTuTkChuDuocNhan";

            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idBoPhan", idBoPhan);
                    command.Parameters.AddWithValue("@AccountId", accountId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TaskInfo task = new TaskInfo
                            {
                                Id = reader["CongViecID"].ToString(),
                                Ten = reader["TenCongViec"].ToString(),
                                MoTa = reader["MoTaCongViec"].ToString(),
                                ThoiGianGiaoViec = reader["thoiGianGiaoViec"] as DateTime?,
                                ThoiGianHoanThanh = reader["thoiGianHoanThanh"] as DateTime?,  // Xử lý NULL
                                ThoiHanHoanThanh = reader["thoiHanHoanThanh"] as DateTime?,
                                GhiChu = reader["ghiChu"].ToString(),
                                // Các thuộc tính bổ sung
                                TenBoPhan = reader["TenBoPhan"]?.ToString(),
                                TenLoaiCongViec = reader["TenLoaiCongViec"]?.ToString(),
                                TenTienDoCongViec = reader["TenTienDoCongViec"]?.ToString(),
                                TenNhanSuGiaoViec = reader["TenNhanSuGiaoViec"]?.ToString(),
                                SoLuongNhanSuChuDong = reader["SoLuongNhanSuChuDong"]?.ToString(),
                                TenNhanSuNhanViec = reader["TenNhanSuNhanViec"]?.ToString()
                            };

                            tasks.Add(task);
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

        //Vy
        public List<TaskType> LayDanhSachLoaiCongViec()
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
                        command.CommandType = CommandType.StoredProcedure; 
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
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Lỗi khi lấy dữ liệu danh sách loại công việc: " + ex.Message);
            }
            return danhSachLoaiCongViec;
        }

        public bool ThemCongViecGiaoViec(TaskInfo task)
        {
            if (string.IsNullOrEmpty(task.IdLichSuMacDinh))
            {
                throw new ArgumentException("IdLichSuMacDinh is required and cannot be null or empty.");
            }

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
                return true;
            }
        }


        public string TaoCongViecId (string idLoaiCongViec, string idBoPhan)
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
        public string TaoLichSuId()
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
        public string LayIdLoaiCongViecTuTen(string tenLoaiCongViec)
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

        public bool LuuBoPhanNhanViec(string idBoPhanNhanViec, string idCongViec) 
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

        public bool LuuTaiKhoanNhanViec(string idTaiKhoanNhanViec, string idCongViec)
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

        public List<TaskInfo> LayDanhSachCongViecDaGiao(string idNguoiDung)
        {
            List<TaskInfo> danhSachCongViec = new List<TaskInfo>();
            SqlConnection conn = SqlConnectionData.Connect();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("proc_layDanhSachCongViecDaGiao", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idNguoiDung", idNguoiDung);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("Đang đọc công việc: " + reader["ten"].ToString()); 
                    TaskInfo congViec = new TaskInfo
                    {
                        Id = reader["id"].ToString(),
                        Ten = reader["ten"].ToString(),
                        ThoiHanHoanThanh = reader["thoiHanHoanThanh"] as DateTime?,
                        TenTienDoCongViec = reader["tienDoCongViec"].ToString(),
                        TenNhanSuGiaoViec = reader["NguoiGiaoViec"].ToString()
                    };
                    danhSachCongViec.Add(congViec);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách công việc: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return danhSachCongViec;
        }
        public bool ThemCongViecChuDong(string idCongViec, int soLuongNhanSuChuDong)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("proc_themCongViecChuDong", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", idCongViec);
                cmd.Parameters.AddWithValue("@soLuongNhanSuChuDong", soLuongNhanSuChuDong);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm công việc chủ động: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public TaskInfo LayChiTietCongViecTheoIdCongViec(string IdTask)
        {
            TaskInfo task = new TaskInfo();
            string query = "proc_layChiTietCongViecTheoIdCongViec";

            try
            {
                using (SqlConnection con = SqlConnectionData.Connect())
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@idCongViec", IdTask);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                task = new TaskInfo
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
                                    IdLichSuMacDinh = reader["idLichSuMacDinh"].ToString(),
                                    TenLoaiCongViec = reader["tenLoaiCongViec"].ToString()
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy danh sách công việc theo ID tài khoản: " + ex.Message);
            }

            return task;
        }

        public int LaySoLuongNhanSuChuDongTheoIdCongViec(string idCongViec)
        {
            int soLuong = 0;
            string query = "proc_laySoLuongNhanSuChuDongTheoIdCongViec";
            try
            {
                using (SqlConnection con = SqlConnectionData.Connect())
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@idCongViec", idCongViec);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                soLuong = (int)reader["soLuongNhanSuChuDong"];
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy ID công việc: " + ex.Message);
            }
            return soLuong;
        }

        public TaskInfo LayChiTietCongViec(string idTask)
        {
            TaskInfo task = null;
            string query = "proc_layChiTietCongViec"; 

            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@IdTask", idTask);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            task = new TaskInfo
                            {
                                Id = reader["id"].ToString(),
                                Ten = reader["ten"].ToString(),
                                MoTa = reader["moTa"].ToString(),
                                ThoiGianGiaoViec = reader["thoiGianGiaoViec"] as DateTime?,
                                ThoiGianHoanThanh = reader["thoiGianHoanThanh"] as DateTime?,
                                ThoiHanHoanThanh = reader["thoiHanHoanThanh"] as DateTime?,
                                GhiChu = reader["ghiChu"].ToString(),
                                IdTaiKhoanGiaoViec = reader["idTaiKhoanGiaoViec"].ToString(),
                                TenBoPhan = reader["tenBoPhan"].ToString(),
                                TenLoaiCongViec = reader["tenLoaiCongViec"].ToString(),
                                TenTienDoCongViec = reader["tenTienDoCongViec"].ToString(),
                                TenNhanSuNhanViec = reader["tenNhanSuNhanViec"].ToString(),
                                SoLuongNhanSuChuDong = reader["soLuongNhanSuChuDong"].ToString()
                            };
                        }
                    }
                }
            }
            return task;
        }
        public List<TaskInfo> LayLichSuCongViec(string idNguoiDung)
        {
            List<TaskInfo> resultList = new List<TaskInfo>();

            using (SqlConnection connection = SqlConnectionData.Connect())
            {
                using (SqlCommand command = new SqlCommand("proc_LayLichSuCongViecChiTiet", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idTaiKhoan", idNguoiDung);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TaskInfo taskInfo = new TaskInfo
                            {
                                GhiChu = reader["ghiChu"].ToString(),
                                Ten = reader["tenCongViec"].ToString()
                            };
                            resultList.Add(taskInfo);
                        }
                    }
                }
            }
            return resultList;
        }




    }
}
