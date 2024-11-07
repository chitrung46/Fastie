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
        private string idTaiKhoan;
        private string idBoPhan;
        private Panel mainLayout;
        TaskBLL taskBLL = new TaskBLL();
        private TaskForm taskForm;
        public AssignTaskForm(string idTaiKhoan, string idBoPhan, Panel mainLayout)
        {
            InitializeComponent();
            this.idTaiKhoan = idTaiKhoan;
            this.idBoPhan = idBoPhan;
            this.mainLayout = mainLayout;
        }

        private void btnDetailAssignTask_Click(object sender, EventArgs e)
        {
            DetailAssignTaskForm detailAssignTaskForm = new DetailAssignTaskForm(this.idTaiKhoan, this.idBoPhan);
            detailAssignTaskForm.FormClosed += (s, args) => LoadDataTaskTable();
            detailAssignTaskForm.Show();
        }

        private void btnDetailAssignFastingTask_Click(object sender, EventArgs e)
        {
            DetailAssignFastingTaskForm detailAssignFastingTask = new DetailAssignFastingTaskForm(this.idTaiKhoan, this.idBoPhan);
            detailAssignFastingTask.Show();
        }

        private void btnDetailAssignPositiveTask_Click(object sender, EventArgs e)
        {
            DetailAssignPositiveTaskForm detailAssignPositiveTaskForm = new DetailAssignPositiveTaskForm(this.idTaiKhoan, this.idBoPhan);
            detailAssignPositiveTaskForm.Show();
        }

        private void LoadDataTaskTable()
        {
            flowLayoutPanelTasks.Controls.Clear();

            List<TaskInfo> danhSachCongViec = taskBLL.LayDanhSachCongViecDaGiao(idTaiKhoan);

            foreach (TaskInfo congViec in danhSachCongViec)
            {
                LayoutAssignTaskForm layoutCongViec = new LayoutAssignTaskForm
                {
                    TaskName = congViec.Ten,
                    TaskTime = congViec.ThoiHanHoanThanh.HasValue ? congViec.ThoiHanHoanThanh.Value.ToString("dd/MM/yyyy") : "N/A",
                    TaskStatus = congViec.TenTienDoCongViec,
                    TaskJobAssigner = congViec.TenNhanSuGiaoViec
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
