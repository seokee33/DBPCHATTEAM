﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBUI.UIControls
{
    public partial class FriendListForm : UserControl
    {
        ListOfFriend listform;
        public FriendListForm(ListOfFriend list)
        {
            InitializeComponent();
            this.listform = list;

        }

        #region Properties
        private string _UID;
        private int _fNum;
        private string _name;
        private Image _profile;
        private int _friends_Seq;


        public string UID
        {
            get { return _UID; }
            set { _UID = value; }
        }
        public int friendNum
        {
            get { return _fNum; }
            set { _fNum = value; }
        }
        public int friends_Seq
        {
            get { return _friends_Seq; }
            set { _friends_Seq = value; }
        }
        public string FriendListName
        {
            get { return _name; }
            set { _name = value; labelFriendName.Text = value; }
        }

        public Image FriendListProfile
        {
            get { return _profile; }
            set { _profile = value; roundPictureBoxFriend.Image = value; }
        }
        #endregion

        private void ChattingToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void DeleteFriendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBManager.GetInstance().executeQuerry("DELETE FROM `CHAT`.`Friends` WHERE (`UserID` = '"+ LoginUser.GetInstance().get_User().get_UID() + "'and `FriendID` = '"+_fNum+"');");
            DBManager.GetInstance().executeQuerry("DELETE FROM `CHAT`.`Friends` WHERE (`UserID` = '" + _fNum + "'and `FriendID` = '" + LoginUser.GetInstance().get_User().get_Seq() + "');");
            listform.ListOfFriend_Load(sender, e);

        }

        private void FriendProfile_Click(object sender, EventArgs e)
        {
            int roomNum;
            if(DBManager.GetInstance().exist("SELECT EXISTS(SELECT * FROM CHAT.User_Chat_Room WHERE `UserSeq` = '" + LoginUser.GetInstance().get_User().get_UID() + "' and `FriendSeq` ='" + _UID + "' ) AS exist; ") == 0)
            {
                DBManager.GetInstance().executeQuerry("INSERT INTO `CHAT`.`User_Chat_Room` (`UserSeq`,`FriendSeq`, `RoomID`) VALUES ('" + LoginUser.GetInstance().get_User().get_UID() + "','" + _UID + "', '" + _fNum + "');");
                DBManager.GetInstance().executeQuerry("INSERT INTO `CHAT`.`User_Chat_Room` (`UserSeq`,`FriendSeq`, `RoomID`) VALUES ('" + _UID + "','" + LoginUser.GetInstance().get_User().get_UID() + "', '" + _fNum + "');");
                DataTable dt = DBManager.GetInstance().select("SELECT `RoomID` FROM CHAT.User_Chat_Room WHERE `UserSeq` = '" + LoginUser.GetInstance().get_User().get_UID() + "' and `FriendSeq` ='" + _UID + "';");
                roomNum = Convert.ToInt32(dt.Rows[0][0]);

            }
            else
            {
                DataTable dt = DBManager.GetInstance().select("SELECT `RoomID` FROM CHAT.User_Chat_Room WHERE `UserSeq` = '" + LoginUser.GetInstance().get_User().get_UID() + "' and `FriendSeq` ='" + _UID + "';");
                roomNum = Convert.ToInt32(dt.Rows[0][0]);
            }

            ChatRoom chatroom = new ChatRoom(roomNum);
            chatroom.Show();



            //DataTable dt = DBManager.GetInstance().select("SELECT AUTO_INCREMENT FROM information_schema.tables WHERE table_name = 'User_Chat_Room';");
            //int room_Num = Convert.ToInt32(dt.Rows[0][0]);
            //DBManager.GetInstance().executeQuerry("INSERT INTO `CHAT`.`User_Chat_Room` (`UserSeq`, `RoomID`) VALUES ('"+LoginUser.GetInstance().get_User().get_Seq()+"', '"+room_Num+"');");
            //DBManager.GetInstance().executeQuerry("INSERT INTO `CHAT`.`User_Chat_Room` (`UserSeq`, `RoomID`) VALUES ('" + _friends_Seq + "', '" + room_Num + "');");
        }
    }
}
