﻿using Fastie.Screens.Task;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastie.Components.LayoutRole
{
    public partial class LayoutGetTaskForm : UserControl
    {
        private string taskName;
        private string taskTime;
        private string taskStatus;
        private string taskJobAssigner;

        public LayoutGetTaskForm()
        {
            InitializeComponent();
        }

        public string TaskName
        {
            get { return taskName; }
            set { taskName = value; lblTitleTask.Text = value; }
        }
        public string TaskTime
        {
            get { return taskTime; }
            set { taskTime = value; lblTaskTime.Text = value; }
        }

        public string TaskStatus
        {
            get { return taskStatus; }
            set { taskStatus = value; btnTaskStatus.Text = value; }
        }
        public string JobAssigner
        {
            get { return taskJobAssigner; }
            set { taskJobAssigner = value; lblJobAssigner.Text = value; }
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
