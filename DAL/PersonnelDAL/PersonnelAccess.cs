using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class PersonnelAccess:DatabaseAccess
    {
        public List<Personnel> GetPersonnelListDAL()
        {
            List<Personnel> list = GetPersonnelList();
            return list;
        }
        public void InsertPersonnelDAL(Personnel personnel)
        {
            InsertPersonnel(personnel); 
        }
        public void UpdatePersonnelDAL(Personnel personnel)
        {
            UpdatePersonnel(personnel);
        }

        public void DeletePersonnelDAL(string id)
        {
            DeletePersonnel(id);
        }
    }
}
