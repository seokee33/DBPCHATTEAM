using DBUI.UIControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBUI
{
    public partial class emoticon : Form
    {
        private int roomNum;
        private string friendName;
        public emoticon(int roomNum, string friendName)
        {
            InitializeComponent();
            
            this.roomNum = roomNum;
            this.friendName = friendName;
            populatItems();
        }
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void populatItems()
        {
            UserInfo friend = new UserInfo();

            List<EmoticonInfo> emoticons = DBManager.GetInstance().select_Emoticon("SELECT * FROM CHAT.Emoticon;");

            emoticon_PB.Controls.Clear();
            Emoticonitem[] emoticonItem = new Emoticonitem[emoticons.Count];
            for (int i = 0; i < emoticons.Count; i++)
            {
                emoticonItem[i] = new Emoticonitem(roomNum,this);
                emoticonItem[i].Seq = emoticons[i].Seq;
                
                if (emoticons[i].PB != null)
                    emoticonItem[i].PB = emoticons[i].PB;

            }
            if (emoticon_PB.Controls.Count > 0)
            {
                emoticon_PB.Controls.Clear();
            }
            for (int i = 0; i < emoticons.Count; i++)
            {
                emoticon_PB.Controls.Add(emoticonItem[i]);
            }
        }

    }
}
