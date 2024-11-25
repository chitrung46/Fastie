using DTO;
using DAL;
using System.Collections.Generic;
using System;

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

        public bool DeletePosition(string id)
        {
            try
            {
                return positionDAL.DeletePosition(id);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Position> TimKiemChucVu(string searchValue)
        {
            return positionDAL.TimKiemChucVu(searchValue);
        }
    }
}
