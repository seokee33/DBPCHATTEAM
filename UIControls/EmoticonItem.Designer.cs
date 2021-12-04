
namespace DBUI.UIControls
{
    partial class Emoticonitem
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
            this.pb_emoticon = new System.Windows.Forms.PictureBox();
            this.emoticon_Seq = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_emoticon)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_emoticon
            // 
            this.pb_emoticon.BackColor = System.Drawing.Color.Transparent;
            this.pb_emoticon.Location = new System.Drawing.Point(17, 32);
            this.pb_emoticon.Margin = new System.Windows.Forms.Padding(2);
            this.pb_emoticon.Name = "pb_emoticon";
            this.pb_emoticon.Size = new System.Drawing.Size(116, 109);
            this.pb_emoticon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_emoticon.TabIndex = 5;
            this.pb_emoticon.TabStop = false;
            // 
            // emoticon_Seq
            // 
            this.emoticon_Seq.AutoSize = true;
            this.emoticon_Seq.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.emoticon_Seq.Location = new System.Drawing.Point(62, 10);
            this.emoticon_Seq.Name = "emoticon_Seq";
            this.emoticon_Seq.Size = new System.Drawing.Size(21, 20);
            this.emoticon_Seq.TabIndex = 4;
            this.emoticon_Seq.Text = "1";
            // 
            // Emoticonitems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pb_emoticon);
            this.Controls.Add(this.emoticon_Seq);
            this.Name = "Emoticonitems";
            ((System.ComponentModel.ISupportInitialize)(this.pb_emoticon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_emoticon;
        private System.Windows.Forms.Label emoticon_Seq;
    }
}
