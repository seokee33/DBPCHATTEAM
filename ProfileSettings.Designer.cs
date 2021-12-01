
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
            this.button1.Location = new System.Drawing.Point(44, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(332, 32);
            this.button1.TabIndex = 26;
            this.button1.Text = "확인";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // myTextBoxNickName
            // 
            this.myTextBoxNickName.BorderColor = System.Drawing.Color.LightGray;
            this.myTextBoxNickName.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.myTextBoxNickName.Location = new System.Drawing.Point(44, 437);
            this.myTextBoxNickName.Name = "myTextBoxNickName";
            this.myTextBoxNickName.Size = new System.Drawing.Size(332, 27);
            this.myTextBoxNickName.TabIndex = 25;
            this.myTextBoxNickName.Text = "별명";
            // 
            // myTextBoxBirthDay
            // 
            this.myTextBoxBirthDay.BorderColor = System.Drawing.Color.LightGray;
            this.myTextBoxBirthDay.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.myTextBoxBirthDay.Location = new System.Drawing.Point(44, 389);
            this.myTextBoxBirthDay.Name = "myTextBoxBirthDay";
            this.myTextBoxBirthDay.Size = new System.Drawing.Size(332, 27);
            this.myTextBoxBirthDay.TabIndex = 24;
            this.myTextBoxBirthDay.Text = "생일";
            // 
            // myTextBoxAdress
            // 
            this.myTextBoxAdress.BorderColor = System.Drawing.Color.LightGray;
            this.myTextBoxAdress.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.myTextBoxAdress.Location = new System.Drawing.Point(44, 342);
            this.myTextBoxAdress.Name = "myTextBoxAdress";
            this.myTextBoxAdress.Size = new System.Drawing.Size(332, 27);
            this.myTextBoxAdress.TabIndex = 23;
            this.myTextBoxAdress.Text = "주소";
            // 
            // myTextBoxPW
            // 
            this.myTextBoxPW.BorderColor = System.Drawing.Color.LightGray;
            this.myTextBoxPW.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.myTextBoxPW.Location = new System.Drawing.Point(44, 295);
            this.myTextBoxPW.Name = "myTextBoxPW";
            this.myTextBoxPW.Size = new System.Drawing.Size(332, 27);
            this.myTextBoxPW.TabIndex = 22;
            this.myTextBoxPW.Text = "비밀번호";
            // 
            // myTextBoxName
            // 
            this.myTextBoxName.BorderColor = System.Drawing.Color.LightGray;
            this.myTextBoxName.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.myTextBoxName.Location = new System.Drawing.Point(44, 247);
            this.myTextBoxName.Name = "myTextBoxName";
            this.myTextBoxName.Size = new System.Drawing.Size(332, 27);
            this.myTextBoxName.TabIndex = 21;
            this.myTextBoxName.Text = "이름";
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
            // ProfileSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(415, 627);
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
    }
}