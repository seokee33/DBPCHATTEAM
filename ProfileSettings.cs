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

        private void button1_Click(object sender, EventArgs e)
        {
            string name = myTextBoxName.Text;
            string pw = myTextBoxPW.Text;
            string address = myTextBoxAdress.Text;
            string birth = myTextBoxBirthDay.Text;
            string nickname = myTextBoxNickName.Text;
            DateTime date = Convert.ToDateTime(birth);

            if (name.Equals("이름") || pw.Equals("비밀번호")|| address.Equals("주소")|| birth.Equals("생일")|| nickname.Equals("별명"))
            {
                MessageBox.Show("수정할 정보를 입력해주세요!!");
                return;
            }
            Encry encry = new Encry();
            DBManager.GetInstance().insert_Image(roundPictureBoxProfilePoto,
                "UPDATE `CHAT`.`UserInfo` " +
                   "SET `Password` = '" + encry.EncryptString(pw, pw) + "', `Address` = '" + address + "', `Birth` = '" + birth + "', `NickName` = '" + nickname + "', `Name` = '" + name + "',`Image` = '@Image' " +
                "WHERE (`Seq` = '" + LoginUser.GetInstance().get_User().get_Seq() + "')");

            LoginUser.GetInstance().set_User(new UserInfo(LoginUser.GetInstance().get_User().get_Seq(), LoginUser.GetInstance().get_User().get_UID(), encry.EncryptString(pw, pw), address, date, nickname, name, roundPictureBoxProfilePoto));
            MessageBox.Show("회원정보가 변경되었습니다.");
        }
    }
}
