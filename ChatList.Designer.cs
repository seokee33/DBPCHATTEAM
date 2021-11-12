
namespace DBUI
{
    partial class ChatList
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.FixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxPin = new System.Windows.Forms.PictureBox();
            this.pictureBoxNewChat = new System.Windows.Forms.PictureBox();
            this.panelChatList = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNewChat)).BeginInit();
            this.panelChatList.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "채팅";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FixToolStripMenuItem,
            this.DelToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 48);
            // 
            // FixToolStripMenuItem
            // 
            this.FixToolStripMenuItem.Name = "FixToolStripMenuItem";
            this.FixToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.FixToolStripMenuItem.Text = "상단고정";
            // 
            // DelToolStripMenuItem
            // 
            this.DelToolStripMenuItem.Name = "DelToolStripMenuItem";
            this.DelToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.DelToolStripMenuItem.Text = "대화삭제";
            // 
            // pictureBoxPin
            // 
            this.pictureBoxPin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxPin.Image = global::DBUI.Properties.Resources.pin;
            this.pictureBoxPin.Location = new System.Drawing.Point(260, 16);
            this.pictureBoxPin.Name = "pictureBoxPin";
            this.pictureBoxPin.Size = new System.Drawing.Size(15, 15);
            this.pictureBoxPin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPin.TabIndex = 33;
            this.pictureBoxPin.TabStop = false;
            this.pictureBoxPin.Visible = false;
            // 
            // pictureBoxNewChat
            // 
            this.pictureBoxNewChat.Image = global::DBUI.Properties.Resources.talk_bubble_with_plus_sign;
            this.pictureBoxNewChat.Location = new System.Drawing.Point(363, 575);
            this.pictureBoxNewChat.Name = "pictureBoxNewChat";
            this.pictureBoxNewChat.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxNewChat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNewChat.TabIndex = 31;
            this.pictureBoxNewChat.TabStop = false;
            this.pictureBoxNewChat.Click += new System.EventHandler(this.pictureBoxNewChat_Click);
            // 
            // panelChatList
            // 
            this.panelChatList.Controls.Add(this.pictureBoxPin);
            this.panelChatList.Location = new System.Drawing.Point(0, 37);
            this.panelChatList.Name = "panelChatList";
            this.panelChatList.Size = new System.Drawing.Size(415, 532);
            this.panelChatList.TabIndex = 34;
            // 
            // ChatList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(415, 627);
            this.Controls.Add(this.panelChatList);
            this.Controls.Add(this.pictureBoxNewChat);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChatList";
            this.Text = "ChatList";
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNewChat)).EndInit();
            this.panelChatList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxNewChat;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DelToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxPin;
        private System.Windows.Forms.Panel panelChatList;
    }
}