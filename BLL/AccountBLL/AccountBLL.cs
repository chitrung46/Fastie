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
        AccountDAL accountDAL = new AccountDAL();
        public int ThemTaiKhoan(Account taiKhoan)
        {
            try
            {
                return accountDAL.ThemTaiKhoan(taiKhoan);   
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Account> LayDanhSachTaiKhoan()
        {
            try
            {
                return accountDAL.LayDanhSachTaiKhoan();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int CapNhatTaiKhoan(Account taiKhoan)
        {
            try
            {
                return accountDAL.CapNhatTaiKhoan(taiKhoan);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        public int VoHieuHoaTaiKhoan(string id)
        {
            try
            {
                return accountDAL.VoHieuHoaTaiKhoan(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int CapNhatTrangThaiTaiKhoan(string idTaiKhoan)
        {
            try
            {
                return accountDAL.CapNhatTrangThaiTaiKhoan(idTaiKhoan);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}