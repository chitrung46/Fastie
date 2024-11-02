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
