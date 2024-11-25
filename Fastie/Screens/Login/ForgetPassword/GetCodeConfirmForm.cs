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
using Fastie.Components.Toastify;



namespace Fastie.Screens.Login.ForgetPassword
{
    public partial class GetCodeConfirmForm : Form
    {
        private string generatedCode; 
        private int attemptCount = 0;
        private string userEmail;

        public GetCodeConfirmForm(string code, string email)
        {
            InitializeComponent();
            generatedCode = code;
            userEmail = email;

        }

        private void showMessage(string message, string type)
        {
            LayoutToastify layoutToastify = new LayoutToastify();
            layoutToastify.SetMessage(message, type);
            layoutToastify.Show();
        }

        private void btnConfirmCode_Click(object sender, EventArgs e)
        {
            string enteredCode = txtCode1.Text + txtCode2.Text + txtCode3.Text + txtCode4.Text;

            if (enteredCode == generatedCode)
            {
                // Mã xác nhận đúng, mở form đặt lại mật khẩu
                ResetPasswordForm resetPasswordForm = new ResetPasswordForm(userEmail);
                resetPasswordForm.Show();
                this.Close();
            }
            else
            {
               attemptCount++;
                if(attemptCount >= 3)
                {
                    showMessage("Bạn đã nhập sai quá 3 lần. Vui lòng nhập lại mail", "error");
                    ForgetPasswordForm forgetPasswordForm = new ForgetPasswordForm();
                    forgetPasswordForm.Show();
                    this.Close();
                }
                else
                {
                    showMessage("Mã xác nhận không đúng! Bạn còn " + (3 - attemptCount) + " lần nhập.", "error");

                    ClearCodeFields();
                }
            }
        }
        private void ClearCodeFields()
        {
            txtCode1.Text = string.Empty;
            txtCode2.Text = string.Empty;
            txtCode3.Text = string.Empty;
            txtCode4.Text = string.Empty;
            txtCode1.Focus(); // Đưa con trỏ về ô đầu tiên
        }

        // Kiểm soát các ký tự nhập vào cho các ô mã (chỉ cho phép số)
        private void txtCode_KeyPress(object sender, KeyPressEventArgs e, TextBox nextTextBox)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (nextTextBox != null && e.KeyChar != (char)Keys.Back)
            {
                nextTextBox.Focus();
            }
        }

        private void txtCode1_Load(object sender, EventArgs e)
        {

        }

        private void txtCode1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (txtCode1.Text.Length == 0) {
                txtCode2.Focus();
            }
            else if (txtCode1.Text.Length == 1 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCode2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (txtCode2.Text.Length == 0)
            {
                txtCode3.Focus();
            }
            else if (txtCode2.Text.Length == 1 && !char.IsControl(e.KeyChar))
            {
                txtCode3.Focus();
                e.Handled = true;
            }
        }

        private void txtCode3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (txtCode3.Text.Length == 0)
            {
                txtCode4.Focus();
            }
            else if (txtCode3.Text.Length == 1 && !char.IsControl(e.KeyChar))
            {
                txtCode4.Focus();
                e.Handled = true;
            }
        }

        private void txtCode4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (txtCode4.Text.Length == 0)
            {
                btnConfirmCode.Focus();
            }
            else if (txtCode4.Text.Length == 1 && !char.IsControl(e.KeyChar))
            {
                btnConfirmCode.Focus();
                e.Handled = true;
            }
        }

        private void customPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GetCodeConfirmForm_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnConfirmCode;
        }
    }
}
