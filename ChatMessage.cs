using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBUI
{
    class ChatMessage
    {
        private DateTime date;
        private string user_ID;
        private string Msg;
        private int room_ID;

        public ChatMessage(DateTime date, string user_ID, string msg)
        {
            this.date = date;
            this.user_ID = user_ID;
            Msg = msg;
        }
        public DateTime Get_Date()
        {
            return this.date;
        }
        public string Get_UserID()
        {
            return this.user_ID;
        }
        public string get_Msg()
        {
            return this.Msg;
        }
        public int get_RoomID()
        {
            return this.room_ID;
        }
    }
}
