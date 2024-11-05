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
        private Panel mainLayout;
        public LayoutTaskForm(Panel mainLayout)
        {
            InitializeComponent();
            this.mainLayout = mainLayout;
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

        
        //Add form in main layout
        private void addFormInMainLayout(Form userControl)
        {
            mainLayout.Controls.Clear();
            userControl.TopLevel = false;
            mainLayout.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            userControl.Show();
        }

        private void btnGetInformation_Click(object sender, EventArgs e)
        {
            DetailsTaskForm detailsTaskForm = new DetailsTaskForm(mainLayout);
            addFormInMainLayout(detailsTaskForm);
        }
    }
}
