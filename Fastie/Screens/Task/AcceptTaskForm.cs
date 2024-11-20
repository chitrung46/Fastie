using BLL;
using DTO;
using Fastie.Components.LayoutRole;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastie.Screens.Task
{
    public partial class AcceptTaskForm : Form
    {
        TaskBLL taskBLL = new TaskBLL();
        private TaskForm taskForm;
        private string currentTaskType;


        public string CurrentTaskType { get => currentTaskType; set => currentTaskType = value; }
        public AcceptTaskForm(TaskForm taskForm)
        {
            InitializeComponent();
            this.taskForm = taskForm;
        }

        private void AcceptTaskForm_Load(object sender, EventArgs e)
        {
            LoadDataTaskTable();
        }
        private void setStateButton(Button stateButton)
        {
            Button[] button = { btnInitialtiveTask, btnAssignTask };
            for (int i = 0; i < button.Length; i++)
            {
                if (button[i] != stateButton)
                {
                    button[i].BackColor = Color.FromArgb(55, 55, 55);
                }
            }
            stateButton.BackColor = Color.IndianRed;
        }

        public void LoadDataTaskTable(string taskType = null)
        {
            this.currentTaskType = taskType;
            flowLayoutPanelTasks.Controls.Clear();

            List<TaskInfo> filteredTasks = null;

            if (taskType == "Việc được giao")
            {
                filteredTasks = taskBLL.nhanNhiemVuDuocGiaoTuTaiKhoan(taskForm.IdTaiKhoan)
                                       .Where(task => task.IdTaiKhoanGiaoViec != taskForm.IdTaiKhoan)
                                       .ToList();
            }
            else
            {
                filteredTasks = taskBLL.nhanCongViecChuaDuocGiaoTuTaiKhoan(taskForm.IdBoPhan, taskForm.IdTaiKhoan);
            }
            if (filteredTasks != null && filteredTasks.Count > 0)
            {
                foreach (var task in filteredTasks)
                {
                    MessageBox.Show(task.Ten);
                    LayoutGetTaskForm layoutGetTaskForm = new LayoutGetTaskForm(taskForm, this.currentTaskType)
                    {
                        TaskName = task.Ten,
                        TaskTime = task.ThoiHanHoanThanh.HasValue ? task.ThoiHanHoanThanh.Value.ToString("dd/MM/yyyy") : "N/A",
                        TaskStatus = task.TenTienDoCongViec,
                        JobAssigner = task.TenNhanSuGiaoViec,
                        TaskId = task.Id
                    };
                    flowLayoutPanelTasks.Controls.Add(layoutGetTaskForm);
                }
            }
            else
            {
   
                MessageBox.Show("Không có công việc nào phù hợp để hiển thị.", "Thông báo");
            }
        }



        private void flowLayoutPanelTasks_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInitialtiveTask_Click(object sender, EventArgs e)
        {
            btnStateTask("Việc chủ động");
        }
        private void btnStateTask(string taskType)
        {
            this.currentTaskType = taskType;
            //MessageBox.Show(currentTaskType);
            LoadDataTaskTable(currentTaskType);
            if(this.currentTaskType == "Việc chủ động")
            {
                setStateButton(btnInitialtiveTask);
            }
            else
            {
                setStateButton(btnAssignTask);
            }
        }
        public void BtnStateTask(string taskType) { btnStateTask(taskType); }
        private void btnAssignTask_Click(object sender, EventArgs e)
        {
            btnStateTask("Việc được giao");
        }

    }
}
