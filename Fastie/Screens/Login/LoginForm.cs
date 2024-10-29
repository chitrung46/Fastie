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
using BLL;
using DTO;
using System.Web;
namespace Fastie.Screens.Login
{
    public partial class LoginForm : Form
    {

        //Initial AccountBLL and Account
        AccountBLL accBLL = new AccountBLL();   
        Account acc = new Account();
       
        public LoginForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            acc.TenDangNhap = txtUsername.Text;
            acc.MatKhau = txtPassword.Text;

            string[] getUser = accBLL.checkLogin(acc);

            if (getUser.Length == 1 && getUser[0] == "Email hoặc mật khẩu không chính xác!")
            {
                MessageBox.Show("Email hoặc mật khẩu không chính xác!");
                return;
            }

            if (string.IsNullOrWhiteSpace(acc.TenDangNhap))
            {
                MessageBox.Show("Email không được để trống");
                return;
            }

            if (string.IsNullOrWhiteSpace(acc.MatKhau))
            {
                MessageBox.Show("Mật khẩu không được để trống");
                return;
            }

            List<(string, string, string, string)> userData = new List<(string, string, string, string)>
            {
                (getUser[0], getUser[1], getUser[2], getUser[3])
            };
            UserAccountSession.Instance.SetUserInfo(userData);
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();

        }
    }

}
