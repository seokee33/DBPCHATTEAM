
namespace DBUI
{
    partial class BirthDayFriendList
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
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.panelBorder = new System.Windows.Forms.Panel();
            this.panelBirthDayFriend1 = new System.Windows.Forms.Panel();
            this.labelBirthDayFriendName1 = new System.Windows.Forms.Label();
            this.roundPictureBoxBirthDayFriendPoto1 = new DBUI.RoundPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBirthDayFriendList = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.panelBorder.SuspendLayout();
            this.panelBirthDayFriend1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBoxBirthDayFriendPoto1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxClose.Image = global::DBUI.Properties.Resources.window_close_icon_135015;
            this.pictureBoxClose.Location = new System.Drawing.Point(324, 3);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(15, 15);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 5;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // panelBorder
            // 
            this.panelBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panelBorder.Controls.Add(this.pictureBoxClose);
            this.panelBorder.Location = new System.Drawing.Point(0, 0);
            this.panelBorder.Name = "panelBorder";
            this.panelBorder.Size = new System.Drawing.Size(346, 35);
            this.panelBorder.TabIndex = 2;
            this.panelBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBorder_MouseDown);
            // 
            // panelBirthDayFriend1
            // 
            this.panelBirthDayFriend1.Controls.Add(this.labelBirthDayFriendName1);
            this.panelBirthDayFriend1.Controls.Add(this.roundPictureBoxBirthDayFriendPoto1);
            this.panelBirthDayFriend1.Location = new System.Drawing.Point(0, 68);
            this.panelBirthDayFriend1.Name = "panelBirthDayFriend1";
            this.panelBirthDayFriend1.Size = new System.Drawing.Size(326, 73);
            this.panelBirthDayFriend1.TabIndex = 3;
            this.panelBirthDayFriend1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBirthDayFriend1_Paint);
            // 
            // labelBirthDayFriendName1
            // 
            this.labelBirthDayFriendName1.AutoSize = true;
            this.labelBirthDayFriendName1.Location = new System.Drawing.Point(94, 27);
            this.labelBirthDayFriendName1.Name = "labelBirthDayFriendName1";
            this.labelBirthDayFriendName1.Size = new System.Drawing.Size(29, 12);
            this.labelBirthDayFriendName1.TabIndex = 5;
            this.labelBirthDayFriendName1.Text = "이름";
            this.labelBirthDayFriendName1.Click += new System.EventHandler(this.labelBirthDayFriendName1_Click);
            // 
            // roundPictureBoxBirthDayFriendPoto1
            // 
            this.roundPictureBoxBirthDayFriendPoto1.Image = global::DBUI.Properties.Resources.프로필;
            this.roundPictureBoxBirthDayFriendPoto1.Location = new System.Drawing.Point(13, 7);
            this.roundPictureBoxBirthDayFriendPoto1.Name = "roundPictureBoxBirthDayFriendPoto1";
            this.roundPictureBoxBirthDayFriendPoto1.Size = new System.Drawing.Size(55, 55);
            this.roundPictureBoxBirthDayFriendPoto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roundPictureBoxBirthDayFriendPoto1.TabIndex = 4;
            this.roundPictureBoxBirthDayFriendPoto1.TabStop = false;
            this.roundPictureBoxBirthDayFriendPoto1.Click += new System.EventHandler(this.roundPictureBoxBirthDayFriendPoto1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(8, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "생일인 친구";
            // 
            // panelBirthDayFriendList
            // 
            this.panelBirthDayFriendList.AutoScroll = true;
            this.panelBirthDayFriendList.Location = new System.Drawing.Point(0, 64);
            this.panelBirthDayFriendList.Name = "panelBirthDayFriendList";
            this.panelBirthDayFriendList.Size = new System.Drawing.Size(346, 432);
            this.panelBirthDayFriendList.TabIndex = 6;
            // 
            // BirthDayFriendList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(346, 496);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelBirthDayFriend1);
            this.Controls.Add(this.panelBorder);
            this.Controls.Add(this.panelBirthDayFriendList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BirthDayFriendList";
            this.Text = "BirthDayFriendList";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.panelBorder.ResumeLayout(false);
            this.panelBirthDayFriend1.ResumeLayout(false);
            this.panelBirthDayFriend1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBoxBirthDayFriendPoto1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Panel panelBorder;
        private System.Windows.Forms.Panel panelBirthDayFriend1;
        private System.Windows.Forms.Label labelBirthDayFriendName1;
        private RoundPictureBox roundPictureBoxBirthDayFriendPoto1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelBirthDayFriendList;
    }
}