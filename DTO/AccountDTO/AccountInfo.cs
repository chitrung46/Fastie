using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AccountInfo
    {
        private String tenDangNhap;
        private String tenNhanSu;
        private String tenBoPhan;
        private String tenChucVu;

        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string TenNhanSu { get => tenNhanSu; set => tenNhanSu = value; }
        public string TenBoPhan { get => tenBoPhan; set => tenBoPhan = value; }
        public string TenChucVu { get => tenChucVu; set => tenChucVu = value; }


        public AccountInfo() { }

        public AccountInfo(string tenDangNhap, string tenNhanSu, string tenBoPhan, string tenChucVu)
        {
            TenDangNhap = tenDangNhap;
            TenNhanSu = tenNhanSu;
            TenBoPhan = tenBoPhan;
            TenChucVu = tenChucVu;
        }

    }
}
