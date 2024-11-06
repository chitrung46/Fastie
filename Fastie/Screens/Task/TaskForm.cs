using Fastie.Components.LayoutRole;
using Fastie.Screens.Task;
using Fastie.Screens.Task.ReportTask;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastie
{
    public partial class TaskForm: Form
    {
        private string currentUserId;
        public TaskForm(string userId)
        {
            InitializeComponent();
            currentUserId = userId;
            setStateButton(btnTaskTable);

            // Truyền userId vào TaskTableForm
            TaskTableForm taskTableForm = new TaskTableForm(currentUserId);
            addFormInMainLayout(taskTableForm);
        }

        //Check other panel is not click
        private void setStateButton(Button stateButton)
        {
            Button[] button = {btnTaskTable, btnAssignTask, btnAcceptTask, btnReportTask, btnAdjustTask};
            for (int i = 0; i < button.Length; i++)
            {
                if (button[i] != stateButton)
                {
                    button[i].BackColor = Color.FromArgb(55, 55, 55);
                }
            }
            stateButton.BackColor = Color.FromArgb(59, 171, 201);
        }

        //Add form in main layout
        private void addFormInMainLayout(Form userControl)
        {
            mainLayout.Controls.Clear();
            userControl.TopLevel = false;
            mainLayout.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            userControl.Show();
        }
        private void btnTaskTable_Click(object sender, EventArgs e)
        {
            TaskTableForm taskTableForm = new TaskTableForm(currentUserId);
            setStateButton(btnTaskTable);
            addFormInMainLayout(taskTableForm);
        }

        private void btnAssignTask_Click(object sender, EventArgs e)
        {
            AssignTaskForm assignTaskForm = new AssignTaskForm();
            addFormInMainLayout(assignTaskForm);
            setStateButton(btnAssignTask);
        }

        private void btnAcceptTask_Click(object sender, EventArgs e)
        {
            AcceptTaskForm acceptTaskForm = new AcceptTaskForm(currentUserId);
            setStateButton(btnAcceptTask);
            addFormInMainLayout(acceptTaskForm);
            
        }

        private void btnReportTask_Click(object sender, EventArgs e)
        {
            ReportTaskForm reportTaskForm = new ReportTaskForm();
            addFormInMainLayout(reportTaskForm);
            setStateButton(btnReportTask);
        }

        private void btnAdjustTask_Click(object sender, EventArgs e)
        {
            setStateButton(btnAdjustTask);
        }

        private void TaskForm_Load(object sender, EventArgs e)
        {
        }
    }
}
