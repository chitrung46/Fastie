using Fastie.Components.LayoutNotification;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastie.Screens.Task.Components
{
    public partial class DetailNotificationForm : Form
    {
        private NotificationForm notification;
        public DetailNotificationForm(NotificationForm notification)
        {
            InitializeComponent();
            this.notification = notification;
        }

        private void lblDepartmentContent_Click(object sender, EventArgs e)
        {

        }

        private void DetailNotificationForm_Load(object sender, EventArgs e)
        {
            lblTaskAssigner.Text = notification.AssignerName;
            lblTaskDetail.Text = notification.TaskName;

        }
    }
}
