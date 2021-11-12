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
    public partial class NewChatForm : UserControl
    {
        public NewChatForm()
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
    }
}
