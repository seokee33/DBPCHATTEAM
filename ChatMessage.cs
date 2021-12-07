using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBUI
{
    public class ChatMessage
    {
        private DateTime date;
        private string user_ID;
        private string Msg;
        private int room_ID;
        private PictureBox _PB;

        public ChatMessage(DateTime date, string user_ID, string msg, PictureBox pb)
        {
            this.date = date;
            this.user_ID = user_ID;
            this.Msg = msg;
            this._PB = pb;

        }
        public PictureBox get_PB()
        {
            return this._PB;
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
