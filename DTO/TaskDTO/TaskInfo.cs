using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaskInfo
    {
        // Thuộc tính cơ bản của công việc
        private string id;
        private string ten;
        private string moTa;
        private DateTime? thoiGianGiaoViec;
        private DateTime? thoiGianHoanThanh;
        private DateTime? thoiHanHoanThanh;
        private string ghiChu;
        private string idTaiKhoanGiaoViec;
        private string idBoPhanGiaoViec;
        private string idLoaiCongViec;
        private string idTienDoCongViec;
        private string idLichSuMacDinh;

        // Thuộc tính bổ sung từ TaskWithPersonel
        private string tenBoPhan;
        private string tenLoaiCongViec;
        private string tenTienDoCongViec;
        private string tenNhanSuGiaoViec;
        private string soLuongNhanSuChuDong;
        private string tenNhanSuNhanViec;


        

        // Constructor đầy đủ
        public TaskInfo(string id, string ten, string moTa, DateTime? thoiGianGiaoViec, DateTime? thoiGianHoanThanh, DateTime? thoiHanHoanThanh,
                        string ghiChu, string idTaiKhoanGiaoViec, string idBoPhanGiaoViec, string idLoaiCongViec, string idTienDoCongViec, string idLichSuMacDinh,
                        string tenBoPhan, string tenLoaiCongViec, string tenTienDoCongViec, string tenNhanSuGiaoViec, string soLuongNhanSuChuDong, string tenNhanSuNhanViec)
        {
            this.id = id;
            this.ten = ten;
            this.moTa = moTa;
            this.thoiGianGiaoViec = thoiGianGiaoViec;
            this.thoiGianHoanThanh = thoiGianHoanThanh;
            this.thoiHanHoanThanh = thoiHanHoanThanh;
            this.ghiChu = ghiChu;
            this.idTaiKhoanGiaoViec = idTaiKhoanGiaoViec;
            this.idBoPhanGiaoViec = idBoPhanGiaoViec;
            this.idLoaiCongViec = idLoaiCongViec;
            this.idTienDoCongViec = idTienDoCongViec;
            this.idLichSuMacDinh = idLichSuMacDinh;
            this.tenBoPhan = tenBoPhan;
            this.tenLoaiCongViec = tenLoaiCongViec;
            this.tenTienDoCongViec = tenTienDoCongViec;
            this.tenNhanSuGiaoViec = tenNhanSuGiaoViec;
            this.soLuongNhanSuChuDong = soLuongNhanSuChuDong;
            this.tenNhanSuNhanViec = tenNhanSuNhanViec;
        }

        // Constructor tối giản (nếu chỉ có các thuộc tính cơ bản)
        public TaskInfo() { }

        // Các thuộc tính công khai
        public string Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public DateTime? ThoiGianGiaoViec { get => thoiGianGiaoViec; set => thoiGianGiaoViec = value; }
        public DateTime? ThoiGianHoanThanh { get => thoiGianHoanThanh; set => thoiGianHoanThanh = value; }
        public DateTime? ThoiHanHoanThanh { get => thoiHanHoanThanh; set => thoiHanHoanThanh = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public string IdTaiKhoanGiaoViec { get => idTaiKhoanGiaoViec; set => idTaiKhoanGiaoViec = value; }
        public string IdBoPhanGiaoViec { get => idBoPhanGiaoViec; set => idBoPhanGiaoViec = value; }
        public string IdLoaiCongViec { get => idLoaiCongViec; set => idLoaiCongViec = value; }
        public string IdTienDoCongViec { get => idTienDoCongViec; set => idTienDoCongViec = value; }
        public string IdLichSuMacDinh { get => idLichSuMacDinh; set => idLichSuMacDinh = value; }

        // Thuộc tính nhân sự bổ sung
        public string TenBoPhan { get => tenBoPhan; set => tenBoPhan = value; }
        public string TenLoaiCongViec { get => tenLoaiCongViec; set => tenLoaiCongViec = value; }
        public string TenTienDoCongViec { get => tenTienDoCongViec; set => tenTienDoCongViec = value; }
        public string TenNhanSuGiaoViec { get => tenNhanSuGiaoViec; set => tenNhanSuGiaoViec = value; }
        public string SoLuongNhanSuChuDong {  get => soLuongNhanSuChuDong; set => soLuongNhanSuChuDong = value; }
        public string TenNhanSuNhanViec { get => tenNhanSuNhanViec; set => tenNhanSuNhanViec = value; }
    }
}