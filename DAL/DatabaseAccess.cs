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
    public class SqlConnectionData
    {
        public static SqlConnection Connect()
        {
            string strcon = @"Data Source=DESKTOP-G1KLLU0;Initial Catalog=FASTIE;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(strcon);
            return conn;
        }
    }
    public class DatabaseAccess
    {
        //For account login
        public static string checkLoginDTO(Account acc)
        {
            string user = null;
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
                    user = reader.ToString();
                }
                reader.Close();
                conn.Close();
            }
            else
            {
                return "Email hoặc mật khẩu không chính xác!";
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
                        TenDangNhap = reader["TenDangNhap"].ToString(),
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
                        TenDangNhap = reader["TenDangNhap"].ToString(),
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

        public static List<AccountInfo> getDepartmentListwithAllPosition(string idDepartment)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            List<AccountInfo> department = new List<AccountInfo>();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("proc_getAccountListHavePermissionByDepartmentIdInAllPosition", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@departmentId", idDepartment);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    AccountInfo info = new AccountInfo
                    {
                        TenDangNhap = reader["TenDangNhap"].ToString(),
                        TenNhanSu = reader["TenNhanSu"].ToString(),
                        TenBoPhan = reader["TenBoPhan"].ToString(),
                        TenChucVu = reader["TenChucVu"].ToString()
                    };
                    department.Add(info);
                }
                conn.Close();
                return department;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách bộ phận theo ID: " + ex.Message);
            }
        }

        public static List<AccountInfo> getPositionListwithAllDepartment(string idPosition)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            List<AccountInfo> position = new List<AccountInfo>();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("proc_getAccountListHavePermissionByPositionIdInAllDepartment", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@positionId", idPosition);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    AccountInfo info = new AccountInfo
                    {
                        TenDangNhap = reader["TenDangNhap"].ToString(),
                        TenNhanSu = reader["TenNhanSu"].ToString(),
                        TenBoPhan = reader["TenBoPhan"].ToString(),
                        TenChucVu = reader["TenChucVu"].ToString()
                    };
                    position.Add(info);
                }
                conn.Close();
                return position;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách chức vụ theo ID: " + ex.Message);
            }

        }
    }
}
