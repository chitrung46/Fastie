using BLL;
using DTO;
using Fastie.Components.LayoutNotification;
using Fastie.Components.LayoutRole;
using Fastie.Components.LayoutTask;
using Fastie.Components.NoPermissionAccessForm;
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
 
        TaskBLL taskBLL = new TaskBLL();
        private TaskForm taskForm;
        public TaskTableForm(TaskForm taskform)
        {
            InitializeComponent();
            this.taskForm = taskform;
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
            List<TaskInfo> tasks = taskBLL.layCongViecTheoID(this.taskForm.IdTaiKhoan);
            if(tasks.Count == 0)
            {
            }

            foreach (var task in tasks)
            {
                var taskForm = new LayoutTaskForm(this.taskForm)
                {
                    TitleTask = task.Ten,
                    Status = task.GhiChu,
                    IdTask = task.Id
                };

                flowLayoutPanelTask.Controls.Add(taskForm);
            }
        }


    }

}
