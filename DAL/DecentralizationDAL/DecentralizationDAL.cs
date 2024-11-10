using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DecentralizationDAL
{
    public class DecentralizationDAL : DatabaseAccess
    {
        //For Decentralization
        public AccountInfo getAccountInfo(string accountId)
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
        public List<AccountInfo> getAllAccountInfo()
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
        public List<Permission> getAllPermissionsByAccountId(string accountId)
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

        public bool deleteAllRoles(string accountId)
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

        public List<AccountInfo> getAllPersonnelRoleLess()
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

        public bool updateRoles(string accountId, string listNameRoles)
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

        public List<PositionInfo> getPositionList()
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

        public List<DepartmentInfo> getDepartmentList()
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
        private List<AccountInfo> getListForRoleAndRoleless(string procedureName, string[] procParameters, string[] parameters)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            List<AccountInfo> listInfo = new List<AccountInfo>();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(procedureName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i < parameters.Length; i++)
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
        public List<AccountInfo> getListByDepartmentIdAndPositionId(string idDepartment, string idPosition)
        {
            string procedureName = "proc_getAccountListHavePermissionByDepartmentIdAndPositionId";
            string[] procParameters = { "@departmentId", "@positionId" };
            string[] parameters = { idDepartment, idPosition };
            return getListForRoleAndRoleless(procedureName, procParameters, parameters);
        }
        public List<AccountInfo> getDepartmentListwithAllPosition(string idDepartment)
        {
            string procedureName = "proc_getAccountListHavePermissionByDepartmentIdInAllPosition";
            string[] procParameters = { "@departmentId" };
            string[] parameters = { idDepartment };
            return getListForRoleAndRoleless(procedureName, procParameters, parameters);
        }

        public List<AccountInfo> getPositionListwithAllDepartment(string idPosition)
        {
            string procedureName = "proc_getAccountListHavePermissionByPositionIdInAllDepartment";
            string[] procParameters = { "@positionId" };
            string[] parameters = { idPosition };
            return getListForRoleAndRoleless(procedureName, procParameters, parameters);
        }

        //For roleless
        public List<AccountInfo> getListByDepartmentIdAndPositionIdRoleLess(string idDepartment, string idPosition)
        {
            string procedureName = "proc_getAccountListHavePermissionByDepartmentIdAndPositionIdRoleless";
            string[] procParameters = { "@departmentId", "@positionId" };
            string[] parameters = { idDepartment, idPosition };
            return getListForRoleAndRoleless(procedureName, procParameters, parameters);
        }
        public List<AccountInfo> getDepartmentListwithAllPositionRoleLess(string idDepartment)
        {
            string procedureName = "proc_getAccountListHavePermissionByDepartmentIdInAllPositionRoleless";
            string[] procParameters = { "@departmentId" };
            string[] parameters = { idDepartment };
            return getListForRoleAndRoleless(procedureName, procParameters, parameters);
        }
        public List<AccountInfo> getPositionListwithAllDepartmentRoleLess(string idPosition)
        {
            string procedureName = "proc_getAccountListHavePermissionByPositionIdInAllDepartmentRoleless";
            string[] procParameters = { "@positionId" };
            string[] parameters = { idPosition };
            return getListForRoleAndRoleless(procedureName, procParameters, parameters);
        }

        //Check permission for accessing
        public bool checkPermission(string accountId, string permissionId)
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

            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi kiểm tra quyền: " + ex.Message);
            }
        }

        //Chức năng tìm kiếm
        public List<AccountInfo> TimKiemNhanSuChuaCoQuyen(string searchValue)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            List<AccountInfo> personnel = new List<AccountInfo>();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("proc_TimKiemTheoNhanSuBoPhanChucVuChuaCoQuyen", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tenTimKiem", searchValue);
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
                throw new Exception("Lỗi khi tìm kiếm nhân sự: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return personnel;
        }
        
        public List<AccountInfo> TimKiemNhanSuCoQuyen(string searchValue)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            List<AccountInfo> personnel = new List<AccountInfo>();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("proc_TimKiemTheoNhanSuBoPhanChucVuCoQuyen", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tenTimKiem", searchValue);
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
                throw new Exception("Lỗi khi tìm kiếm nhân sự: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return personnel;
        }
    }
}
