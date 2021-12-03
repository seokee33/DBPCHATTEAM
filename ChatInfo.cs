using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBUI
{
    class ChatInfo
    {
        private int _Seq;
        private string _UserSeq;
        private string _FriendSeq;
        private int _RoomID;
        private int _Top;

        public ChatInfo()
        {
        }

        public ChatInfo(int seq, string userSeq, string friendSeq, int roomID, int top)
        {
            _Seq = seq;
            _UserSeq = userSeq;
            _FriendSeq = friendSeq;
            _RoomID = roomID;
            _Top = top;
        }

        public int Seq
        {
            get { return _Seq; }
            set { _Seq = value; }
        }

        public string UserSeq
        {
            get { return _UserSeq; }
            set { _UserSeq = value; }
        }

        public string FriendSeq
        {
            get { return _FriendSeq; }
            set { _FriendSeq = value; }
        }

        public int RoomID
        {
            get { return _RoomID; }
            set { _RoomID = value; }
        }
        public int Top
        {
            get { return _Top; }
            set { _Top = value; }
        }
    }
}
