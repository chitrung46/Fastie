using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastie
{
    public partial class FormLayout : Form
    {
        public FormLayout()
        {
            InitializeComponent();
        }

        private void FormLayout_Load(object sender, EventArgs e)
        {
            DecentralizationForm decentralization = new DecentralizationForm();
            addFormInMainLayout(decentralization);
        }

        //Add form in main layout
        private void addFormInMainLayout(Form userControl)
        {
            mainLayout.Controls.Clear();
            userControl.TopLevel = false;
            mainLayout.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            userControl.Show();
        }

        //Check other panel is not click
        private void setStatePanel(Panel statePanel)
        {
            Panel[] panel = { stateDecentralization, statePart, statePosition, statePersonnel, stateWork, stateAnalytics };
            for (int i = 0; i < panel.Length; i++)
            {
                if (panel[i] != statePanel)
                {
                    panel[i].BackColor = Color.Transparent;
                }
            }
            statePanel.BackColor = Color.FromArgb(59, 171, 201);
        }

        //Set Click panel

        private void btnDecentralization_Click(object sender, EventArgs e)
        {
            DecentralizationForm decentralization = new DecentralizationForm();
            addFormInMainLayout(decentralization);
            setStatePanel(stateDecentralization);
        }

        private void btnPart_Click(object sender, EventArgs e)
        {
            DepartmentForm part = new DepartmentForm();
            addFormInMainLayout(part);
            setStatePanel(statePart);
        }

        private void btnPosition_Click(object sender, EventArgs e)
        {
            PositionForm position = new PositionForm();
            addFormInMainLayout(position);
            setStatePanel(statePosition);
        }

        private void btnPersonnel_Click(object sender, EventArgs e)
        {
            PersonnelForm personnel = new PersonnelForm();
            addFormInMainLayout(personnel);
            setStatePanel(statePersonnel);
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            TaskForm work = new TaskForm();
            addFormInMainLayout(work);
            setStatePanel(stateWork);
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            Analytics analytics = new Analytics();
            addFormInMainLayout(analytics);
            setStatePanel(stateAnalytics);
        }

        //Set hover
        private void pnlDecentralization_MouseLeave(object sender, EventArgs e)
        {
            btnDecentralization.BackColor = Color.Transparent;
        }

        private void pnlDecentralization_MouseEnter(object sender, EventArgs e)
        {
            btnDecentralization.BackColor = Color.FromArgb(91, 91, 92);
        }

        private void pnlPart_MouseEnter(object sender, EventArgs e)
        {
            btnPart.BackColor = Color.FromArgb(91, 91, 92);
        }

        private void pnlPart_MouseLeave(object sender, EventArgs e)
        {
            btnPart.BackColor = Color.Transparent;  
        }

        private void pnlPosition_MouseEnter(object sender, EventArgs e)
        {
            btnPosition.BackColor = Color.FromArgb(91, 91, 92);
        }

        private void pnlPosition_MouseLeave(object sender, EventArgs e)
        {
            btnPosition.BackColor = Color.Transparent;
        }

        private void pnlPersonnel_MouseEnter(object sender, EventArgs e)
        {
            btnPersonnel.BackColor = Color.FromArgb(91, 91, 92);
        }

        private void pnlPersonnel_MouseLeave(object sender, EventArgs e)
        {
            btnPersonnel.BackColor = Color.Transparent;
        }

        private void pnlWork_MouseEnter(object sender, EventArgs e)
        {
            btnWork.BackColor = Color.FromArgb(91, 91, 92); 
        }

        private void pnlWork_MouseLeave(object sender, EventArgs e)
        {
            btnWork.BackColor = Color.Transparent;
        }

        private void pnlAnalytics_MouseEnter(object sender, EventArgs e)
        {
            btnAnalytics.BackColor = Color.FromArgb(91, 91, 92);
        }

        private void pnlAnalytics_MouseLeave(object sender, EventArgs e)
        {
            btnAnalytics.BackColor = Color.Transparent;
        }

        private void pnlLogout_MouseEnter(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.FromArgb(91, 91, 92);
        }

        private void pnlLogout_MouseLeave(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.Transparent;
        }

        private void stateDecentralization_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
