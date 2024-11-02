using DAL;
using DAL.PermissionDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.PermissionBLL
{
    public class PermissionBLL
    {
        public bool checkPermission(string accountId, string permissionId)
        {
            try
            {
                return PermissionDAL.checkPermission(accountId, permissionId);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL" + ex.Message);
            }
        }
    }
}
