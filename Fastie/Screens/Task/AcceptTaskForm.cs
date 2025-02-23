﻿using BLL;
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
        private string idTaiKhoan;
        public string CurrentTaskType { get; set; }

        public AcceptTaskForm(string idTaiKhoan)
        {
            InitializeComponent();
            this.idTaiKhoan = idTaiKhoan;
        }

        private void AcceptTaskForm_Load(object sender, EventArgs e)
        {
            LoadDataTaskTable("Chưa hoàn thành");
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

        public void LoadDataTaskTable(string taskType)
        {
            CurrentTaskType = taskType;  
            flowLayoutPanelTasks.Controls.Clear();

            List<TaskInfo> tasks;

            if (taskType == "Việc được giao")
            {
                tasks = taskBLL.nhanNhiemVuDuocGiaoTuTaiKhoan(this.idTaiKhoan);
            }
            else
            {
                tasks = taskBLL.nhanCongViecChuaDuocGiaoTuTaiKhoan(this.idTaiKhoan);
            }

            if (tasks != null && tasks.Count > 0)
            {
                foreach (var task in tasks)
                {
                    LayoutGetTaskForm layoutGetTaskForm = new LayoutGetTaskForm(this.idTaiKhoan)
                    {
                        TaskName = task.Ten,
                        TaskTime = task.ThoiHanHoanThanh.HasValue ? task.ThoiHanHoanThanh.Value.ToString("dd/MM/yyyy") : "N/A",
                        TaskStatus = task.GhiChu,
                        JobAssigner = task.TenNhanSuGiaoViec,
                        CongViecID = task.Id
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
