using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBUI
{

    class Setting
    {
        private bool auto_Login;
        private bool alarm = true;
        private Setting()
        {
        }

        private static Setting instance_ = new Setting();

        public static Setting GetInstance()
        {
            return instance_;
        }

        public bool get_Auto_Login()
        {
            return this.auto_Login;
        }
        public void set_Auto_Login(bool value)
        {
            this.auto_Login = value;
        }

        public bool get_alarm()
        {
            return this.alarm;
        }
        public void set_alarmn(bool alarm)
        {
            this.alarm = alarm;
        }

        public bool Auto_Login()
        {
            try
            {
                StreamReader sr = new StreamReader(new FileStream("autoLogin.txt", FileMode.Open));
                int i_Auto_Check = Convert.ToInt32(sr.ReadLine());
                string id = Convert.ToString(sr.ReadLine());
                string pw = Convert.ToString(sr.ReadLine());
                sr.Close();
                if (i_Auto_Check == 1)
                {
                    UserInfo user = new UserInfo();

                    if (DBManager.GetInstance().exist("SELECT EXISTS (SELECT * FROM CHAT.UserInfo WHERE UID = '" + id + "') AS exist;") == 1)
                    {
                        user = DBManager.GetInstance().select_profile("SELECT * FROM CHAT.UserInfo WHERE UID = '" + id + "';");

                        if (pw.Equals(user.get_Password()))
                        {
                            LoginUser.GetInstance().set_User(user);
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("비밀번호를 다시 확인해주세요!!");
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("없는 아이디 입니다.!!");
                        return false;
                    }
                }
            }
            catch
            {
                return false;
            }
            return false;
        }
    }
}
