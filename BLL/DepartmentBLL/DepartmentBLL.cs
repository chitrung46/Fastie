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
        public void InsertDepartment(Department deparment)
        {
            DepartmentDAL.InsertDepartment(deparment);
        }

        public void UpdateDepartment(Department deparment)
        {
            DepartmentDAL.UpdateDepartment(deparment);
        }

        public List<Department> GetDepartmentList()
        {
            List<Department> list = DepartmentDAL.GetDepartmentList();
            return list;
        }

        public void DeleteDepartment(string departmentId)
        {
            DepartmentDAL.DeleteDepartment(departmentId);
        } 
    }
}
