using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DepartmentInfo
    {
        private string idBoPhan;
        private string tenBoPhan;
        private string moTa;

        public DepartmentInfo(string idBoPhan, string tenBoPhan)
        {
            this.idBoPhan = idBoPhan;
            this.tenBoPhan = tenBoPhan;
        }

        public DepartmentInfo(string idBoPhan, string tenBoPhan, string moTa)
        {
            this.idBoPhan = idBoPhan;
            this.tenBoPhan = tenBoPhan;
            this.moTa = moTa;
        }

        public string IdBoPhan { get => idBoPhan; set => idBoPhan = value; }
        public string TenBoPhan { get => tenBoPhan; set => tenBoPhan = value; }
        public string MoTa { get => moTa; set => moTa = value; }
    }
}
