using BLL;
using DTO;
using Fastie.Components.LayoutAccount;
using Fastie.Components.LayoutPersonnel;
using Fastie.Components.Toastify;
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
using System.Text.RegularExpressions;

namespace Fastie
{
    public partial class EditAccount : Form
    {
        private LayoutAccountForm layoutAccountForm;
        private AccountForm accountForm;
        AccountBLL accountBLL = new AccountBLL();
        public EditAccount(AccountForm accountForm, LayoutAccountForm layoutAccountForm)
        {
            InitializeComponent();
            this.layoutAccountForm = layoutAccountForm;
            this.accountForm = accountForm;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditAccount_Load(object sender, EventArgs e)
        {
            txtUsername.Text = layoutAccountForm.Username;
            txtPassword.Text = layoutAccountForm.Password;
            this.AcceptButton = btnAdd;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                showMessage("Vui lòng nhập tên đăng nhập", "error");
                btnAdd.Enabled = true;
                return;
            }
            if (!IsValidEmail(txtUsername.Text))
            {
                showMessage("Tên đăng nhập không hợp lệ", "error");
                btnAdd.Enabled = true;
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                showMessage("Vui lòng nhập mật khẩu", "error");
                btnAdd.Enabled = true;
                return;
            }
            if (txtPassword.Text.Length < 6)
            {
                showMessage("Mật khẩu phải có ít nhất 6 ký tự", "error");
                btnAdd.Enabled = true;
                return;
            }

            Account updateAccount = new Account
            {
                TenDangNhap = txtUsername.Text,
                MatKhau = txtPassword.Text,
                Id = layoutAccountForm.IdAccount,
            };

            int result = accountBLL.CapNhatTaiKhoan(updateAccount);
            try
            {
                if (result == -1)
                {
                    showMessage("Tên đăng nhập đã tồn tại!", "error");
                    this.Close();
                }
                else if (result == 0)
                {
                    sendEmail();
                    showMessage("Cập nhật tài khoản thành công!", "success");
                    accountForm.LoadDataAccount();
                    this.Close();
                }
                else
                {
                    showMessage("Vui lòng thử lại sao!", "error");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                showMessage("Đã xảy ra lỗi không mong muốn!", "error");
                this.Close();
            }
        }
        private void showMessage(string message, string type)
        {
            LayoutToastify layoutToastify = new LayoutToastify();
            layoutToastify.SetMessage(message, type);
            layoutToastify.Show();
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
        private bool sendEmail()
        {
            try
            {
                // Thông tin email gửi
                string fromEmail = "fastie.n02@gmail.com";
                string fromPassword = "rtpl hzno ottm erol"; // Mật khẩu ứng dụng của email gửi

                // Lấy thông tin người nhận từ TextBox hoặc biến đầu vào
                string name = layoutAccountForm.PersonnelName;
                string email = layoutAccountForm.Email;
                string userName = txtUsername.Text.Trim();


                // Nội dung email xác nhận tạo tài khoản thành công
                string content = $@"
Kính gửi {name},

Chúng tôi xin thông báo rằng tài khoản của bạn tại Fastie đã được cập nhật thành công!  

Dưới đây là thông tin tài khoản sau khi cập nhật:  
- Tên tài khoản: {userName}  
- Email đăng ký: {email}  
- Thời gian cập nhật: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}

Nếu bạn không thực hiện thay đổi này hoặc nhận thấy bất kỳ hoạt động nào bất thường trên tài khoản của mình, xin vui lòng liên hệ với chúng tôi ngay lập tức qua email này hoặc gọi đến số 0939999666 để được hỗ trợ.

Chúng tôi luôn sẵn sàng hỗ trợ bạn và cam kết bảo vệ thông tin cá nhân cũng như tài khoản của bạn.  

Cảm ơn bạn đã tiếp tục tin tưởng và đồng hành cùng Fastie!  

Trân trọng,  
Fastie  
Đội ngũ hỗ trợ khách hàng  
";


                // Tạo đối tượng MailMessage
                MailMessage mail = new MailMessage();
                mail.To.Add(email); // Email người nhận
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
