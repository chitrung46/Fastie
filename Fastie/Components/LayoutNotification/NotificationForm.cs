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
            get { return AssignerName; }
            set { assignerName = value; lblAssignerName.Text = value; }
        }
    }
}
