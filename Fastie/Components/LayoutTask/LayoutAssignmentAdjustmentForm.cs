using BLL;
using Fastie.Components.Toastify;
using Fastie.Screens.Task.AssignmentAdjustmentTask;
using Fastie.Screens.Task.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastie.Components.LayoutTask
{
    public partial class LayoutAssignmentAdjustmentForm : UserControl
    {
        private string idCongViec;
        private string taskName;
        private DateTime taskTime;
        private string taskStatus;
        private string taskJobAssigner;
        private string reason;

        private AssignmentAdjustmentTaskForm assignmentAdjustmentTaskForm;
        private TaskForm taskForm;

        TaskBLL taskBLL = new TaskBLL();
        public LayoutAssignmentAdjustmentForm(TaskForm taskForm, AssignmentAdjustmentTaskForm assignmentAdjustmentTaskForm)
        {
            InitializeComponent();
            this.assignmentAdjustmentTaskForm = assignmentAdjustmentTaskForm;
            this.taskForm = taskForm;
        }

        public string TaskName
        {
            get { return taskName; }
            set { taskName = value; lblTaskName.Text = taskName; }
        }
        public DateTime TaskTime
            {
            get { return taskTime; }
            set { taskTime = value; lblTaskTime.Text = taskTime.ToString(); }
        }
        public string TaskStatus
        {
            get { return taskStatus; }
            set { taskStatus = value; btnTaskStatus.Text = taskStatus; }
        }
        public string TaskJobAssigner
        {
            get { return taskJobAssigner; }
            set { taskJobAssigner = value; lblJobAssigner.Text = taskJobAssigner; }
        }

        public string IdCongViec 
        {   
            get { return idCongViec; }
            set { idCongViec = value; }
        }

        public string Reason
        {
            get { return reason; }
            set { reason = value; }
        }

        private void showMessage(string message, string type)
        {
            LayoutToastify layoutToastify = new LayoutToastify();
            layoutToastify.SetMessage(message, type);
            layoutToastify.Show();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = taskBLL.XacNhanDieuChinhPhanCong(this.idCongViec, taskForm.IdTaiKhoan);
                if(result)
                {
                    showMessage("Xác nhận điều chỉnh phân công thành công", "success");
                } else
                {
                    showMessage("Xác nhận điều chỉnh phân công thất bại", "error");
                }
            } catch(Exception ex)
            {
                showMessage(ex.Message, "error");
            }
            assignmentAdjustmentTaskForm.LoadDataAssignmentAdjusment();
        }

        private void btnReason_Click(object sender, EventArgs e)
        {
            DetailAdjustmentTask detailAdjustmentTask = new DetailAdjustmentTask(this.reason);
            detailAdjustmentTask.Show();
        }

        private void btnRefuse_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = taskBLL.TuChoiDieuChinhPhanCong(this.idCongViec, taskForm.IdTaiKhoan);
                if (result)
                {
                    showMessage("Từ chối điều chỉnh phân công thành công", "success");
                }
                else
                {
                    showMessage("Từ chối điều chỉnh phân công thất bại", "error");
                }
            }catch(Exception ex)
            {
                showMessage(ex.Message, "error");
            }
            assignmentAdjustmentTaskForm.LoadDataAssignmentAdjusment();

        }
    }
}
