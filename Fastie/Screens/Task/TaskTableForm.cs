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

        public void LoadTaskTable()
        {
            LoadDataTask();
            LoadDataNotification();
        }
        private void LoadDataNotification()
        {
            flowLayoutPanelNotification.Controls.Clear();

            List<TaskInfo> workHistoryList = taskBLL.LayLichSuCongViec(this.taskForm.IdTaiKhoan);

            if (workHistoryList.Count == 0)
            {
                lblShowNoNotification.Visible = true;
            }
            else
            {

                foreach (var history in workHistoryList)
                {
                    var notificationForm = new NotificationForm
                    {
                        TaskName = history.Ten,
                        AssignerName = history.GhiChu // Sử dụng ghi chú làm tên người giao việc trong ví dụ này
                    };
                    flowLayoutPanelNotification.Controls.Add(notificationForm);
                }
                lblShowNoNotification.Visible = false;
            }
        }


        private void LoadDataTask()
        {
            flowLayoutPanelTask.Controls.Clear();
            List<TaskInfo> tasks = taskBLL.layCongViecTheoID(this.taskForm.IdTaiKhoan);
            if(tasks.Count == 0)
            {
                lblShowNoTask.Visible = true;
            }
            else
            {
                foreach (var task in tasks)
                {
                    var taskForm = new LayoutTaskForm(this.taskForm)
                    {
                        TitleTask = task.Ten,
                        Status = task.TenTienDoCongViec,
                        IdTask = task.Id
                    };

                    flowLayoutPanelTask.Controls.Add(taskForm);
                }
                lblShowNoTask.Visible = false;
            }
        }


    }

}
