﻿using System;
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
        AccountDAL accountDAL = new AccountDAL();
        public int ThemTaiKhoan(Account taiKhoan)
        {
            return accountDAL.ThemTaiKhoan(taiKhoan);
        }

        public List<Account> LayDanhSachTaiKhoan()
        {
            try
            {
                return accountDAL.LayDanhSachTaiKhoan();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}