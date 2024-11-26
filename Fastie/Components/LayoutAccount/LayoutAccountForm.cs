using BLL.PermissionBLL;
using Fastie.Components.Toastify;
using Fastie.Screens.Account;
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
        private string username;
        private string password;
        private string email;
        private string positionId;
        private string departmentId;
        private string personnelId;

        private string phoneNumber;
        PermissionBLL permissionBLL = new PermissionBLL();  

        private AccountForm accountForm;
        private HomeForm homeForm;  

        public LayoutAccountForm()
        {
            InitializeComponent();
        }


        public LayoutAccountForm(AccountForm accountForm, HomeForm homeForm)
        {
            InitializeComponent();
            this.accountForm = accountForm;
            this.homeForm = homeForm;
        }

        public string PersonnelId
        {
            get { return personnelId; }
            set { personnelId = value; }
        }
        public string DepartmentId
        {
            get { return departmentId; }
            set { departmentId = value; }
        }
        public string PositionId
        {
            get { return positionId; }
            set { positionId = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; lblUsername.Text = username;}
        }
        public string Password
        {
            get { return password; }
            set { password = value;}
        }

        public string Email
        {
            get { return email; }
            set { email = value;}
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; lblNumberphone.Text = phoneNumber; }
        }
        public string PersonnelName
        {
            get { return personnelName; }
            set { personnelName = value; lblPersonnelName.Text = personnelName; }
        }

        public string DepartmentName
        {
            get { return departmentName; }
            set { departmentName = value; }
        }
        public string PositionName
        {
            get { return positionName; }
            set { positionName = value; }
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
            //CreateAccount createAccount = new CreateAccount();
            //createAccount.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditAccount editAccount = new EditAccount(accountForm, this);    
            editAccount.Show();
        }

        private void showMessage(string message, string type)
        {
            LayoutToastify layoutToastify = new LayoutToastify();
            layoutToastify.SetMessage(message, type);
            layoutToastify.Show();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string idTaiKhoan = homeForm.IdTaiKhoan;
            bool checkPermission = permissionBLL.checkPermission(idTaiKhoan, "Q0005");
            if (checkPermission)
            {
                string[] information;

                if (statusAccount == "Vô hiệu hóa")
                {
                    information = new string[]
                    {
                        "Kích hoạt lại tài khoản?",
                        "Tài khoản này sẽ hoạt động lại",
                        "Kích hoạt"
                    };
                }
                else
                {
                    information = new string[]
                    {
                        "Vô hiệu hóa tài khoản?",
                        $"{this.personnelName} sẽ được vô hiệu hóa",
                        "Vô hiệu hóa"
                    };
                }

                LayoutConfirmForm layoutConfirmForm = new LayoutConfirmForm(accountForm, this.idAccount)
                {
                    Title = information[0],
                    Content = information[1],
                    btnConfirmText = information[2]
                };

                layoutConfirmForm.Show();
            }
            else
            {
                showMessage("Bạn không có quyền xóa tài khoản", "Thông báo");
            }
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            DetailAccountForm detailAccountForm = new DetailAccountForm(this);
            detailAccountForm.Show();
        }

        private void LayoutAccountForm_Load(object sender, EventArgs e)
        {
            if(statusAccount == "Vô hiệu hóa")
            {
                btnDelete.BackColor = Color.Red;
            }
        }
    }
}
