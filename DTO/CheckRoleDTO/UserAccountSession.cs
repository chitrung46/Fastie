using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserAccountSession
    {
        private static UserAccountSession instance;

        public List<(string Id, string IdNhanSu, string IdBoPhan, string IdChucVu)> UserInfo { get; private set; }

        private UserAccountSession()
        {
            UserInfo = new List<(string Id, string IdNhanSu, string IdBoPhan, string IdChucVu)>();
        }

        public static UserAccountSession Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserAccountSession();
                }
                return instance;
            }
        }

        public void SetUserInfo(List<(string Id, string IdNhanSu, string IdBoPhan, string IdChucVu)> userInfo)
        {
            UserInfo = userInfo;
        }
    }
}
