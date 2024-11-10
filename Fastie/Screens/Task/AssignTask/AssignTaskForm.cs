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
    public partial class AssignTaskForm : Form
    {

        TaskBLL taskBLL = new TaskBLL();
        private TaskForm taskForm;
        public AssignTaskForm(TaskForm taskForm)
        {
            InitializeComponent();
            this.taskForm = taskForm;
        }

        private void btnDetailAssignTask_Click(object sender, EventArgs e)
        {
            DetailAssignTaskForm detailAssignTaskForm = new DetailAssignTaskForm(taskForm.IdTaiKhoan, taskForm.IdBoPhan);
            detailAssignTaskForm.FormClosed += (s, args) => LoadDataTaskTable();
            detailAssignTaskForm.Show();
        }

        private void btnDetailAssignFastingTask_Click(object sender, EventArgs e)
        {
            DetailAssignFastingTaskForm detailAssignFastingTask = new DetailAssignFastingTaskForm(taskForm.IdTaiKhoan, taskForm.IdBoPhan);
            detailAssignFastingTask.FormClosed += (s, args) => LoadDataTaskTable();
            detailAssignFastingTask.Show();
        }

        private void btnDetailAssignPositiveTask_Click(object sender, EventArgs e)
        {
            DetailAssignPositiveTaskForm detailAssignPositiveTaskForm = new DetailAssignPositiveTaskForm(taskForm.IdTaiKhoan, taskForm.IdBoPhan);
            detailAssignPositiveTaskForm.FormClosed += (s, args) => LoadDataTaskTable();
            detailAssignPositiveTaskForm.Show();
        }

        private void LoadDataTaskTable()
        {
            flowLayoutPanelTasks.Controls.Clear();

            List<TaskInfo> danhSachCongViec = taskBLL.LayDanhSachCongViecDaGiao(taskForm.IdTaiKhoan);

            foreach (TaskInfo congViec in danhSachCongViec)
            {
                LayoutAssignTaskForm layoutCongViec = new LayoutAssignTaskForm(taskForm)
                {
                    TaskName = congViec.Ten,
                    TaskTime = congViec.ThoiHanHoanThanh.HasValue ? congViec.ThoiHanHoanThanh.Value.ToString("dd/MM/yyyy") : "N/A",
                    TaskStatus = congViec.TenTienDoCongViec,
                    TaskJobAssigner = congViec.TenNhanSuGiaoViec,
                    IdTask = congViec.Id
                };

                flowLayoutPanelTasks.Controls.Add(layoutCongViec);
            }
        }

        private void AssignTaskForm_Load(object sender, EventArgs e)
        {
            LoadDataTaskTable();
        }

 
    }
}
