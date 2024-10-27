using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class AccountBLL
    {
        AccountAccess accAccess = new AccountAccess();
        public string checkLogin(Account acc)
        {
            if (acc.accountName == "")
            {
                return "required_email";
            }

            if (acc.password == "")
            {
                return "required_password";
            }

            string info = accAccess.checkLogin(acc);
            return info;

        }
    }
}
