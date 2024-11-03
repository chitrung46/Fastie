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

namespace Fastie.Screens.Task
{
    public partial class AssignTaskForm : Form
    {
        public AssignTaskForm()
        {
            InitializeComponent();
        }

        private void btnDetailAssignTask_Click(object sender, EventArgs e)
        {
            DetailAssignTaskForm detailAssignTaskForm = new DetailAssignTaskForm();
            detailAssignTaskForm.Show();
        }

        private void btnDetailAssignFastingTask_Click(object sender, EventArgs e)
        {
            DetailAssignFastingTaskForm detailAssignFastingTask = new DetailAssignFastingTaskForm();
            detailAssignFastingTask.Show();
        }

        private void btnDetailAssignPositiveTask_Click(object sender, EventArgs e)
        {
            DetailAssignPositiveTaskForm detailAssignPositiveTaskForm = new DetailAssignPositiveTaskForm();
            detailAssignPositiveTaskForm.Show();
        }

        private void LoadDataTaskTable()
        {
            flowLayoutPanelTasks.Controls.Clear();
            LayoutAssignTaskForm[] layoutAssignTaskForms = new LayoutAssignTaskForm[20];
            for (int i = 0; i < 20; i++)
            {
                layoutAssignTaskForms[i] = new LayoutAssignTaskForm
                {
                    TaskName = "Task " + i,
                    TaskTime = "Time " + i,
                    TaskStatus = "Status " + i,
                    TaskJobAssigner = "Job Assigner " + i
                };
                flowLayoutPanelTasks.Controls.Add(layoutAssignTaskForms[i]);
            }
        }

        private void AssignTaskForm_Load(object sender, EventArgs e)
        {
            LoadDataTaskTable();
        }

 
    }
}
