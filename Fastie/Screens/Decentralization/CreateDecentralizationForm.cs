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
    public partial class CreateDecentralizationForm : Form
    {
        public CreateDecentralizationForm()
        {
            InitializeComponent();
        }

        private void checkboxPersonnelManagement_CheckedChanged(object sender, EventArgs e)
        {
            if(checkboxPersonnelManagement.Checked)
            {
                checkboxAddPersonnel.Checked = true;
                checkboxUpdatePersonnel.Checked = true;
                checkboxDeletePersonnel.Checked = true;
            } else
            {
                checkboxAddPersonnel.Checked = false;
                checkboxUpdatePersonnel.Checked = false;
                checkboxDeletePersonnel.Checked = false;
            }   
        }

        private void checkboxPartManagement_CheckedChanged(object sender, EventArgs e)
        {
            if(checkboxPartManagement.Checked)
            {
                checkboxAddPart.Checked = true;
                checkboxUpdatePart.Checked = true;
                checkboxDeletePart.Checked = true;
            } else
            {
                checkboxAddPart.Checked = false;
                checkboxUpdatePart.Checked = false;
                checkboxDeletePart.Checked = false;
            }
        }

        private void checkboxPositionManagement_CheckedChanged(object sender, EventArgs e)
        {
            if(checkboxPositionManagement.Checked)
            {
                checkboxAddPosition.Checked = true;
                checkboxUpdatePosition.Checked = true;
                checkboxDeletePosition.Checked = true;
            } else
            {
                checkboxAddPosition.Checked = false;
                checkboxUpdatePosition.Checked = false;
                checkboxDeletePosition.Checked = false;
            }
        }

        private void checkboxAccountManagement_CheckedChanged(object sender, EventArgs e)
        {
            if(checkboxAccountManagement.Checked)
            {
                checkboxAddAccount.Checked = true;
                checkboxUpdateAccount.Checked = true;
                checkboxDeleteAccount.Checked = true;
            } else
            {
                checkboxAddAccount.Checked = false;
                checkboxUpdateAccount.Checked = false;
                checkboxDeleteAccount.Checked = false;
            }
        }

        private void checkboxTasksManagement_CheckedChanged(object sender, EventArgs e)
        {
            if(checkboxTasksManagement.Checked)
            {
                checkboxSendComments.Checked = true;
                checkboxSendNotification.Checked = true;
                checkboxAssignTasks.Checked = true;
                checkboxDeleteTasks.Checked = true;
                checkboxUpdateTasks.Checked = true;
            } else
            {
                checkboxSendComments.Checked = false;
                checkboxSendNotification.Checked = false;
                checkboxAssignTasks.Checked = false;
                checkboxDeleteTasks.Checked = false;
                checkboxUpdateTasks.Checked = false;

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
