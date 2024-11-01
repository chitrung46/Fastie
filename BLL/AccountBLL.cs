using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Net;
using DAL;
using DTO;

namespace BLL
{
    public class AccountBLL
    {
        private DatabaseAccess taiKhoanDAL = new DatabaseAccess();

        // Kiểm tra đăng nhập
        public string KiemTraDangNhap(Account acc)
        {
            if (string.IsNullOrWhiteSpace(acc.TenDangNhap))
            {
                return "required_email";
            }

            if (string.IsNullOrWhiteSpace(acc.MatKhau))
            {
                return "required_password";
            }

            string info = taiKhoanDAL.CheckLoginDTO(acc);
            return info;
        }

        // Lấy danh sách tất cả tài khoản
        public List<Account> LayTatCaTaiKhoan()
        {
            return taiKhoanDAL.GetAllAccounts();
        }

        // Cập nhật tài khoản
        public bool CapNhatTaiKhoan(string tenDangNhap, string matKhau)
        {
            return taiKhoanDAL.UpdateAccount(tenDangNhap, matKhau);
        }

        // Lấy tài khoản theo email
        public Account LayTaiKhoanBangEmail(string email)
        {
            return taiKhoanDAL.GetAccountByEmail(email);
        }

        // Gửi mail để lấy lại mật khẩu
        public bool GuiMailLayLaiMatKhau(string email, string matKhauMail)
        {
            return taiKhoanDAL.GuiMailLayLaiMatKhau(email, matKhauMail);
        }

        // Cập nhật mật khẩu
        public bool UpdatePassword(string email, string newPassword)
        {
            return taiKhoanDAL.UpdatePassword(email, newPassword);
        }
    }
}


/*
namespace BLL
{
    public class AccountBLL
    {
        //private AccountAccess taiKhoanDAL = new AccountAccess();
        private DatabaseAccess taikhoanDAL = new DatabaseAccess();

        // Kiểm tra đăng nhập
        public string checkLogin(Account acc)
        {
            if (acc.TenDangNhap == "")
            {
                return "required_email";
            }

            if (acc.MatKhau == "")
            {
                return "required_password";
            }

            string info = taiKhoanDAL.checkLogin(acc);
            return info;

        }



        // Lấy danh sách tất cả tài khoản
        public List<Account> LayTatCaTaiKhoan()
        {
            return taiKhoanDAL.GetAllAccounts();
        }


        // Cập nhật tài khoản
        public bool CapNhatTaiKhoan(string tenDangNhap, string matKhau)
        {
            return taiKhoanDAL.UpdateAccount(tenDangNhap, matKhau);
        }

        // Lấy tài khoản theo email
        public Account LayTaiKhoanBangEmail(string email)
        {
            return taiKhoanDAL.GetAccountByEmail(email);
        }

        // Gửi mail để lấy lại mật khẩu
        public bool GuiMailLayLaiMatKhau(string email, string matKhauMail)
        {
            Nhansu nhanSu = taiKhoanDAL.GetNhanSuByEmail(email);
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
            return taiKhoanDAL.UpdatePassword(email, newPassword);
        }

    }
}
*/