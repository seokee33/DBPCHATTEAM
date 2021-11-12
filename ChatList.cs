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
            ChatListForm[] chatlistform = new ChatListForm[10];

            for (int i = 0; i < chatlistform.Length; i++)
            {
                chatlistform[i] = new ChatListForm();
                chatlistform[i].FriendName = "ㅇㅇㅇ";
                chatlistform[i].ChatMsg = "zzz";
                // 사진 db에서 받아오기

                if (flowLayoutPanelChatList.Controls.Count < 0)
                {
                    flowLayoutPanelChatList.Controls.Clear();
                }
                else
                    flowLayoutPanelChatList.Controls.Add(chatlistform[i]);
            }
        }

        private void ChatList_Load(object sender, EventArgs e)
        {
            populatItems();
        }
    }
}
