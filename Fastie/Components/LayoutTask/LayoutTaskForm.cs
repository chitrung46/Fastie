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

        public LayoutTaskForm()
        {
            InitializeComponent();
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
    }
}
