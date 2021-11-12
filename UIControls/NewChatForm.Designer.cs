
namespace DBUI.UIControls
{
    partial class NewChatForm
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelFriendName = new System.Windows.Forms.Label();
            this.panelFriendProfile = new System.Windows.Forms.Panel();
            this.roundPictureBoxFriend = new DBUI.RoundPictureBox();
            this.checkBoxMakeNewChat = new System.Windows.Forms.CheckBox();
            this.panelFriendProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBoxFriend)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFriendName
            // 
            this.labelFriendName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.labelFriendName.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelFriendName.Location = new System.Drawing.Point(120, 35);
            this.labelFriendName.Name = "labelFriendName";
            this.labelFriendName.Size = new System.Drawing.Size(220, 21);
            this.labelFriendName.TabIndex = 38;
            this.labelFriendName.Text = "이름";
            // 
            // panelFriendProfile
            // 
            this.panelFriendProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panelFriendProfile.Controls.Add(this.labelFriendName);
            this.panelFriendProfile.Controls.Add(this.roundPictureBoxFriend);
            this.panelFriendProfile.Controls.Add(this.checkBoxMakeNewChat);
            this.panelFriendProfile.Location = new System.Drawing.Point(0, 0);
            this.panelFriendProfile.Name = "panelFriendProfile";
            this.panelFriendProfile.Size = new System.Drawing.Size(382, 90);
            this.panelFriendProfile.TabIndex = 40;
            // 
            // roundPictureBoxFriend
            // 
            this.roundPictureBoxFriend.Image = global::DBUI.Properties.Resources.프로필;
            this.roundPictureBoxFriend.Location = new System.Drawing.Point(25, 9);
            this.roundPictureBoxFriend.Name = "roundPictureBoxFriend";
            this.roundPictureBoxFriend.Size = new System.Drawing.Size(70, 70);
            this.roundPictureBoxFriend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roundPictureBoxFriend.TabIndex = 39;
            this.roundPictureBoxFriend.TabStop = false;
            // 
            // checkBoxMakeNewChat
            // 
            this.checkBoxMakeNewChat.AutoSize = true;
            this.checkBoxMakeNewChat.Location = new System.Drawing.Point(345, 40);
            this.checkBoxMakeNewChat.Name = "checkBoxMakeNewChat";
            this.checkBoxMakeNewChat.Size = new System.Drawing.Size(15, 14);
            this.checkBoxMakeNewChat.TabIndex = 0;
            this.checkBoxMakeNewChat.UseVisualStyleBackColor = true;
            // 
            // NewChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.panelFriendProfile);
            this.Name = "NewChatForm";
            this.Size = new System.Drawing.Size(380, 89);
            this.panelFriendProfile.ResumeLayout(false);
            this.panelFriendProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBoxFriend)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelFriendName;
        private RoundPictureBox roundPictureBoxFriend;
        private System.Windows.Forms.Panel panelFriendProfile;
        private System.Windows.Forms.CheckBox checkBoxMakeNewChat;
    }
}
