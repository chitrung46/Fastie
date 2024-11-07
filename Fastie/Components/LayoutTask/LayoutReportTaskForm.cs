﻿using System;
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
    public partial class LayoutDetailReportTaskForm : UserControl
    {
        private string reportContent;
        private string reportDate;
        private string fileName;
        private string imageName;
        private string idReport;

        public LayoutDetailReportTaskForm()
        {
            InitializeComponent();
        }


        public string ReportContent
        {
            get { return reportContent; }
            set { reportContent = value; lblReportContent.Text = reportContent; }
        }

        public string IdReport
        {
            get { return idReport; }
            set { idReport = value; }
        }

        public string ReportDate
        {
            get { return reportDate; }
            set { reportDate = value; lblReportDate.Text = reportDate; }
        }
        public string FileName
        {
            get { return fileName; }
            set { fileName = value; lblFileName.Text = fileName;}
        }
        public string ImageName
        {
            get { return imageName; }
            set { imageName = value; lblImageName.Text = imageName; }
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {

        }

        private void LayoutDetailReportTaskForm_Load(object sender, EventArgs e)
        {
        }
    }
}
