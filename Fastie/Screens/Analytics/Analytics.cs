using Fastie.Screens.Analytics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Fastie
{
    public partial class Analytics : Form
    {
        public Analytics()
        {
            InitializeComponent();
        }

        private void Analytics_Load(object sender, EventArgs e)
        {
            PieChartStatusTaskForm pieChartStatusTaskForm = new PieChartStatusTaskForm();
            addFormInMainLayout(pieChartStatusTaskForm);
        }

        private void addFormInMainLayout(Form userControl)
        {
            PanelChart.Controls.Clear();
            userControl.TopLevel = false;
            PanelChart.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            userControl.Show();
        }
    }
}
