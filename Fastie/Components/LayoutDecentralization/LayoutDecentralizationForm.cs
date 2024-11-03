using Fastie.Screens.Decentralization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastie.Components.LayoutDecentralization
{
    public partial class LayoutDecentralizationForm : UserControl
    {
        private string number;
        private string personnelName;
        private string positionName;
        private string departmentName;

        private string accountName;
        private DecentralizationForm decentralizationBackupForm;
        public LayoutDecentralizationForm()
        {
            InitializeComponent();
        }

        public LayoutDecentralizationForm(DecentralizationForm decentralizationBackupForm)
        {
            InitializeComponent();
            this.decentralizationBackupForm = decentralizationBackupForm;
        }

        public string Number
        {
            get { return number; }
            set { number = value; lblNumber.Text = number; }
        }
        public string PersonnelName
        {
            get { return personnelName; }
            set { personnelName = value; lblPersonnelName.Text = personnelName; }
        }
        public string PositionName
        {
            get { return positionName; }
            set { positionName = value; lblPositionName.Text = positionName; }
        }
        public string DepartmentName
        {
            get { return departmentName; }
            set { departmentName = value; lblDepartmentName.Text = departmentName; }
        }

        public string AccountName
        {
            get { return accountName; }
            set { accountName = value;}
        }
        private void btnUpdateDecentralization_Click(object sender, EventArgs e)
        {
            UpdateDecentralizationForm createDecentralization = new UpdateDecentralizationForm(this,this.accountName);
            createDecentralization.Show();
        }

        public void loadDataFromDecentralization()
        {
            switch (decentralizationBackupForm.StateCurrentList) {
                case "Role":
                    decentralizationBackupForm.loadDataForRole();
                    break;
                case "Roleless":
                    decentralizationBackupForm.loadDataForRoleLess();
                    break;
                default:
                    break;
            }
        }
        private void btnDeleteAllPermission_Click(object sender, EventArgs e)
        {
            if(decentralizationBackupForm.StateCurrentList == "Role")
            {
                string[] information = { "Bạn có chắc chắn xóa toàn bộ quyền?", $"{this.personnelName} sẽ mất toàn bộ quyền trong hệ thống", "Xóa quyền" };
                LayoutConfirmForm deleteLayoutConfirm = new LayoutConfirmForm(this, this.accountName);
                deleteLayoutConfirm.Title = information[0];
                deleteLayoutConfirm.Content = information[1];
                deleteLayoutConfirm.btnConfirmText = information[2];
                deleteLayoutConfirm.Show();
            }
        }
        private void hideDeleteButton()
        {
            if (decentralizationBackupForm.StateCurrentList == "Roleless")
            {
                btnDeleteAllPermission.Visible = false;
            }
            else
            {
                btnDeleteAllPermission.Visible = true;
            }
        }

        private void LayoutDecentralizationForm_Load(object sender, EventArgs e)
        {
            hideDeleteButton();
        }

    }
}
