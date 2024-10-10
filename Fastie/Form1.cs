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
            Decentralization decentralization = new Decentralization();
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
        private void pnlDecentralization_Click(object sender, EventArgs e)
        {
            Decentralization decentralization = new Decentralization();
            addFormInMainLayout(decentralization);
            setStatePanel(stateDecentralization);
        }

        private void pnlPart_Click(object sender, EventArgs e)
        {
            Part part = new Part();
            addFormInMainLayout(part);
            setStatePanel(statePart);
        }

        private void pnlPosition_Click(object sender, EventArgs e)
        {
            Position position = new Position();
            addFormInMainLayout(position);
            setStatePanel(statePosition);
        }

        private void pnlPersonnel_Click(object sender, EventArgs e)
        {
            Personnel personnel = new Personnel();
            addFormInMainLayout(personnel);
            setStatePanel(statePersonnel);
        }

        private void pnlWork_Click(object sender, EventArgs e)
        {
            Work work = new Work();
            addFormInMainLayout(work);
            setStatePanel(stateWork);
        }

        private void pnlAnalytics_Click(object sender, EventArgs e)
        {
            Analytics analytics = new Analytics();
            addFormInMainLayout(analytics);
            setStatePanel(stateAnalytics);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //Set hover
        private void pnlDecentralization_MouseLeave(object sender, EventArgs e)
        {
            pnlDecentralization.BackColor = Color.Transparent;
        }

        private void pnlDecentralization_MouseEnter(object sender, EventArgs e)
        {
            pnlDecentralization.BackColor = Color.FromArgb(91, 91, 92);
        }

        private void pnlPart_MouseEnter(object sender, EventArgs e)
        {
            pnlPart.BackColor = Color.FromArgb(91, 91, 92);
        }

        private void pnlPart_MouseLeave(object sender, EventArgs e)
        {
            pnlPart.BackColor = Color.Transparent;  
        }

        private void pnlPosition_MouseEnter(object sender, EventArgs e)
        {
            pnlPosition.BackColor = Color.FromArgb(91, 91, 92);
        }

        private void pnlPosition_MouseLeave(object sender, EventArgs e)
        {
            pnlPosition.BackColor = Color.Transparent;
        }

        private void pnlPersonnel_MouseEnter(object sender, EventArgs e)
        {
            pnlPersonnel.BackColor = Color.FromArgb(91, 91, 92);
        }

        private void pnlPersonnel_MouseLeave(object sender, EventArgs e)
        {
            pnlPersonnel.BackColor = Color.Transparent;
        }

        private void pnlWork_MouseEnter(object sender, EventArgs e)
        {
            pnlWork.BackColor = Color.FromArgb(91, 91, 92); 
        }

        private void pnlWork_MouseLeave(object sender, EventArgs e)
        {
            pnlWork.BackColor = Color.Transparent;
        }

        private void pnlAnalytics_MouseEnter(object sender, EventArgs e)
        {
            pnlAnalytics.BackColor = Color.FromArgb(91, 91, 92);
        }

        private void pnlAnalytics_MouseLeave(object sender, EventArgs e)
        {
            pnlAnalytics.BackColor = Color.Transparent;
        }

        private void pnlLogout_MouseEnter(object sender, EventArgs e)
        {
            pnlLogout.BackColor = Color.FromArgb(91, 91, 92);
        }

        private void pnlLogout_MouseLeave(object sender, EventArgs e)
        {
            pnlLogout.BackColor = Color.Transparent;
        }
    }
}
