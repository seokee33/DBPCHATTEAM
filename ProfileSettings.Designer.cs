﻿
namespace DBUI
{
    partial class ProfileSettings
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
            this.buttonChangeProfilePoto = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.myTextBoxNickName = new DBUI.UIControls.MyTextBox();
            this.myTextBoxBirthDay = new DBUI.UIControls.MyTextBox();
            this.myTextBoxAdress = new DBUI.UIControls.MyTextBox();
            this.myTextBoxPW = new DBUI.UIControls.MyTextBox();
            this.myTextBoxName = new DBUI.UIControls.MyTextBox();
            this.roundPictureBoxProfilePoto = new DBUI.RoundPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBoxProfilePoto)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonChangeProfilePoto
            // 
            this.buttonChangeProfilePoto.BackColor = System.Drawing.Color.White;
            this.buttonChangeProfilePoto.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonChangeProfilePoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeProfilePoto.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonChangeProfilePoto.Location = new System.Drawing.Point(99, 194);
            this.buttonChangeProfilePoto.Name = "buttonChangeProfilePoto";
            this.buttonChangeProfilePoto.Size = new System.Drawing.Size(223, 32);
            this.buttonChangeProfilePoto.TabIndex = 20;
            this.buttonChangeProfilePoto.Text = "프로필 사진 변경하기";
            this.buttonChangeProfilePoto.UseVisualStyleBackColor = false;
            this.buttonChangeProfilePoto.Click += new System.EventHandler(this.buttonChangeProfilePoto_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(27, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(358, 32);
            this.button1.TabIndex = 26;
            this.button1.Text = "확인";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // myTextBoxNickName
            // 
            this.myTextBoxNickName.BorderColor = System.Drawing.Color.LightGray;
            this.myTextBoxNickName.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.myTextBoxNickName.Location = new System.Drawing.Point(98, 437);
            this.myTextBoxNickName.Name = "myTextBoxNickName";
            this.myTextBoxNickName.Size = new System.Drawing.Size(287, 27);
            this.myTextBoxNickName.TabIndex = 25;
            // 
            // myTextBoxBirthDay
            // 
            this.myTextBoxBirthDay.BorderColor = System.Drawing.Color.LightGray;
            this.myTextBoxBirthDay.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.myTextBoxBirthDay.Location = new System.Drawing.Point(98, 389);
            this.myTextBoxBirthDay.Name = "myTextBoxBirthDay";
            this.myTextBoxBirthDay.Size = new System.Drawing.Size(287, 27);
            this.myTextBoxBirthDay.TabIndex = 24;
            // 
            // myTextBoxAdress
            // 
            this.myTextBoxAdress.BorderColor = System.Drawing.Color.LightGray;
            this.myTextBoxAdress.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.myTextBoxAdress.Location = new System.Drawing.Point(98, 342);
            this.myTextBoxAdress.Name = "myTextBoxAdress";
            this.myTextBoxAdress.Size = new System.Drawing.Size(287, 27);
            this.myTextBoxAdress.TabIndex = 23;
            // 
            // myTextBoxPW
            // 
            this.myTextBoxPW.BorderColor = System.Drawing.Color.LightGray;
            this.myTextBoxPW.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.myTextBoxPW.Location = new System.Drawing.Point(98, 295);
            this.myTextBoxPW.Name = "myTextBoxPW";
            this.myTextBoxPW.Size = new System.Drawing.Size(287, 27);
            this.myTextBoxPW.TabIndex = 22;
            // 
            // myTextBoxName
            // 
            this.myTextBoxName.BorderColor = System.Drawing.Color.LightGray;
            this.myTextBoxName.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.myTextBoxName.Location = new System.Drawing.Point(98, 247);
            this.myTextBoxName.Name = "myTextBoxName";
            this.myTextBoxName.Size = new System.Drawing.Size(287, 27);
            this.myTextBoxName.TabIndex = 21;
            // 
            // roundPictureBoxProfilePoto
            // 
            this.roundPictureBoxProfilePoto.Image = global::DBUI.Properties.Resources.프로필;
            this.roundPictureBoxProfilePoto.Location = new System.Drawing.Point(159, 75);
            this.roundPictureBoxProfilePoto.Name = "roundPictureBoxProfilePoto";
            this.roundPictureBoxProfilePoto.Size = new System.Drawing.Size(95, 95);
            this.roundPictureBoxProfilePoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roundPictureBoxProfilePoto.TabIndex = 19;
            this.roundPictureBoxProfilePoto.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 11.25F);
            this.label1.Location = new System.Drawing.Point(33, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 11.25F);
            this.label2.Location = new System.Drawing.Point(36, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "PW";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 11.25F);
            this.label3.Location = new System.Drawing.Point(33, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "주소";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 11.25F);
            this.label4.Location = new System.Drawing.Point(33, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "생일";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 11.25F);
            this.label5.Location = new System.Drawing.Point(33, 440);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "별명";
            // 
            // ProfileSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(415, 627);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.myTextBoxNickName);
            this.Controls.Add(this.myTextBoxBirthDay);
            this.Controls.Add(this.myTextBoxAdress);
            this.Controls.Add(this.myTextBoxPW);
            this.Controls.Add(this.myTextBoxName);
            this.Controls.Add(this.buttonChangeProfilePoto);
            this.Controls.Add(this.roundPictureBoxProfilePoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProfileSettings";
            this.Text = "ProfileSettings";
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBoxProfilePoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RoundPictureBox roundPictureBoxProfilePoto;
        private System.Windows.Forms.Button buttonChangeProfilePoto;
        private UIControls.MyTextBox myTextBoxName;
        private UIControls.MyTextBox myTextBoxPW;
        private UIControls.MyTextBox myTextBoxAdress;
        private UIControls.MyTextBox myTextBoxBirthDay;
        private UIControls.MyTextBox myTextBoxNickName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}