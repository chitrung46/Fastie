using Fastie.Components.LayoutRole;
using Fastie.Components.LayoutTask;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace Fastie.Screens.Task
{
    public partial class DetailsTaskForm : Form
    {
        private TaskForm taskForm;
        private LayoutGetTaskForm layoutGetTaskForm;
        private LayoutTaskForm layoutTaskForm;
        private LayoutAssignTaskForm layoutAssignTaskForm;
        private TaskInfo taskInfo;
        TaskBLL taskBLL = new TaskBLL();
        public DetailsTaskForm(TaskForm taskForm, LayoutGetTaskForm layoutGetTaskForm)
        {
            InitializeComponent();
            this.taskForm = taskForm;
            this.layoutGetTaskForm = layoutGetTaskForm;
        }
        public DetailsTaskForm(TaskForm taskForm, LayoutTaskForm layoutTaskForm)
        {
            InitializeComponent();
            this.taskForm = taskForm;
            this.layoutTaskForm = layoutTaskForm;
        }
        public DetailsTaskForm(TaskForm taskForm, LayoutAssignTaskForm layoutAssignTaskForm)
        {
            InitializeComponent();
            this.taskForm = taskForm;
            this.layoutAssignTaskForm = layoutAssignTaskForm;
            this.taskInfo = taskBLL.LayChiTietCongViecTheoIdCongViec(layoutAssignTaskForm.IdTask);
            lblPersonnelName.Text = taskInfo.Ten;
            label9.Text = taskInfo.TenLoaiCongViec;
            label11.Text = taskInfo.MoTa;
            label12.Text = taskInfo.ThoiHanHoanThanh.ToString();
            label13.Text = taskBLL.LaySoLuongNhanSuChuDongTheoIdCongViec(layoutAssignTaskForm.IdTask).ToString();
        }

        private void customPanel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            BackForm();
        }

        private void pictureBack_Click(object sender, EventArgs e)
        {
            BackForm();
        }

       
        private void BackForm()
        {
            switch (taskForm.FormCurrent)
            {
                case "TaskTableForm":
                    TaskTableForm taskTableForm = new TaskTableForm(taskForm);
                    taskForm.AddFormInMainLayout(taskTableForm);
                    break;
                case "AcceptTaskForm":
                    if(layoutGetTaskForm.CurrentTaskType == "Việc chủ động")
                    {
                        AcceptTaskForm acceptTaskForm = new AcceptTaskForm(taskForm);
                        taskForm.AddFormInMainLayout(acceptTaskForm);
                    } else if(layoutGetTaskForm.CurrentTaskType == "Việc được giao")
                    {
                        AcceptTaskForm acceptTaskForm = new AcceptTaskForm(taskForm);
                        taskForm.AddFormInMainLayout(acceptTaskForm);
                    }
                    break;
                case "AssignTaskForm":
                    AssignTaskForm assignTaskForm = new AssignTaskForm(taskForm);
                    taskForm.AddFormInMainLayout(assignTaskForm);
                    break;

            }
        }

        private void addFormInPanelReport(Form userControl)
        {
            pnlReport.Controls.Clear();
            userControl.TopLevel = false;
            pnlReport.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            userControl.Show();
        }

        private void DetailsTaskForm_Load(object sender, EventArgs e)
        {
            switch (taskForm.FormCurrent) {                
                case "TaskTableForm":
                    break;
                case "AcceptTaskForm":
                    break;
                case "AssignTaskForm":
                    NearlyReportForm nearlyReport = new NearlyReportForm();
                    addFormInPanelReport(nearlyReport);
                    break;
            }   
        }

        private void flowLayoutPanelReport_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
