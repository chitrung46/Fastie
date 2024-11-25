using Fastie.Screens.Login.ForgetPassword;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using BLL.LoginBLL;
using DTO;
using Fastie.Components.Toastify;
using Fastie.Screens.ContactInformation;
using System.Text.RegularExpressions;
namespace Fastie.Screens.Login
{
    public partial class LoginForm : Form
    {
        LoginBLL loginBLL = new LoginBLL();
        GetInFoLoginBLL getInFoLoginBLL = new GetInFoLoginBLL();    
        Account acc = new Account();
        public LoginForm()
        {
            InitializeComponent();
        }
        private void showMessage(string message, string type)
        {
            LayoutToastify layoutToastify = new LayoutToastify();
            layoutToastify.SetMessage(message, type);
            layoutToastify.Show();
        }
        private void pictureEye_Click(object sender, EventArgs e)
        {

        }

        private void lblForgetPassword_Click(object sender, EventArgs e)
        {
            ForgetPasswordForm forgetPasswordForm = new ForgetPasswordForm();
            forgetPasswordForm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnLogin;
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            acc.TenDangNhap = txtEmail.Text;
            acc.MatKhau = txtPassword.Text;
            string[] getUser = loginBLL.checkLogin(acc);

            if (string.IsNullOrWhiteSpace(acc.TenDangNhap))
            {
                showMessage("Email không được để trống", "error");
                return;
            }
            if(!IsValidEmail(acc.TenDangNhap))
            {
                showMessage("Email không hợp lệ!", "error");
                return;
            }
            if (string.IsNullOrWhiteSpace(acc.MatKhau))
            {
                showMessage("Mật khẩu không được để trống", "error");
                return;
            }

            if (getUser.Length == 1 && getUser[0] == "Email hoặc mật khẩu không chính xác!")
            {
                showMessage("Email hoặc mật khẩu không đúng!", "error");
                return;
            }

            if (getUser[4] == "Vô hiệu hóa")
            {
                showMessage("Tài khoản của bạn đã bị vô hiệu hóa!", "error");
                return;
            }

            string[] getInfoUser = getInFoLoginBLL.LayTenNhanSuVaBoPhan(getUser[0]);
            string tenNhanSu = getInfoUser[0];
            string tenBoPhan = getInfoUser[1];
            List<AccountId> userData = new List<AccountId>
            {
                new AccountId(getUser[0], getUser[1], getUser[2], getUser[3], tenNhanSu, tenBoPhan)
            };
            UserAccountSession.Instance.SetUserInfo(userData);
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }

        private void lblForgetPassword_Click_1(object sender, EventArgs e)
        {
            ForgetPasswordForm forgetPasswordForm = new ForgetPasswordForm();
            forgetPasswordForm.Show();
        }

        private void pictureEye_Click_1(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == true)
            {

                txtPassword.PasswordChar = false;
                pictureEye.Image = Properties.Resources.icons8_hide_50;
            }
            else
            {
                txtPassword.PasswordChar = true;
                pictureEye.Image = Properties.Resources.icons8_eye_23;
            }
        }
        public bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Mẫu kiểm tra định dạng email
                string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                return Regex.IsMatch(email, emailPattern);
            }
            catch (Exception)
            {
                return false;
            }
        }
        private void pictureBoxHelp_Click(object sender, EventArgs e)
        {
            ContactInformationForm contactInformationForm = new ContactInformationForm();
            contactInformationForm.Show();
        }

        private void lblTerm_Click(object sender, EventArgs e)
        {
            TermForm termForm = new TermForm();
            termForm.Show();
        }


    }

}
