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
        private String tenNhanSu;
        private String tenBoPhan;
        private String tenChucVu;
        private String trangThai;

        public String IdTaiKhoan { get => idTaiKhoan; set => idTaiKhoan = value; }
        public String IdNhanSu { get => idNhanSu; set => idNhanSu = value; }
        public String IdBoPhan { get => idBoPhan; set => idBoPhan = value; }
        public String IdChucVu { get => idChucVu; set => idChucVu = value; }
        public String TenNhanSu { get => tenNhanSu; set => tenNhanSu = value; }
        public String TenBoPhan { get => tenBoPhan; set => tenBoPhan = value; }
        public String TenChucVu { get => tenChucVu; set => tenChucVu = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }

        public AccountId() {}
        public AccountId(string idTaiKhoan, String idNhanSu, String idBoPhan, String idChucVu)
        {
            IdBoPhan = idBoPhan;
            IdChucVu = idChucVu;
            IdTaiKhoan = idTaiKhoan;
            IdNhanSu = idNhanSu;
        }



        public AccountId(string idTaiKhoan, String idNhanSu, String idBoPhan, String idChucVu, string tenNhanSu, string tenBoPhan)
        {
            this.idTaiKhoan = idTaiKhoan;
            this.idNhanSu = idNhanSu;
            this.idBoPhan = idBoPhan;
            this.idChucVu = idChucVu;
            this.tenNhanSu = tenNhanSu;
            this.tenBoPhan = tenBoPhan;
        }



    }
}
