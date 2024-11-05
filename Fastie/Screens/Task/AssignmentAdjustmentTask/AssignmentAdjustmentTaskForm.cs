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
        public AssignmentAdjustmentTaskForm()
        {
            InitializeComponent();
            loadDataAssignmentAdjusment();
        }

        public void LoadDataAssignmentAdjusment()
        {
            loadDataAssignmentAdjusment();
        }
        private void loadDataAssignmentAdjusment()
        {
            flowLayoutPanelTask.Controls.Clear();
            
            LayoutAssignmentAdjustmentForm[] layoutAssignmentAdjustmentForms = new LayoutAssignmentAdjustmentForm[20];
            for (int i = 0; i < 20; i++)
            {
                layoutAssignmentAdjustmentForms[i] = new LayoutAssignmentAdjustmentForm
                {
                    TaskName = "Task " + i,
                    TaskTime = "Time " + i,
                    TaskStatus = "Status " + i,
                    TaskJobAssigner = "Job Assigner " + i
                };
                flowLayoutPanelTask.Controls.Add(layoutAssignmentAdjustmentForms[i]);
            }
        }
    }
}
