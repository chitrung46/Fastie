using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.TaskDTO
{
    public class ThongTinGiaoViec
    {
        private string ten;
        private string moTa;
        private string thoiHanHoanThanh;
        private string idTaiKhoanGiaoViec;
        private string idBoPhanGiaoViec;
        private string danhSachTaiKhoanNhanViec;
        private string danhSachBoPhanNhanViec;
        private string danhSachHinhAnh;
        private string danhSachTaiLieu;
        private string tenHinhAnh;
        private string tenTaiLieu;
        private string idCongViecGoc;
        private int soLuongNhanSuChuDong;
        public ThongTinGiaoViec()
        {
        }

        public ThongTinGiaoViec(string ten, string moTa, string thoiHanHoanThanh, string idTaiKhoanGiaoViec, string idBoPhanGiaoViec, string danhSachTaiKhoanNhanViec, string danhSachBoPhanNhanViec, string danhSachHinhAnh, string danhSachTaiLieu, string tenHinhAnh, string tenTaiLieu)
        {
            this.ten = ten;
            this.moTa = moTa;
            this.thoiHanHoanThanh = thoiHanHoanThanh;
            this.idTaiKhoanGiaoViec = idTaiKhoanGiaoViec;
            this.idBoPhanGiaoViec = idBoPhanGiaoViec;
            this.danhSachTaiKhoanNhanViec = danhSachTaiKhoanNhanViec;
            this.danhSachBoPhanNhanViec = danhSachBoPhanNhanViec;
            this.danhSachHinhAnh = danhSachHinhAnh;
            this.danhSachTaiLieu = danhSachTaiLieu;
            this.tenHinhAnh = tenHinhAnh;
            this.tenTaiLieu = tenTaiLieu;
        }
        public ThongTinGiaoViec(string ten, string moTa, string thoiHanHoanThanh, string idTaiKhoanGiaoViec, string idBoPhanGiaoViec, string danhSachTaiKhoanNhanViec, string danhSachBoPhanNhanViec, string danhSachHinhAnh, string danhSachTaiLieu, string idCongViecGoc, string tenHinhAnh, string tenTaiLieu)
        {
            this.ten = ten;
            this.moTa = moTa;
            this.thoiHanHoanThanh = thoiHanHoanThanh;
            this.idTaiKhoanGiaoViec = idTaiKhoanGiaoViec;
            this.idBoPhanGiaoViec = idBoPhanGiaoViec;
            this.danhSachTaiKhoanNhanViec = danhSachTaiKhoanNhanViec;
            this.danhSachBoPhanNhanViec = danhSachBoPhanNhanViec;
            this.danhSachHinhAnh = danhSachHinhAnh;
            this.danhSachTaiLieu = danhSachTaiLieu;
            this.idCongViecGoc = idCongViecGoc;
            this.tenHinhAnh = tenHinhAnh;
            this.tenTaiLieu = tenTaiLieu;
        }
        public ThongTinGiaoViec(string ten, string moTa, string thoiHanHoanThanh, string idTaiKhoanGiaoViec, string idBoPhanGiaoViec, string danhSachTaiKhoanNhanViec, string danhSachBoPhanNhanViec, string danhSachHinhAnh, string danhSachTaiLieu, int soLuongNhanSuChuDong, string tenHinhAnh, string tenTaiLieu)
        {
            this.ten = ten;
            this.moTa = moTa;
            this.thoiHanHoanThanh = thoiHanHoanThanh;
            this.idTaiKhoanGiaoViec = idTaiKhoanGiaoViec;
            this.idBoPhanGiaoViec = idBoPhanGiaoViec;
            this.danhSachTaiKhoanNhanViec = danhSachTaiKhoanNhanViec;
            this.danhSachBoPhanNhanViec = danhSachBoPhanNhanViec;
            this.danhSachHinhAnh = danhSachHinhAnh;
            this.danhSachTaiLieu = danhSachTaiLieu;
            this.soLuongNhanSuChuDong = soLuongNhanSuChuDong;
            this.tenHinhAnh = tenHinhAnh;
            this.tenTaiLieu = tenTaiLieu;
        }

        public string Ten { get => ten; set => ten = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public string ThoiHanHoanThanh { get => thoiHanHoanThanh; set => thoiHanHoanThanh = value; }
        public string IdTaiKhoanGiaoViec { get => idTaiKhoanGiaoViec; set => idTaiKhoanGiaoViec = value; }
        public string IdBoPhanGiaoViec { get => idBoPhanGiaoViec; set => idBoPhanGiaoViec = value; }
        public string DanhSachTaiKhoanNhanViec { get => danhSachTaiKhoanNhanViec; set => danhSachTaiKhoanNhanViec = value; }
        public string DanhSachBoPhanNhanViec { get => danhSachBoPhanNhanViec; set => danhSachBoPhanNhanViec = value; }
        public string DanhSachHinhAnh { get => danhSachHinhAnh; set => danhSachHinhAnh = value; }
        public string DanhSachTaiLieu { get => danhSachTaiLieu; set => danhSachTaiLieu = value; }
        public string IdCongViecGoc { get => idCongViecGoc; set => idCongViecGoc = value; }
        public int SoLuongNhanSuChuDong { get => soLuongNhanSuChuDong; set => soLuongNhanSuChuDong = value; }
        public string TenHinhAnh { get => tenHinhAnh; set => tenHinhAnh = value; }
        public string TenTaiLieu { get => tenTaiLieu; set => tenTaiLieu = value; }
    }
}
