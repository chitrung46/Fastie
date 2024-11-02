using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaskInfo
    {
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

        public TaskInfo(string id, string ten, string moTa, DateTime? thoiGianGiaoViec, DateTime? thoiGianHoanThanh, DateTime? thoiHanHoanThanh,
                string ghiChu, string idTaiKhoanGiaoViec, string idBoPhanGiaoViec, string idLoaiCongViec, string idTienDoCongViec, string idLichSuMacDinh)
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
        }


        public TaskInfo() { }

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

    }
}
