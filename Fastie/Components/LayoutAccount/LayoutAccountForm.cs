using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastie.Components.LayoutAccount
{
    public partial class LayoutAccountForm : UserControl
    {
        private string personnelName;
        private string departmentName;
        private string positionName;
        private string statusAccount;
        private string hasAccount;
        private string idAccount;

        private AccountForm accountForm;
        public LayoutAccountForm(AccountForm accountForm)
        {
            InitializeComponent();
            this.accountForm = accountForm;
        }

        public string PersonnelName
        {
            get { return personnelName; }
            set { personnelName = value; lblPersonnelName.Text = personnelName; }
        }

        public string DepartmentName
        {
            get { return departmentName; }
            set { departmentName = value; lblDepartmentName.Text = departmentName; }
        }
        public string PositionName
        {
            get { return positionName; }
            set { positionName = value; lblPositionName.Text = positionName; }
        }
        public string StatusAccount
        {
            get { return statusAccount; }
            set { statusAccount = value; lblStatusAccount.Text = statusAccount; }
        }
        public string HasAccount
        {
            get { return hasAccount; }
            set { hasAccount = value; lblHasAccount.Text = hasAccount; }
        }
        public string IdAccount
        {
            get { return idAccount; }
            set { idAccount = value; }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
