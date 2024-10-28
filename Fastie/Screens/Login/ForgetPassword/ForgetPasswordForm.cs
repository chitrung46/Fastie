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
    public partial class ForgetPasswordForm : Form
    {
        public ForgetPasswordForm()
        {
            InitializeComponent();
        }

        private void btnGetPassword_Click(object sender, EventArgs e)
        {
            GetCodeConfirmForm getCodeConfirmForm = new GetCodeConfirmForm();
            getCodeConfirmForm.Show();
        }

        private void ForgetPasswordForm_Load(object sender, EventArgs e)
        {

        }
    }
}
