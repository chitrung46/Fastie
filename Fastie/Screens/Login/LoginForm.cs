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
namespace Fastie.Screens.Login
{
    public partial class LoginForm : Form
    {
        AccountBLL taiKhoanBLL = new AccountBLL();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {

            acc.TenDangNhap = txt_Email.Text;
            acc.MatKhau = txtPassword.Text;

            string getUser = taiKhoanBLL.checkLogin(acc);
            switch (getUser)
            {
                case "required_email":
                    MessageBox.Show("Email không được để trống");
                    return;
                case "required_password":
                    MessageBox.Show("Mật khẩu không được để trống");
                    return;
                case "Email hoặc mật khẩu không chính xác!":
                    MessageBox.Show("Email hoặc mật khẩu không chính xác!");
                    return;
            }
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();


        }

    }

}
