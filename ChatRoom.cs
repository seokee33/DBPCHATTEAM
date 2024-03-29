﻿using DBUI.UIControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBUI
{
    public partial class ChatRoom : Form
    {
        int roomNum;
        string friendName;
        Thread thread;
        List<ChatMessage> message = new List<ChatMessage>();
        public ChatRoom(int roomNum, string friendName)
        {
            InitializeComponent();
            this.roomNum = roomNum;
            this.friendName = friendName;
            labelFDName.Text = friendName;
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
            thread.Abort();
            //DBManager.GetInstance().init();
            this.Close();
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

        private void get_Message()
        {
            while (true)
            {
                List<ChatMessage> recent_msg = new List<ChatMessage>();
                DataTable get_mesage;
                if (message.Count == 0)
                {
                    recent_msg = new List<ChatMessage>();
                    get_mesage = DBManager.GetInstance().select("SELECT Message_Date, user_id, message FROM CHAT.ChatMessage where room_id = " + roomNum + ";");
                    foreach (DataRow data in get_mesage.Rows)
                    {
                        recent_msg.Add(new ChatMessage(Convert.ToDateTime(data[0]), Convert.ToString(data[1]), Convert.ToString(data[2]),null));
                        message.Add(new ChatMessage(Convert.ToDateTime(data[0]), Convert.ToString(data[1]), Convert.ToString(data[2]), null));
                    }

                }
                else
                {
                    recent_msg = new List<ChatMessage>();
                    DateTime last_Msg = message[message.Count - 1].Get_Date();
                    get_mesage = DBManager.GetInstance().select("SELECT Message_Date, user_id, message FROM CHAT.ChatMessage where room_id = '" + roomNum + "' and date_format(Message_Date,'%Y-%m-%d %H:%i:%S')>date_format('" + last_Msg.ToString("yyyy-MM-dd HH:mm:ss") + "', '%Y-%m-%d %H:%i:%S');");
                    foreach (DataRow data in get_mesage.Rows)
                    {
                        recent_msg.Add(new ChatMessage(Convert.ToDateTime(data[0]), Convert.ToString(data[1]), Convert.ToString(data[2]), null));
                        message.Add(new ChatMessage(Convert.ToDateTime(data[0]), Convert.ToString(data[1]), Convert.ToString(data[2]), null));
                    }
                }
                if (recent_msg.Count > 0)
                {
                    foreach (ChatMessage msg in recent_msg)
                    {
                        try
                        {
                            textBoxMessage.BeginInvoke(new Action(() => {
                                textBoxMessage.Text += (msg.Get_UserID() + " : " + msg.get_Msg() + Environment.NewLine);
                                textBoxMessage.SelectionStart = textBoxMessage.TextLength;
                                textBoxMessage.ScrollToCaret();
                            }
                            ));
                        }
                        catch
                        {

                        }
                    }
                }
                
            }
        }
        private void buttonMessageSend_Click(object sender, EventArgs e)
        {
            DBManager.GetInstance().msgexecuteQuerry("INSERT INTO `CHAT`.`ChatMessage` (`Message_Date`, `user_id`,`room_id`, `message`) VALUES ('" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + LoginUser.GetInstance().get_User().get_UID() + "', '" + roomNum + "','" + textBoxMessageSend.Text + "');");
            textBoxMessageSend.Text = "";

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text.Length == 0)
            {
                MessageBox.Show("검색어를 입력해주세요");
                return;
            }

            ChatSearch search = new ChatSearch(textBoxSearch.Text, message);
            search.Show();
        }

        private void pictureBoxNewChat_Click(object sender, EventArgs e)
        {
            emoticon emoticon = new emoticon(roomNum, friendName);
            emoticon.Show();
        }
    }
}


/*
using DBUI.UIControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBUI
{
    public partial class ChatRoom : Form
    {
        int roomNum;
        string friendName;
        Thread thread;
        List<ChatMessage> message = new List<ChatMessage>();
        public delegate void InvokeDelegate();

        public ChatRoom(int roomNum, string friendName)
        {
            InitializeComponent();
            this.roomNum = roomNum;
            this.friendName = friendName;
            labelFDName.Text = friendName;
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
            thread.Abort();
            DBManager.GetInstance().init();
            this.Close();
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

        private void get_Message()
        {
            while (true)
            {
                List<ChatMessage> recent_msg = new List<ChatMessage>();
                List<ChatMessage> get_msg = new List<ChatMessage>();
                if (message.Count == 0)
                {
                    recent_msg = new List<ChatMessage>();
                    get_msg = DBManager.GetInstance().select_MSG("SELECT Message_Date, user_id, message, msg_Image FROM CHAT.ChatMessage where room_id = " + roomNum + ";");
                    foreach (ChatMessage data in get_msg)
                    {
                        recent_msg.Add(data);
                        message.Add(data);
                    }
                    
                }
                else
                {
                    recent_msg = new List<ChatMessage>();
                    DateTime last_Msg = message[message.Count - 1].Get_Date();
                    get_msg = DBManager.GetInstance().select_MSG("SELECT Message_Date, user_id, message FROM CHAT.ChatMessage where room_id = '" + roomNum + "' and date_format(Message_Date,'%Y-%m-%d %H:%i:%S')>date_format('" + last_Msg.ToString("yyyy-MM-dd HH:mm:ss") + "', '%Y-%m-%d %H:%i:%S');");
                    foreach (ChatMessage data in get_msg)
                    {
                        recent_msg.Add(data);
                        message.Add(data);
                    }
                }
                if (recent_msg.Count > 0)
                {
                    foreach (ChatMessage msg in recent_msg)
                    {
                        try
                        {
                            if (msg.get_PB() == null)
                            {
                                if (msg.Get_UserID().Equals(LoginUser.GetInstance().get_User().get_UID()))
                                {
                                    Chatsendmsg chatSend = new Chatsendmsg(msg.Get_UserID(), msg.get_Msg());
                                    chat_Panel.BeginInvoke(new Action(() => chat_Panel.Controls.Add(chatSend)));
                                }
                                else
                                {
                                    Chatmsg chatmsg = new Chatmsg(msg.Get_UserID(), msg.get_Msg());
                                    chat_Panel.BeginInvoke(new Action(() => chat_Panel.Controls.Add(chatmsg)));
                                }
                            }
                            else
                            {
                                if (msg.Get_UserID().Equals(LoginUser.GetInstance().get_User().get_UID()))
                                {
                                    chatSendImage sendImage = new chatSendImage(msg.Get_UserID(), msg.get_PB());
                                    chat_Panel.BeginInvoke(new Action(() => chat_Panel.Controls.Add(sendImage)));
                                }
                                else
                                {
                                    Chat_Image chat_Image = new Chat_Image();
                                    chat_Image.Name = msg.Get_UserID();
                                    chat_Image.PB = msg.get_PB();
                                    chat_Panel.BeginInvoke(new InvokeDelegate(chat_Panel.Controls.Add(chat_Image)));
                                }
                            }
                        }
                        catch
                        {

                        }
                    }
                }
            }
        }
        public void atcion_A(Object chat)
        {
            if (typeof(Chat_Image).IsInstanceOfType(chat))
                chat_Panel.Controls.Add((Chat_Image)chat);
            else if (typeof(chatSendImage).IsInstanceOfType(chat))
                chat_Panel.Controls.Add((chatSendImage)chat);
            else if (typeof(Chatmsg).IsInstanceOfType(chat))
                chat_Panel.Controls.Add((Chatmsg)chat);
            else if (typeof(Chatsendmsg).IsInstanceOfType(chat))
                chat_Panel.Controls.Add((Chatsendmsg)chat);
            else
                return;
        }
        private void buttonMessageSend_Click(object sender, EventArgs e)
        {
            DBManager.GetInstance().msgexecuteQuerry("INSERT INTO `CHAT`.`ChatMessage` (`Message_Date`, `user_id`,`room_id`, `message`) VALUES ('" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + LoginUser.GetInstance().get_User().get_UID() + "', '" + roomNum + "','" + textBoxMessageSend.Text + "');");
            textBoxMessageSend.Text = "";

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text.Length == 0)
            {
                MessageBox.Show("검색어를 입력해주세요");
                return;
            }
                
            ChatSearch search = new ChatSearch(textBoxSearch.Text, message);
            search.Show();
        }

        private void pictureBoxNewChat_Click(object sender, EventArgs e)
        {
            emoticon emoticon = new emoticon(roomNum,friendName);
            emoticon.Show();
        }
    }
}
*/