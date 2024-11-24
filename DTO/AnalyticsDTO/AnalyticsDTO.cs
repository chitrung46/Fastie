using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DTO.AnalyticsDTO
{
    public class AnalyticsDTO
    {
        //Bo phan
        private string idBoPhan;
        private string tenBoPhan;
        private string moTa;

        //Chuc vu
        private string idChucVu;
        private string tenChucVu;

        //Nhan su
        private string idNhanSu;
        private string tenNhanSu;

        public AnalyticsDTO(string idChucVu, string tenChucVu, string idBoPhan, string tenBoPhan, string idNhanSu, string tenNhanSu)
        {
            this.idChucVu = idChucVu;
            this.tenChucVu = tenChucVu;
            this.idBoPhan = idBoPhan;
            this.tenBoPhan = tenBoPhan;
            this.idNhanSu = idNhanSu;
            this.tenNhanSu = tenNhanSu;
        }
        public AnalyticsDTO(string idChucVu, string tenChucVu)
        {
            IdChucVu = idChucVu;
            TenChucVu = tenChucVu;
            IdBoPhan = null;
            TenBoPhan = null;
            IdNhanSu = null;
            TenNhanSu = null;
        }

        public AnalyticsDTO() { }

        public string IdChucVu { get => idChucVu; set => idChucVu = value; }
        public string TenChucVu { get => tenChucVu; set => tenChucVu = value; }
        public string IdBoPhan { get => idBoPhan; set => idBoPhan = value; }
        public string TenBoPhan { get => tenBoPhan; set => tenBoPhan = value; }
        public string IdNhanSu { get => idNhanSu; set => idNhanSu = value; }
        public string TenNhanSu { get => tenNhanSu; set => tenNhanSu = value; }
        public int SoLuongDungHan { get; set; }
        public int SoLuongTreHan { get; set; }
        public int SoLanNhanViecChuDong { get; set; }
        public int SoLanXinDieuChinh { get; set; }
        public int SoLuongHoanThanh { get; set; }
        public int SoLuongChuaHoanThanh { get; set; }
        public decimal TyLeHoanThanh { get; set; }
        public int TongSoCongViec { get; set; }
        public string IdBoPhan1 { get; set; }
        public string TenBoPhan1 { get; set; }
        public string MoTa { get; set; }
    }
}

