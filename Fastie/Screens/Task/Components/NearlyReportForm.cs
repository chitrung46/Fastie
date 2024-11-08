using Fastie.Components.LayoutTask;
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
    public partial class NearlyReportForm : Form
    {
        public NearlyReportForm()
        {
            InitializeComponent();
        }

        public void LoadDataTaskTable()
        {
            int length = 5; //Change report data length
            if (length > 0)
            {
                flowLayoutPanelReport.Controls.Clear();
                for (int i = 0; i < length; i++)
                {
                    LayoutDetailReportForm layoutDetailReportForm = new LayoutDetailReportForm()
                    {
                        ReportContent = "Đây là nội dung báo cáo " + i,
                        ReportDate = "20/11/2024",
                        FileName = "file_" + i + ".txt",
                        ImageName = "image_" + i + ".png",
                        IdReport = "ID" + i
                    };

                    flowLayoutPanelReport.Controls.Add(layoutDetailReportForm);
                }
            }
        }

        private void NearlyReportForm_Load(object sender, EventArgs e)
        {
            LoadDataTaskTable();
        }
    }
}
