using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBUI
{
    public partial class FriendList : Form
    {
        Thread thread;
        public FriendList()
        {
            InitializeComponent();
            this.panelBorder.MouseDown += panelBorder_MouseDown;
            this.MouseWheel += new MouseEventHandler(PanelFriendList_MouseWheel);

            try
            {
                thread = new Thread(() => get_Message());
                thread.Start();
            }
            catch
            {
                Console.WriteLine("챗 스레드 종료");
            }
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
            Setting.GetInstance().set_alarmn(false);
            pictureBoxBell.Visible = false;
            pictureBoxBellhide.Visible = true;

            //알림 끄기
        }

        private void pictureBoxBellhide_Click(object sender, EventArgs e)
        {
            Setting.GetInstance().set_alarmn(true);
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

        private void pictureBoxLogout_Click(object sender, EventArgs e)
        {
            LoginUser.GetInstance().set_User(new UserInfo());
            StreamWriter sr = new StreamWriter(new FileStream("autoLogin.txt", FileMode.Create));
            sr.WriteLine(0);
            sr.WriteLine("");
            sr.WriteLine("");
            sr.Close();
            this.Hide();
            Login login = new Login();
            login.Show();


        }

        private void get_Message()
        {
            DataTable dt;
            List<ChatMessage> list = new List<ChatMessage>();
            while (true)
            {
                string SQL = "SELECT msg.user_id, msg.message FROM CHAT.ChatMessage as msg Join(SELECT RoomID FROM CHAT.User_Chat_Room where UserSeq = '" + LoginUser.GetInstance().get_User().get_UID() + "') as room on msg.room_id = room.RoomID where date_format(msg.Message_Date,'%Y-%m-%d %H:%i:%S')> date_format('" + DateTime.Now.AddSeconds(-5).ToString("yyyy-MM-dd HH:mm:ss") + "', '%Y-%m-%d %H:%i:%S') and msg.user_id != '" + LoginUser.GetInstance().get_User().get_UID() + "';";
                dt = DBManager.GetInstance().Alarm_select(SQL);
                list = new List<ChatMessage>();
                foreach (DataRow data in dt.Rows)
                {
                    list.Add(new ChatMessage(Convert.ToString(data[0]), Convert.ToString(data[1])));
                }
                if (list.Count > 0)
                {
                    foreach (ChatMessage msg in list)
                    {
                        Bell bell = new Bell(msg.Get_UserID(), msg.get_Msg());
                        bell.Show();
                        Thread.Sleep(5000);
                        bell.Close();
                        //if (this.InvokeRequired)
                        //{
                        //    this.BeginInvoke(new Action(() =>
                        //    {
                        //        //bell.alarm_msg.begininvoke(new action(() => bell.show()));
                        //        //bell.alarm_id.begininvoke(new action(() => bell.alarm_id.text += msg.get_userid()));
                        //        //bell.alarm_msg.begininvoke(new action(() => bell.alarm_msg.text += msg.get_msg()));

                        //        //bell.alarm_msg.begininvoke(new action(() => bell.close()));
                        //        //bell.Invoke((MethodInvoker)delegate () {
                        //        //    bell.alarm_ID.Text = msg.Get_UserID();
                        //        //    bell.alarm_msg.Text += msg.get_Msg();
                        //        //    bell.Show();
                        //        //});
                        //        bell.Show();
                        //        Thread.Sleep(5);
                        //        bell.Close();

                        //    }
                        //    ));
                        //}
                    }
                }
            }

        }

        private void MethodWithLoadingBar()
        {
           // Thread t1 = new Thread(ShowLoading);
            //t1.Start();/
            // Do the Main GUI Work Here
            //t1.Abort();
        }

        private void ShowLoading(string id, string msg)
        {
            Thread.Sleep(1000); //Uncomment this if you want to delay the display 
                                //(So Loading Bar only shows if the Method takes longer than 1 Second)
            Bell bell = new Bell();
            //bell.alarm_ID.Text = "Try to Connect...";
            bell.ShowDialog();
        }
    }
}
