using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBUI
{
    static class UserData
    {
        static UserInfo User = new UserInfo();
        static public UserInfo Ct
        {
            get
            {
                return User;
            }
            set
            {
                User = value;
            }
        }
    }
}
