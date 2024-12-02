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
        public bool DuyetHoanThanhCongViec(string idCongViec)
        {
            bool result = false;
            string query = "proc_duyetHoanThanhCongViec";
            try
            {
                using (SqlConnection con = SqlConnectionData.Connect())
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@idCongViec", idCongViec);
                        command.ExecuteNonQuery();
                    }
                }
                result = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy ID công việc: " + ex.Message);
            }
            return result;
        }
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
                                    IdLichSuMacDinh = reader["idLichSuMacDinh"].ToString(),
                                    TenTienDoCongViec = reader["tenTienDoCongViec"].ToString(),
                                    TenNhanSuGiaoViec = reader["NguoiGiaoViec"].ToString(),
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
            string query = "proc_layCongViecChuDongTest";

            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@IdBoPhan", idBoPhan);
                    command.Parameters.AddWithValue("@IdTaiKhoanNhanViec", accountId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TaskInfo task = new TaskInfo
                            {
                                //Id = reader["CongViecID"].ToString(),
                                //Ten = reader["TenCongViec"].ToString(),
                                //MoTa = reader["MoTaCongViec"].ToString(),
                                //ThoiGianGiaoViec = reader["thoiGianGiaoViec"] as DateTime?,
                                //ThoiGianHoanThanh = reader["thoiGianHoanThanh"] as DateTime?,  // Xử lý NULL
                                //ThoiHanHoanThanh = reader["thoiHanHoanThanh"] as DateTime?,
                                //GhiChu = reader["ghiChu"].ToString(),
                                //TenBoPhan = reader["TenBoPhan"].ToString(),
                                //TenLoaiCongViec = reader["TenLoaiCongViec"].ToString(),
                                //TenTienDoCongViec = reader["TenTienDoCongViec"].ToString(),
                                //TenNhanSuGiaoViec = reader["TenNhanSuGiaoViec"].ToString(),
                                SoLuongNhanSuChuDong = reader["SoLuongChuDong"].ToString(),
                                //TenNhanSuNhanViec = reader["TenNhanSuNhanViec"].ToString()

                                Id = reader["id"].ToString(),
                                Ten = reader["ten"].ToString(),
                                MoTa = reader["moTa"].ToString(),
                                ThoiGianGiaoViec = reader["thoiGianGiaoViec"] as DateTime?,
                                ThoiGianHoanThanh = reader["thoiGianHoanThanh"] as DateTime?,
                                ThoiHanHoanThanh = reader["thoiHanHoanThanh"] as DateTime?,
                                GhiChu = reader["ghiChu"].ToString(),
                                IdTienDoCongViec = reader["idTienDoCongViec"].ToString(),
                                TenNhanSuGiaoViec = reader["TenNhanSuGiaoViec"].ToString(),
                                TenTienDoCongViec = reader["tienDoCongViec"].ToString()
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
                                TenNhanSuGiaoViec = reader["TenNhanSuGiaoViec"].ToString(),
                                TenTienDoCongViec = reader["tienDoCongViec"].ToString()
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
                        TenNhanSuNhanViec = reader["NguoiNhanViec"].ToString()
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
                                SoLuongNhanSuChuDong = reader["soLuongNhanSuChuDong"].ToString(),
                                DuongDanTaiLieu = reader["duongDanTaiLieu"].ToString(),
                                DuongDanHinhAnh = reader["duongDanHinhAnh"].ToString(),
                                TenTaiLieu = reader["tenTaiLieu"].ToString(),
                                TenHinhAnh = reader["tenHinhAnh"].ToString()
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
                using (SqlCommand command = new SqlCommand("proc_LayThongBaoTheoMaTaiKhoan", connection))
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
                                TenNhanSuGiaoViec = reader["TenNhanSu"].ToString(),
                                Ten = reader["TenCongViec"].ToString(),
                                TenHanhDong = reader["TenHanhDong"].ToString()
                            };
                            resultList.Add(taskInfo);
                        }
                    }
                }
            }
            return resultList;
        }
        public string BaoCaoDangTienHanhCongViec(string idCongViec, string idTaiKhoanKhoiTao, string ghiChu)
        {
            string query = "proc_baoCaoDangTienHanhCongViec";
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Add parameters
                cmd.Parameters.AddWithValue("@idCongViec", idCongViec);
                cmd.Parameters.AddWithValue("@idTaiKhoanKhoiTao", idTaiKhoanKhoiTao);
                cmd.Parameters.AddWithValue("@ghiChu", ghiChu);

                // Define the output parameter
                SqlParameter outputParam = new SqlParameter("@idLichSuCongViec", SqlDbType.VarChar, 20);
                outputParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(outputParam);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return outputParam.Value.ToString();  // Return the output parameter value
                }
                catch (Exception ex)
                {
                    // Handle exception
                    return string.Empty;  // Return empty if error occurs
                }
            }
        }
        public string BaoCaoHoanThanhCongViec(string idCongViec, string idTaiKhoanKhoiTao, string ghiChu)
        {
            string query = "proc_baoCaoHoanThanhCongViec";
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Add parameters
                cmd.Parameters.AddWithValue("@idCongViec", idCongViec);
                cmd.Parameters.AddWithValue("@idTaiKhoanKhoiTao", idTaiKhoanKhoiTao);
                cmd.Parameters.AddWithValue("@ghiChu", ghiChu);

                // Define the output parameter
                SqlParameter outputParam = new SqlParameter("@idLichSuCongViec", SqlDbType.VarChar, 20);
                outputParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(outputParam);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return outputParam.Value.ToString();  // Return the output parameter value
                }
                catch (Exception ex)
                {
                    // Handle exception
                    return string.Empty;  // Return empty if error occurs
                }
            }
        }

        public string BaoCaoDangTienHanhCongViecOnline(string idCongViec, string idTaiKhoanKhoiTao, string thoiGianBaoCao, string ghiChu)
        {
            string query = "proc_baoCaoDangTienHanhCongViecOnline";
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Add parameters
                cmd.Parameters.AddWithValue("@idCongViec", idCongViec);
                cmd.Parameters.AddWithValue("@idTaiKhoanKhoiTao", idTaiKhoanKhoiTao);
                cmd.Parameters.AddWithValue("@thoiGianBaoCao", thoiGianBaoCao);
                cmd.Parameters.AddWithValue("@ghiChu", ghiChu);

                // Define the output parameter
                SqlParameter outputParam = new SqlParameter("@idLichSuCongViec", SqlDbType.VarChar, 20);
                outputParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(outputParam);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return outputParam.Value.ToString();  // Return the output parameter value
                }
                catch (Exception ex)
                {
                    // Handle exception
                    return string.Empty;  // Return empty if error occurs
                }
            }
        }
        public string BaoCaoHoanThanhCongViecOnline(string idCongViec, string idTaiKhoanKhoiTao, string thoiGianBaoCao, string ghiChu)
        {
            string query = "proc_baoCaoHoanThanhCongViecOnline";
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Add parameters
                cmd.Parameters.AddWithValue("@idCongViec", idCongViec);
                cmd.Parameters.AddWithValue("@idTaiKhoanKhoiTao", idTaiKhoanKhoiTao);
                cmd.Parameters.AddWithValue("@thoiGianBaoCao", thoiGianBaoCao);
                cmd.Parameters.AddWithValue("@ghiChu", ghiChu);

                // Define the output parameter
                SqlParameter outputParam = new SqlParameter("@idLichSuCongViec", SqlDbType.VarChar, 20);
                outputParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(outputParam);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return outputParam.Value.ToString();  // Return the output parameter value
                }
                catch (Exception ex)
                {
                    // Handle exception
                    return string.Empty;  // Return empty if error occurs
                }
            }
        }
        public bool ThemTaiLieu(BaoCao baoCao)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("proc_themTaiLieu", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ten", baoCao.Ten);
                cmd.Parameters.AddWithValue("@loai", baoCao.Loai);
                cmd.Parameters.AddWithValue("@duongDan", baoCao.DuongDan);
                cmd.Parameters.AddWithValue("@idLichSuCongViec", baoCao.IdLichSuCongViec);
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
        public bool ThemHinhAnh(BaoCao baoCao)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("proc_themHinhAnh", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ten", baoCao.Ten);
                cmd.Parameters.AddWithValue("@loai", baoCao.Loai);
                cmd.Parameters.AddWithValue("@duongDan", baoCao.DuongDan);
                cmd.Parameters.AddWithValue("@idLichSuCongViec", baoCao.IdLichSuCongViec);
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
        public List<DanhSachBaoCao> LayDanhSachBaoCao(string idCongViec)
        {
            List<DanhSachBaoCao> danhSachCongViec = new List<DanhSachBaoCao>();
            SqlConnection conn = SqlConnectionData.Connect();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("proc_layDanhSachBaoCao", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCongViec", idCongViec);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DanhSachBaoCao baoCao = new DanhSachBaoCao
                    {
                        NoiDung = reader["ghiChu"].ToString(),
                        NgayBaoCao = reader["thoiGianKhoiTao"] as DateTime?,
                        TenAnh = reader["tenHinhAnh"].ToString(),
                        TenFile = reader["tenTaiLieu"].ToString(),
                        DuongDanAnh = reader["duongDanHinhAnh"].ToString(),
                        DuongDanFile = reader["duongDanTaiLieu"].ToString()
                    };
                    danhSachCongViec.Add(baoCao);
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

        //Nhận việc online
        public bool NhanCongViecOnline(string idTaiKhoanNhanViec, string idCongViec, string loaiNhanViec)
        {
            string query = "proc_NhanViecOnline";
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@idTaiKhoanNhanViec", idTaiKhoanNhanViec);
                    cmd.Parameters.AddWithValue("@idCongViec", idCongViec);
                    cmd.Parameters.AddWithValue("@loaiNhanViec", loaiNhanViec);

                    conn.Open();

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
                catch (SqlException ex)
                {
                    return false;
                }
            }
        }

        public void TaoLichSuNhanViec(string idCongViec, string idTaiKhoanNhan)
        {
            string query = "proc_TaoLichSuNhanViec";

            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idCongViec", idCongViec);
                    command.Parameters.AddWithValue("@idTaiKhoanNhan", idTaiKhoanNhan);
                    command.ExecuteNonQuery();
                }
            }
        }

        //Tạo đơn xin điều chỉnh phân công
        public bool TaoDonXinDieuChinhPhanCong(string idCongViec, string idTaiKhoanNhanViec, string liDo)
        {
            string query = "proc_TaoDonXinDieuChinhPhanCong";
            try
            {
                using (SqlConnection con = SqlConnectionData.Connect())
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@idCongViec", idCongViec);
                        command.Parameters.AddWithValue("@idTaiKhoanKhoiTao", idTaiKhoanNhanViec);
                        command.Parameters.AddWithValue("@liDo", liDo);
                        command.ExecuteNonQuery();
                    }
                }
                return true;
            } catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi tạo đơn xin điều chỉnh phân công: " + ex.Message);
            }
            return false;
        }

        //Hiên thị danh sách điều chỉnh phân công
        public List<TaskInfo> HienThiDanhSachDieuChinhPhanCong(string idTaiKhoanGiaoViec)
        {
            string query = "proc_HienThiDanhSachDieuChinhPhanCong";
            List<TaskInfo> taskInfos = new List<TaskInfo>();  // Khai báo danh sách chứa các đối tượng TaskInfo
            try
            {
                using (SqlConnection con = SqlConnectionData.Connect())
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@idTaiKhoanGiaoViec", idTaiKhoanGiaoViec);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                TaskInfo taskInfo = new TaskInfo
                                {
                                    Id = reader["IdCongViec"].ToString(),
                                    Ten = reader["TenCongViec"].ToString(),
                                    ThoiHanHoanThanh = reader.GetDateTime(reader.GetOrdinal("NgayKetThuc")),
                                    TenNhanSuGiaoViec = reader["TenTaiKhoanGiaoViec"].ToString(),
                                    TenTienDoCongViec = reader["TienDoCongViec"].ToString(),
                                    LiDoDieuChinh = reader["LiDo"].ToString()
                                };

                                // Thêm đối tượng TaskInfo vào danh sách
                                taskInfos.Add(taskInfo);
                            }
                        }
                    }
                }
                return taskInfos;  // Trả về danh sách TaskInfo
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi hiển thị đơn xin điều chỉnh phân công: " + ex.Message);
            }
            return taskInfos;  // Trả về danh sách (dù có thể rỗng nếu có lỗi)
        }

        public bool XacNhanDieuChinhPhanCong(string idCongViec, string idTaiKhoanKhoiTao)
        {
            string query = "proc_XoaTaiKhoanNhanViecXinDieuChinhPhanCong";
            try
            {
                using (SqlConnection con = SqlConnectionData.Connect())
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@idCongViec", idCongViec);
                        command.Parameters.AddWithValue("@idTaiKhoanKhoiTao", idTaiKhoanKhoiTao);
                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi xác nhận điều chỉnh phân công: " + ex.Message);
            }
            return false;
        }

        public bool TuChoiDieuChinhPhanCong(string idCongViec, string idTaiKhoanKhoiTao)
        {
            string query = "proc_XuLyTuChoiDonXinDieuChinhPhanCong";
            try
            {
                using (SqlConnection con = SqlConnectionData.Connect())
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@idCongViec", idCongViec);
                        command.Parameters.AddWithValue("@idTaiKhoanKhoiTao", idTaiKhoanKhoiTao);

                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi từ chối điều chỉnh phân công: " + ex.Message);
            }
            return false;

        }



        //giaoviecmoi
        public bool GiaoViec(string loaiGiaoViec, ThongTinGiaoViec ThongTinCongViec)
        {
            string query = "proc_GiaoViec";
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@loaiGiaoViec", loaiGiaoViec);
                cmd.Parameters.AddWithValue("@ten", ThongTinCongViec.Ten);
                cmd.Parameters.AddWithValue("@moTa", ThongTinCongViec.MoTa);
                cmd.Parameters.AddWithValue("@thoiHanHoanThanh", ThongTinCongViec.ThoiHanHoanThanh);
                cmd.Parameters.AddWithValue("@idTaiKhoanGiaoViec", ThongTinCongViec.IdTaiKhoanGiaoViec);
                cmd.Parameters.AddWithValue("@idBoPhanGiaoViec", ThongTinCongViec.IdBoPhanGiaoViec);
                cmd.Parameters.AddWithValue("@danhSachTaiKhoanNhanViec", ThongTinCongViec.DanhSachTaiKhoanNhanViec);
                cmd.Parameters.AddWithValue("@danhSachBoPhanNhanViec", ThongTinCongViec.DanhSachBoPhanNhanViec);
                cmd.Parameters.AddWithValue("@danhSachHinhAnh", ThongTinCongViec.DanhSachHinhAnh);
                cmd.Parameters.AddWithValue("@danhSachTaiLieu", ThongTinCongViec.DanhSachTaiLieu);
                cmd.Parameters.AddWithValue("@idCongViecGoc", ThongTinCongViec.IdCongViecGoc);
                cmd.Parameters.AddWithValue("@soLuongNhanSuChuDong", ThongTinCongViec.SoLuongNhanSuChuDong);
                cmd.Parameters.AddWithValue("@tenHinhAnh", ThongTinCongViec.TenHinhAnh);
                cmd.Parameters.AddWithValue("@tenTaiLieu", ThongTinCongViec.TenTaiLieu);
                conn.Open();
                cmd.ExecuteNonQuery();
                
            }
            return true;
        }
        public DateTime? ThoiHanHoanThanhCongViecGoc(string idCongViecGoc)
        {
            string query = "proc_ThoiHanHoanThanhCongViecGoc";
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Add input parameter
                cmd.Parameters.AddWithValue("@idCongViecGoc", idCongViecGoc);

                // Define the output parameter
                SqlParameter outputParam = new SqlParameter("@thoiHanHoanThanh", SqlDbType.DateTime);
                outputParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(outputParam);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    // Return the output parameter value
                    return outputParam.Value != DBNull.Value ? Convert.ToDateTime(outputParam.Value) : DateTime.MinValue;
                }
                catch (Exception ex)
                {
                    // Handle exception
                    return DateTime.MinValue;  // Return minimum value of DateTime if error occurs
                }
            }
        }
        public bool KiemTraCongViecChuDong(string idTask)
        {
            string query = "proc_kiemTraCongViecChuDong";
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdTask", idTask);
                conn.Open();
                cmd.ExecuteNonQuery();
                var result = cmd.ExecuteScalar(); // Lấy kết quả đầu tiên
                return result != null;
            }
        }
        public string KiemTraCongViecPhatSinh(string idTask)
        {
            string query = "proc_kiemTraCongViecPhatSinh";
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@IdTask", idTask);

                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        return result.ToString(); // Trả về idCongViecGoc
                    }
                    else
                    {
                        return null; // Không tìm thấy công việc phát sinh
                    }
                }
            }
        }


        public bool XoaCongViec(string idTask) 
        {
            string query = "proc_XoaCongViec";
            try
            {
                using (SqlConnection con = SqlConnectionData.Connect())
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@id", idTask);
                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("XoaCongViec: " + ex.Message);
            }
            return false;

        }
        public bool XoaCongViecPhatSinh(string idTask)
        {
            string query = "proc_XoaCongViecPhatSinh";
            try
            {
                using (SqlConnection con = SqlConnectionData.Connect())
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@id", idTask);
                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("XoaCongViecPhatSinh: " + ex.Message);
            }
            return false;

        }

        public bool CapNhatCongViec(string idCongViec, string loaiGiaoViec, ThongTinGiaoViec ThongTinCongViec)
        {
            string query = "proc_CapNhatCongViec";
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@loaiGiaoViec", loaiGiaoViec);
                cmd.Parameters.AddWithValue("@id", idCongViec);
                cmd.Parameters.AddWithValue("@ten", ThongTinCongViec.Ten);
                cmd.Parameters.AddWithValue("@moTa", ThongTinCongViec.MoTa);
                cmd.Parameters.AddWithValue("@thoiHanHoanThanh", ThongTinCongViec.ThoiHanHoanThanh);
                cmd.Parameters.AddWithValue("@idTaiKhoanGiaoViec", ThongTinCongViec.IdTaiKhoanGiaoViec);
                
                cmd.Parameters.AddWithValue("@danhSachTaiKhoanNhanViec", ThongTinCongViec.DanhSachTaiKhoanNhanViec);
                cmd.Parameters.AddWithValue("@danhSachBoPhanNhanViec", ThongTinCongViec.DanhSachBoPhanNhanViec);
                cmd.Parameters.AddWithValue("@danhSachHinhAnh", ThongTinCongViec.DanhSachHinhAnh);
                cmd.Parameters.AddWithValue("@danhSachTaiLieu", ThongTinCongViec.DanhSachTaiLieu);
                
                cmd.Parameters.AddWithValue("@soLuongNhanSuChuDong", ThongTinCongViec.SoLuongNhanSuChuDong);
                cmd.Parameters.AddWithValue("@tenHinhAnh", ThongTinCongViec.TenHinhAnh);
                cmd.Parameters.AddWithValue("@tenTaiLieu", ThongTinCongViec.TenTaiLieu);
                conn.Open();
                cmd.ExecuteNonQuery();

            }
            return true;
        }

        public void TaoCongViecTuYKien(string tenCongViec, string tenBoPhan, string moTa, string thoiGianGhiNhan, string thoiHanHoanThanh)
        {
            try
            {
                string query = "proc_TaoCongViecTuYKien";
                using (SqlConnection conn = SqlConnectionData.Connect())
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ten", tenCongViec);
                    cmd.Parameters.AddWithValue("@moTa", moTa);
                    cmd.Parameters.AddWithValue("@thoiGianGhiNhan", thoiGianGhiNhan);
                    cmd.Parameters.AddWithValue("@tenBoPhan", tenBoPhan);
                    cmd.Parameters.AddWithValue("@thoiHanHoanThanh", thoiHanHoanThanh);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool NhanViec(string loaiNhanViec, string idCongViec, string idTaiKhoanNhanViec)
        {
            try
            {
                using (SqlConnection connection = SqlConnectionData.Connect())
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("proc_NhanViec", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số cho stored procedure
                        command.Parameters.AddWithValue("@loaiNhanViec", loaiNhanViec);
                        command.Parameters.AddWithValue("@idCongViec", idCongViec);
                        command.Parameters.AddWithValue("@idTaiKhoanNhanViec", idTaiKhoanNhanViec);

                        // Thực thi stored procedure
                        int rowsAffected = command.ExecuteNonQuery();

                        // Kiểm tra nếu có dòng nào bị ảnh hưởng
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Log lỗi (nếu cần) và trả về false
                Console.WriteLine("Lỗi khi nhận việc: " + ex.Message);
                return false;
            }
        }
        public DateTime LayThoiHanHoanThanh(string idCongViecGoc)
        {
            DateTime thoiHanHoanThanh = DateTime.MaxValue; // Giá trị mặc định nếu không tìm thấy
            // Thay bằng chuỗi kết nối của bạn

            using (SqlConnection connection = SqlConnectionData.Connect())
            {
                using (SqlCommand command = new SqlCommand("proc_LayThoiHanHoanThanh", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idCongViec", idCongViecGoc);

                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && DateTime.TryParse(result.ToString(), out DateTime parsedDate))
                    {
                        thoiHanHoanThanh = parsedDate;
                    }
                }
            }
            return thoiHanHoanThanh;
        }
        public Personnel LayThongTinTheoMaTaiKhoan(string idTaiKhoan)
        {
            Personnel personnel = null; // Initialize as null to handle cases where no data is found.
            string query = "proc_LayThongTinTheoMaTaiKhoan";

            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idTaiKhoan", idTaiKhoan);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) // Ensure there is data to read.
                        {
                            personnel = new Personnel
                            {
                                Ten = reader["Ten"].ToString(),
                                Email = reader["Email"].ToString(),                                
                                Sdt = reader["SDT"].ToString()
                            };
                        }
                    }
                }
            }
            return personnel; // Will return null if no matching record is found.
        }

        public string LayIdCongViec()
        {
            string result = null;
            try
            {
                using (SqlConnection connection = SqlConnectionData.Connect())
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("proc_LayIdCongViec", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số cho stored procedure
                        //command.Parameters.AddWithValue("@loaiNhanViec", loaiNhanViec);
                        //command.Parameters.AddWithValue("@idCongViec", idCongViec);
                        //command.Parameters.AddWithValue("@idTaiKhoanNhanViec", idTaiKhoanNhanViec);

                        // Thực thi stored procedure
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                result = reader["idCongViec"]?.ToString();
                            }
                        }
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                // Log lỗi (nếu cần) và trả về false
                Console.WriteLine("Lỗi khi nhận việc: " + ex.Message);
                return null;
            }
        }
    }
}
