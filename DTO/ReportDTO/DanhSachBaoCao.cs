using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DanhSachBaoCao
    {
        private string noiDung;
        private DateTime? ngayBaoCao;
        private string tenFile;
        private string tenAnh;
        private string duongDanFile;
        private string duongDanAnh;

        public DanhSachBaoCao(string noiDung, DateTime? ngayBaoCao, string tenFile, string tenAnh, string duongDanAnh, string duongDanFile)
        {
            this.noiDung = noiDung;
            this.ngayBaoCao = ngayBaoCao;
            this.tenFile = tenFile;
            this.tenAnh = tenAnh;
            this.duongDanAnh = duongDanAnh;
            this.duongDanFile = duongDanFile;
        }
        public DanhSachBaoCao() { }

        public string NoiDung { get => noiDung; set => noiDung = value; }
        public DateTime? NgayBaoCao { get => ngayBaoCao; set => ngayBaoCao = value; }
        public string TenFile { get => tenFile; set => tenFile = value; }
        public string TenAnh { get => tenAnh; set => tenAnh = value; }
        public string DuongDanFile { get => duongDanFile; set => duongDanFile = value; }
        public string DuongDanAnh { get => duongDanAnh; set => duongDanAnh = value; }

    }
}
