using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChucVuDTO
    {
        private string id;
        private string ten;
        private string moTa;

        public ChucVuDTO(string id, string ten, string moTa)
        {
            this.id = id;
            this.ten = ten;
            this.moTa = moTa;
        }
        public ChucVuDTO() { }
        public string Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public string MoTa { get => moTa; set => moTa = value; }
    }
}
