using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastie.Screens.Login.ForgetPassword
{
    public partial class GetCodeConfirmForm : Form
    {
        public GetCodeConfirmForm()
        {
            InitializeComponent();
        }

        private void GetCodeConfirmForm_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmCode_Click(object sender, EventArgs e)
        {
            if(txtCode1 != null && txtCode2 != null && txtCode3 != null && txtCode4 != null)
            {
                String code = txtCode1.Text + txtCode2.Text + txtCode3.Text + txtCode4.Text;
                ResetPasswordForm resetPasswordForm = new ResetPasswordForm();
                resetPasswordForm.Show();
            }
            else
            {
                MessageBox.Show("Code is incorrect");
                //Hanlde when the code is not equal with the code email
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

    }
}
