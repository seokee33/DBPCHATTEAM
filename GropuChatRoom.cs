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

namespace DBUI
{
    public partial class GropuChatRoom : Form
    {
        public GropuChatRoom()
        {
            InitializeComponent();
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

        private void pictureBoxMax2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pictureBoxMax2.Visible = false;
            pictureBoxMax.Visible = true;
        }

        private void pictureBoxMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBoxMax2.Visible = true;
            pictureBoxMax.Visible = false;
        }

        private void pictureBoxMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        private void GropuChatRoom_Load(object sender, EventArgs e)
        {
            populatItems();
        }

        private void populatItems()
        {
            GroupChatForm[] groupChatForms = new GroupChatForm[5];

            for (int i = 0; i < groupChatForms.Length; i++)
            {
                groupChatForms[i] = new GroupChatForm();
                groupChatForms[i].FriendName = "ㅇㅇㅇ";
                // 사진 db에서 받아오기

                if (flowLayoutPanel.Controls.Count < 0)
                {
                    flowLayoutPanel.Controls.Clear();
                }
                else
                    flowLayoutPanel.Controls.Add(groupChatForms[i]);
            }
        }
    }


}
