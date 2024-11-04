using DAL;
using Fastie.Screens.Task;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastie.Components.LayoutRole
{
    public partial class LayoutGetTaskForm : UserControl
    {
        private string taskName;
        private string taskTime;
        private string taskStatus;
        private string taskJobAssigner;

        public string CongViecID { get; set; } 

        public LayoutGetTaskForm()
        {
            InitializeComponent();
        }

        public string TaskName
        {
            get { return taskName; }
            set { taskName = value; lblTitleTask.Text = value; }
        }
        public string TaskTime
        {
            get { return taskTime; }
            set { taskTime = value; lblTaskTime.Text = value; }
        }

        public string TaskStatus
        {
            get { return taskStatus; }
            set { taskStatus = value; btnTaskStatus.Text = value; }
        }
        public string JobAssigner
        {
            get { return taskJobAssigner; }
            set { taskJobAssigner = value; lblJobAssigner.Text = value; }
        }

        private void btnGetTask_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CongViecID))
            {
                
                TaskAccess.UpdateTaskStatus(CongViecID, "Đang tiến hành");

               
                if (this.ParentForm is AcceptTaskForm parentForm)
                {
                    parentForm.LoadDataTaskTable("Chưa hoàn thành");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy form cha để tải lại dữ liệu.", "Lỗi");
                }

                if (this.Parent != null)
                {
                    this.Parent.Controls.Remove(this);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy ID công việc để nhận.", "Lỗi");
            }
        }





    }
}
