using System;
using System.Windows.Forms;
using BLL;
using Fastie.Components.Toastify;
using Microsoft.Office.Interop.Word;
namespace Fastie.Screens.Login.ForgetPassword
{
    public partial class ResetPasswordForm : Form
    {
        ResetPasswordBLL resetPasswordBLL = new ResetPasswordBLL();
        private string userEmail;

        // Khởi tạo với email được truyền từ `GetCodeConfirmForm`
        public ResetPasswordForm(string email)
        {
            InitializeComponent();
            userEmail = email;
        }

        private void showMessage(string message, string type)
        {
            LayoutToastify layoutToastify = new LayoutToastify();
            layoutToastify.SetMessage(message, type);
            layoutToastify.Show();
        }
        private void btnGetPassword_Click(object sender, EventArgs e)
        {
            string newPassword = txtNewPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            // Kiểm tra xem mật khẩu có khớp không
            if (newPassword != confirmPassword)
            {
                showMessage("Mật khẩu và xác nhận mật khẩu không khớp!", "error");
                return;
            }

            // Kiểm tra tính hợp lệ của mật khẩu mới (ví dụ: độ dài tối thiểu)
            if (string.IsNullOrEmpty(newPassword) || newPassword.Length < 6)
            {
                showMessage("Mật khẩu phải có ít nhất 6 ký tự!", "error");
                return;
            }
            string currentPassword = resetPasswordBLL.GetPasswordByEmail(userEmail);
            if (currentPassword == newPassword)
            {
                showMessage("Mật khẩu mới không được giống mật khẩu cũ. Vui lòng nhập mật khẩu khác.", "error");
                return;
            }
            // Gọi BLL để cập nhật mật khẩu trong cơ sở dữ liệu
            bool isUpdated = resetPasswordBLL.UpdateNewPassword(userEmail, newPassword);
            if (isUpdated)
            {
                showMessage("Đặt lại mật khẩu thành công!", "success");
                this.Close();
            }
            else
            {
                showMessage("Có lỗi xảy ra khi đặt lại mật khẩu.", "error");
            }
        }

        private void ResetPasswordForm_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnGetPassword;
        }
    }
}
