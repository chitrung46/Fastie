using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Net;
using DAL;
using DTO;

namespace BLL
{
    public class ResetPasswordBLL
    {
        // getListAllAccount
        public List<Account> getListAllAccount()
        {
            return ResetPasswordDAL.GetListAllAccount();
        }

        // update account
        public bool UpdateAccount(string tenDangNhap, string matKhau)
        {
            return ResetPasswordDAL.UpdateAccount(tenDangNhap, matKhau);
        }

        // get account by email
        public Account GetAccountByEmail(string email)
        {
            return ResetPasswordDAL.GetAccountByEmail(email);
        }

        // Send email to get password
        public bool SendMailToGetPassword(string email, string matKhauMail)
        {
            Personnel nhanSu = ResetPasswordDAL.GetPersonnelByEmail(email);
            if (nhanSu == null)
            {
                return false;
            }

            try
            {
                string from = "anhquan20041452@gmail.com"; //Email to send
                string pass = matKhauMail;                // the app password to send email
                string to = nhanSu.Email;                 // the receiver email
                string content = $"Hi {nhanSu.Ten}, mật khẩu của bạn là: ..."; // Content to send

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
                return true; 
            }
            catch (Exception)
            {
                return false; 
            }
        }


        // Update new password
        public bool UpdateNewPassword(string email, string newPassword)
        {
            return ResetPasswordDAL.UpdatePassword(email, newPassword);
        }
        public string GetPasswordByEmail(string email)
        {
            return ResetPasswordDAL.GetPasswordByEmail(email); // Gọi phương thức DAL
        }


    }
}