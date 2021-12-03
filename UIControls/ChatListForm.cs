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
    public partial class ChatListForm : UserControl
    {
        public ChatListForm()
        {
            InitializeComponent();
        }

        #region Properties
        private string _name;
        private Image _profile;
        private string _mgs;
        private int _roomNum;

        public string FriendName
        {
            get { return _name; }
            set { _name = value; labelName.Text = value; }
        }

        public int RoomNum
        {
            get { return _roomNum; }
            set { _roomNum = value; }
        }
        public string ChatMsg
        {
            get { return _mgs; }
            set { _mgs = value; labelMsg.Text = value; }
        }

        public Image FriendProfile
        {
            get { return _profile; }
            set { _profile = value; roundPictureBoxFriend.Image = value; }
        }
        #endregion

        private void FriendProfile_Click(object sender, EventArgs e)
        {
            ChatRoom chatroom = new ChatRoom(_roomNum);
            chatroom.Show();
        }

        private void FixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBoxPin.Visible == false)
            {
                pictureBoxPin.Visible = true;
                FixToolStripMenuItem.Text = "고정해제";
            }
            else
            {
                pictureBoxPin.Visible = false;
                FixToolStripMenuItem.Text = "상단고정";
            }
        }

        private void DeleteMsgToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
