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
        private string Name;
        private int ImageID;
        private RoundPictureBox pb;

        public UserInfo()
        {
        }

        public UserInfo(int seq, string uID, string password, string address, DateTime birth, string nickName, string name,RoundPictureBox pb)
        {
            Seq = seq;
            UID = uID;
            Password = password;
            Address = address;
            Birth = birth;
            NickName = nickName;
            Name = name;
            this.pb = pb;
        }
        public UserInfo(int seq, string uID, string address, DateTime birth, string nickName,RoundPictureBox pb)
        {
            Seq = seq;
            UID = uID;
            Address = address;
            Birth = birth;
            NickName = nickName;
            this.pb = pb;
        }

        public UserInfo(int seq, string UID, string password, string address, DateTime birth, string nickName, string name)
        {
            Seq = seq;
            this.UID = UID;
            this.Password = password;
            this.Address = address;
            Birth = birth;
            NickName = nickName;
            Name = name;
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
        public string get_UID()
        {
            return this.UID;
        }
        public DateTime get_Birth()
        {
            return this.Birth;
        }
        public int get_ImageID()
        {
            return this.ImageID;
        }
        public RoundPictureBox get_PB()
        {
            return this.pb;
        }
    }
}
