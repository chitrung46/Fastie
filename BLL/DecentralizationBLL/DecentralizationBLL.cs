using DAL.DecentralizationDAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DecentralizationBLL
{
    public class DecentralizationBLL
    {
        //For Decentralization
        public AccountInfo getAccountInfo(string accountId)
        {
            try
            {
                return DecentralizationDAL.getAccountInfo(accountId);
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
                return DecentralizationDAL.getAllAccountInfo();
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
                return DecentralizationDAL.getAllPermissionsByAccountId(accountId);
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
                return DecentralizationDAL.deleteAllRoles(accountId);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL" + ex.Message);
            }
        }

        public List<AccountInfo> getAllPersonnelRoleLess()
        {
            try
            {
                return DecentralizationDAL.getAllPersonnelRoleLess();
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
                return DecentralizationDAL.updateRoles(accountId, listNameRoles);
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
                return DecentralizationDAL.getPositionList();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL" + ex.Message);
            }
        }

        public List<DepartmentInfo> getDepartmentList()
        {
            try
            {
                return DecentralizationDAL.getDepartmentList();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL" + ex.Message);
            }
        }

        //For have Role
        public List<AccountInfo> getListByDepartmentIdAndPositionId(string idDepartment, string idPosition)
        {
            try
            {
                return DecentralizationDAL.getListByDepartmentIdAndPositionId(idDepartment, idPosition);
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
                return DecentralizationDAL.getDepartmentListwithAllPosition(idDepartment);
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
                return DecentralizationDAL.getPositionListwithAllDepartment(idPosition);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL" + ex.Message);
            }
        }
        //For Roleless
        public List<AccountInfo> getListByDepartmentIdAndPositionIdRoleLess(string idDepartment, string idPosition)
        {
            try
            {
                return DecentralizationDAL.getListByDepartmentIdAndPositionIdRoleLess(idDepartment, idPosition);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL" + ex.Message);
            }
        }
        public List<AccountInfo> getDepartmentListwithAllPositionRoleLess(string idDepartment)
        {
            try
            {
                return DecentralizationDAL.getDepartmentListwithAllPositionRoleLess(idDepartment);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL" + ex.Message);
            }
        }
        public List<AccountInfo> getPositionListwithAllDepartmentRoleLess(string idPosition)
        {
            try
            {
                return DecentralizationDAL.getPositionListwithAllDepartmentRoleLess(idPosition);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL" + ex.Message);
            }
        }

        //Chech Permission for Accessing
        public bool checkPermission(string accountId, string permissionId)
        {
            try
            {
                return DecentralizationDAL.checkPermission(accountId, permissionId);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL" + ex.Message);
            }
        }
    }
}
