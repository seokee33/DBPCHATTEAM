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
    public partial class BirthDayFriendList : Form
    {
        public BirthDayFriendList()
        {
            InitializeComponent();
            this.panelBorder.MouseDown += panelBorder_MouseDown;
            this.MouseWheel += new MouseEventHandler(PanelBirthDayFriendList_MouseWheel);
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



        #endregion

        private void PanelBirthDayFriendList_MouseWheel(object sender, MouseEventArgs e)
        {
            panelBirthDayFriendList.Focus();
        }

        private void panelBirthDayFriend1_Paint(object sender, PaintEventArgs e)
        {
            //채팅 폼
        }

        private void roundPictureBoxBirthDayFriendPoto1_Click(object sender, EventArgs e)
        {
            //채팅 폼
        }

        private void labelBirthDayFriendName1_Click(object sender, EventArgs e)
        {
            //채팅 폼
        }
    }
}
