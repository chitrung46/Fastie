using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastie.Components.LayoutTask
{
    public partial class LayoutReportTaskForm : UserControl
    {
        private string taskName;
        private string taskTime;
        private string taskStatus;
        private string taskJobAssigner;
        private string taskDetail;
        public LayoutReportTaskForm()
        {
            InitializeComponent();
        }

        public string TaskName
        {
            get { return taskName; }
            set { taskName = value; lblTaskName.Text = value; }
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
        public string TaskJobAssigner
        {
            get { return taskJobAssigner; }
            set { taskJobAssigner = value; lblJobAssigner.Text = value; }
        }
        public string TaskDetail
        {
            get { return taskDetail; }
            set { taskDetail = value; btnTaskDetail.Text = value; }
        }

    }
}
