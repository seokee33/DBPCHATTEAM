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
//panelFriendList 내용담은 Form
namespace DBUI
{
    public partial class ListOfFriend : Form
    {
        private List<UserInfo> friendsList;
        public ListOfFriend()
        {
            InitializeComponent();
            friendsList = new List<UserInfo>();
            this.MouseWheel += new MouseEventHandler(PanelFriendList_MouseWheel);
            labelMyProfileName.Text = LoginUser.GetInstance().get_User().get_NickName();
            if(LoginUser.GetInstance().get_User().get_PB()!=null)
                roundPictureBoxMyProfilePoto.Image = LoginUser.GetInstance().get_User().get_PB().Image;
        }

        private void PanelFriendList_MouseWheel(object sender, MouseEventArgs e)
        {
            panelFriendList.Focus();
        }
        //아이디로 친구추가

        private void populatItems()
        {
            UserInfo friend = new UserInfo();

            friendsList = DBManager.GetInstance().select_Friends("SELECT  u.Seq, u.UID, u.Address, u.Birth, u.NickName, u.Image From CHAT.Friends AS f JOIN CHAT.UserInfo AS u ON f.FriendID = u.Seq WHERE f.UserID = " + LoginUser.GetInstance().get_User().get_Seq() + ";");

            flowLayoutPanelFriendList.Controls.Clear();
            FriendListForm[] friendListForm = new FriendListForm[friendsList.Count];
            for (int i = 0; i < friendsList.Count; i++)
            {
                friendListForm[i] = new FriendListForm();
                friendListForm[i].FriendListName = friendsList[i].get_NickName();
                if(friendsList[i].get_PB() != null)
                    friendListForm[i].FriendListProfile = friendsList[i].get_PB().Image;


                // 사진 db에서 받아오기

                if (flowLayoutPanelFriendList.Controls.Count < 0)
                {
                    flowLayoutPanelFriendList.Controls.Clear();
                }
                else
                    flowLayoutPanelFriendList.Controls.Add(friendListForm[i]);
            }
        }

        public void ListOfFriend_Load(object sender, EventArgs e)
        {
            populatItems();
        }

        private void pictureBoxAddFriendID_Click(object sender, EventArgs e)
        {
            AddFriendID addFriendID = new AddFriendID(this);
            addFriendID.Show();
        }


        private void BirthDay_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            BirthDayFriendList birthDayFriendList = new BirthDayFriendList();
            birthDayFriendList.Show();
        }

        private void buttonFriendSearch_Click(object sender, EventArgs e)
        {
            List<UserInfo> searchFriend = new List<UserInfo>();
            foreach(UserInfo user in friendsList)
            {
                if (user.get_NickName().Equals(myTextBoxFriendSearch.Text))
                {
                    searchFriend.Add(user);
                }
            }
            flowLayoutPanelFriendList.Controls.Clear();
            FriendListForm[] friendListForm = new FriendListForm[searchFriend.Count];
            for (int i = 0; i < searchFriend.Count; i++)
            {
                friendListForm[i] = new FriendListForm();
                friendListForm[i].FriendListName = searchFriend[i].get_NickName();
                // 사진 db에서 받아오기

                if (flowLayoutPanelFriendList.Controls.Count < 0)
                {
                    flowLayoutPanelFriendList.Controls.Clear();
                }
                else
                    flowLayoutPanelFriendList.Controls.Add(friendListForm[i]);
            }

        }
    }
}
