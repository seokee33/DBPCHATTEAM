using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBUI
{
    class LoginUser
    {

        private UserInfo user = new UserInfo();
        private LoginUser()
        {
        }

        private static LoginUser instance_ = new LoginUser();

        public static LoginUser GetInstance()
        {
            return instance_;
        }

        public void set_User(UserInfo user)
        {
            this.user = user;
        }
        public UserInfo get_User()
        {
            return this.user;
        }


    }
}
