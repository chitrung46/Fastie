using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.PermissionBLL
{
    class PermissionBLL
    {
        public bool checkPermission(string accountId, string permissionId)
        {
            try
            {
                return ResetPasswordDAL.checkPermission(accountId, permissionId);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL" + ex.Message);
            }
        }
    }
}
