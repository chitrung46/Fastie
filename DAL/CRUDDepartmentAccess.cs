using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CRUDDepartmentAccess:DatabaseAccess
    {
        public void InsertDepartmentDAL(BoPhanDTO boPhanDTO)
        {
            InsertDepartment(boPhanDTO);
        }

        public void EditDepartmentDAL(BoPhanDTO boPhan) 
        {
            EditDepartment(boPhan);
        }

        public List<BoPhanDTO> GetDepartmentListDAL ()
        {
            List<BoPhanDTO> list = GetDepartmentList();
            return list;
        }

        public void DeleteDepartMentDAL(string departmentId)
        {
            DeleteDepartment(departmentId);
        }
    }
}
