
namespace DBUI
{
    partial class ListOfFriend
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelFriendList = new System.Windows.Forms.Panel();
            this.flowLayoutPanelFriendList = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonFriendSearch = new System.Windows.Forms.Button();
            this.myTextBoxFriendSearch = new DBUI.UIControls.MyTextBox();
            this.pictureBoxAddFriendID = new System.Windows.Forms.PictureBox();
            this.panelBirthDay = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBoxBirthDay = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxLine2 = new System.Windows.Forms.PictureBox();
            this.panelMyProfile = new System.Windows.Forms.Panel();
            this.labelMyProfileName = new System.Windows.Forms.Label();
            this.roundPictureBoxMyProfilePoto = new DBUI.RoundPictureBox();
            this.pictureBoxLine = new System.Windows.Forms.PictureBox();
            this.btn_star_friend = new System.Windows.Forms.Button();
            this.panelFriendList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddFriendID)).BeginInit();
            this.panelBirthDay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBirthDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLine2)).BeginInit();
            this.panelMyProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBoxMyProfilePoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLine)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFriendList
            // 
            this.panelFriendList.Controls.Add(this.btn_star_friend);
            this.panelFriendList.Controls.Add(this.flowLayoutPanelFriendList);
            this.panelFriendList.Controls.Add(this.buttonFriendSearch);
            this.panelFriendList.Controls.Add(this.myTextBoxFriendSearch);
            this.panelFriendList.Controls.Add(this.pictureBoxAddFriendID);
            this.panelFriendList.Controls.Add(this.panelBirthDay);
            this.panelFriendList.Controls.Add(this.label1);
            this.panelFriendList.Controls.Add(this.label2);
            this.panelFriendList.Controls.Add(this.pictureBoxLine2);
            this.panelFriendList.Controls.Add(this.panelMyProfile);
            this.panelFriendList.Location = new System.Drawing.Point(0, 0);
            this.panelFriendList.Name = "panelFriendList";
            this.panelFriendList.Size = new System.Drawing.Size(415, 630);
            this.panelFriendList.TabIndex = 39;
            // 
            // flowLayoutPanelFriendList
            // 
            this.flowLayoutPanelFriendList.AutoScroll = true;
            this.flowLayoutPanelFriendList.Location = new System.Drawing.Point(0, 289);
            this.flowLayoutPanelFriendList.Name = "flowLayoutPanelFriendList";
            this.flowLayoutPanelFriendList.Size = new System.Drawing.Size(415, 338);
            this.flowLayoutPanelFriendList.TabIndex = 52;
            // 
            // buttonFriendSearch
            // 
            this.buttonFriendSearch.BackColor = System.Drawing.Color.White;
            this.buttonFriendSearch.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonFriendSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFriendSearch.Location = new System.Drawing.Point(319, 13);
            this.buttonFriendSearch.Name = "buttonFriendSearch";
            this.buttonFriendSearch.Size = new System.Drawing.Size(45, 27);
            this.buttonFriendSearch.TabIndex = 51;
            this.buttonFriendSearch.Text = "검색";
            this.buttonFriendSearch.UseVisualStyleBackColor = false;
            this.buttonFriendSearch.Click += new System.EventHandler(this.buttonFriendSearch_Click);
            // 
            // myTextBoxFriendSearch
            // 
            this.myTextBoxFriendSearch.BorderColor = System.Drawing.Color.LightGray;
            this.myTextBoxFriendSearch.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.myTextBoxFriendSearch.Location = new System.Drawing.Point(6, 13);
            this.myTextBoxFriendSearch.Name = "myTextBoxFriendSearch";
            this.myTextBoxFriendSearch.Size = new System.Drawing.Size(307, 27);
            this.myTextBoxFriendSearch.TabIndex = 50;
            // 
            // pictureBoxAddFriendID
            // 
            this.pictureBoxAddFriendID.Image = global::DBUI.Properties.Resources.add_friend__1_;
            this.pictureBoxAddFriendID.Location = new System.Drawing.Point(368, 13);
            this.pictureBoxAddFriendID.Name = "pictureBoxAddFriendID";
            this.pictureBoxAddFriendID.Size = new System.Drawing.Size(31, 27);
            this.pictureBoxAddFriendID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAddFriendID.TabIndex = 49;
            this.pictureBoxAddFriendID.TabStop = false;
            this.pictureBoxAddFriendID.Click += new System.EventHandler(this.pictureBoxAddFriendID_Click);
            // 
            // panelBirthDay
            // 
            this.panelBirthDay.Controls.Add(this.label4);
            this.panelBirthDay.Controls.Add(this.pictureBoxBirthDay);
            this.panelBirthDay.Location = new System.Drawing.Point(0, 184);
            this.panelBirthDay.Name = "panelBirthDay";
            this.panelBirthDay.Size = new System.Drawing.Size(400, 56);
            this.panelBirthDay.TabIndex = 44;
            this.panelBirthDay.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.BirthDay_MouseDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(104, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 21);
            this.label4.TabIndex = 33;
            this.label4.Text = "친구의 생일을 확인해보세요!";
            this.label4.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.BirthDay_MouseDoubleClick);
            // 
            // pictureBoxBirthDay
            // 
            this.pictureBoxBirthDay.Image = global::DBUI.Properties.Resources.balloons;
            this.pictureBoxBirthDay.Location = new System.Drawing.Point(30, 10);
            this.pictureBoxBirthDay.Name = "pictureBoxBirthDay";
            this.pictureBoxBirthDay.Size = new System.Drawing.Size(55, 36);
            this.pictureBoxBirthDay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBirthDay.TabIndex = 33;
            this.pictureBoxBirthDay.TabStop = false;
            this.pictureBoxBirthDay.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.BirthDay_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(14, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 25);
            this.label1.TabIndex = 46;
            this.label1.Text = "친구";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(14, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 25);
            this.label2.TabIndex = 43;
            this.label2.Text = "생일";
            // 
            // pictureBoxLine2
            // 
            this.pictureBoxLine2.Image = global::DBUI.Properties.Resources.substract;
            this.pictureBoxLine2.Location = new System.Drawing.Point(24, 232);
            this.pictureBoxLine2.Name = "pictureBoxLine2";
            this.pictureBoxLine2.Size = new System.Drawing.Size(328, 41);
            this.pictureBoxLine2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLine2.TabIndex = 45;
            this.pictureBoxLine2.TabStop = false;
            // 
            // panelMyProfile
            // 
            this.panelMyProfile.Controls.Add(this.labelMyProfileName);
            this.panelMyProfile.Controls.Add(this.roundPictureBoxMyProfilePoto);
            this.panelMyProfile.Controls.Add(this.pictureBoxLine);
            this.panelMyProfile.Location = new System.Drawing.Point(6, 46);
            this.panelMyProfile.Name = "panelMyProfile";
            this.panelMyProfile.Size = new System.Drawing.Size(394, 92);
            this.panelMyProfile.TabIndex = 42;
            // 
            // labelMyProfileName
            // 
            this.labelMyProfileName.AutoSize = true;
            this.labelMyProfileName.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelMyProfileName.Location = new System.Drawing.Point(107, 34);
            this.labelMyProfileName.Name = "labelMyProfileName";
            this.labelMyProfileName.Size = new System.Drawing.Size(42, 21);
            this.labelMyProfileName.TabIndex = 23;
            this.labelMyProfileName.Text = "이름";
            // 
            // roundPictureBoxMyProfilePoto
            // 
            this.roundPictureBoxMyProfilePoto.Image = global::DBUI.Properties.Resources.프로필;
            this.roundPictureBoxMyProfilePoto.Location = new System.Drawing.Point(15, 10);
            this.roundPictureBoxMyProfilePoto.Name = "roundPictureBoxMyProfilePoto";
            this.roundPictureBoxMyProfilePoto.Size = new System.Drawing.Size(70, 70);
            this.roundPictureBoxMyProfilePoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roundPictureBoxMyProfilePoto.TabIndex = 22;
            this.roundPictureBoxMyProfilePoto.TabStop = false;
            // 
            // pictureBoxLine
            // 
            this.pictureBoxLine.Image = global::DBUI.Properties.Resources.substract;
            this.pictureBoxLine.Location = new System.Drawing.Point(18, 71);
            this.pictureBoxLine.Name = "pictureBoxLine";
            this.pictureBoxLine.Size = new System.Drawing.Size(376, 41);
            this.pictureBoxLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLine.TabIndex = 24;
            this.pictureBoxLine.TabStop = false;
            // 
            // btn_star_friend
            // 
            this.btn_star_friend.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_star_friend.Location = new System.Drawing.Point(358, 246);
            this.btn_star_friend.Name = "btn_star_friend";
            this.btn_star_friend.Size = new System.Drawing.Size(45, 34);
            this.btn_star_friend.TabIndex = 53;
            this.btn_star_friend.UseVisualStyleBackColor = true;
            // 
            // ListOfFriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(415, 627);
            this.Controls.Add(this.panelFriendList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListOfFriend";
            this.Text = "ListOfFriend";
            this.Load += new System.EventHandler(this.ListOfFriend_Load);
            this.panelFriendList.ResumeLayout(false);
            this.panelFriendList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddFriendID)).EndInit();
            this.panelBirthDay.ResumeLayout(false);
            this.panelBirthDay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBirthDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLine2)).EndInit();
            this.panelMyProfile.ResumeLayout(false);
            this.panelMyProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBoxMyProfilePoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFriendList;
        private System.Windows.Forms.Button buttonFriendSearch;
        private UIControls.MyTextBox myTextBoxFriendSearch;
        private System.Windows.Forms.PictureBox pictureBoxAddFriendID;
        private System.Windows.Forms.Panel panelBirthDay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBoxBirthDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxLine2;
        private System.Windows.Forms.Panel panelMyProfile;
        private System.Windows.Forms.Label labelMyProfileName;
        private RoundPictureBox roundPictureBoxMyProfilePoto;
        private System.Windows.Forms.PictureBox pictureBoxLine;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelFriendList;
        private System.Windows.Forms.Button btn_star_friend;
    }
}