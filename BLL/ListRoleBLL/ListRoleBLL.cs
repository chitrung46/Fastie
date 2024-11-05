using DTO.ListRoleDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.ListRoleDAL;
namespace BLL.ListRoleBLL
{
    public class ListRoleBLL
    {
        public List<ListRole> LayDanhSachQuyen()
        {
            return ListRoleDAL.LayDanhSachQuyen();
        }
    }
}
