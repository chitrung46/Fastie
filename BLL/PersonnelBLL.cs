using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PersonnelBLL
    {
        private readonly PersonnelAccess personnelAccess = new PersonnelAccess();
        public List<Position> GetPositionListBLL()
        {
            return personnelAccess.GetPersonnelListDAL();
        }
        public void InsertPersonnelDAL(Personnel personnel)
        {
            personnelAccess.InsertPersonnelDAL(personnel);
        }

        public void UpdatePersonnelBLL(Personnel personnel)
        {
            personnelAccess.UpdatePersonnelDAL(personnel);
        }

        public void DeletePositionBLL(string id)
        {
            personnelAccess.DeletePersonnelDAL(id);
        }
    }
}
