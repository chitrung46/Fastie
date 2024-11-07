using Fastie.Screens.Task;
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
    public partial class LayoutTaskForm : UserControl
    {
        private string titleTask;
        private string status;
        private string idTask;
        private TaskForm taskForm;

        public LayoutTaskForm(TaskForm taskForm)
        {
            InitializeComponent();
            this.taskForm = taskForm;
        }

        public string TitleTask
        {
            get { return titleTask; }
            set { titleTask = value; lblTitleTask.Text = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; btnStatus.Text = value; }
        }

        public string IdTask
        {
            get { return idTask; }
            set { idTask = value; }
        }
        private void btnGetInformation_Click(object sender, EventArgs e)
        {
            //DetailsTaskForm detailsTaskForm = new DetailsTaskForm(this.taskForm, this);
            //Console.WriteLine($"Opening DetailsTaskForm with idTask: {this.idTask}");
            DetailsTaskForm detailsTaskForm = new DetailsTaskForm(this.taskForm, this.idTask);
            taskForm.AddFormInMainLayout(detailsTaskForm);
        }



    }
}
