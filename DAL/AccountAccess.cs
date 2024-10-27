using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class AccountAccess
    {
        public string checkLogin(Account acc)
        {
            string info = DatabaseAccess.checkLoginDTO(acc);
            return info;
        }

    }
}
