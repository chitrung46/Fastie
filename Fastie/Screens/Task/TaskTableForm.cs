using Fastie.Components.LayoutNotification;
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
    public partial class TaskTableForm : Form
    {
       private Panel mainLayout;
        public TaskTableForm(Panel mainLayout)
        {
            InitializeComponent();
            this.mainLayout = mainLayout;
        }
        private void TaskTableForm_Load_1(object sender, EventArgs e)
        {
            LoadDataNotification();
            LoadDataTask();
        }
        private void LoadDataNotification()
        {
            flowLayoutPanelNotification.Controls.Clear();
            for (int i = 0; i < 20; i++)
            {
                var notificationForm = new NotificationForm
                {
                    TaskName = "Task " + i,
                    AssignerName = "Assigner " + i
                };

                flowLayoutPanelNotification.Controls.Add(notificationForm);
            }
        }

        private void LoadDataTask()
        {
            flowLayoutPanelTask.Controls.Clear();
            for(int i = 0 ; i < 20 ; i++)
            {
                var taskForm = new LayoutTaskForm(mainLayout)
                {
                    TitleTask = "Title" + i,
                    Status = "Status" + i
                };
                flowLayoutPanelTask.Controls.Add(taskForm);
            }
        }

        private void flowLayoutPanelNotification_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
