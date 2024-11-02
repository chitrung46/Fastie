using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DepartmentDAL;
using DTO;

namespace BLL.DepartmentBLL
{
    public class DepartmentBLL
    {
        public void InsertDepartmentDAL(Department deparment)
        {
            DepartmentDAL.InsertDepartment(deparment);
        }

        public void UpdateDepartmentDAL(Department deparment)
        {
            DepartmentDAL.UpdateDepartment(deparment);
        }

        public List<Department> GetDepartmentListDAL()
        {
            List<Department> list = DepartmentDAL.GetDepartmentList();
            return list;
        }

        public void DeleteDepartMentDAL(string departmentId)
        {
            DepartmentDAL.DeleteDepartment(departmentId);
        } 
    }
}
