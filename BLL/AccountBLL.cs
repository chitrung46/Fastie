using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Net;
using DAL;
using DTO;

/*
namespace BLL
{
    public class AccountBLL
    {
        private AccountAccess taiKhoanDAL = new AccountAccess();

        // Kiểm tra đăng nhập
        public bool KiemTraDangNhap(string tenDangNhap, string matKhau)
        {
            Account taiKhoan = taiKhoanDAL.CheckLogin(tenDangNhap, matKhau);
            return taiKhoan != null;
        }

        // Lấy danh sách tất cả tài khoản
        public List<Account> LayTatCaTaiKhoan()
        {
            return taiKhoanDAL.GetAllAccounts();
        }

        // Thêm tài khoản mới
        public string ThemTaiKhoan(string tenDangNhap, string matKhau)
        {
            string result = taiKhoanDAL.InsertAccount(tenDangNhap, matKhau);
            if (result == "Tài khoản đã được thêm thành công.")
            {
                return "Tài khoản đã được thêm thành công.";
            }
            else
            {
                return result; // Trả về thông báo lỗi nếu tên đăng nhập đã tồn tại
            }
        }

        // Xóa tài khoản
        public bool XoaTaiKhoan(string tenDangNhap, string matKhau)
        {
            return taiKhoanDAL.DeleteAccount(tenDangNhap, matKhau);
        }

        // Cập nhật tài khoản
        public bool CapNhatTaiKhoan(string tenDangNhap, string matKhau)
        {
            return taiKhoanDAL.UpdateAccount(tenDangNhap, matKhau);
        }


        public Account LayTaiKhoanBangEmail(string email)
        {
            return taiKhoanDAL.GetAccountByEmail(email);
        }

        public bool GuiMailLayLaiMatKhau(Account taiKhoan, string matKhauMail)
        {
            try
            {
                string from = "anhquan20041452@gmail.com"; // Email gửi
                string pass = matKhauMail;             // Mật khẩu ứng dụng email gửi
                string to = taiKhoan.Email;            // Email người nhận
                string content = $"Hi, mật khẩu của bạn là: {taiKhoan.matKhau}";  // Nội dung

                System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
                mail.To.Add(to);
                mail.From = new System.Net.Mail.MailAddress(from);
                mail.Subject = "Gửi lại mật khẩu";
                mail.Body = content;

                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                smtp.Credentials = new System.Net.NetworkCredential(from, pass);

                smtp.Send(mail);
                return true; // Gửi thành công
            }
            catch (Exception)
            {
                return false; // Gửi thất bại
            }
        }

        public bool UpdatePassword(string email, string newPassword)
        {
            return taiKhoanDAL.UpdatePassword(email, newPassword);
        }



    }
}
*/


namespace BLL
{
    public class AccountBLL
    {
        private AccountAccess taiKhoanDAL = new AccountAccess();

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
