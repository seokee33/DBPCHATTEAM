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
    public partial class GroupChatForm : UserControl
    {
        public GroupChatForm()
        {
            InitializeComponent();
        }

        #region Properties
        private string _name;
        private Image _profile;

        public string FriendName
        {
            get { return _name; }
            set { _name = value; labelName.Text = value; }
        }

        public Image FriendProfile
        {
            get { return _profile; }
            set { _profile = value; roundPictureBoxProfile.Image = value; }
        }
        #endregion
    }
}
