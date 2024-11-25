using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fastie.Components.Toastify;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Text.RegularExpressions;

namespace Fastie.Screens.ContactInformation
{
    public partial class ContactInformationForm : Form
    {
        public ContactInformationForm()
        {
            InitializeComponent();
        }

        private void showMessage(string message, string type)
        {
            LayoutToastify layoutToastify = new LayoutToastify();
            layoutToastify.SetMessage(message, type);
            layoutToastify.Show();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // Kiểm tra các điều kiện trước khi gọi hàm gửi yêu cầu
            btnSend.Enabled = false;

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                showMessage("Vui lòng nhập tên!", "error");
                btnSend.Enabled = true;
                return;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                showMessage("Vui lòng nhập email!", "error");
                btnSend.Enabled = true;
                return;
            }

            if (!IsValidEmail(txtEmail.Text))
            {
                showMessage("Email không hợp lệ!", "error");
                btnSend.Enabled = true;
                return;
            }

            if (string.IsNullOrWhiteSpace(cbTypeRequest.Texts) || cbTypeRequest.Texts == "Chọn")
            {
                showMessage("Vui lòng chọn chủ đề yêu cầu!", "error");
                btnSend.Enabled = true;
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDescribe.Text))
            {
                showMessage("Vui lòng nhập mô tả vấn đề!", "error");
                btnSend.Enabled = true;
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNumberphone.Text))
            {
                showMessage("Vui lòng nhập số điện thoại liên hệ!", "error");
                btnSend.Enabled = true;
                return;
            }

            // Gọi hàm sendRequest để gửi email
            bool result = sendRequest();

            if (result)
            {
                showMessage("Yêu cầu hỗ trợ của bạn đã được gửi thành công!", "success");
                this.Close();
            }
            else
            {
                showMessage("Có lỗi xảy ra khi gửi yêu cầu. Vui lòng thử lại sau!", "error");
                this.Close();
            }
        }

        public bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Mẫu kiểm tra định dạng email
                string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                return Regex.IsMatch(email, emailPattern);
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool sendRequest()
        {
            try
            {
                // Thông tin email gửi
                string fromEmail = "fastie.n02@gmail.com";
                string fromPassword = "rtpl hzno ottm erol"; // Mật khẩu ứng dụng của email gửi

                // Lấy thông tin người nhận từ TextBox hoặc biến đầu vào
                string userEmail = txtEmail.Text.Trim();
                string userName = txtName.Text.Trim(); // Nếu bạn có trường tên người dùng

                // Lấy thông tin về yêu cầu (có thể được truyền vào từ giao diện)
                string subject = cbTypeRequest.Texts.Trim(); // Chủ đề yêu cầu hỗ trợ
                string issueDescription = txtDescribe.Text.Trim(); // Mô tả vấn đề người dùng gửi
                string phoneNumber = txtNumberphone.Text.Trim(); // Số điện thoại liên hệ

                // Nội dung email xác nhận
                string content = $@"
Kính gửi {userName},

Cảm ơn bạn đã liên hệ với đội ngũ Firon! Chúng tôi đã nhận được yêu cầu hỗ trợ của bạn và sẽ xem xét ngay lập tức. Một trong các đại diện của chúng tôi sẽ liên hệ lại với bạn trong thời gian sớm nhất để giải quyết vấn đề của bạn.

Dưới đây là thông tin về yêu cầu của bạn:

- Ngày gửi yêu cầu: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}
- Chủ đề yêu cầu: {subject}
- Mô tả vấn đề: {issueDescription}
- Số điện thoại liên hệ: {phoneNumber}

Chúng tôi cam kết sẽ hỗ trợ bạn một cách nhanh chóng và hiệu quả. Nếu có thêm thông tin cần cung cấp hoặc nếu bạn có bất kỳ câu hỏi nào, xin vui lòng trả lời email này hoặc gọi điện cho chúng tôi qua số 0939999666.

Chân thành cảm ơn và mong được hỗ trợ bạn!

Trân trọng,
Firon
Đội ngũ hỗ trợ khách hàng
                ";

                // Tạo đối tượng MailMessage
                MailMessage mail = new MailMessage();
                mail.To.Add(userEmail); // Email người nhận
                mail.From = new MailAddress(fromEmail); // Email người gửi
                mail.Subject = "Xác nhận yêu cầu hỗ trợ của bạn - [Đội ngũ Firon]"; // Tiêu đề email
                mail.Body = content; // Nội dung email

                // Thiết lập cấu hình SMTP
                SmtpClient smtp = new SmtpClient("smtp.gmail.com")
                {
                    EnableSsl = true,
                    Port = 587,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new NetworkCredential(fromEmail, fromPassword)
                };

                // Gửi email
                smtp.Send(mail);

                // Trả về true nếu gửi thành công
                return true;
            }
            catch (Exception ex)
            {
                // Xử lý lỗi, có thể log thêm thông tin lỗi vào đây
                showMessage(ex.Message, "error");
                return false;
            }


        }
    }
}
