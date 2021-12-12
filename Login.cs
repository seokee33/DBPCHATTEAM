using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.panelBorder.MouseDown += panelBorder_MouseDown;
            auto_Input_Login();
        }

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

        private void labelSignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Login_Execute2();
        }
        private void Login_Execute2()
        {
            UserInfo user = new UserInfo();
            Encry encry = new Encry();

            if (myTextBoxID.Text.Equals("아이디") || myTextBoxID.Text.Length == 0 || myTextBoxPW.Text.Equals("비밀번호") || myTextBoxPW.Text.Length == 0)
            {
                MessageBox.Show("아이디와 비밀번호를 입력해주세요!!");
                return;
            }
            if (DBManager.GetInstance().exist("SELECT EXISTS (SELECT * FROM CHAT.UserInfo WHERE UID = '" + myTextBoxID.Text + "') AS exist;") == 1)
            {
                user = DBManager.GetInstance().select_profile("SELECT * FROM CHAT.UserInfo WHERE UID = '" + myTextBoxID.Text + "';");
                string str_Encry = "";
                //if (Setting.GetInstance().get_Auto_Login())
                //    str_Encry = myTextBoxPW.Text;
                //else
                //    str_Encry = encry.EncryptString(myTextBoxPW.Text, myTextBoxPW.Text);
                str_Encry = encry.EncryptString(myTextBoxPW.Text, myTextBoxPW.Text);

                if (str_Encry.Equals(user.get_Password()) || myTextBoxPW.Text.Equals(user.get_Password()))
                {
                    LoginUser.GetInstance().set_User(user);
                    write_Auto_Login(LoginUser.GetInstance().get_User().get_UID(), LoginUser.GetInstance().get_User().get_Password());
                    FriendList fl = new FriendList();
                    fl.Show();
                    LoginFormValue.GetInstance().set_Login(this);
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("비밀번호를 다시 확인해주세요!!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("아이디를 확인하세요!!");
                return;
            }
        }
        private void Login_Execute()
        {

            UserInfo user = new UserInfo();
            Encry encry = new Encry();

            if (myTextBoxID.Text.Equals("아이디") || myTextBoxID.Text.Length == 0 || myTextBoxPW.Text.Equals("비밀번호") || myTextBoxPW.Text.Length == 0)
            {
                MessageBox.Show("아이디와 비밀번호를 입력해주세요!!");
                return;
            }
            if (DBManager.GetInstance().exist("SELECT EXISTS (SELECT * FROM CHAT.UserInfo WHERE UID = '" + myTextBoxID.Text + "') AS exist;") == 1)
            {
                user = DBManager.GetInstance().select_profile("SELECT * FROM CHAT.UserInfo WHERE UID = '" + myTextBoxID.Text + "';");
                string str_Encry = encry.EncryptString(myTextBoxPW.Text, myTextBoxPW.Text);

                if (str_Encry.Equals(user.get_Password()))
                {
                    LoginUser.GetInstance().set_User(user);
                    write_Auto_Login(LoginUser.GetInstance().get_User().get_UID(), LoginUser.GetInstance().get_User().get_Password());
                    FriendList fl = new FriendList();
                    fl.Show();
                    LoginFormValue.GetInstance().set_Login(this);
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("비밀번호를 다시 확인해주세요!!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("아이디를 확인하세요!!");
                return;
            }
        }
        private void write_Auto_Login(string id, string pw)
        {
            StreamWriter sr = new StreamWriter(new FileStream("autoLogin.txt", FileMode.Create));
            if (checkBoxAutoLogin.Checked)
            {
                sr.WriteLine(1);
                sr.WriteLine(id);
                sr.WriteLine(pw);
            }
            else
            {
                sr.WriteLine(0);
                sr.WriteLine("");
                sr.WriteLine("");
            }
            sr.Close();
        }


        private void auto_Input_Login()
        {
            StreamReader sr = new StreamReader(new FileStream("autoLogin.txt", FileMode.Open));
            int i_Auto_Check = Convert.ToInt32(sr.ReadLine());
            if (i_Auto_Check == 1)
            {
                Setting.GetInstance().set_Auto_Login(true);
                string id = Convert.ToString(sr.ReadLine());
                string pw = Convert.ToString(sr.ReadLine());
                myTextBoxID.Text = id;
                myTextBoxPW.Text = pw;
                checkBoxAutoLogin.Checked = true;
                sr.Close();
            }
            else 
            {
                Setting.GetInstance().set_Auto_Login(false);
                sr.Close();
                return;
            }
            
        }
    }
}