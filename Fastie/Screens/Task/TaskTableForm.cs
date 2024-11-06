using BLL;
using DTO;
using Fastie.Components.LayoutNotification;
using Fastie.Components.LayoutRole;
using Fastie.Components.LayoutTask;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastie.Screens.Task
{
    public partial class TaskTableForm : Form
    {
 
        private readonly TaskBLL taskBLL = new TaskBLL();
        private string currentUserId;
        public TaskTableForm(string userId)
        {
            InitializeComponent();
            currentUserId = userId;
        }
        private void TaskTableForm_Load_1(object sender, EventArgs e)
        {
            LoadDataNotification();
            LoadDataTask();
        }
        private void LoadDataNotification()
        {
            flowLayoutPanelNotification.Controls.Clear();
            for (int i = 0; i < 20; i++)
            {
                var notificationForm = new NotificationForm
                {
                    TaskName = "Task " + i,
                    AssignerName = "Assigner " + i
                };

                flowLayoutPanelNotification.Controls.Add(notificationForm);
            }
        }

        private void LoadDataTask()
        {
            flowLayoutPanelTask.Controls.Clear();

            List<TaskInfo> tasks = taskBLL.layCongViecTheoID(currentUserId);

            foreach (var task in tasks)
            {
                var taskForm = new LayoutTaskForm
                {
                    TitleTask = task.Ten,
                    Status = task.GhiChu,
                };

                flowLayoutPanelTask.Controls.Add(taskForm);
            }
        }
    }

}
