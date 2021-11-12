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
    public partial class ChatList : Form
    {
        public ChatList()
        {
            InitializeComponent();
            this.MouseWheel += new MouseEventHandler(PanelChatList_MouseWheel);
        }

        private void pictureBoxNewChat_Click(object sender, EventArgs e)
        {
            NewChat newForm = new NewChat();
            newForm.Show();
        }
        private void PanelChatList_MouseWheel(object sender, MouseEventArgs e)
        {
            panelChatList.Focus();
        }
    }
}
