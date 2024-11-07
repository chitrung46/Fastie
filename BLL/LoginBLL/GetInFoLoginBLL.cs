using DAL.LoginDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.LoginBLL
{
    public class GetInFoLoginBLL
    {
        GetInFoLoginDAL getInFoLoginDAL = new GetInFoLoginDAL();
        public string[] LayTenNhanSuVaBoPhan(string idTaiKhoan)
        {
            try
            {
                return getInFoLoginDAL.LayTenNhanSuVaBoPhan(idTaiKhoan);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xử lý lấy thông tin nhân sự và bộ phận" + ex.Message);
            }
        }
    }
}
