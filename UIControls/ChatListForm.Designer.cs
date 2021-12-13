
namespace DBUI.UIControls
{
    partial class ChatListForm
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
            this.labelName = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.FixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteMsgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelFriendProfile = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPin = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            this.panelFriendProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPin)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.labelName.ContextMenuStrip = this.contextMenuStrip1;
            this.labelName.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelName.Location = new System.Drawing.Point(119, 38);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(102, 21);
            this.labelName.TabIndex = 37;
            this.labelName.Text = "이름";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FixToolStripMenuItem,
            this.DeleteMsgToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 48);
            // 
            // FixToolStripMenuItem
            // 
            this.FixToolStripMenuItem.Name = "FixToolStripMenuItem";
            this.FixToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.FixToolStripMenuItem.Text = "상단고정";
            this.FixToolStripMenuItem.Click += new System.EventHandler(this.FixToolStripMenuItem_Click);
            // 
            // DeleteMsgToolStripMenuItem
            // 
            this.DeleteMsgToolStripMenuItem.Name = "DeleteMsgToolStripMenuItem";
            this.DeleteMsgToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.DeleteMsgToolStripMenuItem.Text = "대화삭제";
            this.DeleteMsgToolStripMenuItem.Click += new System.EventHandler(this.DeleteMsgToolStripMenuItem_Click);
            // 
            // panelFriendProfile
            // 
            this.panelFriendProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panelFriendProfile.ContextMenuStrip = this.contextMenuStrip1;
            this.panelFriendProfile.Controls.Add(this.pictureBox1);
            this.panelFriendProfile.Controls.Add(this.pictureBoxPin);
            this.panelFriendProfile.Controls.Add(this.labelName);
            this.panelFriendProfile.Location = new System.Drawing.Point(0, 0);
            this.panelFriendProfile.Name = "panelFriendProfile";
            this.panelFriendProfile.Size = new System.Drawing.Size(390, 96);
            this.panelFriendProfile.TabIndex = 39;
            this.panelFriendProfile.Click += new System.EventHandler(this.panelFriendProfile_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DBUI.Properties.Resources.messages;
            this.pictureBox1.Location = new System.Drawing.Point(25, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBoxPin
            // 
            this.pictureBoxPin.Image = global::DBUI.Properties.Resources.pin;
            this.pictureBoxPin.Location = new System.Drawing.Point(362, 22);
            this.pictureBoxPin.Name = "pictureBoxPin";
            this.pictureBoxPin.Size = new System.Drawing.Size(15, 15);
            this.pictureBoxPin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPin.TabIndex = 41;
            this.pictureBoxPin.TabStop = false;
            this.pictureBoxPin.Visible = false;
            // 
            // ChatListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.panelFriendProfile);
            this.Name = "ChatListForm";
            this.Size = new System.Drawing.Size(390, 96);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panelFriendProfile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Panel panelFriendProfile;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteMsgToolStripMenuItem;
        public System.Windows.Forms.PictureBox pictureBoxPin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
