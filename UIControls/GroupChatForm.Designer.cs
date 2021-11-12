
namespace DBUI.UIControls
{
    partial class GroupChatForm
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
            this.labelName = new System.Windows.Forms.Label();
            this.roundPictureBoxProfile = new DBUI.RoundPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelName.Location = new System.Drawing.Point(91, 29);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(31, 15);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "이름";
            // 
            // roundPictureBoxProfile
            // 
            this.roundPictureBoxProfile.Image = global::DBUI.Properties.Resources.프로필;
            this.roundPictureBoxProfile.Location = new System.Drawing.Point(10, 8);
            this.roundPictureBoxProfile.Name = "roundPictureBoxProfile";
            this.roundPictureBoxProfile.Size = new System.Drawing.Size(56, 51);
            this.roundPictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roundPictureBoxProfile.TabIndex = 0;
            this.roundPictureBoxProfile.TabStop = false;
            // 
            // GroupChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.roundPictureBoxProfile);
            this.Name = "GroupChatForm";
            this.Size = new System.Drawing.Size(177, 67);
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBoxProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundPictureBox roundPictureBoxProfile;
        private System.Windows.Forms.Label labelName;
    }
}
