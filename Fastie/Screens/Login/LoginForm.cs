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
namespace Fastie.Screens.Login
{
    public partial class LoginForm : Form
    {
        LoginBLL loginBLL = new LoginBLL();
        Account acc = new Account();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void pictureEye_Click(object sender, EventArgs e)
        {
            if(txtPassword.PasswordChar == true)
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

        private void lblForgetPassword_Click(object sender, EventArgs e)
        {
            ForgetPasswordForm forgetPasswordForm = new ForgetPasswordForm();
            forgetPasswordForm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            acc.TenDangNhap = txtEmail.Text;
            acc.MatKhau = txtPassword.Text;
            lblError.Visible = false;
            lblError.Text = "";
            string[] getUser = loginBLL.checkLogin(acc);

            if (getUser.Length == 1 && getUser[0] == "Email hoặc mật khẩu không chính xác!")
            {
                lblError.Text = "Email hoặc mật khẩu không chính xác!";
                lblError.Visible = true;
                return;
            }

            if (getUser[4] == "Vô hiệu hóa")
            {
                lblError.Text = "Tài khoản của bạn đã bị vô hiệu hóa!";
                lblError.Visible = true;
                return;
            }

            if (string.IsNullOrWhiteSpace(acc.TenDangNhap))
            {
                lblError.Text = "Email không được để trống";
                lblError.Visible = true;
                return;
            }

            if (string.IsNullOrWhiteSpace(acc.MatKhau))
            {
                lblError.Text = "Mật khẩu không được để trống";
                lblError.Visible = true;
                return;
            }

            List<AccountId> userData = new List<AccountId>
            {
                new AccountId(getUser[0], getUser[1], getUser[2], getUser[3])
            };
            UserAccountSession.Instance.SetUserInfo(userData);
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }
    }

}
