using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CRUDPersonnelBLL
    {
        private readonly CRUDPersonnelAccess cRUDPersonnelAccess = new CRUDPersonnelAccess();   
        public void InsertPersonnelDAL(NhanSuDTO nhanSu)
        {
            cRUDPersonnelAccess.InsertPersonnelDAL(nhanSu);
        }
    }
}
