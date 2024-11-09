using BLL.PermissionBLL;
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

        PermissionBLL permissionBLL = new PermissionBLL();  

        private AccountForm accountForm;
        private HomeForm homeForm;  
        public LayoutAccountForm(AccountForm accountForm, HomeForm homeForm)
        {
            InitializeComponent();
            this.accountForm = accountForm;
            this.homeForm = homeForm;
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
            CreateAccount createAccount = new CreateAccount();
            createAccount.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditAccount editAccount = new EditAccount();    
            editAccount.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string idTaiKhoan = homeForm.IdTaiKhoan;
            bool checkPermission = permissionBLL.checkPermission(idTaiKhoan, "Q0005");
            if (checkPermission)
            {
                string[] information = { "Bạn có chắc chắn xóa tài khoản này?", $"{this.personnelName} sẽ được xóa khỏi hệ thống", "Xóa tài khoản" };
                LayoutConfirmForm deleteLayoutConfirm = new LayoutConfirmForm(this, this.idAccount);
                deleteLayoutConfirm.Title = information[0];
                deleteLayoutConfirm.Content = information[1];
                deleteLayoutConfirm.btnConfirmText = information[2];
                deleteLayoutConfirm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền xóa tài khoản", "Thông báo");
            }
        }
    }
}
