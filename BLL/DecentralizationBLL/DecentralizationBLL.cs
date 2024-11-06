using DAL.DecentralizationDAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL.DecentralizationBLL
{
    public class DecentralizationBLL
    {
        DecentralizationDAL decentralizationDAL = new DecentralizationDAL();
        public AccountInfo getAccountInfo(string accountId)
        {
            try
            {
                return decentralizationDAL.getAccountInfo(accountId);
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
                return decentralizationDAL.getAllAccountInfo();
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
                return decentralizationDAL.getAllPermissionsByAccountId(accountId);
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
                return decentralizationDAL.deleteAllRoles(accountId);
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
                return decentralizationDAL.getAllPersonnelRoleLess();
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
                return decentralizationDAL.updateRoles(accountId, listNameRoles);
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
                return decentralizationDAL.getPositionList();
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
                return decentralizationDAL.getDepartmentList();
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
                return decentralizationDAL.getListByDepartmentIdAndPositionId(idDepartment, idPosition);
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
                return decentralizationDAL.getDepartmentListwithAllPosition(idDepartment);
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
                return decentralizationDAL.getPositionListwithAllDepartment(idPosition);
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
                return decentralizationDAL.getListByDepartmentIdAndPositionIdRoleLess(idDepartment, idPosition);
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
                return decentralizationDAL.getDepartmentListwithAllPositionRoleLess(idDepartment);
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
                return decentralizationDAL.getPositionListwithAllDepartmentRoleLess(idPosition);
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
                return decentralizationDAL.checkPermission(accountId, permissionId);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL" + ex.Message);
            }
        }
    }
}
