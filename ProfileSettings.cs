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
    public partial class ProfileSettings : Form
    {
        public ProfileSettings()
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

        private void pictureBoxFriendListhide_Click(object sender, EventArgs e)
        {
            FriendList friendList = new FriendList();
            this.Visible = false;
            friendList.ShowDialog();
        }

        private void pictureBoxChatListhide_Click(object sender, EventArgs e)
        {
            // form 열기          
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

        #endregion

        private void buttonChangeProfilePoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select Image";
            openFileDialog.Filter = "( *.bmp; *.jpg; *.png; *.jpeg) | *.BMP; *.JPG; *.PNG; *.JPEG";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                roundPictureBoxProfilePoto.Image = Bitmap.FromFile(openFileDialog.FileName);

            }
        }
    }
}
