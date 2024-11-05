using DAL.PermissionDAL;
using System;

namespace BLL.PermissionBLL
{
    public class PermissionBLL
    {
        public bool checkPermission(string accountId, string permissionId)
        {
            try { 
            
                return PermissionDAL.checkPermission(accountId, permissionId);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL" + ex.Message);
            }
        }
    }
}
