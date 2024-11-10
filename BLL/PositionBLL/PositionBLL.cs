using DTO;
using DAL;
using System.Collections.Generic;

namespace BLL
{
    public class PositionBLL
    {

        PositionDAL positionDAL = new PositionDAL();
        public List<Position> GetPositionList()
        {
            return positionDAL.GetPositionList();
        }
        public void InsertPosition(Position position)
        {
            positionDAL.InsertPosition(position);
        }

        public void UpdatePosition(Position position)
        {
            positionDAL.UpdatePosition(position);
        }

        public void DeletePosition(string id) 
        {
            positionDAL.DeletePosition(id);
        }

        public List<Position> TimKiemChucVu(string searchValue)
        {
            return positionDAL.TimKiemChucVu(searchValue);
        }
    }
}
