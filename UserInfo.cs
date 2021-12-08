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
        private int friendNum;
        private int top;

        public UserInfo()
        {
        }

        public UserInfo(int seq, string Name,RoundPictureBox pb)
        {
            this.friendNum = seq;
            this.Name = Name;
            this.pb = pb;
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
        public UserInfo(int fNum,int seq, string uID, string address, DateTime birth, string nickName,RoundPictureBox pb, int _top)
        {
            this.friendNum = fNum;
            Seq = seq;
            UID = uID;
            Address = address;
            Birth = birth;
            NickName = nickName;
            this.pb = pb;
            top = _top;
        }


        public UserInfo(int v1, string v2, string v3, string v4, DateTime dateTime, string v5, string v6)
        {
        }

        //public UserInfo(int seq, string UID, string password, string address, DateTime birth, string nickName, string name,RoundPictureBox pb)
        //{
        //    this.Seq = seq;
        //    this.UID = UID;
        //    this.Password = password;
        //    this.Address = address;
        //    this.Birth = birth;
        //    this.NickName = nickName;
        //    this.Name = name;
        //    this.pb = pb;
        //}
        public int get_FriendNum()
        {
            return this.friendNum;
        }
        public string get_NickName()
        {
            return this.NickName;
        }
        public string get_Address()
        {
            return this.Address;
        }
        public string get_Name()
        {
            return this.Name;
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
            if (this.pb != null)
                return this.pb;
            else
                return null;
        }

        public int Top
        {
            get { return top; }
            set { top = value; }
        }
    }
}
