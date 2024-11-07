using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.LoginDAL;
namespace BLL.LoginBLL
{
    public class LoginBLL
    {
        LoginDAL loginDAL = new LoginDAL();
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

            return loginDAL.checkLogin(acc);

        }

    }
}
