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
            this.Close();
        }



        #endregion

        private void PanelBirthDayFriendList_MouseWheel(object sender, MouseEventArgs e)
        {
            flowLayoutPanelBirthDayFriendList.Focus();
        }

        private void populatItems()
        { 
            BirthDayFriendProfileForm[] birthDayFriendListsform = new BirthDayFriendProfileForm[10];
            
            for (int i = 0; i < birthDayFriendListsform.Length; i++)
            {
                birthDayFriendListsform[i] = new BirthDayFriendProfileForm();
                birthDayFriendListsform[i].BDFriendName = "ㅇㅇㅇ";
                // 사진 db에서 받아오기

                if (flowLayoutPanelBirthDayFriendList.Controls.Count < 0)
                {
                    flowLayoutPanelBirthDayFriendList.Controls.Clear();
                }
                else
                    flowLayoutPanelBirthDayFriendList.Controls.Add(birthDayFriendListsform[i]);
            }
        }

        private void BirthDayFriendList_Load(object sender, EventArgs e)
        {
            populatItems();
        }
    }
}
