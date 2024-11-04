using DAL;
using DTO;
using DTO.Task;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TaskBLL
    {
        //private readonly TaskAccess taskAccess = new TaskAccess();

        public List<TaskInfo> GetTaskListBLL()
        {
            return TaskAccess.GetTasksFromDatabase(); 
        }

        public List<TaskWithPersonel> GetTaskPersonelBLL()
        {
            return TaskAccess.GetTaskWithPersonnel();
        }

        public void UpdateTaskStatus(string CongviecID, string newStatus)
        {
            TaskAccess.UpdateTaskStatus(CongviecID, newStatus);
        }

    }
}
