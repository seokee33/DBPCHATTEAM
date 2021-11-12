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
    public partial class FriendListForm : UserControl
    {
        public FriendListForm()
        {
            InitializeComponent();
        }

        #region Properties
        private string _name;
        private Image _profile;

        public string FriendListName
        {
            get { return _name; }
            set { _name = value; labelFriendName.Text = value; }
        }

        public Image FriendListProfile
        {
            get { return _profile; }
            set { _profile = value; roundPictureBoxFriend.Image = value; }
        }
        #endregion

        private void ChattingToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void DeleteFriendToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FriendProfile_Click(object sender, EventArgs e)
        {
            ChatRoom chatroom = new ChatRoom();
            chatroom.Show();
        }
    }
}
