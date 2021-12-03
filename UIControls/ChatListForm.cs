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
    public partial class ChatListForm : UserControl
    {
        ChatList chat;
        public ChatListForm(ChatList chatList)
        {
            InitializeComponent();
            this.chat = chatList;
        }

        #region Properties
        private string _name;
        private Image _profile;
        private string _mgs;
        private int _roomNum;
        private int _top;
        private int _Seq;

        public int Seq
        {
            get { return _Seq; }
            set { _Seq = value; }
        }
        public string FriendName
        {
            get { return _name; }
            set { _name = value; labelName.Text = value; }
        }
        public int Top
        {
            get { return _top; }
            set { _top = value; }
        }
        public int RoomNum
        {
            get { return _roomNum; }
            set { _roomNum = value; }
        }
        public string ChatMsg
        {
            get { return _mgs; }
            set { _mgs = value; labelMsg.Text = value; }
        }

        public Image FriendProfile
        {
            get { return _profile; }
            set { _profile = value; roundPictureBoxFriend.Image = value; }
        }
        #endregion

        private void FriendProfile_Click(object sender, EventArgs e)
        {
            
        }

        private void FixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBoxPin.Visible == false)
            {
                pictureBoxPin.Visible = true;
                DBManager.GetInstance().executeQuerry("UPDATE `CHAT`.`User_Chat_Room` SET `Top` = '1' WHERE (`Seq` = '"+_Seq+"');");
                FixToolStripMenuItem.Text = "고정해제";
            }
            else
            {
                pictureBoxPin.Visible = false;
                DBManager.GetInstance().executeQuerry("UPDATE `CHAT`.`User_Chat_Room` SET `Top` = '0' WHERE (`Seq` = '" + _Seq + "');");
                FixToolStripMenuItem.Text = "상단고정";
            }
            chat.populatItems();
        }

        private void DeleteMsgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = DBManager.GetInstance().select("SELECT Seq FROM CHAT.User_Chat_Room where RoomID = '" + _roomNum + "';");
            foreach (DataRow data in dt.Rows)
                DBManager.GetInstance().executeQuerry("DELETE FROM `CHAT`.`User_Chat_Room` WHERE (`Seq` = '" + data[0] + "');");

            chat.populatItems();
        }

        private void panelFriendProfile_Click(object sender, EventArgs e)
        {
            ChatRoom chatroom = new ChatRoom(_roomNum, _name);
            chatroom.Show();
        }
    }
}
