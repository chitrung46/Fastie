using DTO;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PositionAccess : DatabaseAccess
    {
        public void InsertPositionDAL(Position chucVu)
        {
            InsertPosition(chucVu);
        }

        public List<Position> GetPositionListDAL()
        {
            List<Position> list = GetPositionList();
            return list;
        }

        public void UpdatePositionDAL (Position chucVu)
        {
            UpdatePosition(chucVu);
        }

        public void DeletePositionDAL(string id) 
        { 
            DeletePosition(id);     
        }

    }
}
