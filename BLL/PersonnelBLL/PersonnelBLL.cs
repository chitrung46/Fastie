using DTO;
using DAL;
using System.Collections.Generic;
using System;

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

        public bool DeletePersonnel(string id)
        {

            try
            {
                return personnelDAL.DeletePersonnel(id);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Personnel> TimKiemNhanSu(string searchValue)
        {
            return personnelDAL.TimKiemNhanSu(searchValue);
        }
        
    }
}
