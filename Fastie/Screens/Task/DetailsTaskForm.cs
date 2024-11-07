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
using BLL;
using DTO;

namespace Fastie.Screens.Task
{
    public partial class DetailsTaskForm : Form
    {
        private TaskForm taskForm;
        private LayoutGetTaskForm layoutGetTaskForm;
        private LayoutTaskForm layoutTaskForm;
        private LayoutAssignTaskForm layoutAssignTaskForm;
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
        public DetailsTaskForm(TaskForm taskForm, LayoutAssignTaskForm layoutAssignTaskForm)
        {
            InitializeComponent();
            this.taskForm = taskForm;
            this.layoutAssignTaskForm = layoutAssignTaskForm;
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

        public void LoadDataTaskTable()
        {
            int length = 5; //Change report data length
            if (length > 0)
            {
                pnlReport.Visible = true;
                flowLayoutPanelReport.Controls.Clear();
                for (int i = 0; i < length; i++)
                {
                    LayoutDetailReportTaskForm1 layoutDetailReportTaskForm = new LayoutDetailReportTaskForm1()
                    {
                        ReportContent = "Đây là nội dung báo cáo " + i,
                        ReportDate = "20/11/2024",
                        FileName = "file_" + i + ".txt",
                        ImageName = "image_" + i + ".png",
                        IdReport = "ID" + i
                    };

                    flowLayoutPanelReport.Controls.Add(layoutDetailReportTaskForm);
                }
            }
            else
            {
                pnlReport.Visible = false;
            }
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
                case "AssignTaskForm":
                    AssignTaskForm assignTaskForm = new AssignTaskForm(taskForm);
                    taskForm.AddFormInMainLayout(assignTaskForm);
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
                case "AssignTaskForm":
                    LoadDataTaskTable();
                    break;
            }   
        }
    }
}
