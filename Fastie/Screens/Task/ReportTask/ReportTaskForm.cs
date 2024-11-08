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
        public ReportTaskForm()
        {
            InitializeComponent();
        }

        private void LoadDataTaskTable()
        {
            flowLayoutPanelTasks.Controls.Clear();

            LayoutReportTaskForm[] layoutReportTaskForm = new LayoutReportTaskForm[20];
            for (int i = 0; i < 20; i++)
            {
                layoutReportTaskForm[i] = new LayoutReportTaskForm(this)
                {
                    TaskName = "Task " + i,
                    TaskTime = "Time " + i,
                    TaskStatus = "Status " + i,
                    TaskJobAssigner = "Job Assigner " + i
                };
                flowLayoutPanelTasks.Controls.Add(layoutReportTaskForm[i]);
            }
        }

        private void flowLayoutPanelTasks_Paint(object sender, PaintEventArgs e)
        {
        }

        private void ReportTaskForm_Load(object sender, EventArgs e)
        {
            LoadDataTaskTable();
        }
    }
}
