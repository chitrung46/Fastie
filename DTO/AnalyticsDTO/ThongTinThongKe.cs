using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.AnalyticsDTO
{
    public class ThongTinThongKe
    {
        private string idCongViec;
        private string tenCongViec;
        private string tienDoCongViec;
        private string mucDoHoanThanh;
        private string noiDungBaoCao;

        private int soLanNhanViecChuDong;
        private int soLanXinDieuChinhPhanCong;
        private float tiLeHoanThanhCongViec;

        public ThongTinThongKe() { }

        public ThongTinThongKe(string idCongViec, string tenCongViec, string tienDoCongViec)
        {
            this.idCongViec = idCongViec;
            this.tenCongViec = tenCongViec;
            this.tienDoCongViec = tienDoCongViec;
        }

        public ThongTinThongKe(string idCongViec, string tenCongviec, string mucDoHoanThanh, string noiDungBaoCao)
        {
            this.idCongViec = idCongViec;
            this.tenCongViec = tenCongViec;
            this.mucDoHoanThanh = mucDoHoanThanh;
            this.noiDungBaoCao = noiDungBaoCao;
        }


        public int SoLuongCongViecHoanThanhDungHan { get; set; }
        public int SoLuongCongViecHoanThanhTreHan { get; set; }
        public string IdCongViec { get => idCongViec; set => idCongViec = value; }
        public string TenCongViec { get => tenCongViec; set => tenCongViec = value; }
        public string TienDoCongViec { get => tienDoCongViec; set => tienDoCongViec = value; }
        public string MucDoHoanThanh { get => mucDoHoanThanh; set => mucDoHoanThanh = value; }
        public string NoiDungBaoCao { get => noiDungBaoCao; set => noiDungBaoCao = value; }
        public int SoLanNhanViecChuDong { get => soLanNhanViecChuDong; set => soLanNhanViecChuDong = value; }
        public int SoLanXinDieuChinhPhanCong { get => soLanXinDieuChinhPhanCong; set => soLanXinDieuChinhPhanCong = value; }
        public decimal TiLeHoanThanhCongViec { get; set; }
    }
}
