using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TaskBLL
    {
        private readonly TaskAccess taskAccess = new TaskAccess();

        public List<TaskInfo> GetTaskListBLL()
        {
            return taskAccess.GetTaskListDAL(); 
        }
    }
}
