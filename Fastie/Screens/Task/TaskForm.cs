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

namespace Fastie
{
    public partial class TaskForm: Form
    {
        public TaskForm()
        {
            InitializeComponent();
            btnTaskTable.BackColor = Color.FromArgb(59, 171, 201);
            btnAssignTask.BackColor = Color.FromArgb(55, 55, 55);
            btnAcceptTask.BackColor = Color.FromArgb(55, 55, 55);
            btnReportTask.BackColor = Color.FromArgb(55, 55, 55);
            btnAdjustTask.BackColor = Color.FromArgb(55, 55, 55);
        }

        public void LoadForm(object Form)
        {
            if (this.pnlTask.Controls.Count > 0)
                this.pnlTask.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnlTask.Controls.Add(f);
            this.pnlTask.Tag = f;
            f.Show();
        }
        private void btnTaskTable_Click(object sender, EventArgs e)
        {
            btnTaskTable.BackColor = Color.FromArgb(59, 171, 201);
            btnAssignTask.BackColor = Color.FromArgb(55, 55, 55);
            btnAcceptTask.BackColor = Color.FromArgb(55, 55, 55);
            btnReportTask.BackColor = Color.FromArgb(55, 55, 55);
            btnAdjustTask.BackColor = Color.FromArgb(55, 55, 55);
        }

        private void btnAssignTask_Click(object sender, EventArgs e)
        {
            LoadForm(new AssignTaskForm());
            btnAssignTask.BackColor = Color.FromArgb(59, 171, 201);
            btnTaskTable.BackColor = Color.FromArgb(55, 55, 55);
            btnAcceptTask.BackColor = Color.FromArgb(55, 55, 55);
            btnReportTask.BackColor = Color.FromArgb(55, 55, 55);
            btnAdjustTask.BackColor = Color.FromArgb(55, 55, 55);
        }

        private void btnAcceptTask_Click(object sender, EventArgs e)
        {
            btnAcceptTask.BackColor = Color.FromArgb(59, 171, 201);
            btnTaskTable.BackColor = Color.FromArgb(55, 55, 55);
            btnAssignTask.BackColor = Color.FromArgb(55, 55, 55);
            btnReportTask.BackColor = Color.FromArgb(55, 55, 55);
            btnAdjustTask.BackColor = Color.FromArgb(55, 55, 55);
        }

        private void btnReportTask_Click(object sender, EventArgs e)
        {
            btnReportTask.BackColor = Color.FromArgb(59, 171, 201);
            btnTaskTable.BackColor = Color.FromArgb(55, 55, 55);
            btnAcceptTask.BackColor = Color.FromArgb(55, 55, 55);
            btnAcceptTask.BackColor = Color.FromArgb(55, 55, 55);
            btnAdjustTask.BackColor = Color.FromArgb(55, 55, 55);
        }

        private void btnAdjustTask_Click(object sender, EventArgs e)
        {
            btnAdjustTask.BackColor = Color.FromArgb(59, 171, 201);
            btnTaskTable.BackColor = Color.FromArgb(55, 55, 55);
            btnAcceptTask.BackColor = Color.FromArgb(55, 55, 55);
            btnReportTask.BackColor = Color.FromArgb(55, 55, 55);
            btnAssignTask.BackColor = Color.FromArgb(55, 55, 55);
        }
    }
}
