using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using DAL;
using System.Net.Http;
using DTO;

namespace BLL
{
    public class ResetPasswordBLL
    {
        // Lấy danh sách tất cả tài khoản
        public List<Account> LayTatCaTaiKhoan()
        {
            return ResetPasswordDAL.GetAllAccounts();
        }

        // Cập nhật tài khoản
        public bool CapNhatTaiKhoan(string tenDangNhap, string matKhau)
        {
            return ResetPasswordDAL.UpdateAccount(tenDangNhap, matKhau);
        }

        // Lấy tài khoản theo email
        public Account LayTaiKhoanBangEmail(string email)
        {
            return ResetPasswordDAL.GetAccountByEmail(email);
        }

        // Gửi mail để lấy lại mật khẩu
        public bool GuiMailLayLaiMatKhau(string email, string matKhauMail)
        {
            Nhansu nhanSu = ResetPasswordDAL.GetNhanSuByEmail(email);
            if (nhanSu == null)
            {
                // Nếu không tìm thấy nhân sự, báo lỗi
                return false;
            }

            try
            {
                string from = "anhquan20041452@gmail.com"; // Email gửi
                string pass = matKhauMail;                // Mật khẩu ứng dụng email gửi
                string to = nhanSu.Email;                 // Email người nhận
                string content = $"Hi {nhanSu.Ten}, mật khẩu của bạn là: ..."; // Nội dung

                MailMessage mail = new MailMessage
                {
                    From = new MailAddress(from),
                    Subject = "Gửi lại mật khẩu",
                    Body = content
                };
                mail.To.Add(to);

                SmtpClient smtp = new SmtpClient("smtp.gmail.com")
                {
                    EnableSsl = true,
                    Port = 587,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new NetworkCredential(from, pass)
                };

                smtp.Send(mail);
                return true; // Gửi thành công
            }
            catch (Exception)
            {
                return false; // Gửi thất bại
            }
        }


        // Cập nhật mật khẩu
        public bool UpdatePassword(string email, string newPassword)
        {
            return ResetPasswordDAL.UpdatePassword(email, newPassword);
        }

    }
}