using System;

namespace DTO
{
    public class Account
    {
        private string id;
        private string tenDangNhap;
        private string matKhau;
        private DateTime khoiTaoLuc;
        private DateTime capNhatLuc;
        private string trangThai;

        public Account() { }
        public Account(string id, string tenDangNhap, string matKhau, DateTime khoiTaoLuc, DateTime capNhatLuc, string trangThai)
        {
            this.id = id;
            this.tenDangNhap = tenDangNhap;
            this.matKhau = matKhau;
            this.khoiTaoLuc = khoiTaoLuc;
            this.capNhatLuc = capNhatLuc;
            this.trangThai = trangThai;
        }

        public Account(string tenDangNhap, string matKhau)
        {
            this.tenDangNhap = tenDangNhap;
            this.matKhau = matKhau;
        }

        public string Id { get => id; set => id = value; }
        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public DateTime KhoiTaoLuc { get => khoiTaoLuc; set => khoiTaoLuc = value; }
        public DateTime CapNhatLuc { get => capNhatLuc; set => capNhatLuc = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
   

    }




}
