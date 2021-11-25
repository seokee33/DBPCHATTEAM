
namespace DBUI
{
    partial class Login
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLogin = new System.Windows.Forms.Button();
            this.checkBoxAutoLogin = new System.Windows.Forms.CheckBox();
            this.labelSignUp = new System.Windows.Forms.Label();
            this.myTextBoxID = new DBUI.UIControls.MyTextBox();
            this.myTextBoxPW = new DBUI.UIControls.MyTextBox();
            this.panelBorder = new System.Windows.Forms.Panel();
            this.pictureBoxMini = new System.Windows.Forms.PictureBox();
            this.pictureBoxMax2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxMax = new System.Windows.Forms.PictureBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMax2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.White;
            this.buttonLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonLogin.Location = new System.Drawing.Point(34, 376);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(332, 32);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "로그인";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // checkBoxAutoLogin
            // 
            this.checkBoxAutoLogin.AutoSize = true;
            this.checkBoxAutoLogin.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBoxAutoLogin.Location = new System.Drawing.Point(34, 339);
            this.checkBoxAutoLogin.Name = "checkBoxAutoLogin";
            this.checkBoxAutoLogin.Size = new System.Drawing.Size(118, 19);
            this.checkBoxAutoLogin.TabIndex = 3;
            this.checkBoxAutoLogin.Text = "로그인 상태 유지";
            this.checkBoxAutoLogin.UseVisualStyleBackColor = true;
            this.checkBoxAutoLogin.CheckedChanged += new System.EventHandler(this.checkBoxAutoLogin_CheckedChanged);
            // 
            // labelSignUp
            // 
            this.labelSignUp.AutoSize = true;
            this.labelSignUp.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelSignUp.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelSignUp.Location = new System.Drawing.Point(173, 423);
            this.labelSignUp.Name = "labelSignUp";
            this.labelSignUp.Size = new System.Drawing.Size(55, 15);
            this.labelSignUp.TabIndex = 4;
            this.labelSignUp.Text = "회원가입";
            this.labelSignUp.Click += new System.EventHandler(this.labelSignUp_Click);
            // 
            // myTextBoxID
            // 
            this.myTextBoxID.BorderColor = System.Drawing.Color.LightGray;
            this.myTextBoxID.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.myTextBoxID.Location = new System.Drawing.Point(34, 257);
            this.myTextBoxID.Name = "myTextBoxID";
            this.myTextBoxID.Size = new System.Drawing.Size(332, 27);
            this.myTextBoxID.TabIndex = 7;
            this.myTextBoxID.Text = "아이디";
            // 
            // myTextBoxPW
            // 
            this.myTextBoxPW.BorderColor = System.Drawing.Color.LightGray;
            this.myTextBoxPW.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.myTextBoxPW.Location = new System.Drawing.Point(34, 298);
            this.myTextBoxPW.Name = "myTextBoxPW";
            this.myTextBoxPW.Size = new System.Drawing.Size(332, 27);
            this.myTextBoxPW.TabIndex = 6;
            this.myTextBoxPW.Text = "비밀번호";
            // 
            // panelBorder
            // 
            this.panelBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panelBorder.Location = new System.Drawing.Point(0, 0);
            this.panelBorder.Name = "panelBorder";
            this.panelBorder.Size = new System.Drawing.Size(410, 60);
            this.panelBorder.TabIndex = 1;
            this.panelBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBorder_MouseDown);
            // 
            // pictureBoxMini
            // 
            this.pictureBoxMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMini.Image = global::DBUI.Properties.Resources.window_minimize_icon_138009;
            this.pictureBoxMini.Location = new System.Drawing.Point(339, 5);
            this.pictureBoxMini.Name = "pictureBoxMini";
            this.pictureBoxMini.Size = new System.Drawing.Size(15, 15);
            this.pictureBoxMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMini.TabIndex = 10;
            this.pictureBoxMini.TabStop = false;
            this.pictureBoxMini.Click += new System.EventHandler(this.pictureBoxMini_Click);
            // 
            // pictureBoxMax2
            // 
            this.pictureBoxMax2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMax2.Image = global::DBUI.Properties.Resources.window_maximize_icon_181228;
            this.pictureBoxMax2.Location = new System.Drawing.Point(355, 5);
            this.pictureBoxMax2.Name = "pictureBoxMax2";
            this.pictureBoxMax2.Size = new System.Drawing.Size(15, 15);
            this.pictureBoxMax2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMax2.TabIndex = 4;
            this.pictureBoxMax2.TabStop = false;
            this.pictureBoxMax2.Visible = false;
            this.pictureBoxMax2.Click += new System.EventHandler(this.pictureBoxMax2_Click);
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
            // pictureBoxClose
            // 
            this.pictureBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxClose.Image = global::DBUI.Properties.Resources.window_close_icon_135015;
            this.pictureBoxClose.Location = new System.Drawing.Point(371, 5);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(15, 15);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 9;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(400, 686);
            this.Controls.Add(this.myTextBoxID);
            this.Controls.Add(this.pictureBoxMax2);
            this.Controls.Add(this.pictureBoxMax);
            this.Controls.Add(this.pictureBoxMini);
            this.Controls.Add(this.pictureBoxClose);
            this.Controls.Add(this.panelBorder);
            this.Controls.Add(this.myTextBoxPW);
            this.Controls.Add(this.labelSignUp);
            this.Controls.Add(this.checkBoxAutoLogin);
            this.Controls.Add(this.buttonLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMax2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.CheckBox checkBoxAutoLogin;
        private System.Windows.Forms.Label labelSignUp;
        private UIControls.MyTextBox myTextBoxPW;
        private UIControls.MyTextBox myTextBoxID;
        private System.Windows.Forms.Panel panelBorder;
        private System.Windows.Forms.PictureBox pictureBoxMax;
        private System.Windows.Forms.PictureBox pictureBoxMini;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.PictureBox pictureBoxMax2;
    }
}

