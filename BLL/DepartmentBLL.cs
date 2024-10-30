using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class DepartmentBLL
    {
        private readonly DepartmentAccess departmentAccess = new DepartmentAccess();
        public void InsertDepartmentBLL(Department boPhan)
        {
            departmentAccess.InsertDepartmentDAL(boPhan);
        }

        public void UpdateDepartmentBLL(Department boPhan)
        {
            departmentAccess.UpdateDepartmentDAL(boPhan);
        }

        public List<Department> GetDepartmentListBLL()
        {
            return departmentAccess.GetDepartmentListDAL();
        }

        public void DeleteDepartmentBLL(string departmentId)
        {
            departmentAccess.DeleteDepartMentDAL(departmentId);
        }
    }
}
