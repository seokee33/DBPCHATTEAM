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
    public partial class SignUp : Form
    {

        private bool id_Duplicate;
        
        public SignUp()
        {
            InitializeComponent();
            this.panelBorder.MouseDown += panelBorder_MouseDown;
            id_Duplicate = false;
        }

        #region 상단
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

        private void buttonSginUp_Click(object sender, EventArgs e)
        {
            if (myTextBoxName.Text.Equals("이름") || myTextBoxName.Text.Length == 0 || myTextBoxID.Text.Equals("아이디") || myTextBoxID.Text.Length == 0 ||
              myTextBoxPW.Text.Equals("비밀번호") || myTextBoxPW.Text.Length == 0 || myTextBoxAdress.Text.Equals("주소") || myTextBoxAdress.Text.Length == 0 ||
              myTextBoxBirth.Text.Equals("생일") || myTextBoxBirth.Text.Length == 0 || myTextBoxNickName.Text.Equals("별명") || myTextBoxNickName.Text.Length == 0)
            {
                MessageBox.Show("정보를 입력하세요!!");
                return;
            }
            if(!id_Duplicate)
            {
                MessageBox.Show("중복체크를 해주세요.");
                return;
            }
            UserInfo user = new UserInfo();
            Encry encry = new Encry();
            string str_Encry = encry.EncryptString(myTextBoxPW.Text, myTextBoxPW.Text);
            DBManager.GetInstance().insert_Image(roundPictureBoxProfilePoto,"INSERT INTO CHAT.UserInfo (UID, Password, Address, Birth, NickName, Name, Image) VALUE ('" + myTextBoxID.Text + "', '" + str_Encry + "', '" + myTextBoxAdress.Text + "', '" + myTextBoxBirth.Text + "', '" + myTextBoxNickName.Text + "', '" + myTextBoxName.Text + "',@Image)", myTextBoxID.Text);
            MessageBox.Show("회원가입이 완료 되었습니다.");

            this.Close();
        }
        //프로필 사진 등록
        private void roundedPictureBoxAddPoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select Image";
            openFileDialog.Filter = "( *.bmp; *.jpg; *.png; *.jpeg) | *.BMP; *.JPG; *.PNG; *.JPEG";
            
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                roundPictureBoxProfilePoto.Image = Bitmap.FromFile(openFileDialog.FileName);
            }
        }

        //private void roundPictureBoxProfilePoto_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog openFileDialog = new OpenFileDialog();
        //    openFileDialog.Title = "Select Image";
        //    openFileDialog.Filter = "( *.bmp; *.jpg; *.png; *.jpeg) | *.BMP; *.JPG; *.PNG; *.JPEG";

        //    if (openFileDialog.ShowDialog() == DialogResult.OK)
        //    {
        //        roundPictureBoxProfilePoto.Image = Bitmap.FromFile(openFileDialog.FileName);
        //    }
        //}

        private void buttonDuplicateCheck_Click(object sender, EventArgs e)
        {
            UserInfo user = new UserInfo();
            if (myTextBoxID.Text.Length == 0 || myTextBoxID.Text == "아이디")
            {
                MessageBox.Show("ID를 입력해 주세요!");
                return;
            }
            else
            {
                if (DBManager.GetInstance().exist("SELECT EXISTS (SELECT * FROM CHAT.UserInfo WHERE UID = '" + myTextBoxID.Text + "') AS exist;") == 1)
                {
                    MessageBox.Show("같은 아이디가 존재합니다!");
                    return;
                }
                else
                {
                    MessageBox.Show("사용 가능한 아이디입니다!");
                    id_Duplicate = true;
                    return;
                }
            }
        }


    }
}
