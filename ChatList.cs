using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBUI.UIControls;

namespace DBUI
{
    public partial class ChatList : Form
    {
        public ChatList()
        {
            InitializeComponent();
            this.MouseWheel += new MouseEventHandler(PanelChatList_MouseWheel);
        }

        private void pictureBoxNewChat_Click(object sender, EventArgs e)
        {
            NewChat newForm = new NewChat();
            newForm.Show();
        }
        private void PanelChatList_MouseWheel(object sender, MouseEventArgs e)
        {
            flowLayoutPanelChatList.Focus();
        }

        private void populatItems()
        {
            DataTable dt = DBManager.GetInstance().select("SELECT * FROM CHAT.User_Chat_Room WHERE UserSeq = '" + LoginUser.GetInstance().get_User().get_UID() + "';");
            List<int> roomList = new List<int>();
            if (dt == null)
                return;
            foreach (DataRow data in dt.Rows)
                roomList.Add(Convert.ToInt32(data[3]));

            
            ChatListForm[] chatListForms = new ChatListForm[roomList.Count];
            for (int i = 0; i < roomList.Count; i++)
            {
                DataTable friend = DBManager.GetInstance().select("SELECT * FROM CHAT.User_Chat_Room WHERE RoomID = '" + roomList[i] + "';");
                string name ="";
                foreach(DataRow data in friend.Rows)
                {
                    if (!Convert.ToString(data[1]).Equals(LoginUser.GetInstance().get_User().get_UID()))
                    {
                        name = Convert.ToString(data[1]);
                    }
                }
                chatListForms[i] = new ChatListForm();
                chatListForms[i].FriendName = name;
                //chatListForms[i].ChatMsg = "zzz";
                // 사진 db에서 받아오기

                if (flowLayoutPanelChatList.Controls.Count < 0)
                {
                    flowLayoutPanelChatList.Controls.Clear();
                }
                else
                    flowLayoutPanelChatList.Controls.Add(chatListForms[i]);
            }
        }

        private void ChatList_Load(object sender, EventArgs e)
        {
            populatItems();
        }
    }
}
