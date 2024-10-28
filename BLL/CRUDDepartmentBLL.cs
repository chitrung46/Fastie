using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class CRUDDepartmentBLL
    {
        private readonly CRUDDepartmentAccess cRUDDepartmentAccess = new CRUDDepartmentAccess();
        public void InsertDepartmentDAL(BoPhanDTO boPhan)
        {
            cRUDDepartmentAccess.InsertDepartmentDAL(boPhan);
        }

        public void EditDepartmentDAL(BoPhanDTO boPhan)
        {
            cRUDDepartmentAccess.EditDepartmentDAL(boPhan);
        }

        public List<BoPhanDTO> GetDepartmentListDAL()
        {
            return cRUDDepartmentAccess.GetDepartmentListDAL();
        }

        public void DeleteDepartmentDAL(string departmentId)
        {
            cRUDDepartmentAccess.DeleteDepartMentDAL(departmentId);
        }
    }
}
