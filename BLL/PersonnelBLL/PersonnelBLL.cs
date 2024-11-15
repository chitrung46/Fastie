using DTO;
using DAL;
using System.Collections.Generic;

namespace BLL
{
    public class PersonnelBLL
    {
        PersonnelDAL personnelDAL = new PersonnelDAL();
        public List<Personnel> GetPersonnelList()
        {
            return personnelDAL.GetPersonnelList();
        }
        public void InsertPersonnel(Personnel personnel)
        {
            personnelDAL.InsertPersonnel(personnel);
        }

        public void UpdatePersonnel(Personnel personnel)
        {
            personnelDAL.UpdatePersonnel(personnel);
        }

        public void DeletePersonnel(string id)
        {
            personnelDAL.DeletePersonnel(id);
        }

        public List<Personnel> TimKiemNhanSu(string searchValue)
        {
            return personnelDAL.TimKiemNhanSu(searchValue);
        }
        
    }
}
