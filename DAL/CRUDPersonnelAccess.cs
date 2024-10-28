using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class CRUDPersonnelAccess:DatabaseAccess
    {
        public void InsertPersonnelDAL(NhanSuDTO nhanSu)
        {
            InsertPersonnel(nhanSu); 
        }
    }
}
