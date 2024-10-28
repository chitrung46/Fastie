using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CRUDPositionBLL
    {
        private readonly CRUDPositionAccess cRUDPositionAccess = new CRUDPositionAccess();
        public void InsertPositionDAL(ChucVuDTO chucVu)
        {
            cRUDPositionAccess.InsertPositionDAL(chucVu);
        }

        public List<ChucVuDTO> GetPositionListDAL()
        {
            return cRUDPositionAccess.GetPositionListDAL();
        }

        public void EditPositionDAL(ChucVuDTO chucVu)
        {
            cRUDPositionAccess.EditPositionDAL(chucVu);
        }

        public void DeletePositionDAL(string id) 
        {
            cRUDPositionAccess.DeletePositionDAL(id);
        }
    }
}
