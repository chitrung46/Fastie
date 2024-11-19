using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BaoCao 
    {
        private string id;
        private string ten;
        private string loai;
        private string duongDan;
        private string idLichSuCongViec;
        public BaoCao() { }
        public BaoCao(string id, string ten, string loai, string duongDan, string idLichSuCongViec)
        {
            this.id = id;
            this.ten = ten;
            this.loai = loai;
            this.duongDan = duongDan;
            this.idLichSuCongViec = idLichSuCongViec;
        }

        public string Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Loai { get => loai; set => loai = value; }    
        public string DuongDan { get => duongDan; set => duongDan = value; }    
        public string IdLichSuCongViec { get => idLichSuCongViec; set => idLichSuCongViec = value; }
    }
}
