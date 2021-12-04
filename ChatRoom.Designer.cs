
namespace DBUI
{
    partial class ChatRoom
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
            this.panelBorder = new System.Windows.Forms.Panel();
            this.pictureBoxMax = new System.Windows.Forms.PictureBox();
            this.pictureBoxMini = new System.Windows.Forms.PictureBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.pictureBoxMax2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBoxNewChat = new System.Windows.Forms.PictureBox();
            this.buttonMessageSend = new System.Windows.Forms.Button();
            this.textBoxMessageSend = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelFDName = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chat_Panel = new System.Windows.Forms.Panel();
            this.panelBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMax2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNewChat)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBorder
            // 
            this.panelBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panelBorder.Controls.Add(this.pictureBoxMax);
            this.panelBorder.Controls.Add(this.pictureBoxMini);
            this.panelBorder.Controls.Add(this.pictureBoxClose);
            this.panelBorder.Controls.Add(this.pictureBoxMax2);
            this.panelBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBorder.Location = new System.Drawing.Point(0, 0);
            this.panelBorder.Name = "panelBorder";
            this.panelBorder.Size = new System.Drawing.Size(400, 32);
            this.panelBorder.TabIndex = 10;
            this.panelBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBorder_MouseDown);
            // 
            // pictureBoxMax
            // 
            this.pictureBoxMax.Image = global::DBUI.Properties.Resources.window_maximize_icon_137012;
            this.pictureBoxMax.Location = new System.Drawing.Point(365, 6);
            this.pictureBoxMax.Name = "pictureBoxMax";
            this.pictureBoxMax.Size = new System.Drawing.Size(15, 15);
            this.pictureBoxMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMax.TabIndex = 8;
            this.pictureBoxMax.TabStop = false;
            this.pictureBoxMax.Click += new System.EventHandler(this.pictureBoxMax_Click);
            // 
            // pictureBoxMini
            // 
            this.pictureBoxMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMini.Image = global::DBUI.Properties.Resources.window_minimize_icon_138009;
            this.pictureBoxMini.Location = new System.Drawing.Point(349, 6);
            this.pictureBoxMini.Name = "pictureBoxMini";
            this.pictureBoxMini.Size = new System.Drawing.Size(15, 15);
            this.pictureBoxMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMini.TabIndex = 5;
            this.pictureBoxMini.TabStop = false;
            this.pictureBoxMini.Click += new System.EventHandler(this.pictureBoxMini_Click);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxClose.Image = global::DBUI.Properties.Resources.window_close_icon_135015;
            this.pictureBoxClose.Location = new System.Drawing.Point(382, 6);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(15, 15);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 6;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // pictureBoxMax2
            // 
            this.pictureBoxMax2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMax2.Image = global::DBUI.Properties.Resources.window_maximize_icon_181228;
            this.pictureBoxMax2.Location = new System.Drawing.Point(365, 6);
            this.pictureBoxMax2.Name = "pictureBoxMax2";
            this.pictureBoxMax2.Size = new System.Drawing.Size(15, 15);
            this.pictureBoxMax2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMax2.TabIndex = 7;
            this.pictureBoxMax2.TabStop = false;
            this.pictureBoxMax2.Visible = false;
            this.pictureBoxMax2.Click += new System.EventHandler(this.pictureBoxMax2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel3.Controls.Add(this.pictureBoxNewChat);
            this.panel3.Controls.Add(this.buttonMessageSend);
            this.panel3.Controls.Add(this.textBoxMessageSend);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 591);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 95);
            this.panel3.TabIndex = 13;
            // 
            // pictureBoxNewChat
            // 
            this.pictureBoxNewChat.Image = global::DBUI.Properties.Resources.free_icon_smiling_emoticon_square_face_40157;
            this.pictureBoxNewChat.Location = new System.Drawing.Point(355, 28);
            this.pictureBoxNewChat.Name = "pictureBoxNewChat";
            this.pictureBoxNewChat.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxNewChat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNewChat.TabIndex = 32;
            this.pictureBoxNewChat.TabStop = false;
            this.pictureBoxNewChat.Click += new System.EventHandler(this.pictureBoxNewChat_Click);
            // 
            // buttonMessageSend
            // 
            this.buttonMessageSend.BackColor = System.Drawing.Color.White;
            this.buttonMessageSend.FlatAppearance.BorderSize = 0;
            this.buttonMessageSend.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMessageSend.Location = new System.Drawing.Point(301, 15);
            this.buttonMessageSend.Name = "buttonMessageSend";
            this.buttonMessageSend.Size = new System.Drawing.Size(48, 64);
            this.buttonMessageSend.TabIndex = 2;
            this.buttonMessageSend.Text = "전송";
            this.buttonMessageSend.UseVisualStyleBackColor = false;
            this.buttonMessageSend.Click += new System.EventHandler(this.buttonMessageSend_Click);
            // 
            // textBoxMessageSend
            // 
            this.textBoxMessageSend.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMessageSend.Location = new System.Drawing.Point(12, 15);
            this.textBoxMessageSend.Multiline = true;
            this.textBoxMessageSend.Name = "textBoxMessageSend";
            this.textBoxMessageSend.Size = new System.Drawing.Size(283, 64);
            this.textBoxMessageSend.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel1.Controls.Add(this.labelFDName);
            this.panel1.Controls.Add(this.buttonSearch);
            this.panel1.Controls.Add(this.textBoxSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 121);
            this.panel1.TabIndex = 14;
            // 
            // labelFDName
            // 
            this.labelFDName.AutoSize = true;
            this.labelFDName.Font = new System.Drawing.Font("맑은 고딕", 30F);
            this.labelFDName.Location = new System.Drawing.Point(12, 12);
            this.labelFDName.Name = "labelFDName";
            this.labelFDName.Size = new System.Drawing.Size(103, 54);
            this.labelFDName.TabIndex = 4;
            this.labelFDName.Text = "이름";
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.White;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(332, 75);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(48, 28);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "검색";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(21, 80);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(291, 23);
            this.textBoxSearch.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 1);
            this.panel2.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 590);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(400, 1);
            this.panel4.TabIndex = 18;
            // 
            // chat_Panel
            // 
            this.chat_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chat_Panel.Location = new System.Drawing.Point(0, 154);
            this.chat_Panel.Name = "chat_Panel";
            this.chat_Panel.Size = new System.Drawing.Size(400, 436);
            this.chat_Panel.TabIndex = 19;
            // 
            // ChatRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 686);
            this.Controls.Add(this.chat_Panel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChatRoom";
            this.Text = "ChatRoom";
            this.panelBorder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMax2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNewChat)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBorder;
        private System.Windows.Forms.PictureBox pictureBoxMax;
        private System.Windows.Forms.PictureBox pictureBoxMini;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.PictureBox pictureBoxMax2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonMessageSend;
        private System.Windows.Forms.TextBox textBoxMessageSend;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelFDName;
        private RoundPictureBox roundPictureBoxFDpoto;
        private System.Windows.Forms.PictureBox pictureBoxNewChat;
        private System.Windows.Forms.Panel chat_Panel;
    }
}