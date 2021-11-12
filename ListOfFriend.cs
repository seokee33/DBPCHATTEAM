using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        private void pictureBoxAddFriendID_Click(object sender, EventArgs e)
        {
            AddFriendID addFriendID = new AddFriendID();
            addFriendID.Show();
        }

        private void ChattingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //우크릭시 채팅하기 선택
            //채팅방 나오도록 show()
        }

        private void DeleteFriendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //우클릭시 친구삭제 선택
            //친구 삭제기능
        }
    }
}
