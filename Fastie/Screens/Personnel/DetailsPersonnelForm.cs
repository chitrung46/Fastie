using Fastie.Components.LayoutPersonnel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastie.Screens.Personnel
{
    public partial class DetailsPersonnelForm : Form
    {
        private LayoutPersonnelForm layoutPersonnelForm;
        public DetailsPersonnelForm(LayoutPersonnelForm layoutPersonnelForm)
        {
            InitializeComponent();
            this.layoutPersonnelForm = layoutPersonnelForm;
        }

        private void DetailsPersonnelForm_Load(object sender, EventArgs e)
        {
            lblName.Text = layoutPersonnelForm.PersonnelName;
            lblEmail.Text = layoutPersonnelForm.Email;
            lblGender.Text = layoutPersonnelForm.Gender;
            lblDateOfBirth.Text = layoutPersonnelForm.DateOfBirth.ToString("dd/MM/yyyy");
            lblDateOfWork.Text = layoutPersonnelForm.DateOfWork.ToString("dd/MM/yyyy");
            lblNumberPhone.Text = layoutPersonnelForm.NumberPhone;
        }
    }
}
