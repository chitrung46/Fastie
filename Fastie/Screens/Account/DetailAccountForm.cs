using Fastie.Components.LayoutAccount;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastie.Screens.Account
{
    public partial class DetailAccountForm : Form
    {
        private LayoutAccountForm layoutAccountForm;
        public DetailAccountForm(LayoutAccountForm layoutAccountForm)
        {
            InitializeComponent();
            this.layoutAccountForm = layoutAccountForm;
        }

        private void DetailAccountForm_Load(object sender, EventArgs e)
        {
            lblPersonnelName.Text = layoutAccountForm.PersonnelName;
            lblPart.Text = layoutAccountForm.DepartmentName;
            lblPosition.Text = layoutAccountForm.PositionName;
            lblState.Text = layoutAccountForm.StatusAccount;
            lblEmail.Text = layoutAccountForm.Email;
            lblNumberPhone.Text = layoutAccountForm.PhoneNumber;
            lblUsername.Text = layoutAccountForm.Username;
            lblPassword.Text = layoutAccountForm.Password;
        }
    }
}
