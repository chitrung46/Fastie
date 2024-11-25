using Fastie.Screens.Task;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using BLL;
using DTO;
using Fastie.Components.Toastify;
using System.Security.AccessControl;
namespace Fastie.Components.LayoutTask
{
    public partial class LayoutAssignTaskForm : UserControl
    {
        TaskBLL taskBLL = new TaskBLL();
        private string taskName;
        private string taskTime;
        private string taskStatus;
        private string taskJobAssigner;
        private string idTask;

        private TaskForm taskForm;
        private AssignTaskForm assignTaskForm;
        public LayoutAssignTaskForm(TaskForm taskForm)
        {
            InitializeComponent();
            this.taskForm = taskForm;
        }
        public LayoutAssignTaskForm(TaskForm taskForm, AssignTaskForm assignTaskForm)
        {
            InitializeComponent();
            this.taskForm = taskForm;
            this.assignTaskForm = assignTaskForm;
        }

        public string IdTask
        {
            get { return idTask; }
            set { idTask = value; }
        }

        public string TaskName
        {
            get { return taskName; }
            set { taskName = value; lblTaskName.Text = value; }
        }
        public string TaskTime
        {
            get { return taskTime; }
            set { taskTime = value; lblTaskTime.Text = value; }
        }
        public string TaskStatus
        {
            get { return taskStatus; }
            set { taskStatus = value; btnTaskStatus.Text = value; }
        }
        public string TaskJobAssigner
        {
            get { return taskJobAssigner; }
            set { taskJobAssigner = value; lblJobAssigner.Text = value; }
        }
        private void showMessage(string message, string type)
        {
            LayoutToastify layoutToastify = new LayoutToastify();
            layoutToastify.SetMessage(message, type);
            layoutToastify.Show();
        }
        private void btnGetTask_Click(object sender, EventArgs e)
        {
            DetailsTaskForm detailsTaskForm = new DetailsTaskForm(taskForm, this);
            taskForm.AddFormInMainLayout(detailsTaskForm);
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            if (taskStatus != "Chờ duyệt")
            {
                showMessage("Không thỏa mãn điều kiện duyệt!", "error");
            }
            else
            {
                try
                {
                    bool success = taskBLL.DuyetHoanThanhCongViec(idTask);
                    if (success)
                    {
                        showMessage("Công việc đã được duyệt hoàn thành!", "success");
                    }
                    else
                    {
                        showMessage("Không thể duyệt!", "error");
                    }
                }
                catch (Exception ex)
                {
                    showMessage("Không thể duyệt!", "error");
                }
            }

        }

        private void btnAssignArisingTask_Click(object sender, EventArgs e)
        {
            DetailAssignTaskForm detailAssignTaskForm = new DetailAssignTaskForm("Giao việc phát sinh", idTask, taskForm.IdTaiKhoan, taskForm.IdBoPhan);
            //assignTaskForm.LoadDataAssignTask();
            detailAssignTaskForm.FormClosed += (s, args) => assignTaskForm.LoadDataAssignTask();
            detailAssignTaskForm.Show();
        }
    }
}
