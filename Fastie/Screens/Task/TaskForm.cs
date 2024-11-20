using BLL.PermissionBLL;
using Fastie.Components.LayoutRole;
using Fastie.Components.NoPermissionAccessForm;
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
using Fastie.Screens.Task.AssignmentAdjustmentTask;
using Fastie.Screens.Task.ReportTask;
using Fastie.Screens.Task.ReportTaskOnline;

namespace Fastie
{
    public partial class TaskForm: Form
    {
        PermissionBLL permissionBLL = new PermissionBLL();

        private string idTaiKhoan;
        private string idChucVu;
        private string idBoPhan;
        private string formCurrent;
        public TaskForm(string idTaiKhoan, string idBoPhan, string idChucVu)
        {
            InitializeComponent();
            this.idTaiKhoan = idTaiKhoan;
            this.idChucVu = idChucVu;
            this.idBoPhan = idBoPhan;

            bool checkPermission = permissionBLL.checkPermission(this.idTaiKhoan, "Q0019");
            setStateButton(btnTaskTable);
            if (checkPermission) {
                this.formCurrent = "TaskTableForm";
                TaskTableForm taskTableForm = new TaskTableForm(this);
                addFormInMainLayout(taskTableForm);

            } else {
                NoPermissionAccessForm noPermissionAccessForm = new NoPermissionAccessForm();
                addFormInMainLayout(noPermissionAccessForm);
            }
        }
 
        public string IdTaiKhoan { get => idTaiKhoan; set => idTaiKhoan = value; }
        public string IdChucVu { get => idChucVu; set => idChucVu = value; }

        public string IdBoPhan { get => idBoPhan; set => idBoPhan = value; }
        public string FormCurrent { get => formCurrent; set => formCurrent = value; }

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
        public void AddFormInMainLayout(Form userControl)
        {
            addFormInMainLayout(userControl);
        }
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
            this.formCurrent = "TaskTableForm";
            bool checkPermission = permissionBLL.checkPermission(this.idTaiKhoan, "Q0019");
            setStateButton(btnTaskTable);
            if (checkPermission)
            {
                TaskTableForm taskTableForm = new TaskTableForm(this);
                addFormInMainLayout(taskTableForm);
            } else
            {
                NoPermissionAccessForm noPermissionAccessForm = new NoPermissionAccessForm();
                addFormInMainLayout(noPermissionAccessForm);
            }
        }

        private void btnAssignTask_Click(object sender, EventArgs e)
        {
            this.formCurrent = "AssignTaskForm";
            bool checkPermission = permissionBLL.checkPermission(this.idTaiKhoan, "Q0020");
            setStateButton(btnAssignTask);
            if (checkPermission)
            {
                AssignTaskForm assignTaskForm = new AssignTaskForm(this);
                addFormInMainLayout(assignTaskForm);
            }
            else
            {
                NoPermissionAccessForm noPermissionAccessForm = new NoPermissionAccessForm();
                addFormInMainLayout(noPermissionAccessForm);
            }

        }

        private void btnAcceptTask_Click(object sender, EventArgs e)
        {
            this.formCurrent = "AcceptTaskForm";
            bool checkPermission = permissionBLL.checkPermission(this.idTaiKhoan, "Q0021");
            setStateButton(btnAcceptTask);
            if (checkPermission)
            {
                AcceptTaskForm acceptTaskForm = new AcceptTaskForm(this);
                addFormInMainLayout(acceptTaskForm);
            }
            else
            {
                NoPermissionAccessForm noPermissionAccessForm = new NoPermissionAccessForm();
                addFormInMainLayout(noPermissionAccessForm);
            }
;
            
        }

        private void btnReportTask_Click(object sender, EventArgs e)
        {
            bool checkPermission = permissionBLL.checkPermission(this.idTaiKhoan, "Q0022");
            setStateButton(btnReportTask);
            if (checkPermission)
            {
                ReportTaskForm reportTaskForm = new ReportTaskForm(this);
                addFormInMainLayout(reportTaskForm);
            }
            else
            {
                NoPermissionAccessForm noPermissionAccessForm = new NoPermissionAccessForm();
                addFormInMainLayout(noPermissionAccessForm);
            }
            
        }

        private void btnAdjustTask_Click(object sender, EventArgs e)
        {
            AssignmentAdjustmentTaskForm assignmentAdjustmentTaskForm = new AssignmentAdjustmentTaskForm();
            addFormInMainLayout(assignmentAdjustmentTaskForm);
            setStateButton(btnAdjustTask);
        }

        private void TaskForm_Load(object sender, EventArgs e)
        {
        }

        private void btnReportOnline_Click(object sender, EventArgs e)
        {
            ReportTaskOnlineForm reportTaskOnlineForm = new ReportTaskOnlineForm();
            reportTaskOnlineForm.Show();
        }
    }
}
