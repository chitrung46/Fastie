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
        private readonly PositionDAL positionAccess = new PositionDAL();

        public List<Position> GetPositionListBLL()
        {
            return positionAccess.GetPositionListDAL();
        }
        public void InsertPositionBLL(Position position)
        {
            positionAccess.InsertPositionDAL(position);
        }

        public void UpdatePositionBLL(Position position)
        {
            positionAccess.UpdatePositionDAL(position);
        }

        public void DeletePositionBLL(string id) 
        {
            positionAccess.DeletePositionDAL(id);
        }
    }
}
