using DTO;
using DAL;
using System.Collections.Generic;

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
