using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Net.Http;

namespace BLL
{
    public class AccountBLL
    {
        //For account login
        AccountAccess accAccess = new AccountAccess();
        public string checkLogin(Account acc)
        {
            if (acc.TenDangNhap == "")
            {
                return "required_email";
            }

            if (acc.MatKhau == "")
            {
                return "required_password";
            }

            string info = accAccess.checkLogin(acc);
            return info;

        }

        //For Decentralization
        public AccountInfo getAccountInfo(string accountId)
        {
            try
            {
                return DatabaseAccess.getAccountInfo(accountId);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL: " + ex.Message);
            }
        }
        public List<AccountInfo> getAllAccountInfo()
        {
            try
            {
                return DatabaseAccess.getAllAccountInfo();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL: " + ex.Message);
            }
        }
        public List<Permission> getAllPermissions(string accountId)
        {
            try
            {
                return DatabaseAccess.getAllPermissionsByAccountId(accountId);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL: " + ex.Message);
            }
        }

        public bool hasPermission(string accountId, string permissionId)
        {
            var permissions = getAllPermissions(accountId);
            return permissions.Any(p => p.id == permissionId);
        }

        public bool deleteAllRoles(string accountId)
        {
            try
            {
                return DatabaseAccess.deleteAllRoles(accountId);
            } catch (Exception ex)
            {
                throw new Exception("Lỗi BLL" + ex.Message);
            }
        }

        public List<AccountInfo> getAllPersonnelRoleLess()
        {
            try
            {
                return DatabaseAccess.getAllPersonnelRoleLess();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL" + ex.Message);
            }
        }

        public bool updateRoles(string accountId, string listNameRoles)
        {
            try
            {
                return DatabaseAccess.updateRoles(accountId, listNameRoles);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL" + ex.Message);
            }
        }
        
        public List<PositionInfo> getPositionList()
        {
            try
            {
                return DatabaseAccess.getPositionList();
            } catch (Exception ex)
            {
                throw new Exception("Lỗi BLL" + ex.Message);
            }
        }

        public List<DepartmentInfo> getDepartmentList()
        {
            try
            {
                return DatabaseAccess.getDepartmentList();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL" + ex.Message);
            }
        }

        public List<AccountInfo> getDepartmentListwithAllPosition(string idDepartment)
        {
            try
            {
                return DatabaseAccess.getDepartmentListwithAllPosition(idDepartment);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL" + ex.Message);
            }
        }

        public List<AccountInfo> getPositionListwithAllDepartment(string idPosition)
        {
            try
            {
                return DatabaseAccess.getPositionListwithAllDepartment(idPosition);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL" + ex.Message);
            }
        }
    }
}