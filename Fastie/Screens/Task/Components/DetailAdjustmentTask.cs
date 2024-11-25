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
    public partial class DetailAdjustmentTask : Form
    {
        private string reason;
        public DetailAdjustmentTask(string reason)
        {
            InitializeComponent();
            this.reason = reason;
        }

        private void txtReason_Load(object sender, EventArgs e)
        {
            txtReason.Text = this.reason;
        }
    }
}
