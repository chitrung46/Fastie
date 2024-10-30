using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Permission
    {
        public string id { get; set; }
        public string ten { get; set; }
        public string idQuyenCha { get; set; }

        public Permission() { }

        public Permission(string id, string ten, string idQuyenCha)
        {
            this.id = id;
            this.ten = ten;
            this.idQuyenCha = idQuyenCha;
        }
    }
}
