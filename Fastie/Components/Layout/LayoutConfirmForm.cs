using Fastie.Screens.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastie
{
    public partial class LayoutConfirmForm : Form
    {
        public LayoutConfirmForm()
        {
            InitializeComponent();
        }

        public string Title
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }

        public string Content 
        {
            get { return lblContent.Text; }
            set { lblContent.Text = value; }
        }

        public string btnConfirmText
        {
            get { return btnConfirm.Text; }
            set { btnConfirm.Text = value; }
        }

        private void pictureClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LayoutConfirm_Load(object sender, EventArgs e)
        {
            lblContent.Text = Content;
            lblTitle.Text = Title;
            btnConfirm.Text = btnConfirmText;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            switch (btnConfirm.Text)
            {
                case "Xóa":
                    MessageBox.Show("Xóa thành công");
                    break;
                case "Cập nhật":
                    MessageBox.Show("Cập nhật thành công");
                    break;
                case "Thêm":
                    MessageBox.Show("Thêm thành công");
                    break;
                case "Đăng xuất":
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                    break;
                default:
                    break;
            }
        }
    }
}
