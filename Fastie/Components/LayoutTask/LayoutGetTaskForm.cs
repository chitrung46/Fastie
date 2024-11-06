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

        public string TaskId
        {
            get { return taskId; }
            set { taskId = value; }
        }

        public LayoutGetTaskForm(TaskForm taskForm)
        {
            InitializeComponent();
            this.taskForm = taskForm;
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
                taskBLL.capNhatTrangThaiCongViec(taskId, "TD002"); 

                if (this.ParentForm is AcceptTaskForm parentForm)
                {
                    parentForm.LoadDataTaskTable(parentForm.CurrentTaskType);
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
            DetailsTaskForm detailsTaskForm = new DetailsTaskForm(taskForm, taskId);
            taskForm.AddFormInMainLayout(detailsTaskForm);
        }
    }
}
