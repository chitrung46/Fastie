using System;
using System.Collections.Generic;
using DAL.DepartmentDAL;
using DAL.TaskDAL;
using DTO;

namespace BLL.DepartmentBLL
{
    public class DepartmentBLL
    {
        DepartmentDAL departmentDAL = new DepartmentDAL();
        public void InsertDepartment(Department deparment)
        {
            departmentDAL.InsertDepartment(deparment);
        }

        public void UpdateDepartment(Department deparment)
        {
            departmentDAL.UpdateDepartment(deparment);
        }

        public List<Department> GetDepartmentList()
        {
            List<Department> list = departmentDAL.GetDepartmentList();
            return list;
        }

        public void DeleteDepartment(string departmentId)
        {
            departmentDAL.DeleteDepartment(departmentId);
        } 
        public List<AcceptTaskPersonnel> LayQuanLiBoPhan(string idBoPhan)
        {
            return departmentDAL.LayQuanLiBoPhan(idBoPhan);
        }

        public List<AcceptTaskPersonnel> LayNhanSuBoPhan(string idBoPhan)
        {
            
            try
            {
                return departmentDAL.LayNhanSuBoPhan(idBoPhan);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi nhận mã bộ phận: {idBoPhan}.", ex);
            }
        }
        public List<Department> TimKiemBoPhan(string searchValue)
        {
            try
            {
                return departmentDAL.TimKiemBoPhan(searchValue);
            } catch (Exception ex)
            {
                throw new Exception($"Lỗi khi tìm kiếm bộ phận: {searchValue}.", ex);
            }   
        }
    }
}
