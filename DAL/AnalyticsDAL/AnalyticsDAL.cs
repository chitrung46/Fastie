using DTO;
using DTO.AnalyticsDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL.AnalyticsDAL
{
    public class AnalyticsDAL : DatabaseAccess
    {
        public List<AnalyticsDTO> LayBoPhanDuaTrenIDTaiKhoan(string accountId)
        {
            List<AnalyticsDTO> departments = new List<AnalyticsDTO>();
            string storedProcedure = "proc_LayBoPhanDuaTrenIDTaiKhoan";

            using (SqlConnection con = SqlConnectionData.Connect())
            {
                SqlCommand command = new SqlCommand(storedProcedure, con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@accountId", accountId);

                con.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    AnalyticsDTO department = new AnalyticsDTO(
                        idBoPhan: reader["id"].ToString(),
                        tenBoPhan: reader["ten"].ToString(),
                        idChucVu: null,
                        tenChucVu: null,
                        idNhanSu: null,
                        tenNhanSu: null
                    );
                    departments.Add(department);
                }
            }
            return departments;
        }

        public List<AnalyticsDTO> LayChucVuDuaTrenBoPhan(string departmentId)
        {
            List<AnalyticsDTO> positions = new List<AnalyticsDTO>();

            using (SqlConnection con = SqlConnectionData.Connect())
            {
                SqlCommand command = new SqlCommand("proc_LayChucVuDuaTrenBoPhan", con);
                command.CommandType = CommandType.StoredProcedure;

                // Debugging output
                Console.WriteLine("Department ID passed to stored procedure: " + departmentId);

                // Add the departmentId parameter
                command.Parameters.AddWithValue("@departmentId", departmentId);

                con.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    AnalyticsDTO position = new AnalyticsDTO(
                        reader["id"].ToString(),
                        reader["ten"].ToString()
                    );
                    positions.Add(position);
                }
                reader.Close();
            }

            return positions;
        }

        public List<AnalyticsDTO> LayNhanSuDuaTrenChucVuVaBoPhan(string departmentId, string positionId)
        {
            List<AnalyticsDTO> personnelList = new List<AnalyticsDTO>();
            string query = "proc_LayNhanSuDuaTrenChucVuVaBoPhan"; // Stored Procedure Name

            using (SqlConnection con = SqlConnectionData.Connect())
            {
                SqlCommand command = new SqlCommand(query, con);
                command.CommandType = CommandType.StoredProcedure;

                // Add parameters
                command.Parameters.AddWithValue("@DepartmentId", departmentId ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@PositionId", positionId ?? (object)DBNull.Value);

                con.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    AnalyticsDTO personnel = new AnalyticsDTO
                    {
                        IdNhanSu = reader["id"].ToString(),
                        TenNhanSu = reader["ten"].ToString()
                    };
                    personnelList.Add(personnel);
                }
                reader.Close();
            }

            return personnelList;
        }
        /*
        public List<AnalyticsDTO> GetAllPositions()
        {
            List<AnalyticsDTO> positions = new List<AnalyticsDTO>();
            string query = "SELECT DISTINCT ChucVu.id, ChucVu.ten FROM ChucVu";

            using (SqlConnection con = SqlConnectionData.Connect())
            {
                SqlCommand command = new SqlCommand(query, con);
                con.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    AnalyticsDTO position = new AnalyticsDTO
                    {
                        IdChucVu = reader["id"].ToString(),
                        TenChucVu = reader["ten"].ToString()
                    };
                    positions.Add(position);
                }
                reader.Close();
            }
            return positions;
        }
        */

        public List<AnalyticsDTO> ThongKeTrangThaiCongViec(string idTaiKhoan, string idBoPhan, string idChucVu, string idNhanSu, DateTime tuNgay, DateTime denNgay)
        {
            Console.WriteLine($"DAL Parameters - AccountId: {idTaiKhoan}, DepartmentId: {idBoPhan}, PositionId: {idChucVu}, PersonnelId: {idNhanSu}, StartDate: {tuNgay}, EndDate: {denNgay}");
            List<AnalyticsDTO> data = new List<AnalyticsDTO>();

            using (SqlConnection con = SqlConnectionData.Connect())
            {
                SqlCommand command = new SqlCommand("proc_ThongKeTrangThaiCongViec1", con);
                command.CommandType = CommandType.StoredProcedure;

                // Thêm tham số vào câu lệnh SQL
                command.Parameters.AddWithValue("@idTaiKhoan", idTaiKhoan);
                command.Parameters.AddWithValue("@idBoPhan", idBoPhan ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@idChucVu", idChucVu ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@idNhanSu", idNhanSu ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@tuNgay", tuNgay);
                command.Parameters.AddWithValue("@denNgay", denNgay);

                con.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string trangThai = reader["TrangThai"].ToString();
                    int soLuong = Convert.ToInt32(reader["SoLuong"]);
                    Console.WriteLine($"DAL Result - TrangThai: {trangThai}, SoLuong: {soLuong}");

                    data.Add(new AnalyticsDTO
                    {
                        TenChucVu = trangThai, // Tên trạng thái
                        IdChucVu = soLuong.ToString() // Số lượng
                    });
                }
            }

            return data;
        }
        public List<AnalyticsDTO> ThongKeHoanThanh(string idTaiKhoan, string idBoPhan, string idChucVu, string idNhanSu, DateTime tuNgay, DateTime denNgay)
        {
            Console.WriteLine($"DAL Parameters - AccountId: {idTaiKhoan}, DepartmentId: {idBoPhan}, PositionId: {idChucVu}, PersonnelId: {idNhanSu}, StartDate: {tuNgay}, EndDate: {denNgay}");
            List<AnalyticsDTO> completionData = new List<AnalyticsDTO>();

            using (SqlConnection con = SqlConnectionData.Connect())
            {
                SqlCommand command = new SqlCommand("proc_ThongKeHoanThanh1", con);
                command.CommandType = CommandType.StoredProcedure;

                // Add parameters to the stored procedure
                command.Parameters.AddWithValue("@idTaiKhoan", idTaiKhoan);
                command.Parameters.AddWithValue("@idBoPhan", string.IsNullOrEmpty(idBoPhan) ? (object)DBNull.Value : idBoPhan);
                command.Parameters.AddWithValue("@idChucVu", string.IsNullOrEmpty(idChucVu) ? (object)DBNull.Value : idChucVu);
                command.Parameters.AddWithValue("@idNhanSu", string.IsNullOrEmpty(idNhanSu) ? (object)DBNull.Value : idNhanSu);
                command.Parameters.AddWithValue("@tuNgay", tuNgay);
                command.Parameters.AddWithValue("@denNgay", denNgay);

                con.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    AnalyticsDTO completionDTO = new AnalyticsDTO
                    {
                        SoLuongDungHan = reader["SoLuongDungHan"] != DBNull.Value ? Convert.ToInt32(reader["SoLuongDungHan"]) : 0,
                        SoLuongTreHan = reader["SoLuongTreHan"] != DBNull.Value ? Convert.ToInt32(reader["SoLuongTreHan"]) : 0
                    };

                    completionData.Add(completionDTO);
                }
                reader.Close();
            }

            return completionData;
        }
        public List<AnalyticsDTO> ThongKeNhanViecChuDongVaDieuChinh(string idTaiKhoan, string idBoPhan, string idChucVu, string idNhanSu, DateTime tuNgay, DateTime denNgay)
        {
            Console.WriteLine($"DAL Parameters - AccountId: {idTaiKhoan}, DepartmentId: {idBoPhan}, PositionId: {idChucVu}, PersonnelId: {idNhanSu}, StartDate: {tuNgay}, EndDate: {denNgay}");
            List<AnalyticsDTO> acceptTaskData = new List<AnalyticsDTO>();

            using (SqlConnection con = SqlConnectionData.Connect())
            {
                SqlCommand command = new SqlCommand("proc_ThongKeNhanViecChuDongVaDieuChinh1", con);
                command.CommandType = CommandType.StoredProcedure;

                // Add parameters to the stored procedure
                command.Parameters.AddWithValue("@idTaiKhoan", idTaiKhoan);
                command.Parameters.AddWithValue("@idBoPhan", string.IsNullOrEmpty(idBoPhan) ? (object)DBNull.Value : idBoPhan);
                command.Parameters.AddWithValue("@idChucVu", string.IsNullOrEmpty(idChucVu) ? (object)DBNull.Value : idChucVu);
                command.Parameters.AddWithValue("@idNhanSu", string.IsNullOrEmpty(idNhanSu) ? (object)DBNull.Value : idNhanSu);
                command.Parameters.AddWithValue("@tuNgay", tuNgay);
                command.Parameters.AddWithValue("@denNgay", denNgay);

                con.Open();


                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    AnalyticsDTO acceptTaskDTO = new AnalyticsDTO
                    {
                        SoLanNhanViecChuDong = reader["SoLanNhanViecChuDong"] != DBNull.Value ? Convert.ToInt32(reader["SoLanNhanViecChuDong"]) : 0,
                        SoLanXinDieuChinh = reader["SoLanXinDieuChinh"] != DBNull.Value ? Convert.ToInt32(reader["SoLanXinDieuChinh"]) : 0
                    };

                    acceptTaskData.Add(acceptTaskDTO);
                }
                reader.Close();
            }

            return acceptTaskData;
        }

        public List<AnalyticsDTO> ThongKeTyLeHoanThanh(string idTaiKhoan, string idBoPhan, string idChucVu, string idNhanSu, DateTime tuNgay, DateTime denNgay)
        {
            List<AnalyticsDTO> completionRateData = new List<AnalyticsDTO>();

            using (SqlConnection con = SqlConnectionData.Connect())
            {
                SqlCommand command = new SqlCommand("proc_ThongKeTyLeHoanThanh", con);
                command.CommandType = CommandType.StoredProcedure;

                // Add parameters to the stored procedure
                command.Parameters.AddWithValue("@idTaiKhoan", idTaiKhoan ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@idBoPhan", idBoPhan ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@idChucVu", idChucVu ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@idNhanSu", idNhanSu ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@tuNgay", tuNgay);
                command.Parameters.AddWithValue("@denNgay", denNgay);

                con.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    AnalyticsDTO dto = new AnalyticsDTO
                    {
                        // Safely parse data with a fallback value
                        SoLuongHoanThanh = reader["SoLuongHoanThanh"] != DBNull.Value
                            ? int.TryParse(reader["SoLuongHoanThanh"].ToString(), out var hoanThanh) ? hoanThanh : 0
                            : 0,

                        SoLuongChuaHoanThanh = reader["SoLuongChuaHoanThanh"] != DBNull.Value
                            ? int.TryParse(reader["SoLuongChuaHoanThanh"].ToString(), out var chuaHoanThanh) ? chuaHoanThanh : 0
                            : 0,

                        TyLeHoanThanh = reader["TyLeHoanThanh"] != DBNull.Value
                            ? decimal.TryParse(reader["TyLeHoanThanh"].ToString(), out var tyLe) ? tyLe : 0
                            : 0,

                        TongSoCongViec = reader["TongSoCongViec"] != DBNull.Value
                            ? int.TryParse(reader["TongSoCongViec"].ToString(), out var tongSo) ? tongSo : 0
                            : 0
                    };

                    completionRateData.Add(dto);
                }



                reader.Close();
            }

            return completionRateData;
        }

        public string LayChuVuID(string accountId)
        {
            string role = "";
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                SqlCommand cmd = new SqlCommand("proc_LayChucVuTuTaiKhoan", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@AccountId", accountId);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    role = reader["TenChucVu"].ToString(); // Lấy tên chức vụ
                }
                con.Close();
            }
            return role;
        }
        public List<AnalyticsDTO> LayTaCaBoPhan()
        {
            List<AnalyticsDTO> departments = new List<AnalyticsDTO>();

            try
            {
                using (SqlConnection con = SqlConnectionData.Connect())
                {
                    SqlCommand command = new SqlCommand("proc_getDepartmentList", con);
                    command.CommandType = CommandType.StoredProcedure;

                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        departments.Add(new AnalyticsDTO
                        {
                            IdBoPhan = reader["id"].ToString(),
                            TenBoPhan = reader["ten"].ToString(),
                            MoTa = reader["moTa"] != DBNull.Value ? reader["moTa"].ToString() : null
                        });
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching departments: {ex.Message}");
            }

            return departments;
        }

        public List<AnalyticsDTO> LayThongKeTyLeHoanThanhTatCaBoPhan(string idTaiKhoan, DateTime tuNgay, DateTime denNgay)
        {
            List<AnalyticsDTO> result = new List<AnalyticsDTO>();

            using (SqlConnection con = SqlConnectionData.Connect())
            {
                SqlCommand command = new SqlCommand("sp_ThongKeTyLeHoanThanhTatCaBoPhan", con);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@idTaiKhoan", idTaiKhoan);
                command.Parameters.AddWithValue("@tuNgay", tuNgay);
                command.Parameters.AddWithValue("@denNgay", denNgay);
                con.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(new AnalyticsDTO
                        {
                            TenBoPhan = reader["tenBoPhan"].ToString(),
                            TyLeHoanThanh = reader["TyLeHoanThanh"] != DBNull.Value
                                ? Convert.ToDecimal(reader["TyLeHoanThanh"])
                                : 0
                        });
                    }
                }
            }

            return result;
        }












    }






}





