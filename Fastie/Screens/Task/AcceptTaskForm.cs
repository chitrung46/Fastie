using Fastie.Components.LayoutRole;
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
    public partial class AcceptTaskForm : Form
    {
        public AcceptTaskForm()
        {
            InitializeComponent();
        }

        private void AcceptTaskForm_Load(object sender, EventArgs e)
        {
            LoadDataTaskTable("Việc chủ động");
        }
        private void setStateButton(Button stateButton)
        {
            Button[] button = { btnInitialtiveTask, btnAssignTask};
            for (int i = 0; i < button.Length; i++)
            {
                if (button[i] != stateButton)
                {
                    button[i].BackColor = Color.FromArgb(55, 55, 55);
                }
            }
            stateButton.BackColor = Color.IndianRed;
        }

        private void LoadDataTaskTable(string data) //mokup data, we will replace 'string data = List<T> data'
        {
            flowLayoutPanelTasks.Controls.Clear(); 
            LayoutGetTaskForm[] layoutGetTaskForm = new LayoutGetTaskForm[20];
            for (int i = 0; i < 20; i++)
            {
                layoutGetTaskForm[i] = new LayoutGetTaskForm
                {
                    TaskName = data + " " + i,
                    TaskTime = "11/1/2025 ",
                    TaskStatus = "Đã hoàn thành ",
                    JobAssigner = "Đặng Nhật Toàn "
                };
                flowLayoutPanelTasks.Controls.Add(layoutGetTaskForm[i]);
            }
        }

        private void flowLayoutPanelTasks_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInitialtiveTask_Click(object sender, EventArgs e)
        {
            LoadDataTaskTable("Việc chủ động");
            setStateButton(btnInitialtiveTask);
        }

        private void btnAssignTask_Click(object sender, EventArgs e)
        {
            LoadDataTaskTable("Việc được giao");
            setStateButton(btnAssignTask);
        }
    }
}
