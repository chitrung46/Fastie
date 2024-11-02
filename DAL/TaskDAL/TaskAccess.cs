using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TaskAccess:DatabaseAccess
    {
        public List<TaskInfo> GetTaskListDAL()
        {
            List<TaskInfo> list = DatabaseAccess.GetTasksFromDatabase();
            return list;
        }

    }
}
