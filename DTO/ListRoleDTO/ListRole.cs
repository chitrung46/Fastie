using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.ListRoleDTO
{
    public class ListRole
    {
        private string id;
        private string tenQuyen;
        private string idQuyenCha;

        public string Id { get => id; set => id = value; }
        public string TenQuyen { get => tenQuyen; set => tenQuyen = value; }
        public string IdQuyenCha { get => idQuyenCha; set => idQuyenCha = value; }

        public ListRole() { }

        public ListRole(string id, string tenQuyen, string idQuyenCha)
        {
            this.id = id;
            this.tenQuyen = tenQuyen;
            this.idQuyenCha = idQuyenCha;
        }
    }
}
