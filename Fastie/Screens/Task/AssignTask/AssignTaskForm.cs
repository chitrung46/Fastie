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
    }
}
