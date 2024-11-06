using System.Collections.Generic;

namespace DTO
{
    public class UserAccountSession
    {
        private static UserAccountSession instance;

        public List<AccountId> UserInfo { get; private set; }

        private UserAccountSession()
        {
            UserInfo = new List<AccountId>();
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

        public void SetUserInfo(List<AccountId> userInfo)
        {
            UserInfo = userInfo;
        }
    }
}
