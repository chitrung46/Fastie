using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public static class SqlConnectionData
    {
        private static readonly string connectionString = @"Data Source=DESKTOP-G1KLLU0;Initial Catalog=FASTIE;Integrated Security=True;";

        public static SqlConnection Connect()
        {
            return new SqlConnection(connectionString);
        }
    }

    public class DatabaseAccess
    {
        //For account login
        public static string[] checkLoginDTO(Account acc)
        {
            string[] user = new string[4];
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("proc_checkLogin", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@tendangnhap", acc.TenDangNhap);
            command.Parameters.AddWithValue("@matkhau", acc.MatKhau);

            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    user[0] = reader["id"].ToString();
                    user[1] = reader["idNhanSu"].ToString();
                    user[2] = reader["idBoPhan"].ToString();
                    user[3] = reader["idChucVu"].ToString();
                }
                reader.Close();
                conn.Close();
            }
            else
            {
                return new string[] { "Email hoặc mật khẩu không chính xác!" };
            }

            return user;
        }
        
        //For Decentralization
        public static AccountInfo getAccountInfo(string accountId)
        {
            AccountInfo info = null;
            SqlConnection conn = SqlConnectionData.Connect();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("proc_getAccountInfo", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idTaiKhoan", accountId);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    info = new AccountInfo
                    {
                        TenNhanSu = reader["TenNhanSu"].ToString(),
                        TenBoPhan = reader["TenBoPhan"].ToString(),
                        TenChucVu = reader["TenChucVu"].ToString()
                    };
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy thông tin tài khoản: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return info;
        }
        public static List<AccountInfo> getAllAccountInfo()
        {
            SqlConnection conn = SqlConnectionData.Connect();
            List<AccountInfo> personnel = new List<AccountInfo>();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("proc_getAllPersonnel", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    AccountInfo info = new AccountInfo
                    {
                        TenDangNhap = reader["IdDangNhap"].ToString(),
                        TenNhanSu = reader["TenNhanSu"].ToString(),
                        TenBoPhan = reader["TenBoPhan"].ToString(),
                        TenChucVu = reader["TenChucVu"].ToString()
                    };
                    personnel.Add(info);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy thông tin tài khoản: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return personnel;
        }
        public static List<Permission> getAllPermissionsByAccountId(string accountId)
        {
            List<Permission> permissions = new List<Permission>();
            SqlConnection conn = SqlConnectionData.Connect();

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("proc_getAllPermissionsByAccountId", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idTaiKhoan", accountId);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Permission permission = new Permission
                    {
                        id = reader["IdQuyen"].ToString(),
                        ten = reader["TenQuyen"].ToString(),
                        idQuyenCha = reader["IdQuyenCha"].ToString()
                    };
                    permissions.Add(permission);

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách quyền: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return permissions;
        }

        public static bool deleteAllRoles(string accountId)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("proc_deleteAllRoles", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idTaiKhoan", accountId);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa tất cả quyền: " + ex.Message);
            }
            return true;
        }

        public static List<AccountInfo> getAllPersonnelRoleLess()
        {
            SqlConnection conn = SqlConnectionData.Connect();
            List<AccountInfo> personnelRoleless = new List<AccountInfo>();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("proc_getAllPersonnelRoleless", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    AccountInfo info = new AccountInfo
                    {
                        TenDangNhap = reader["IdDangNhap"].ToString(),
                        TenNhanSu = reader["TenNhanSu"].ToString(),
                        TenBoPhan = reader["TenBoPhan"].ToString(),
                        TenChucVu = reader["TenChucVu"].ToString()
                    };
                    personnelRoleless.Add(info);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách nhân sự không có quyền: " + ex.Message);
            }
            return personnelRoleless;
        }

        public static bool updateRoles(string accountId, string listNameRoles)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("proc_UpdateQuyenTaiKhoan", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idTaiKhoan", accountId);
                cmd.Parameters.AddWithValue("@dsTenQuyen", listNameRoles);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật quyền: " + ex.Message);
            }
            return true;
        }

        public static List<PositionInfo> getPositionList()
        {
            SqlConnection conn = SqlConnectionData.Connect();
            List<PositionInfo> positionList = new List<PositionInfo>();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("proc_getPositionList", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var idChucVu = reader["id"].ToString();
                    var tenChucVu = reader["ten"].ToString();
                    var moTa = reader["moTa"]?.ToString(); 

                    PositionInfo positionInfo = string.IsNullOrEmpty(moTa) ?
                        new PositionInfo(idChucVu, tenChucVu) :
                        new PositionInfo(idChucVu, tenChucVu, moTa);
                    positionList.Add(positionInfo);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách chức vụ: " + ex.Message);
            }
            return positionList;
        }

        public static List<DepartmentInfo> getDepartmentList()
        {
            SqlConnection conn = SqlConnectionData.Connect();
            List<DepartmentInfo> positionList = new List<DepartmentInfo>();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("proc_getDepartmentList", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var idBoPhan = reader["id"].ToString();
                    var tenBoPhan = reader["ten"].ToString();
                    var moTa = reader["moTa"]?.ToString();

                    DepartmentInfo departmentInfo = string.IsNullOrEmpty(moTa) ?
                        new DepartmentInfo(idBoPhan, tenBoPhan) :
                        new DepartmentInfo(idBoPhan, tenBoPhan, moTa);
                    positionList.Add(departmentInfo);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách chức vụ: " + ex.Message);
            }
            return positionList;
        }


        //Define format for role and roleless
        private static List<AccountInfo> getListForRoleAndRoleless(string procedureName, string[] procParameters, string[] parameters)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            List<AccountInfo> listInfo = new List<AccountInfo>();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(procedureName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                for(int i = 0; i < parameters.Length; i++)
                {
                   cmd.Parameters.AddWithValue(procParameters[i], parameters[i]);
                }
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    AccountInfo accountInfo = new AccountInfo
                    {
                        TenDangNhap = reader["IdTaiKhoan"].ToString(),
                        TenNhanSu = reader["TenNhanSu"].ToString(),
                        TenBoPhan = reader["TenBoPhan"].ToString(),
                        TenChucVu = reader["TenChucVu"].ToString()
                    };
                    listInfo.Add(accountInfo);
                }
                conn.Close();
                return listInfo;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách: " + ex.Message);
            }
        }
        //For role
        public static List<AccountInfo> getListByDepartmentIdAndPositionId(string idDepartment, string idPosition)
        {
            string procedureName = "proc_getAccountListHavePermissionByDepartmentIdAndPositionId";
            string[] procParameters = { "@departmentId", "@positionId" };
            string[] parameters = { idDepartment, idPosition };
            return getListForRoleAndRoleless(procedureName, procParameters, parameters);
        }
        public static List<AccountInfo> getDepartmentListwithAllPosition(string idDepartment)
        {
            string procedureName = "proc_getAccountListHavePermissionByDepartmentIdInAllPosition";
            string[] procParameters = { "@departmentId" };
            string[] parameters = { idDepartment };
            return getListForRoleAndRoleless(procedureName, procParameters, parameters);
        }

        public static List<AccountInfo> getPositionListwithAllDepartment(string idPosition)
        {
            string procedureName = "proc_getAccountListHavePermissionByPositionIdInAllDepartment";
            string[] procParameters = { "@positionId" };
            string[] parameters = { idPosition };
            return getListForRoleAndRoleless(procedureName, procParameters, parameters);
        }

        //For roleless
        public static List<AccountInfo> getListByDepartmentIdAndPositionIdRoleLess (string idDepartment, string idPosition)
        {
            string procedureName = "proc_getAccountListHavePermissionByDepartmentIdAndPositionIdRoleless";
            string[] procParameters = { "@departmentId", "@positionId" };
            string[] parameters = { idDepartment, idPosition };
            return getListForRoleAndRoleless(procedureName, procParameters, parameters);
        }
        public static List<AccountInfo> getDepartmentListwithAllPositionRoleLess(string idDepartment)
        {
            string procedureName = "proc_getAccountListHavePermissionByDepartmentIdInAllPositionRoleless";
            string[] procParameters = { "@departmentId" };
            string[] parameters = { idDepartment };
            return getListForRoleAndRoleless(procedureName, procParameters, parameters);
        }
        public static List<AccountInfo> getPositionListwithAllDepartmentRoleLess(string idPosition)
        {
            string procedureName = "proc_getAccountListHavePermissionByPositionIdInAllDepartmentRoleless";
            string[] procParameters = { "@positionId" };
            string[] parameters = { idPosition };
            return getListForRoleAndRoleless(procedureName, procParameters, parameters);
        }

        //Check permission for accessing
        public static bool checkPermission(string accountId, string permissionId)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("proc_checkPermissionAccess", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idTaiKhoan", accountId);
                cmd.Parameters.AddWithValue("@idQuyen", permissionId);
                return (int)cmd.ExecuteScalar() == 1 ? true : false;

            } catch(Exception ex)
            {
                throw new Exception("Lỗi khi kiểm tra quyền: " + ex.Message);
            }
        }






        // Lấy tất cả tài khoản
        public static List<Account> GetAllAccounts()
        {
            List<Account> accounts = new List<Account>();
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                SqlCommand cmd = new SqlCommand("proc_getAllAccount", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Account account = new Account(
                        reader["id"].ToString(),
                        reader["Tên đăng nhập"].ToString(),
                        reader["Mật khẩu"].ToString(),
                        Convert.ToDateTime(reader["Thời gian khởi tạo"]),
                        reader["Thời gian cập nhật"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(reader["Thời gian cập nhật"]),
                        reader["Trạng thái"].ToString()
                    );
                    accounts.Add(account);
                }
            }
            return accounts;
        }

        // Thêm tài khoản mới
        public static string InsertAccount(string tenDangNhap, string matKhau)
        {
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                SqlCommand cmd = new SqlCommand("proc_insertAccount", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@tenDangNhap", tenDangNhap);
                cmd.Parameters.AddWithValue("@matKhau", matKhau);

                conn.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    return "Tài khoản đã được thêm thành công.";
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 50000) // Kiểm tra mã lỗi của RAISERROR
                        return ex.Message;
                    throw;
                }
            }
        }

        // Xóa tài khoản
        public static bool DeleteAccount(string tenDangNhap, string matKhau)
        {
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                SqlCommand cmd = new SqlCommand("proc_deleteAccount", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@tenDangNhap", tenDangNhap);
                cmd.Parameters.AddWithValue("@matKhau", matKhau);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        // Cập nhật tài khoản
        public static bool UpdateAccount(string tenDangNhap, string matKhau)
        {
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                SqlCommand cmd = new SqlCommand("proc_updateAccount", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@tenDangNhap", tenDangNhap);
                cmd.Parameters.AddWithValue("@matKhau", matKhau);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        // Lấy tài khoản theo email
        public static Account GetAccountByEmail(string email)
        {
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                SqlCommand cmd = new SqlCommand("proc_getAccountByEmail", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@Email", email);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new Account(
                        reader["id"].ToString(),
                        reader["tenDangNhap"].ToString(),
                        reader["matKhau"].ToString(),
                        DateTime.MinValue,
                        DateTime.MinValue,
                        reader["email"].ToString()
                    );
                }
                return null;
            }
        }

        // Cập nhật mật khẩu theo email
        public static bool UpdatePassword(string email, string newPassword)
        {
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                SqlCommand cmd = new SqlCommand("proc_updatePassword", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@NewPassword", newPassword);
                cmd.Parameters.AddWithValue("@Email", email);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        #region //Bộ phận
        //Them Bo Phan
        public static void InsertDepartment(Department deparment)
        {
            string query = "proc_insertDepartment";
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                SqlCommand command = new SqlCommand(query, con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ten", deparment.Ten);
                command.Parameters.AddWithValue("@moTa", deparment.MoTa);
                con.Open();
                command.ExecuteNonQuery();
            }
        }

        //Sua Bo Phan
        public static void UpdateDepartment(Department deparment)
        {
            string query = "proc_updateDepartment";
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                SqlCommand command = new SqlCommand(query, con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", deparment.Id);
                command.Parameters.AddWithValue("@ten", deparment.Ten);
                command.Parameters.AddWithValue("@moTa", deparment.MoTa);
                con.Open();
                command.ExecuteNonQuery();
            }
        }

        //Show Toan Bo Bo Phan
        public static List<Department> GetDepartmentList() 
        {
            List<Department> list = new List<Department>();
            string query = "proc_getDepartmentList";
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new Department
                        {
                            Id = reader["id"].ToString(),
                            Ten = reader["ten"].ToString(),
                            MoTa = reader["moTa"].ToString()
                        });
                    }
                }
            }
            return list;
        }

        //Xoa Bo Phan
        public static void DeleteDepartment(string departmentId)
        {
            string query = "proc_deleteDepartment";
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                SqlCommand command = new SqlCommand(query, con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", departmentId);
                con.Open();
                command.ExecuteNonQuery();
            }
        }
        #endregion

        #region //Chức vụ

        //Them Chuc Vu
        public static void InsertPosition(Position position)
        {
            string query = "proc_insertPosition";
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                SqlCommand command = new SqlCommand(query, con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ten", position.Ten);
                command.Parameters.AddWithValue("@moTa", position.MoTa);
                con.Open();
                command.ExecuteNonQuery();
            }
        }

        
        //Show Toan Bo Chuc Vu
        public static List<Position> GetPositionList()
        {
            List<Position> list = new List<Position>();
            string query = "proc_getPositionList";
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new Position
                        {
                            Id = reader["id"].ToString(),
                            Ten = reader["ten"].ToString(),
                            MoTa = reader["moTa"].ToString()
                        });
                    }
                }
            }
            return list;
        }
        //Sua Chuc Vu
        public static void UpdatePosition(Position position)
        {
            string query = "proc_updatePosition";
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                SqlCommand command = new SqlCommand(query, con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", position.Id);
                command.Parameters.AddWithValue("@ten", position.Ten);
                command.Parameters.AddWithValue("@moTa", position.MoTa);
                con.Open();
                command.ExecuteNonQuery();
            }
        }
        //Xoa Chuc Vu
        public static void DeletePosition(string positionId)
        {
            string query = "proc_deletePosition";
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                SqlCommand command = new SqlCommand(query, con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", positionId);
                con.Open();
                command.ExecuteNonQuery();
            }
        }

        #endregion

        #region //Nhân sự
        //Them Nhan Su
        public static void InsertPersonnel(Personnel personnel) 
        {
            string query = "proc_insertPersonnel";
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                SqlCommand command = new SqlCommand(query, con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ten", personnel.Ten);
                command.Parameters.AddWithValue("@email", personnel.Email);
                command.Parameters.AddWithValue("@gioiTinh", personnel.GioiTinh);
                command.Parameters.AddWithValue("@ngaySinh", personnel.NgaySinh);
                command.Parameters.AddWithValue("@ngayVaoLam", personnel.NgayVaoLam);
                command.Parameters.AddWithValue("@sdt", personnel.Sdt);
                con.Open();
                command.ExecuteNonQuery();
            }
        }

        public static List<Personnel> GetPersonnelList() {
            List<Personnel> list = new List<Personnel>();
            string query = "proc_getPersonnelList";
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new Personnel
                        {
                            Id = reader["id"].ToString(),
                            Ten = reader["ten"].ToString(),
                            Email = reader["email"].ToString(),
                            GioiTinh = reader["gioiTinh"].ToString(),
                            NgaySinh = reader.GetDateTime(reader.GetOrdinal("ngaySinh")),
                            NgayVaoLam = reader.GetDateTime(reader.GetOrdinal("ngayVaoLam")),
                            Sdt = reader["sdt"].ToString()
                        });
                    }
                }
            }
            return list;
        }

        public static void DeletePersonnel(string id) 
        {
            string query = "proc_deletePersonnel";
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                SqlCommand command = new SqlCommand(query, con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", id);
                con.Open();
                command.ExecuteNonQuery();
            }
        }
        public static void UpdatePersonnel(Personnel personnel)
        {
            string query = "proc_updatePersonnel";
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                SqlCommand command = new SqlCommand(query, con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", personnel.Id);
                command.Parameters.AddWithValue("@ten", personnel.Ten);
                command.Parameters.AddWithValue("@email", personnel.Email);
                command.Parameters.AddWithValue("@gioiTinh", personnel.GioiTinh);
                command.Parameters.AddWithValue("@ngaySinh", personnel.NgaySinh);
                command.Parameters.AddWithValue("@ngayVaoLam", personnel.NgayVaoLam);
                command.Parameters.AddWithValue("@sdt", personnel.Sdt);
                con.Open();
                command.ExecuteNonQuery();
            }
        }
        #endregion
    }
}
