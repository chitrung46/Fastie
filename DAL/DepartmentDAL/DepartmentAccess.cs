using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DepartmentAccess:ResetPasswordDAL
    {
        public void InsertDepartmentDAL(Department deparment)
        {
            InsertDepartment(deparment);
        }

        public void UpdateDepartmentDAL(Department deparment) 
        {
            UpdateDepartment(deparment);
        }

        public List<Department> GetDepartmentListDAL ()
        {
            List<Department> list = ResetPasswordDAL.GetDepartmentList();
            return list;
        }

        public void DeleteDepartMentDAL(string departmentId)
        {
            DeleteDepartment(departmentId);
        }
    }
}
