
namespace DBUI
{
    partial class SignUp
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
            this.buttonSginUp = new System.Windows.Forms.Button();
            this.roundedPictureBoxAddPoto = new DBUI.UIControls.RoundedPictureBox();
            this.roundPictureBoxProfilePoto = new DBUI.RoundPictureBox();
            this.myTextBoxNickName = new DBUI.UIControls.MyTextBox();
            this.myTextBoxBirth = new DBUI.UIControls.MyTextBox();
            this.myTextBoxAdress = new DBUI.UIControls.MyTextBox();
            this.myTextBoxID = new DBUI.UIControls.MyTextBox();
            this.myTextBoxName = new DBUI.UIControls.MyTextBox();
            this.myTextBoxPW = new DBUI.UIControls.MyTextBox();
            this.pictureBoxMax2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxMini = new System.Windows.Forms.PictureBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.panelBorder = new System.Windows.Forms.Panel();
            this.pictureBoxMax = new System.Windows.Forms.PictureBox();
            this.buttonDuplicateCheck = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.roundedPictureBoxAddPoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBoxProfilePoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMax2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMax)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSginUp
            // 
            this.buttonSginUp.BackColor = System.Drawing.Color.White;
            this.buttonSginUp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonSginUp.FlatAppearance.BorderSize = 0;
            this.buttonSginUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSginUp.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonSginUp.Location = new System.Drawing.Point(35, 502);
            this.buttonSginUp.Name = "buttonSginUp";
            this.buttonSginUp.Size = new System.Drawing.Size(332, 32);
            this.buttonSginUp.TabIndex = 9;
            this.buttonSginUp.Text = "회원가입";
            this.buttonSginUp.UseVisualStyleBackColor = false;
            this.buttonSginUp.Click += new System.EventHandler(this.buttonSginUp_Click);
            // 
            // roundedPictureBoxAddPoto
            // 
            this.roundedPictureBoxAddPoto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.roundedPictureBoxAddPoto.Image = global::DBUI.Properties.Resources.plus;
            this.roundedPictureBoxAddPoto.Location = new System.Drawing.Point(224, 169);
            this.roundedPictureBoxAddPoto.Name = "roundedPictureBoxAddPoto";
            this.roundedPictureBoxAddPoto.Size = new System.Drawing.Size(36, 36);
            this.roundedPictureBoxAddPoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.roundedPictureBoxAddPoto.TabIndex = 16;
            this.roundedPictureBoxAddPoto.TabStop = false;
            this.roundedPictureBoxAddPoto.Click += new System.EventHandler(this.roundedPictureBoxAddPoto_Click);
            // 
            // roundPictureBoxProfilePoto
            // 
            this.roundPictureBoxProfilePoto.Image = global::DBUI.Properties.Resources.프로필;
            this.roundPictureBoxProfilePoto.Location = new System.Drawing.Point(164, 109);
            this.roundPictureBoxProfilePoto.Name = "roundPictureBoxProfilePoto";
            this.roundPictureBoxProfilePoto.Size = new System.Drawing.Size(87, 87);
            this.roundPictureBoxProfilePoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roundPictureBoxProfilePoto.TabIndex = 15;
            this.roundPictureBoxProfilePoto.TabStop = false;
            this.roundPictureBoxProfilePoto.Click += new System.EventHandler(this.roundPictureBoxProfilePoto_Click);
            // 
            // myTextBoxNickName
            // 
            this.myTextBoxNickName.BorderColor = System.Drawing.Color.LightGray;
            this.myTextBoxNickName.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.myTextBoxNickName.Location = new System.Drawing.Point(35, 446);
            this.myTextBoxNickName.Name = "myTextBoxNickName";
            this.myTextBoxNickName.Size = new System.Drawing.Size(332, 27);
            this.myTextBoxNickName.TabIndex = 14;
            this.myTextBoxNickName.Text = "별명";
            // 
            // myTextBoxBirth
            // 
            this.myTextBoxBirth.BorderColor = System.Drawing.Color.LightGray;
            this.myTextBoxBirth.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.myTextBoxBirth.Location = new System.Drawing.Point(35, 405);
            this.myTextBoxBirth.Name = "myTextBoxBirth";
            this.myTextBoxBirth.Size = new System.Drawing.Size(332, 27);
            this.myTextBoxBirth.TabIndex = 13;
            this.myTextBoxBirth.Text = "생일";
            // 
            // myTextBoxAdress
            // 
            this.myTextBoxAdress.BorderColor = System.Drawing.Color.LightGray;
            this.myTextBoxAdress.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.myTextBoxAdress.Location = new System.Drawing.Point(35, 364);
            this.myTextBoxAdress.Name = "myTextBoxAdress";
            this.myTextBoxAdress.Size = new System.Drawing.Size(332, 27);
            this.myTextBoxAdress.TabIndex = 12;
            this.myTextBoxAdress.Text = "주소";
            // 
            // myTextBoxID
            // 
            this.myTextBoxID.BorderColor = System.Drawing.Color.LightGray;
            this.myTextBoxID.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.myTextBoxID.Location = new System.Drawing.Point(35, 282);
            this.myTextBoxID.Name = "myTextBoxID";
            this.myTextBoxID.Size = new System.Drawing.Size(273, 27);
            this.myTextBoxID.TabIndex = 11;
            this.myTextBoxID.Text = "아이디";
            // 
            // myTextBoxName
            // 
            this.myTextBoxName.BorderColor = System.Drawing.Color.LightGray;
            this.myTextBoxName.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.myTextBoxName.Location = new System.Drawing.Point(35, 241);
            this.myTextBoxName.Name = "myTextBoxName";
            this.myTextBoxName.Size = new System.Drawing.Size(332, 27);
            this.myTextBoxName.TabIndex = 10;
            this.myTextBoxName.Text = "이름";
            // 
            // myTextBoxPW
            // 
            this.myTextBoxPW.BorderColor = System.Drawing.Color.LightGray;
            this.myTextBoxPW.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.myTextBoxPW.Location = new System.Drawing.Point(35, 322);
            this.myTextBoxPW.Name = "myTextBoxPW";
            this.myTextBoxPW.Size = new System.Drawing.Size(332, 27);
            this.myTextBoxPW.TabIndex = 8;
            this.myTextBoxPW.Text = "비밀번호";
            // 
            // pictureBoxMax2
            // 
            this.pictureBoxMax2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMax2.Image = global::DBUI.Properties.Resources.window_maximize_icon_181228;
            this.pictureBoxMax2.Location = new System.Drawing.Point(565, 5);
            this.pictureBoxMax2.Name = "pictureBoxMax2";
            this.pictureBoxMax2.Size = new System.Drawing.Size(15, 15);
            this.pictureBoxMax2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMax2.TabIndex = 18;
            this.pictureBoxMax2.TabStop = false;
            this.pictureBoxMax2.Visible = false;
            this.pictureBoxMax2.Click += new System.EventHandler(this.pictureBoxMax2_Click);
            // 
            // pictureBoxMini
            // 
            this.pictureBoxMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMini.Image = global::DBUI.Properties.Resources.window_minimize_icon_138009;
            this.pictureBoxMini.Location = new System.Drawing.Point(339, 5);
            this.pictureBoxMini.Name = "pictureBoxMini";
            this.pictureBoxMini.Size = new System.Drawing.Size(15, 15);
            this.pictureBoxMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMini.TabIndex = 20;
            this.pictureBoxMini.TabStop = false;
            this.pictureBoxMini.Click += new System.EventHandler(this.pictureBoxMini_Click);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxClose.Image = global::DBUI.Properties.Resources.window_close_icon_135015;
            this.pictureBoxClose.Location = new System.Drawing.Point(371, 5);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(15, 15);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 19;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // panelBorder
            // 
            this.panelBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panelBorder.Location = new System.Drawing.Point(0, 0);
            this.panelBorder.Name = "panelBorder";
            this.panelBorder.Size = new System.Drawing.Size(399, 60);
            this.panelBorder.TabIndex = 1;
            this.panelBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBorder_MouseDown);
            // 
            // pictureBoxMax
            // 
            this.pictureBoxMax.Image = global::DBUI.Properties.Resources.window_maximize_icon_137012;
            this.pictureBoxMax.Location = new System.Drawing.Point(355, 5);
            this.pictureBoxMax.Name = "pictureBoxMax";
            this.pictureBoxMax.Size = new System.Drawing.Size(15, 15);
            this.pictureBoxMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMax.TabIndex = 8;
            this.pictureBoxMax.TabStop = false;
            this.pictureBoxMax.Click += new System.EventHandler(this.pictureBoxMax_Click);
            // 
            // buttonDuplicateCheck
            // 
            this.buttonDuplicateCheck.BackColor = System.Drawing.Color.White;
            this.buttonDuplicateCheck.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonDuplicateCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDuplicateCheck.Location = new System.Drawing.Point(315, 282);
            this.buttonDuplicateCheck.Name = "buttonDuplicateCheck";
            this.buttonDuplicateCheck.Size = new System.Drawing.Size(52, 27);
            this.buttonDuplicateCheck.TabIndex = 21;
            this.buttonDuplicateCheck.Text = "확인";
            this.buttonDuplicateCheck.UseVisualStyleBackColor = false;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(400, 686);
            this.Controls.Add(this.buttonDuplicateCheck);
            this.Controls.Add(this.pictureBoxMax);
            this.Controls.Add(this.pictureBoxMax2);
            this.Controls.Add(this.pictureBoxMini);
            this.Controls.Add(this.pictureBoxClose);
            this.Controls.Add(this.roundedPictureBoxAddPoto);
            this.Controls.Add(this.roundPictureBoxProfilePoto);
            this.Controls.Add(this.myTextBoxNickName);
            this.Controls.Add(this.myTextBoxBirth);
            this.Controls.Add(this.myTextBoxAdress);
            this.Controls.Add(this.myTextBoxID);
            this.Controls.Add(this.myTextBoxName);
            this.Controls.Add(this.buttonSginUp);
            this.Controls.Add(this.myTextBoxPW);
            this.Controls.Add(this.panelBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp";
            this.Text = "signUp";
            ((System.ComponentModel.ISupportInitialize)(this.roundedPictureBoxAddPoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBoxProfilePoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMax2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private UIControls.MyTextBox myTextBoxPW;
        private System.Windows.Forms.Button buttonSginUp;
        private UIControls.MyTextBox myTextBoxName;
        private UIControls.MyTextBox myTextBoxID;
        private UIControls.MyTextBox myTextBoxAdress;
        private UIControls.MyTextBox myTextBoxBirth;
        private UIControls.MyTextBox myTextBoxNickName;
        private RoundPictureBox roundPictureBoxProfilePoto;
        private UIControls.RoundedPictureBox roundedPictureBoxAddPoto;
        private System.Windows.Forms.PictureBox pictureBoxMax2;
        private System.Windows.Forms.PictureBox pictureBoxMini;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Panel panelBorder;
        private System.Windows.Forms.PictureBox pictureBoxMax;
        private System.Windows.Forms.Button buttonDuplicateCheck;
    }
}