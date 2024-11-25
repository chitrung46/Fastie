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
        private string idNhanSu;
        private string idBoPhan;
        private string idChucVu;

        private String tenNhanSu;
        private String tenBoPhan;
        private String tenChucVu;

        public string TenNhanSu { get => tenNhanSu; set => tenNhanSu = value; }
        public string TenBoPhan { get => tenBoPhan; set => tenBoPhan = value; }
        public string TenChucVu { get => tenChucVu; set => tenChucVu = value; }
        public Account() { }

        public Account(string tenNhanSu, string tenBoPhan, string tenChucVu, string trangThai)
        {
            this.tenNhanSu = tenNhanSu;
            this.tenBoPhan = tenBoPhan;
            this.tenChucVu = tenChucVu;
            this.trangThai = trangThai;
        }

        public Account(string id, string tenDangNhap, string matKhau, DateTime khoiTaoLuc, DateTime capNhatLuc, string trangThai)
        {
            this.id = id;
            this.tenDangNhap = tenDangNhap;
            this.matKhau = matKhau;
            this.khoiTaoLuc = khoiTaoLuc;
            this.capNhatLuc = capNhatLuc;
            this.trangThai = trangThai;
        }

        public Account(string tenDangNhap, string matKhau, string idNhanSu, string idBoPhan, string idChucVu)
        {
            this.tenDangNhap = tenDangNhap;
            this.matKhau = matKhau;
            this.idChucVu = idChucVu;
            this.idBoPhan = idBoPhan;
            this.idNhanSu = idNhanSu;   
        }

        public string Id { get => id; set => id = value; }
        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public DateTime KhoiTaoLuc { get => khoiTaoLuc; set => khoiTaoLuc = value; }
        public DateTime CapNhatLuc { get => capNhatLuc; set => capNhatLuc = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }

        public string IdNhanSu { get => idNhanSu; set => idNhanSu = value; }
        public string IdBoPhan { get => idBoPhan; set => idBoPhan = value; }
        public string IdChucVu { get => idChucVu; set => idChucVu = value; }


    }




}
