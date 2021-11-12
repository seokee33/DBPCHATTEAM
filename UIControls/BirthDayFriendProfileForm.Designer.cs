
namespace DBUI.UIControls
{
    partial class BirthDayFriendProfileForm
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
            this.panelBirthDayFriend = new System.Windows.Forms.Panel();
            this.labelBirthDayFriendName = new System.Windows.Forms.Label();
            this.roundPictureBoxBirthDayFriendPoto = new DBUI.RoundPictureBox();
            this.panelBirthDayFriend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBoxBirthDayFriendPoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBirthDayFriend
            // 
            this.panelBirthDayFriend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panelBirthDayFriend.Controls.Add(this.labelBirthDayFriendName);
            this.panelBirthDayFriend.Controls.Add(this.roundPictureBoxBirthDayFriendPoto);
            this.panelBirthDayFriend.Location = new System.Drawing.Point(0, 0);
            this.panelBirthDayFriend.Name = "panelBirthDayFriend";
            this.panelBirthDayFriend.Size = new System.Drawing.Size(320, 73);
            this.panelBirthDayFriend.TabIndex = 8;
            this.panelBirthDayFriend.Click += new System.EventHandler(this.BirthDayFriendProfile_Click);
            // 
            // labelBirthDayFriendName
            // 
            this.labelBirthDayFriendName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.labelBirthDayFriendName.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelBirthDayFriendName.Location = new System.Drawing.Point(97, 31);
            this.labelBirthDayFriendName.Name = "labelBirthDayFriendName";
            this.labelBirthDayFriendName.Size = new System.Drawing.Size(205, 15);
            this.labelBirthDayFriendName.TabIndex = 37;
            this.labelBirthDayFriendName.Text = "이름";
            this.labelBirthDayFriendName.Click += new System.EventHandler(this.BirthDayFriendProfile_Click);
            // 
            // roundPictureBoxBirthDayFriendPoto
            // 
            this.roundPictureBoxBirthDayFriendPoto.Image = global::DBUI.Properties.Resources.프로필;
            this.roundPictureBoxBirthDayFriendPoto.Location = new System.Drawing.Point(16, 9);
            this.roundPictureBoxBirthDayFriendPoto.Name = "roundPictureBoxBirthDayFriendPoto";
            this.roundPictureBoxBirthDayFriendPoto.Size = new System.Drawing.Size(55, 55);
            this.roundPictureBoxBirthDayFriendPoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roundPictureBoxBirthDayFriendPoto.TabIndex = 38;
            this.roundPictureBoxBirthDayFriendPoto.TabStop = false;
            this.roundPictureBoxBirthDayFriendPoto.Click += new System.EventHandler(this.BirthDayFriendProfile_Click);
            // 
            // BirthDayFriendProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.panelBirthDayFriend);
            this.Name = "BirthDayFriendProfileForm";
            this.Size = new System.Drawing.Size(320, 73);
            this.panelBirthDayFriend.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBoxBirthDayFriendPoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelBirthDayFriend;
        private System.Windows.Forms.Label labelBirthDayFriendName;
        private RoundPictureBox roundPictureBoxBirthDayFriendPoto;
    }
}
