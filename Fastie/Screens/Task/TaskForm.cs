using BLL.PermissionBLL;
using Fastie.Components.LayoutRole;
using Fastie.Components.NoPermissionAccessForm;
using Fastie.Screens.Task;
using Fastie.Screens.Task.AssignmentAdjustmentTask;
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
        PermissionBLL permissionBLL = new PermissionBLL();

        private string idTaiKhoan;
        private string idChucVu;    
        public TaskForm(string idTaiKhoan, string idChucVu)
        {
            InitializeComponent();
            this.idTaiKhoan = idTaiKhoan;
            this.idChucVu = idChucVu;

            bool checkPermission = permissionBLL.checkPermission(this.idTaiKhoan, "Q0019");
            setStateButton(btnTaskTable);
            if (checkPermission) {

                TaskTableForm taskTableForm = new TaskTableForm(mainLayout);
                addFormInMainLayout(taskTableForm);

            } else {
                NoPermissionAccessForm noPermissionAccessForm = new NoPermissionAccessForm();
                addFormInMainLayout(noPermissionAccessForm);
            }
        }
 
        public string IdTaiKhoan { get => idTaiKhoan; set => idTaiKhoan = value; }
        public string IdChucVu { get => idChucVu; set => idChucVu = value; }


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
            bool checkPermission = permissionBLL.checkPermission(this.idTaiKhoan, "Q0019");
            setStateButton(btnTaskTable);
            if (checkPermission)
            {
                TaskTableForm taskTableForm = new TaskTableForm(mainLayout);
                addFormInMainLayout(taskTableForm);
            } else
            {
                NoPermissionAccessForm noPermissionAccessForm = new NoPermissionAccessForm();
                addFormInMainLayout(noPermissionAccessForm);
            }
        }

        private void btnAssignTask_Click(object sender, EventArgs e)
        {
            bool checkPermission = permissionBLL.checkPermission(this.idTaiKhoan, "Q0020");
            setStateButton(btnAssignTask);
            if (checkPermission)
            {
                AssignTaskForm assignTaskForm = new AssignTaskForm();
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
            bool checkPermission = permissionBLL.checkPermission(this.idTaiKhoan, "Q0021");
            setStateButton(btnAcceptTask);
            if (checkPermission)
            {
                AcceptTaskForm acceptTaskForm = new AcceptTaskForm();
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
                ReportTaskForm reportTaskForm = new ReportTaskForm();
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
    }
}
