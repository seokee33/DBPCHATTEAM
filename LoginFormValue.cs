using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBUI
{
    class LoginFormValue
    {
        private Login login = null;
        private LoginFormValue()
        {
        }

        private static LoginFormValue instance_ = new LoginFormValue();

        public static LoginFormValue GetInstance()
        {
            return instance_;
        }

        public Login get_Login()
        {
            return this.login;
        }
        public void set_Login(Login login)
        {
            this.login = login;
        }
    }
}
