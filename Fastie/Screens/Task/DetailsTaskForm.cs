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
        private Panel mainLayout;
        public DetailsTaskForm(Panel mainLayout)
        {
            InitializeComponent();
            this.mainLayout = mainLayout;
        }

        private void customPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void addFormInMainLayout(Form userControl)
        {
            mainLayout.Controls.Clear();
            userControl.TopLevel = false;
            mainLayout.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            userControl.Show();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            TaskTableForm taskTableForm = new TaskTableForm(mainLayout);
            addFormInMainLayout(taskTableForm);
        }

        private void pictureBack_Click(object sender, EventArgs e)
        {
            TaskTableForm taskTableForm = new TaskTableForm(mainLayout);
            addFormInMainLayout(taskTableForm);
        }
    }
}
