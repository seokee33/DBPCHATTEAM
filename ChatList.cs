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
        }

        private void pictureBoxNewChat_Click(object sender, EventArgs e)
        {
            NewChat newForm = new NewChat();
            newForm.Show();
        }
    }
}
