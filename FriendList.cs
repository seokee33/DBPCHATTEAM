using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBUI
{
    public partial class FriendList : Form
    {
        public FriendList()
        {
            InitializeComponent();
            this.panelBorder.MouseDown += panelBorder_MouseDown;
            this.MouseWheel += new MouseEventHandler(PanelFriendList_MouseWheel);
        }

        #region 상단부분
        private void panelBorder_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.panelBorder.Capture = false;

                const int WM_NCLBUTTONDOWN = 0x00A1;
                const int HTCAPTION = 2;

                Message message = Message.Create(Handle, WM_NCLBUTTONDOWN, new IntPtr(HTCAPTION), IntPtr.Zero);

                DefWndProc(ref message);
            }
        }


        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBoxMax2.Visible = true;
            pictureBoxMax.Visible = false;
        }

        private void pictureBoxMax2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pictureBoxMax2.Visible = false;
            pictureBoxMax.Visible = true;
        }

        private void pictureBoxMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region 메뉴

        private void pictureBoxFriendList_Click(object sender, EventArgs e)
        {
            pictureBoxFriendList.Visible = true;
            pictureBoxFriendListhide.Visible = false;
            pictureBoxSettings.Visible = false;
            pictureBoxSettingshide.Visible = true;
            pictureBoxChatList.Visible = false;
            pictureBoxChatListhide.Visible = true;
            panelFriendList.Controls.Clear();
            ListOfFriend fm = new ListOfFriend();
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            panelFriendList.Controls.Add(fm);
            fm.Show();
        }

        private void pictureBoxFriendListhide_Click(object sender, EventArgs e)
        {
            pictureBoxFriendList.Visible = true;
            pictureBoxFriendListhide.Visible = false;
            pictureBoxSettings.Visible = false;
            pictureBoxSettingshide.Visible = true;
            pictureBoxChatList.Visible = false;
            pictureBoxChatListhide.Visible = true;
            panelFriendList.Controls.Clear();
            ListOfFriend fm = new ListOfFriend();
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            panelFriendList.Controls.Add(fm);
            fm.Show();
        }

        private void pictureBoxChatListhide_Click(object sender, EventArgs e)
        {
            pictureBoxChatList.Visible = true;
            pictureBoxChatListhide.Visible = false;
            pictureBoxFriendListhide.Visible = true;
            pictureBoxFriendList.Visible = false;
            pictureBoxSettingshide.Visible = true;
            pictureBoxSettings.Visible = false;
            panelFriendList.Controls.Clear();
            ChatList fm = new ChatList();
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            panelFriendList.Controls.Add(fm);
            fm.Show();
        }

        private void pictureBoxBell_Click(object sender, EventArgs e)
        {
            pictureBoxBell.Visible = false;
            pictureBoxBellhide.Visible = true;

            //알림 끄기
        }

        private void pictureBoxBellhide_Click(object sender, EventArgs e)
        {
            pictureBoxBell.Visible = true;
            pictureBoxBellhide.Visible = false;

            //알림 켜기
        }


        public void pictureBoxSettingshide_Click(object sender, EventArgs e)
        {
            pictureBoxFriendList.Visible = false;
            pictureBoxFriendListhide.Visible = true;
            pictureBoxChatList.Visible = false;
            pictureBoxChatListhide.Visible = true;
            pictureBoxSettings.Visible = true;
            pictureBoxSettingshide.Visible = false;
            panelFriendList.Controls.Clear();
            ProfileSettings fm = new ProfileSettings();
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            panelFriendList.Controls.Add(fm);
            fm.Show();
        }

        #endregion

        #region 내 프로필 클릭
        private void panelMyProfile_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ProfileSettings profileSettings = new ProfileSettings();
            this.Hide();
            profileSettings.ShowDialog();
        }

        private void roundPictureBoxMyProfilePoto_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ProfileSettings profileSettings = new ProfileSettings();
            this.Hide();
            profileSettings.ShowDialog();
        }

        private void labelMyProfileName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ProfileSettings profileSettings = new ProfileSettings();
            this.Hide();
            profileSettings.ShowDialog();
        }
        #endregion


        #region 생일
        private void panelBirthDay_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            BirthDayFriendList birthDayFriendList = new BirthDayFriendList();
            birthDayFriendList.Show();
        }

        private void pictureBoxBirthDay_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            BirthDayFriendList birthDayFriendList = new BirthDayFriendList();
            birthDayFriendList.Show();
        }

        private void label4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            BirthDayFriendList birthDayFriendList = new BirthDayFriendList();
            birthDayFriendList.Show();
        }



        #endregion

        //아이디로 친구추가
        private void pictureBoxAddFriendID_Click(object sender, EventArgs e)
        {
            AddFriendID addFriendID = new AddFriendID();
            addFriendID.Show();
        }


        private void PanelFriendList_MouseWheel(object sender, MouseEventArgs e)
        {
            panelFriendList.Focus();
        }

        private void FriendList_Load(object sender, EventArgs e)
        {
            ListOfFriend fm = new ListOfFriend();
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            panelFriendList.Controls.Add(fm);
            fm.Show();
        }

    }
}
