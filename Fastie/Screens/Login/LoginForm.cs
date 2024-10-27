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

namespace Fastie.Screens.Login
{
    public partial class LoginForm : Form
    {
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
    }
    
}
