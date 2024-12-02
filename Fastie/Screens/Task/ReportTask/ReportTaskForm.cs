using BLL;
using DTO;
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

namespace Fastie.Screens.Task.ReportTask
{
    public partial class ReportTaskForm : Form
    {
        TaskBLL taskBLL = new TaskBLL();
        public TaskForm taskForm;
        public ReportTaskForm(TaskForm taskForm)
        {
            InitializeComponent();
            this.taskForm = taskForm;
        }

        public void LoadDataReportTask()
        {
            loadDataReportTask();
        }
        public void loadDataReportTask()
        {
            flowLayoutPanelTasks.Controls.Clear();
            List<TaskInfo> tasks = taskBLL.layCongViecTheoID(this.taskForm.IdTaiKhoan);
            foreach (TaskInfo congViec in tasks)
            {
                LayoutReportTaskForm layoutCongViec = new LayoutReportTaskForm(taskForm, this)
                {
                    TaskName = congViec.Ten,
                    TaskTime = congViec.ThoiHanHoanThanh.HasValue ? congViec.ThoiHanHoanThanh.Value.ToString("dd/MM/yyyy") : "N/A",
                    TaskStatus = congViec.TenTienDoCongViec,
                    TaskJobAssigner = congViec.TenNhanSuGiaoViec,
                    TaskId = congViec.Id
                };
                flowLayoutPanelTasks.Controls.Add(layoutCongViec);
            }
            
        }

        private void flowLayoutPanelTasks_Paint(object sender, PaintEventArgs e)
        {
        }

        private void ReportTaskForm_Load(object sender, EventArgs e)
        {
            loadDataReportTask();
        }
    }
}
