using BLL;
using DAL;
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

namespace Fastie.Components.LayoutRole
{
    public partial class LayoutGetTaskForm : UserControl
    {
        private string taskName;
        private string taskTime;
        private string taskStatus;
        private string taskJobAssigner;
        private string taskId;
        TaskBLL taskBLL = new TaskBLL();
        private TaskForm taskForm;
        private string currentTaskType;

        public string CurrentTaskType
        {
            get { return currentTaskType; }
            set { currentTaskType = value; }
        }
        public string TaskId
        {
            get { return taskId; }
            set { taskId = value; }
        }

        public LayoutGetTaskForm(TaskForm taskForm, string currentTaskType)
        {
            InitializeComponent();
            this.taskForm = taskForm;
            this.currentTaskType = currentTaskType;
        }

        public string TaskName
        {
            get { return taskName; }
            set { taskName = value; lblTitleTask.Text = value; }
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
        public string JobAssigner
        {
            get { return taskJobAssigner; }
            set { taskJobAssigner = value; lblJobAssigner.Text = value; }
        }

        private void btnGetTask_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(taskId) && !string.IsNullOrEmpty(taskForm.IdTaiKhoan))
            {
                taskBLL.giaoViecChoTaiKhoan(taskForm.IdTaiKhoan, taskId);

              
                if (this.ParentForm is AcceptTaskForm parentForm)
                {
                    if (parentForm.CurrentTaskType == "Việc chủ động")
                    {
                        taskBLL.capNhatTrangThaiCongViec(taskId, "TD002"); 
                    }
                    else if (parentForm.CurrentTaskType == "Việc được giao")
                    {
                        taskBLL.capNhatTrangThaiCongViec(taskId, "TD002"); 
                    }
                }

                if (this.Parent != null)
                {
                    this.Parent.Controls.Remove(this);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy ID công việc hoặc ID tài khoản để nhận.", "Lỗi");
            }
        }




        private void btnDetail_Click(object sender, EventArgs e)
        {
            DetailsTaskForm detailsTaskForm = new DetailsTaskForm(taskForm, this);
            taskForm.AddFormInMainLayout(detailsTaskForm);
        }
    }
}
