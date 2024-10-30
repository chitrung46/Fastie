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
        public AcceptTaskForm()
        {
            InitializeComponent();
        }

        private void AcceptTaskForm_Load(object sender, EventArgs e)
        {
            LoadDataTaskTable();
        }
        private void LoadDataTaskTable()
        {
            flowLayoutPanelTasks.Controls.Clear(); 
            LayoutGetTaskForm[] layoutGetTaskForm = new LayoutGetTaskForm[20];
            for (int i = 0; i < 20; i++)
            {
                layoutGetTaskForm[i] = new LayoutGetTaskForm
                {
                    TaskName = "Task " + i,
                    TaskTime = "Time " + i,
                    TaskStatus = "Status " + i,
                    TaskJobAssigner = "Job Assigner " + i
                };
                flowLayoutPanelTasks.Controls.Add(layoutGetTaskForm[i]);
            }
        }

        private void flowLayoutPanelTasks_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
