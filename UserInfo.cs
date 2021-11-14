using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBUI
{
    class UserInfo
    {
        private int Seq;
        private string UID;
        private string Password;
        private string Address;
        private DateTime Birth;
        private string NickName;

        public UserInfo()
        {
        }

        public UserInfo(int seq, string uID, string password, string address, DateTime birth, string nickName)
        {
            Seq = seq;
            UID = uID;
            Password = password;
            Address = address;
            Birth = birth;
            NickName = nickName;
        }
        public UserInfo(int seq, string uID, string address, DateTime birth, string nickName)
        {
            Seq = seq;
            UID = uID;
            Address = address;
            Birth = birth;
            NickName = nickName;
        }

        public string get_NickName()
        {
            return this.NickName;
        }
        public string get_Password()
        {
            return this.Password;
        }
        public int get_Seq()
        {
            return this.Seq;
        }
    }
}
