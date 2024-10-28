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
using BLL;
namespace Fastie
{
    public partial class LayoutConfirmForm : Form
    {
        private string accountName;
        private DecentralizationForm decentralizationForm;
        AccountBLL accountBll = new AccountBLL();
        public LayoutConfirmForm()
        {
            InitializeComponent();
        }

        public LayoutConfirmForm(DecentralizationForm decentralization ,string accountName)
        {
            InitializeComponent();
            this.accountName = accountName;
            this.decentralizationForm = decentralization;   
        }

        public string AccountName { get => accountName; set => accountName = value; }   
        public string Title { get => lblTitle.Text; set => lblTitle.Text = value; }
        public string Content { get => lblContent.Text; set => lblContent.Text = value; }
        public string btnConfirmText { get => btnConfirm.Text; set => btnConfirm.Text = value; }

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
                case "Xóa quyền":
                    MessageBox.Show("id", this.accountName);
                    bool result = accountBll.deleteAllRoles(this.accountName);
                    if(result)
                    {
                        MessageBox.Show("Xóa quyền thành công");
                        decentralizationForm.loadData();
                    }
                    else
                    {
                        MessageBox.Show("Xóa quyền thất bại");
                    }
                    this.Close();
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
