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
        Thread thread;
        List<ChatMessage> message = new List<ChatMessage>();
        public ChatRoom(int roomNum)
        {
            InitializeComponent();
            this.roomNum = roomNum;
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
                        recent_msg.Add(new ChatMessage(Convert.ToDateTime(data[0]), Convert.ToString(data[1]), Convert.ToString(data[2])));
                        message.Add(new ChatMessage(Convert.ToDateTime(data[0]), Convert.ToString(data[1]), Convert.ToString(data[2])));
                    }
                    
                }
                else
                {
                    recent_msg = new List<ChatMessage>();
                    DateTime last_Msg = message[message.Count - 1].Get_Date();
                    get_mesage = DBManager.GetInstance().select("SELECT Message_Date, user_id, message FROM CHAT.ChatMessage where room_id = '" + roomNum + "' and date_format(Message_Date,'%Y-%m-%d %H:%i:%S')>date_format('" + last_Msg.ToString("yyyy-MM-dd HH:mm:ss") + "', '%Y-%m-%d %H:%i:%S');");
                    foreach (DataRow data in get_mesage.Rows)
                    {
                        recent_msg.Add(new ChatMessage(Convert.ToDateTime(data[0]), Convert.ToString(data[1]), Convert.ToString(data[2])));
                        message.Add(new ChatMessage(Convert.ToDateTime(data[0]), Convert.ToString(data[1]), Convert.ToString(data[2])));
                    }
                }
                if (recent_msg.Count > 0)
                {
                    foreach (ChatMessage msg in recent_msg)
                    {
                        try
                        {
                            textBoxMessage.BeginInvoke(new Action(() => textBoxMessage.Text += (msg.Get_UserID() + " : " + msg.get_Msg() + Environment.NewLine)));
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
    }
}
