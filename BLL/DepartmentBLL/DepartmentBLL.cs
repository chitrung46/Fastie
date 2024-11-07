using System;
using System.Collections.Generic;
using DAL.DepartmentDAL;
using DAL.TaskDAL;
using DTO;

namespace BLL.DepartmentBLL
{
    public class DepartmentBLL
    {
        DepartmentDAL DepartmentDAL = new DepartmentDAL();
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
        public List<AcceptTaskPersonnel> LayQuanLiBoPhan(string idBoPhan)
        {
            return DepartmentDAL.LayQuanLiBoPhan(idBoPhan);
        }

        public List<AcceptTaskPersonnel> LayNhanSuBoPhan(string idBoPhan)
        {
            
            try
            {
                return DepartmentDAL.LayNhanSuBoPhan(idBoPhan);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi nhận mã bộ phận: {idBoPhan}.", ex);
            }
        }
    }
}
