using DAL.PermissionDAL;
using System;

namespace BLL.PermissionBLL
{
    public class PermissionBLL
    {
        public bool checkPermission(string accountId, string permissionId)
        {
            try { 
                Console.WriteLine("-----------" + accountId + "----------" + permissionId);
                return PermissionDAL.checkPermission(accountId, permissionId);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL" + ex.Message + "---------" + accountId + "----------" + permissionId);
            }
        }
    }
}
