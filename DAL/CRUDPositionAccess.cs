using DTO;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CRUDPositionAccess : DatabaseAccess
    {
        public void InsertPositionDAL(ChucVuDTO chucVu)
        {
            InsertPosition(chucVu);
        }

        public List<ChucVuDTO> GetPositionListDAL()
        {
            List<ChucVuDTO> list = GetPositionList();
            return list;
        }

        public void EditPositionDAL (ChucVuDTO chucVu)
        {
            EditPosition(chucVu);
        }

        public void DeletePositionDAL(string id) 
        { 
            DeletePosition(id);
        
        }
    }
}
