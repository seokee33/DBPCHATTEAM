
namespace DBUI.UIControls
{
    partial class FriendListForm
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
            this.components = new System.ComponentModel.Container();
            this.labelFriendName = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.채팅하기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.친구삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roundPictureBoxFriend = new DBUI.RoundPictureBox();
            this.panelFriendProfile = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBoxFriend)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFriendName
            // 
            this.labelFriendName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.labelFriendName.ContextMenuStrip = this.contextMenuStrip1;
            this.labelFriendName.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelFriendName.Location = new System.Drawing.Point(109, 34);
            this.labelFriendName.Name = "labelFriendName";
            this.labelFriendName.Size = new System.Drawing.Size(269, 21);
            this.labelFriendName.TabIndex = 35;
            this.labelFriendName.Text = "이름";
            this.labelFriendName.Click += new System.EventHandler(this.FriendProfile_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.채팅하기ToolStripMenuItem,
            this.친구삭제ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 48);
            // 
            // 채팅하기ToolStripMenuItem
            // 
            this.채팅하기ToolStripMenuItem.Name = "채팅하기ToolStripMenuItem";
            this.채팅하기ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.채팅하기ToolStripMenuItem.Text = "채팅하기";
            this.채팅하기ToolStripMenuItem.Click += new System.EventHandler(this.ChattingToolStripMenuItem_Click);
            // 
            // 친구삭제ToolStripMenuItem
            // 
            this.친구삭제ToolStripMenuItem.Name = "친구삭제ToolStripMenuItem";
            this.친구삭제ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.친구삭제ToolStripMenuItem.Text = "친구삭제";
            this.친구삭제ToolStripMenuItem.Click += new System.EventHandler(this.DeleteFriendToolStripMenuItem_Click);
            // 
            // roundPictureBoxFriend
            // 
            this.roundPictureBoxFriend.ContextMenuStrip = this.contextMenuStrip1;
            this.roundPictureBoxFriend.Image = global::DBUI.Properties.Resources.프로필;
            this.roundPictureBoxFriend.Location = new System.Drawing.Point(23, 9);
            this.roundPictureBoxFriend.Name = "roundPictureBoxFriend";
            this.roundPictureBoxFriend.Size = new System.Drawing.Size(70, 70);
            this.roundPictureBoxFriend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roundPictureBoxFriend.TabIndex = 36;
            this.roundPictureBoxFriend.TabStop = false;
            this.roundPictureBoxFriend.Click += new System.EventHandler(this.FriendProfile_Click);
            // 
            // panelFriendProfile
            // 
            this.panelFriendProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panelFriendProfile.ContextMenuStrip = this.contextMenuStrip1;
            this.panelFriendProfile.Location = new System.Drawing.Point(0, 0);
            this.panelFriendProfile.Name = "panelFriendProfile";
            this.panelFriendProfile.Size = new System.Drawing.Size(390, 90);
            this.panelFriendProfile.TabIndex = 37;
            this.panelFriendProfile.Click += new System.EventHandler(this.FriendProfile_Click);
            // 
            // FriendListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelFriendName);
            this.Controls.Add(this.roundPictureBoxFriend);
            this.Controls.Add(this.panelFriendProfile);
            this.Name = "FriendListForm";
            this.Size = new System.Drawing.Size(390, 90);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBoxFriend)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelFriendName;
        private RoundPictureBox roundPictureBoxFriend;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 채팅하기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 친구삭제ToolStripMenuItem;
        private System.Windows.Forms.Panel panelFriendProfile;
    }
}
