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
            init();
        }

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
        private void init()
        {
            myTextBoxAdress.Text = LoginUser.GetInstance().get_User().get_Address();
            myTextBoxName.Text = LoginUser.GetInstance().get_User().get_Name();
            myTextBoxPW.Text = LoginUser.GetInstance().get_User().get_Password();
            myTextBoxBirthDay.Text = LoginUser.GetInstance().get_User().get_Birth().ToString();
            myTextBoxNickName.Text = LoginUser.GetInstance().get_User().get_NickName();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            string name = myTextBoxName.Text;
            string pw = myTextBoxPW.Text;
            string address = myTextBoxAdress.Text;
            string birth = myTextBoxBirthDay.Text;
            string nickname = myTextBoxNickName.Text;
            if (name.Length == 0 || pw.Length == 0 || address.Length == 0 || birth.Length == 0 || nickname.Length == 0)
            {
                MessageBox.Show("수정할 정보를 입력해주세요!!");
                return;
            }
            DateTime date = Convert.ToDateTime(birth);

            if (!pw.Equals(LoginUser.GetInstance().get_User().get_Password()))
            {
                Encry encry = new Encry();
                pw = encry.EncryptString(pw, pw);
            }

            DBManager.GetInstance().update_Image(roundPictureBoxProfilePoto,
                "UPDATE CHAT.UserInfo SET `Password` = '" + pw + "', `Address` = '" + address + "', `Birth` = '" + date.ToString("yyyy-MM-dd") + "', `NickName` = '" + nickname + "', `Name` = '" + name + "',`Image` = @Image WHERE (`Seq` = '" + LoginUser.GetInstance().get_User().get_Seq() + "')");

            LoginUser.GetInstance().set_User(new UserInfo(LoginUser.GetInstance().get_User().get_Seq(), LoginUser.GetInstance().get_User().get_UID(), pw, address, date, nickname, name, roundPictureBoxProfilePoto));
            MessageBox.Show("회원정보가 변경되었습니다.");
        }
    }
}
