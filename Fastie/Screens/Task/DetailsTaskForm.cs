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

namespace Fastie.Screens.Task
{
    public partial class DetailsTaskForm : Form
    {
        private TaskForm taskForm;
        private TaskBLL taskBLL = new TaskBLL();
        private string idTask;

        public DetailsTaskForm(TaskForm taskForm, string idTask)
        {
            InitializeComponent();
            this.taskForm = taskForm;
            this.idTask = idTask;
            LoadTaskDetails();
        }

        private void customPanel2_Paint(object sender, PaintEventArgs e)
        {
            // Custom paint logic, if needed
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
                    AcceptTaskForm acceptTaskForm = new AcceptTaskForm(taskForm);
                    taskForm.AddFormInMainLayout(acceptTaskForm);
                    break;
            }
        }

        private void LoadTaskDetails()
        {
            Console.WriteLine($"Attempting to load task details for ID: {idTask}"); // Log the task ID

            // Fetch task details
            var taskInfo = taskBLL.GetTaskDetailsById(idTask);

            if (taskInfo != null)
            {
                // Populate form fields with task details
                txbTaskName.Text = taskInfo.Ten; // Set task name
                cboTypeJob.Text = taskInfo.TenLoaiCongViec; // Set job type
                cTBDescribeTask.Text = taskInfo.MoTa; // Set task description
                dtpTimeCompleted.Value = taskInfo.ThoiHanHoanThanh ?? DateTime.Now; // Set completion deadline or default to current date
                cbxDepartment.Text = taskInfo.TenBoPhan; // Set department name
                cbxPersonnel.Text = taskInfo.TenNhanSuGiaoViec; // Set personnel name
                dataGridView2.Text = taskInfo.GhiChu; // Set notes or comments
            }
            else
            {
                MessageBox.Show("Không tìm thấy chi tiết công việc.", "Lỗi");
                Console.WriteLine("No task details found for the given ID.");
            }
        }
    }
}
