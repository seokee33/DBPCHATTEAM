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
    public partial class AddFriendID : Form
    {
        ListOfFriend listOfFriend;
        
        public AddFriendID(ListOfFriend listOfFriend)
        {
            InitializeComponent();
            this.listOfFriend = listOfFriend;
            this.panelBorder.MouseDown += panelBorder_MouseDown;

        }
        public AddFriendID()
        {
            InitializeComponent();
            this.panelBorder.MouseDown += panelBorder_MouseDown;
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

            this.Close();
        }
        #endregion

        private void buttonAddFriendID_Click(object sender, EventArgs e)
        {
            UserInfo user = UserData.Ct;
            UserInfo friend = new UserInfo();
            if (DBManager.GetInstance().exist("SELECT EXISTS (SELECT * FROM CHAT.UserInfo WHERE UID = '" + myTextBoxFriendID.Text + "') AS exist;") == 1)
            {
                DataTable dt = DBManager.GetInstance().select("SELECT * FROM CHAT.UserInfo WHERE UID = '" + myTextBoxFriendID.Text + "';", "SelectID").Tables["SelectID"];
                foreach (DataRow data in dt.Rows)
                    friend = new UserInfo(Convert.ToInt32(data[0]), Convert.ToString(data[1]), Convert.ToString(data[2]), Convert.ToString(data[3]), Convert.ToDateTime(data[4]), Convert.ToString(data[5]),Convert.ToString(data[6]));

                DBManager.GetInstance().executeQuerry("INSERT INTO `CHAT`.`Friends` (`UserID`, `FriendID`) VALUES ('"+user.get_Seq()+"', '"+friend.get_Seq()+"');");
                
                listOfFriend.ListOfFriend_Load(sender, e);
                this.Close();
            }
            else
            {
                MessageBox.Show("아이디가 존재하지않습니다.");
                return;
            }
                
        }
    }
}
