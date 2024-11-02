using DTO;
using DAL;
using System.Collections.Generic;

namespace BLL
{
    public class PersonnelBLL
    {
        public List<Personnel> GetPersonnelList()
        {
            return PersonnelDAL.GetPersonnelList();
        }
        public void InsertPersonnel(Personnel personnel)
        {
            PersonnelDAL.InsertPersonnel(personnel);
        }

        public void UpdatePersonnel(Personnel personnel)
        {
            PersonnelDAL.UpdatePersonnel(personnel);
        }

        public void DeletePersonnel(string id)
        {
            PersonnelDAL.DeletePersonnel(id);
        }
    }
}
