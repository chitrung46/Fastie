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
        private TaskBLL taskBLL = new TaskBLL();
        private string idTask;
        private string currentTaskType;

        public DetailsTaskForm(TaskForm taskForm, string idTask, string currentTaskType)
        {
            InitializeComponent();
            this.taskForm = taskForm;
            this.idTask = idTask;
            this.currentTaskType = currentTaskType;
            LoadTaskDetails();
        }

        public DetailsTaskForm(TaskForm taskForm, string idTask)
        {
            InitializeComponent();
            this.taskForm = taskForm;
            this.idTask = idTask;
            LoadTaskDetails();
        }
        public DetailsTaskForm(TaskForm taskForm, LayoutGetTaskForm layoutGetTaskForm)
        {
            InitializeComponent();
            this.taskForm = taskForm;
            this.layoutGetTaskForm = layoutGetTaskForm;
            LoadTaskDetails();
        }
        public DetailsTaskForm(TaskForm taskForm, LayoutTaskForm layoutTaskForm)
        {
            InitializeComponent();
            this.taskForm = taskForm;
            this.layoutTaskForm = layoutTaskForm;
            LoadTaskDetails();
        }
        public DetailsTaskForm(TaskForm taskForm, LayoutAssignTaskForm layoutAssignTaskForm)
        {
            InitializeComponent();
            this.taskForm = taskForm;
            this.layoutAssignTaskForm = layoutAssignTaskForm;
            LoadTaskDetails();
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
                case "AcceptTaskForm":
                    var acceptTaskForm = new AcceptTaskForm(taskForm);
                    taskForm.AddFormInMainLayout(acceptTaskForm);
                    if (currentTaskType == "Việc chủ động")
                    {
                        
                        acceptTaskForm.LoadDataTaskTable("Việc chủ động");
                        acceptTaskForm.BtnStateTask("Việc chủ động");
                    }
                    else if (currentTaskType == "Việc được giao")
                    {
                        acceptTaskForm.LoadDataTaskTable("Việc được giao");
                        acceptTaskForm.BtnStateTask("Việc được giao");
                    }
                    else
                    {
                        MessageBox.Show("Không xác định được loại công việc.", "Lỗi");
                    }
                    break;

                case "TaskTableForm":
                    TaskTableForm taskTableForm = new TaskTableForm(taskForm);
                    taskForm.AddFormInMainLayout(taskTableForm);
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

        private void LoadTaskDetails()
        {
            // Ghi log idTask ra console
            MessageBox.Show($"ID công việc: {idTask}");

            // Gọi phương thức LayChiTietCongViec từ TaskBLL để lấy thông tin chi tiết công việc
            TaskInfo task = taskBLL.LayChiTietCongViec(idTask);

            if (task != null)
            {
                lblTaskNamee.Text = task.Ten;
                lblTypeJob.Text = task.TenLoaiCongViec;
                lblDescribeTask.Text = task.MoTa;
                dtpTimeCompleted.Text = task.ThoiHanHoanThanh.HasValue ? task.ThoiHanHoanThanh.Value.ToString("dd/MM/yyyy") : "N/A";
                lblDepartment.Text = task.TenBoPhan;
                lblPersonnel.Text = task.TenNhanSuNhanViec;
                lblNumber.Text = task.SoLuongNhanSuChuDong ?? "0";


            }
            else
            {
                MessageBox.Show("Không tìm thấy chi tiết công việc.", "Lỗi");
            }
        }


        private void DetailsTaskForm_Load(object sender, EventArgs e)
        {
            LoadTaskDetails();

            switch (taskForm.FormCurrent)
            {
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AssignTaskForm assignTaskForm = new AssignTaskForm(taskForm);
            taskForm.AddFormInMainLayout(assignTaskForm);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string[] information = { "Bạn có chắc chắn xóa công việc này?", "Bạn sẽ không thể thực hiện các chức năng hệ thống", "Đăng xuất" };

            LayoutConfirmForm layoutConfirmForm = new LayoutConfirmForm();
            layoutConfirmForm.Title = information[0];
            layoutConfirmForm.Content = information[1];
            layoutConfirmForm.btnConfirmText = information[2];
            layoutConfirmForm.Show();
        }
    }
}
