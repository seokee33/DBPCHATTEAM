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
    public partial class BirthDayFriendProfileForm : UserControl
    {
        public BirthDayFriendProfileForm()
        {
            InitializeComponent();
        }

        #region Properties
        private string _name;
        private Image _profile;

        public string BDFriendName
        {
            get { return _name; }
            set { _name = value; labelBirthDayFriendName.Text = value; }
        }

        public Image BDFriendProfile
        {
            get { return _profile; }
            set { _profile = value; roundPictureBoxBirthDayFriendPoto.Image = value; }
        }
        #endregion

        private void BirthDayFriendProfile_Click(object sender, EventArgs e)
        {
            ChatRoom chatroom = new ChatRoom();
            chatroom.Show();
        }


    }
}
