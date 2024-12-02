using Fastie.Screens.Task.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastie.Components.LayoutNotification
{
    public partial class NotificationForm : UserControl
    {
        private string taskName;
        private string assignerName;
        private string actionName;

        public NotificationForm()
        {
            InitializeComponent();
        }

        public string TaskName
        {
            get { return taskName; }
            set { taskName = value; lblTaskName.Text = value; }
        }
        public string AssignerName
        {
            get { return assignerName; }
            set { assignerName = value; lblAssignerName.Text = value; }
        }
        public string ActionName
        {
            get { return actionName; }
            set { actionName = value;}
        }

        private void pictureboxDetail_Click(object sender, EventArgs e)
        {
            DetailNotificationForm detailNotificationForm = new DetailNotificationForm(this);
            detailNotificationForm.Show();
        }
    }
}
