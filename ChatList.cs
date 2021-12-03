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

        public void populatItems()
        {
            DataTable dt = DBManager.GetInstance().select("SELECT * FROM CHAT.User_Chat_Room WHERE UserSeq = '" + LoginUser.GetInstance().get_User().get_UID() + "';");

            List<ChatInfo> roomList = new List<ChatInfo>();
            if (dt == null)
                return;

            foreach (DataRow data in dt.Rows)
                roomList.Add(new ChatInfo(Convert.ToInt32(data[0]), Convert.ToString(data[1]), Convert.ToString(data[2]), Convert.ToInt32(data[3]), Convert.ToInt32(data[4])));

            List<ChatListForm> NoneChatList = new List<ChatListForm>();
            List<ChatListForm> TopChatList = new List<ChatListForm>();
            for (int i = 0; i < roomList.Count; i++)
            {

                if (roomList[i].Top == 0)
                {
                    ChatListForm chat = new ChatListForm(this);
                    chat.FriendName = roomList[i].FriendSeq;
                    chat.RoomNum = roomList[i].RoomID;
                    chat.Chat_Top = roomList[i].Top;
                    chat.Seq = roomList[i].Seq;
                    NoneChatList.Add(chat);
                }
                else
                {
                    ChatListForm chat = new ChatListForm(this);
                    chat.FriendName = roomList[i].FriendSeq;
                    chat.RoomNum = roomList[i].RoomID;
                    chat.Chat_Top = roomList[i].Top;
                    chat.Seq = roomList[i].Seq;
                    chat.pictureBoxPin.Visible = true;
                    TopChatList.Add(chat);
                }
            }
            if (flowLayoutPanelChatList.Controls.Count > 0)
            {
                flowLayoutPanelChatList.Controls.Clear();
            }

            foreach (ChatListForm item in TopChatList)
                flowLayoutPanelChatList.Controls.Add(item);

            foreach (ChatListForm item in NoneChatList)
                flowLayoutPanelChatList.Controls.Add(item);


        }
        public void populatItems2()
        {
            DataTable dt = DBManager.GetInstance().select("SELECT * FROM CHAT.User_Chat_Room WHERE UserSeq = '" + LoginUser.GetInstance().get_User().get_UID() + "';");
            List<int> roomList = new List<int>();
            if (dt == null)
                return;
            foreach (DataRow data in dt.Rows)
                roomList.Add(Convert.ToInt32(data[3]));


            //ChatListForm[] chatListForms = new ChatListForm[roomList.Count];
            List<ChatListForm> NoneChatList = new List<ChatListForm>();
            List<ChatListForm> TopChatList = new List<ChatListForm>();
            for (int i = 0; i < roomList.Count; i++)
            {
                DataTable friend = DBManager.GetInstance().select("SELECT * FROM CHAT.User_Chat_Room WHERE RoomID = '" + roomList[i] + "';");
                string name = "";
                int roomNum = 0;
                int top = 0;
                foreach (DataRow data in friend.Rows)
                {
                    if (!Convert.ToString(data[1]).Equals(LoginUser.GetInstance().get_User().get_UID()))
                    {
                        name = Convert.ToString(data[1]);
                        roomNum = Convert.ToInt32(data[3]);
                        top = Convert.ToInt32(data[4]);
                    }
                }
                if (top == 0)
                {
                    ChatListForm chat = new ChatListForm(this);
                    chat.FriendName = name;
                    chat.RoomNum = roomNum;
                    chat.Chat_Top = top;
                    NoneChatList.Add(chat);
                }
                else
                {
                    ChatListForm chat = new ChatListForm(this);
                    chat.FriendName = name;
                    chat.RoomNum = roomNum;
                    chat.Chat_Top = top;
                    chat.pictureBoxPin.Visible = true;
                    TopChatList.Add(chat);
                }
                //chatListForms[i] = new ChatListForm();
                //chatListForms[i].FriendName = name;
                //chatListForms[i].RoomNum = roomNum;
                // 사진 db에서 받아오기
            }
            if (flowLayoutPanelChatList.Controls.Count < 0)
            {
                flowLayoutPanelChatList.Controls.Clear();
            }
            else
            {
                foreach (ChatListForm item in TopChatList)
                    flowLayoutPanelChatList.Controls.Add(item);

                foreach (ChatListForm item in NoneChatList)
                    flowLayoutPanelChatList.Controls.Add(item);
            }

        }

        private void ChatList_Load(object sender, EventArgs e)
        {
            populatItems();

        }
    }
}
