using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBUI.UIControls;
using System.Windows.Forms;

namespace DBUI
{
    public partial class NewChat : Form
    {
        public NewChat()
        {
            InitializeComponent();
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

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PanelFriendList_MouseWheel(object sender, MouseEventArgs e)
        {
            panelFriendList.Focus();
        }

        private void populatItems()
        {
            NewChatForm[] newChatForms = new NewChatForm[10];

            for (int i = 0; i < newChatForms.Length; i++)
            {
                newChatForms[i] = new NewChatForm();
                newChatForms[i].FriendListName = "ㅇㅇㅇ";
                // 사진 db에서 받아오기

                if (panelFriendList.Controls.Count < 0)
                {
                    panelFriendList.Controls.Clear();
                }
                else
                    panelFriendList.Controls.Add(newChatForms[i]);
            }
        }

        private void NewChat_Load(object sender, EventArgs e)
        {
            populatItems();
        }
    }
}
