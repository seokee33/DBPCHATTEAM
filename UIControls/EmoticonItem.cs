using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBUI.UIControls
{
    public partial class Emoticonitem : UserControl
    {
        private int _Seq;
        private PictureBox _PB;
        private int roomNum;
        emoticon emoticon;
        public Emoticonitem(int roomNum, emoticon emoticon)
        {
            InitializeComponent();
            this.roomNum = roomNum;
            this.emoticon = emoticon;
        }
        public int Seq
        {
            get { return this._Seq; }
            set { _Seq = value; emoticon_Seq.Text = value.ToString(); }
        }
        public PictureBox PB
        {
            get { return this._PB; }
            set { _PB = value; pb_emoticon.Image = value.Image; }
        }

        private void pb_emoticon_DoubleClick(object sender, EventArgs e)
        {
            DBManager.GetInstance().insert_Image(_PB,"INSERT INTO `CHAT`.`ChatMessage` (`Message_Date`, `user_id`,`room_id`, `msg_Image`) VALUES ('" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + LoginUser.GetInstance().get_User().get_UID() + "', '" + roomNum + "',@Image)");
            emoticon.Close();
        }
    }
}
