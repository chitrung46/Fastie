using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AccountId
    {
        private String idTaiKhoan;
        private String idNhanSu;
        private String idBoPhan;
        private String idChucVu;

        public String IdTaiKhoan { get => idTaiKhoan; set => idTaiKhoan = value; }
        public String IdNhanSu { get => idNhanSu; set => idNhanSu = value; }
        public String IdBoPhan { get => idBoPhan; set => idBoPhan = value; }
        public String IdChucVu { get => idChucVu; set => idChucVu = value; }
        public AccountId() {}
        public AccountId(string idTaiKhoan, String idNhanSu, String idBoPhan, String idChucVu)
        {
            IdBoPhan = idBoPhan;
            IdChucVu = idChucVu;
            IdTaiKhoan = idTaiKhoan;
            IdNhanSu = idNhanSu;
        }



    }
}
