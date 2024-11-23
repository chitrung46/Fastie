using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using Fastie.Components.Toastify;

namespace Fastie.Screens.Login.ForgetPassword
{
    public partial class ForgetPasswordForm : Form
    {
        ResetPasswordBLL resetPassword = new ResetPasswordBLL();
        private string verificationCode; // Lưu mã xác nhận để so sánh sau

        public ForgetPasswordForm()
        {
            InitializeComponent();
        }

        private void showMessage(string message, string type)
        {
            LayoutToastify layoutToastify = new LayoutToastify();
            layoutToastify.SetMessage(message, type);
            layoutToastify.Show();
        }
        private void btnGetPassword_Click(object sender, EventArgs e)
        {
            string email = customTextBox_mail.Text.Trim();
            btnGetPassword.Enabled = false;
            // Kiểm tra xem email có tồn tại trong hệ thống
            Account account = resetPassword.GetAccountByEmail(email);
            if (account == null)
            {
                showMessage("Email không tồn tại trong hệ thống!", "error");
                btnGetPassword.Enabled = true;
                return;
            }

            // Tạo mã xác nhận ngẫu nhiên (4 chữ số)
            verificationCode = new Random().Next(1000, 9999).ToString();

            // Gửi email chứa mã xác nhận
            bool isSent = SendVerificationCode(email, verificationCode);
            if (isSent)
            {
                showMessage("Mã xác nhận đã được gửi qua email!", "success");

                // Mở form xác nhận mã với mã đã gửi
                // Mở form xác nhận mã với mã và email đã gửi
                GetCodeConfirmForm confirmForm = new GetCodeConfirmForm(verificationCode, email);
                confirmForm.Show();
                this.Close();

            }
            else
            {
                showMessage("Lỗi khi gửi email!", "error");
                this.Close();
            }
        }

        private bool SendVerificationCode(string toEmail, string code)
        {
            try
            {
                string fromEmail = "fastie.n02@gmail.com";
                string fromPassword = "rtpl hzno ottm erol"; ; // Mật khẩu ứng dụng của email gửi
                string content = $"Hệ thống phần mềm Fastie đã nhận được yêu cầu đổi mật khẩu\r\ncủa bạn.\r\nVui lòng nhập Mã xác nhận dưới đây để tiến hành đổi mật khẩu.\r\nMã xác nhận: {code}\r\nVui lòng không chia sẻ mã này với người khác vì lí do bảo mật.";

                MailMessage mail = new MailMessage();
                mail.To.Add(toEmail);
                mail.From = new MailAddress(fromEmail);
                mail.Subject = "Mã xác nhận lấy lại mật khẩu";
                mail.Body = content;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com")
                {
                    EnableSsl = true,
                    Port = 587,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new NetworkCredential(fromEmail, fromPassword)
                };

                smtp.Send(mail);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void ForgetPasswordForm_Load(object sender, EventArgs e)
        {

        }
    }
}
