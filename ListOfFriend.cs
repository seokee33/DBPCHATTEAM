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
        public ListOfFriend()
        {
            InitializeComponent();
            this.MouseWheel += new MouseEventHandler(PanelFriendList_MouseWheel);
        }
        private void PanelFriendList_MouseWheel(object sender, MouseEventArgs e)
        {
            panelFriendList.Focus();
        }
        //아이디로 친구추가

        private void populatItems()
        {
            FriendListForm[] friendListForm = new FriendListForm[5];
            
            for (int i = 0; i < friendListForm.Length; i++)
            {
                friendListForm[i] = new FriendListForm();
                friendListForm[i].FriendListName = "ㅇㅇㅇ";
                // 사진 db에서 받아오기

                if (flowLayoutPanelFriendList.Controls.Count < 0)
                {
                    flowLayoutPanelFriendList.Controls.Clear();
                }
                else
                    flowLayoutPanelFriendList.Controls.Add(friendListForm[i]);
            }
        }

        private void ListOfFriend_Load(object sender, EventArgs e)
        {
            populatItems();
        }

        private void pictureBoxAddFriendID_Click(object sender, EventArgs e)
        {
            AddFriendID addFriendID = new AddFriendID();
            addFriendID.Show();
        }


        private void BirthDay_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            BirthDayFriendList birthDayFriendList = new BirthDayFriendList();
            birthDayFriendList.Show();
        }

    }
}
