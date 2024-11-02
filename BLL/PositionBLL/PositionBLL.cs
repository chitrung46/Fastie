using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PositionBLL
    {
        public List<Position> GetPositionList()
        {
            return PositionDAL.GetPositionList();
        }
        public void InsertPosition(Position position)
        {
            PositionDAL.InsertPosition(position);
        }

        public void UpdatePosition(Position position)
        {
            PositionDAL.UpdatePosition(position);
        }

        public void DeletePosition(string id) 
        {
            PositionDAL.DeletePosition(id);
        }
    }
}
