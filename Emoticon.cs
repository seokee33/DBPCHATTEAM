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
            EmoticonItem[] emoticonItem = new EmoticonItem[emoticons.Count];
            for (int i = 0; i < emoticons.Count; i++)
            {
                emoticonItem[i] = new EmoticonItem();
                emoticonItem[i].Dock = DockStyle.Top;
                emoticonItem[i].Seq = emoticons[i].Seq;
                

                if (emoticonItem[i].PB != null)
                    emoticonItem[i].PB.Image = emoticons[i].PB.Image;

                // 사진 db에서 받아오기
                if (emoticon_PB.Controls.Count > 0)
                {
                    emoticon_PB.Controls.Clear();
                }
                
                //emoticon_PB.Controls.Add(emoticonItem[i]);
            }
        }
    }
}
