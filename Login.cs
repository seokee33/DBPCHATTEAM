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
        bool auto_Login_Check = false;
        public Login()
        {
            InitializeComponent();
            this.panelBorder.MouseDown += panelBorder_MouseDown;
            Auto_Login();
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

            UserInfo user = new UserInfo();
            Encry encry = new Encry();

                if (myTextBoxID.Text.Equals("아이디") || myTextBoxID.Text.Length == 0 || myTextBoxPW.Text.Equals("비밀번호") || myTextBoxPW.Text.Length == 0)
                {
                    MessageBox.Show("아이디와 비밀번호를 입력해주세요!!");
                    return;
                }
                if (DBManager.GetInstance().exist("SELECT EXISTS (SELECT * FROM CHAT.UserInfo WHERE UID = '" + myTextBoxID.Text + "') AS exist;") == 1)
                {
                    DataTable dt = DBManager.GetInstance().select("SELECT * FROM CHAT.UserInfo WHERE UID = '" + myTextBoxID.Text + "';", "Login").Tables["Login"];
                    string str_Encry = encry.EncryptString(myTextBoxPW.Text, myTextBoxPW.Text);
                    foreach (DataRow data in dt.Rows)
                        user = new UserInfo(Convert.ToInt32(data[0]), Convert.ToString(data[1]), Convert.ToString(data[2]), Convert.ToString(data[3]), Convert.ToDateTime(data[4]), Convert.ToString(data[5]), Convert.ToString(data[6]));
                    if (str_Encry.Equals(user.get_Password()))
                    {
                        if (checkBoxAutoLogin.Checked)
                        {
                            StreamWriter sw = new StreamWriter(new FileStream("autoLogin.txt", FileMode.Create));
                            sw.WriteLine(1);
                            sw.WriteLine(user.get_UID());
                            sw.WriteLine(user.get_Password());
                            sw.Close();
                        }
                        else
                        {
                            StreamWriter sw = new StreamWriter(new FileStream("autoLogin.txt", FileMode.Create));
                            sw.WriteLine(0);
                            sw.WriteLine("");
                            sw.WriteLine("");
                            sw.Close();
                        }
                        LoginUser.GetInstance().set_User(user);
                        //UserData.Ct = user;
                        FriendList fl = new FriendList();
                        this.Hide();
                        fl.Show();
                    }
                    else
                    {
                        MessageBox.Show("비밀번호를 다시 확인해주세요!!");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("아이디와 비번을 확인하세요!!");
                    return;
                }
        }
        private void Auto_Login()
        {
            try
            {
                StreamReader sr = new StreamReader(new FileStream("autoLogin.txt", FileMode.Open));
                int i_Auto_Check = Convert.ToInt32(sr.ReadLine());
                if (i_Auto_Check == 1)
                    auto_Login_Check = true;
                else
                    auto_Login_Check = false;

                if (auto_Login_Check)
                {
                    checkBoxAutoLogin.Checked = true;
                    myTextBoxID.Text = Convert.ToString(sr.ReadLine());
                    myTextBoxPW.Text = Convert.ToString(sr.ReadLine());
                }
                else
                    checkBoxAutoLogin.Checked = false;

                sr.Close();
            }catch(Exception e)
            {
                Console.WriteLine(e);
            }
            
        }

        private void checkBoxAutoLogin_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxAutoLogin.Checked == false)
            {
                auto_Login_Check = false;
                myTextBoxID.Text = "";
                myTextBoxPW.Text = "";
            }
        }
    }
}