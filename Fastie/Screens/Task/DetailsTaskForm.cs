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
    public partial class DetailsTaskForm : Form
    {
        private TaskForm taskForm;
        private LayoutGetTaskForm layoutGetTaskForm;
        private LayoutTaskForm layoutTaskForm;
        public DetailsTaskForm(TaskForm taskForm, LayoutGetTaskForm layoutGetTaskForm)
        {
            InitializeComponent();
            this.taskForm = taskForm;
            this.layoutGetTaskForm = layoutGetTaskForm;
        }
        public DetailsTaskForm(TaskForm taskForm, LayoutTaskForm layoutTaskForm)
        {
            InitializeComponent();
            this.taskForm = taskForm;
            this.layoutTaskForm = layoutTaskForm;
        }

        private void customPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            BackForm();
        }

        private void pictureBack_Click(object sender, EventArgs e)
        {
            BackForm();
        }

        private void BackForm ()
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

        private void DetailsTaskForm_Load(object sender, EventArgs e)
        {
            switch (taskForm.FormCurrent) {                
                case "TaskTableForm":

                    break;
                case "AcceptTaskForm":
                    break;
            }   
        }
    }
}
