using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace Fastie.Screens.Task
{
    public partial class DetailsTaskForm : Form
    {
        private TaskForm taskForm;
        private TaskBLL taskBLL = new TaskBLL();
        private string idTask;

        public DetailsTaskForm(TaskForm taskForm, string idTask)
        {
            InitializeComponent();
            this.taskForm = taskForm;
            this.idTask = idTask;
            //LoadTaskDetails();
        }

        private void customPanel2_Paint(object sender, PaintEventArgs e)
        {
            // Custom paint logic, if needed
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            BackForm();
        }

        private void pictureBack_Click(object sender, EventArgs e)
        {
            BackForm();
        }

        private void BackForm()
        {
            switch (taskForm.FormCurrent)
            {
                case "TaskTableForm":
                    TaskTableForm taskTableForm = new TaskTableForm(taskForm);
                    taskForm.AddFormInMainLayout(taskTableForm);
                    break;
                case "AcceptTaskForm":
                    AcceptTaskForm acceptTaskForm = new AcceptTaskForm(taskForm);
                    taskForm.AddFormInMainLayout(acceptTaskForm);
                    break;
            }
        }

        
           
    }
}
