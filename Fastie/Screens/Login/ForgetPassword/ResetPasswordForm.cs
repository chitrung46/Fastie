using BLL;
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
    public partial class ResetPasswordForm : Form
    {
        private AccountBLL taiKhoanBLL = new AccountBLL();
        private string userEmail;

        // Khởi tạo với email được truyền từ `GetCodeConfirmForm`
        public ResetPasswordForm(string email)
        {
            InitializeComponent();
            userEmail = email;
        }

        private void btnGetPassword_Click(object sender, EventArgs e)
        {
            string newPassword = txtNewPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            // Kiểm tra xem mật khẩu có khớp không
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp!");
                return;
            }

            // Kiểm tra tính hợp lệ của mật khẩu mới (ví dụ: độ dài tối thiểu)
            if (string.IsNullOrEmpty(newPassword) || newPassword.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự!");
                return;
            }

            // Gọi BLL để cập nhật mật khẩu trong cơ sở dữ liệu
            bool isUpdated = taiKhoanBLL.UpdatePassword(userEmail, newPassword);
            if (isUpdated)
            {
                MessageBox.Show("Đặt lại mật khẩu thành công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi đặt lại mật khẩu.");
            }
        }
    }
}
