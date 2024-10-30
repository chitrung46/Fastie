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
    public class AccountBLL
    {
        //For account login
        AccountAccess accountDAL = new AccountAccess();
        public string[] checkLogin(Account acc)
        {
            if (acc.TenDangNhap == "")
            {
                return new string[] { "required_email" };
            }

            if (acc.MatKhau == "")
            {
                return new string[] { "required_password" };
            }

            return accountDAL.checkLogin(acc);

        }

        //For Decentralization
        public AccountInfo getAccountInfo(string accountId)
        {
            try
            {
                return DatabaseAccess.getAccountInfo(accountId);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL: " + ex.Message);
            }
        }
        public List<AccountInfo> getAllAccountInfo()
        {
            try
            {
                return DatabaseAccess.getAllAccountInfo();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL: " + ex.Message);
            }
        }
        public List<Permission> getAllPermissions(string accountId)
        {
            try
            {
                return DatabaseAccess.getAllPermissionsByAccountId(accountId);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL: " + ex.Message);
            }
        }

        public bool hasPermission(string accountId, string permissionId)
        {
            var permissions = getAllPermissions(accountId);
            return permissions.Any(p => p.id == permissionId);
        }

        public bool deleteAllRoles(string accountId)
        {
            try
            {
                return DatabaseAccess.deleteAllRoles(accountId);
            } catch (Exception ex)
            {
                throw new Exception("Lỗi BLL" + ex.Message);
            }
        }

        public List<AccountInfo> getAllPersonnelRoleLess()
        {
            try
            {
                return DatabaseAccess.getAllPersonnelRoleLess();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL" + ex.Message);
            }
        }

        public bool updateRoles(string accountId, string listNameRoles)
        {
            try
            {
                return DatabaseAccess.updateRoles(accountId, listNameRoles);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL" + ex.Message);
            }
        }
        
        public List<PositionInfo> getPositionList()
        {
            try
            {
                return DatabaseAccess.getPositionList();
            } catch (Exception ex)
            {
                throw new Exception("Lỗi BLL" + ex.Message);
            }
        }

        public List<DepartmentInfo> getDepartmentList()
        {
            try
            {
                return DatabaseAccess.getDepartmentList();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL" + ex.Message);
            }
        }

        //For have Role
        public List<AccountInfo> getListByDepartmentIdAndPositionId(string idDepartment, string idPosition)
        {
            try
            {
                return DatabaseAccess.getListByDepartmentIdAndPositionId(idDepartment, idPosition);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL" + ex.Message);
            }
        }
        public List<AccountInfo> getDepartmentListwithAllPosition(string idDepartment)
        {
            try
            {
                return DatabaseAccess.getDepartmentListwithAllPosition(idDepartment);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL" + ex.Message);
            }
        }
        public List<AccountInfo> getPositionListwithAllDepartment(string idPosition)
        {
            try
            {
                return DatabaseAccess.getPositionListwithAllDepartment(idPosition);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL" + ex.Message);
            }
        }
        //For Roleless
        public List<AccountInfo> getListByDepartmentIdAndPositionIdRoleLess(string idDepartment, string idPosition)
        {
            try
            {
                return DatabaseAccess.getListByDepartmentIdAndPositionIdRoleLess(idDepartment, idPosition);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL" + ex.Message);
            }
        }
        public List<AccountInfo> getDepartmentListwithAllPositionRoleLess(string idDepartment)
        {
            try
            {
                return DatabaseAccess.getDepartmentListwithAllPositionRoleLess(idDepartment);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL" + ex.Message);
            }
        }
        public List<AccountInfo> getPositionListwithAllDepartmentRoleLess(string idPosition)
        {
            try
            {
                return DatabaseAccess.getPositionListwithAllDepartmentRoleLess(idPosition);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL" + ex.Message);
            }
        }

        //Chech Permission for Accessing
        public bool checkPermission(string accountId, string permissionId)
        {
            try
            {
                return DatabaseAccess.checkPermission(accountId, permissionId);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL" + ex.Message);
            }
        }

        // Lấy danh sách tất cả tài khoản
        public List<Account> LayTatCaTaiKhoan()
        {
            return accountDAL.GetAllAccounts();
        }

        // Thêm tài khoản mới
        public string ThemTaiKhoan(string tenDangNhap, string matKhau)
        {
            string result = accountDAL.InsertAccount(tenDangNhap, matKhau);
            return result;
        }

        // Xóa tài khoản
        public bool XoaTaiKhoan(string tenDangNhap, string matKhau)
        {
            return accountDAL.DeleteAccount(tenDangNhap, matKhau);
        }

        // Cập nhật tài khoản
        public bool CapNhatTaiKhoan(string tenDangNhap, string matKhau)
        {
            return accountDAL.UpdateAccount(tenDangNhap, matKhau);
        }

        // Lấy tài khoản theo email
        public Account LayTaiKhoanBangEmail(string email)
        {
            return accountDAL.GetAccountByEmail(email);
        }

        // Gửi mail để lấy lại mật khẩu
        public bool GuiMailLayLaiMatKhau(string email, string matKhauMail)
        {
            Nhansu nhanSu = accountDAL.GetNhanSuByEmail(email);
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
            return accountDAL.UpdatePassword(email, newPassword);
        }

    }
}