using BLL;
using DTO.Task;
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
        private readonly TaskBLL taskBLL = new TaskBLL();
        public AcceptTaskForm()
        {
            InitializeComponent();
        }

        private void AcceptTaskForm_Load(object sender, EventArgs e)
        {
            LoadDataTaskTable("Chưa hoàn thành");
        }
        private void setStateButton(Button stateButton)
        {
            Button[] button = { btnInitialtiveTask, btnAssignTask};
            for (int i = 0; i < button.Length; i++)
            {
                if (button[i] != stateButton)
                {
                    button[i].BackColor = Color.FromArgb(55, 55, 55);
                }
            }
            stateButton.BackColor = Color.IndianRed;
        }

        public void LoadDataTaskTable(string taskType)
        {
            flowLayoutPanelTasks.Controls.Clear();

            List<TaskWithPersonel> tasks = taskBLL.GetTaskPersonelBLL()
                                                  .Where(task => task.GhiChu == "Chờ nhận")
                                                  .ToList();
            if (tasks != null && tasks.Count > 0)
            {
                foreach (var task in tasks)
                {
                    LayoutGetTaskForm layoutGetTaskForm = new LayoutGetTaskForm
                    {
                        TaskName = task.TenCongViec,
                        TaskTime = task.ThoiHanHoanThanh.HasValue ? task.ThoiHanHoanThanh.Value.ToString("dd/MM/yyyy") : "N/A",
                        TaskStatus = task.GhiChu,
                        JobAssigner = task.TenNhanSuGiaoViec,
                        CongViecID = task.CongViecID
                    };

                    flowLayoutPanelTasks.Controls.Add(layoutGetTaskForm);
                }
            }
            else
            {
                MessageBox.Show("Không có công việc nào chưa hoàn thành để hiển thị.", "Thông báo");
            }
        }





        private void flowLayoutPanelTasks_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInitialtiveTask_Click(object sender, EventArgs e)
        {
            LoadDataTaskTable("Việc chủ động");
            setStateButton(btnInitialtiveTask);
        }

        private void btnAssignTask_Click(object sender, EventArgs e)
        {
            LoadDataTaskTable("Việc được giao");
            setStateButton(btnAssignTask);
        }
    }
}
