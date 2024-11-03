using System;
namespace DTO
{
    public class Personnel
    {
        private string id;
        private string ten;
        private string email;
        private string gioiTinh;
        private DateTime ngaySinh;
        private DateTime ngayVaoLam;
        private string sdt;

        public Personnel() { }  
        public Personnel(string id, string ten, string email, string gioiTinh, DateTime ngaySinh, DateTime ngayVaoLam, string sdt)
        {
            this.id = id;
            this.ten = ten;
            this.email = email;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.ngayVaoLam = ngayVaoLam;
            this.sdt = sdt;
        }

        public string Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Email { get => email; set => email = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public DateTime NgayVaoLam { get => ngayVaoLam; set => ngayVaoLam = value; }
        public string Sdt { get => sdt; set => sdt = value; }
    }
}
