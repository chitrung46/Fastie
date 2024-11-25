using BLL;
using DTO;
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

namespace Fastie.Screens.Task.AssignmentAdjustmentTask
{
    public partial class AssignmentAdjustmentTaskForm : Form
    {
        TaskBLL taskBLL = new TaskBLL();
        private TaskForm taskForm;
        public AssignmentAdjustmentTaskForm(TaskForm taskForm)
        {
            InitializeComponent();
            this.taskForm = taskForm;
            loadDataAssignmentAdjusment();
        }

        public void LoadDataAssignmentAdjusment()
        {
            loadDataAssignmentAdjusment();
        }

        private void loadDataAssignmentAdjusment()
        {
            flowLayoutPanelTask.Controls.Clear(); 
            List<TaskInfo> taskInfos = taskBLL.HienThiDanhSachDieuChinhPhanCong(this.taskForm.IdTaiKhoan);

            foreach (var task in taskInfos)
            {
                LayoutAssignmentAdjustmentForm layoutForm = new LayoutAssignmentAdjustmentForm(taskForm,this)
                {
                    TaskName = task.Ten,  
                    TaskTime = task.ThoiHanHoanThanh ?? DateTime.MinValue,
                    TaskStatus = task.TenTienDoCongViec,  
                    TaskJobAssigner = task.TenNhanSuGiaoViec ,
                    IdCongViec = task.Id,
                    Reason = task.LiDoDieuChinh
                };

                // Thêm LayoutAssignmentAdjustmentForm vào flowLayoutPanel
                flowLayoutPanelTask.Controls.Add(layoutForm);
            }
        }

    }
}
