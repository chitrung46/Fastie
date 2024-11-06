using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DTO
{
    public class AcceptTaskPersonnel
    {
        private string id;
        private string ten;
        public AcceptTaskPersonnel(string id, string ten)
        {
            this.id = id;
            this.ten = ten;
        }
        public AcceptTaskPersonnel () { }
        public string Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
    }
}
