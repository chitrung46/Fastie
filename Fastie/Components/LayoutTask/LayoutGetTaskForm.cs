/*
using BLL;
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
        private readonly TaskBLL taskBLL = new TaskBLL();
        private string currentUserId;

        public string CongViecID { get; set; }

        public LayoutGetTaskForm(string userId)
        {
            InitializeComponent();
            currentUserId = userId;
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
            if (!string.IsNullOrEmpty(CongViecID) && !string.IsNullOrEmpty(currentUserId))
            {
                taskBLL.giaoViecChoTaiKhoan(currentUserId, CongViecID);
                taskBLL.capNhatTrangThaiCongViec(CongViecID, "TD002"); 

                if (this.ParentForm is AcceptTaskForm parentForm)
                {
                    parentForm.LoadDataTaskTable(parentForm.CurrentTaskType);
                }

                if (this.Parent != null)
                {
                    this.Parent.Controls.Remove(this);
                }
            }
            else
            {
                //MessageBox.Show("Không tìm thấy ID công việc hoặc ID tài khoản để nhận.", "Lỗi");
            }
        }








    }
}
*/
using BLL;
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
        private readonly TaskBLL taskBLL = new TaskBLL();
        private string currentUserId;
        private string _congViecID; // Make CongViecID private

        public LayoutGetTaskForm(string userId)
        {
            InitializeComponent();
            currentUserId = userId;
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

        // New method to set CongViecID
        public void SetCongViecID(string value)
        {
            _congViecID = value;
        }

        private void btnGetTask_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_congViecID) && !string.IsNullOrEmpty(currentUserId))
            {
                taskBLL.giaoViecChoTaiKhoan(currentUserId, _congViecID);
                taskBLL.capNhatTrangThaiCongViec(_congViecID, "TD002");

                if (this.ParentForm is AcceptTaskForm parentForm)
                {
                    parentForm.LoadDataTaskTable(parentForm.CurrentTaskType);
                }

                if (this.Parent != null)
                {
                    this.Parent.Controls.Remove(this);
                }
            }
            else
            {
                //MessageBox.Show("Không tìm thấy ID công việc hoặc ID tài khoản để nhận.", "Lỗi");
            }
        }
    }
}
