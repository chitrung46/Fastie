using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account
    {
        public string accountName { get; set; }
        public string password { get; set; }
        public string state { get; set; }
        public string idPersonnel { get; set; }
        public string idDepartment { get; set; }
        public string idPosition { get; set; }
        public DateTime updatedAt { get; set; }
        public DateTime createAt { get; set; }

        public Account()
        {
        }

        public Account(string accountName, string password, string state, string idPersonnel, string idDepartment, string idPosition, DateTime updatedAt, DateTime createAt)
        {
            this.accountName = accountName;
            this.password = password;
            this.state = state;
            this.idPersonnel = idPersonnel;
            this.idDepartment = idDepartment;
            this.idPosition = idPosition;
            this.updatedAt = updatedAt;
            this.createAt = createAt;
        }
    }
}
