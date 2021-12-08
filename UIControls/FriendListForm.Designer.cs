
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
            this.즐겨찾기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelFriendProfile = new System.Windows.Forms.Panel();
            this.pictureBoxStar = new System.Windows.Forms.PictureBox();
            this.roundPictureBoxFriend = new DBUI.RoundPictureBox();
            this.contextMenuStrip1.SuspendLayout();
            this.panelFriendProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBoxFriend)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFriendName
            // 
            this.labelFriendName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.labelFriendName.ContextMenuStrip = this.contextMenuStrip1;
            this.labelFriendName.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelFriendName.Location = new System.Drawing.Point(156, 51);
            this.labelFriendName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFriendName.Name = "labelFriendName";
            this.labelFriendName.Size = new System.Drawing.Size(308, 32);
            this.labelFriendName.TabIndex = 35;
            this.labelFriendName.Text = "이름";
            this.labelFriendName.Click += new System.EventHandler(this.FriendProfile_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.채팅하기ToolStripMenuItem,
            this.친구삭제ToolStripMenuItem,
            this.즐겨찾기ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(241, 133);
            // 
            // 채팅하기ToolStripMenuItem
            // 
            this.채팅하기ToolStripMenuItem.Name = "채팅하기ToolStripMenuItem";
            this.채팅하기ToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.채팅하기ToolStripMenuItem.Text = "채팅하기";
            this.채팅하기ToolStripMenuItem.Click += new System.EventHandler(this.ChattingToolStripMenuItem_Click);
            // 
            // 친구삭제ToolStripMenuItem
            // 
            this.친구삭제ToolStripMenuItem.Name = "친구삭제ToolStripMenuItem";
            this.친구삭제ToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.친구삭제ToolStripMenuItem.Text = "친구삭제";
            this.친구삭제ToolStripMenuItem.Click += new System.EventHandler(this.DeleteFriendToolStripMenuItem_Click);
            // 
            // 즐겨찾기ToolStripMenuItem
            // 
            this.즐겨찾기ToolStripMenuItem.Name = "즐겨찾기ToolStripMenuItem";
            this.즐겨찾기ToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.즐겨찾기ToolStripMenuItem.Text = "즐겨찾기";
            this.즐겨찾기ToolStripMenuItem.Click += new System.EventHandler(this.즐겨찾기ToolStripMenuItem_Click);
            // 
            // panelFriendProfile
            // 
            this.panelFriendProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panelFriendProfile.ContextMenuStrip = this.contextMenuStrip1;
            this.panelFriendProfile.Controls.Add(this.pictureBoxStar);
            this.panelFriendProfile.Location = new System.Drawing.Point(0, 0);
            this.panelFriendProfile.Margin = new System.Windows.Forms.Padding(4);
            this.panelFriendProfile.Name = "panelFriendProfile";
            this.panelFriendProfile.Size = new System.Drawing.Size(557, 135);
            this.panelFriendProfile.TabIndex = 37;
            this.panelFriendProfile.Click += new System.EventHandler(this.FriendProfile_Click);
            // 
            // pictureBoxStar
            // 
            this.pictureBoxStar.Image = global::DBUI.Properties.Resources.star;
            this.pictureBoxStar.Location = new System.Drawing.Point(486, 47);
            this.pictureBoxStar.Name = "pictureBoxStar";
            this.pictureBoxStar.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxStar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStar.TabIndex = 0;
            this.pictureBoxStar.TabStop = false;
            this.pictureBoxStar.Visible = false;
            // 
            // roundPictureBoxFriend
            // 
            this.roundPictureBoxFriend.ContextMenuStrip = this.contextMenuStrip1;
            this.roundPictureBoxFriend.Image = global::DBUI.Properties.Resources.프로필;
            this.roundPictureBoxFriend.Location = new System.Drawing.Point(33, 14);
            this.roundPictureBoxFriend.Margin = new System.Windows.Forms.Padding(4);
            this.roundPictureBoxFriend.Name = "roundPictureBoxFriend";
            this.roundPictureBoxFriend.Size = new System.Drawing.Size(100, 105);
            this.roundPictureBoxFriend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roundPictureBoxFriend.TabIndex = 36;
            this.roundPictureBoxFriend.TabStop = false;
            this.roundPictureBoxFriend.Click += new System.EventHandler(this.FriendProfile_Click);
            // 
            // FriendListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelFriendName);
            this.Controls.Add(this.roundPictureBoxFriend);
            this.Controls.Add(this.panelFriendProfile);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FriendListForm";
            this.Size = new System.Drawing.Size(557, 135);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panelFriendProfile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStar)).EndInit();
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
        public System.Windows.Forms.PictureBox pictureBoxStar;
        private System.Windows.Forms.ToolStripMenuItem 즐겨찾기ToolStripMenuItem;
    }
}
