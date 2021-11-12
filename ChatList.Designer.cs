
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
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxNewChat = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanelChatList = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNewChat)).BeginInit();
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
            // flowLayoutPanelChatList
            // 
            this.flowLayoutPanelChatList.AutoScroll = true;
            this.flowLayoutPanelChatList.Location = new System.Drawing.Point(0, 37);
            this.flowLayoutPanelChatList.Name = "flowLayoutPanelChatList";
            this.flowLayoutPanelChatList.Size = new System.Drawing.Size(415, 532);
            this.flowLayoutPanelChatList.TabIndex = 32;
            // 
            // ChatList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(415, 627);
            this.Controls.Add(this.flowLayoutPanelChatList);
            this.Controls.Add(this.pictureBoxNewChat);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChatList";
            this.Text = "ChatList";
            this.Load += new System.EventHandler(this.ChatList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNewChat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxNewChat;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelChatList;
    }
}