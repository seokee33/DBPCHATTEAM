
namespace DBUI.UIControls
{
    partial class chatSendImage
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
            this.lb_name = new System.Windows.Forms.Label();
            this.pb_Emoticon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Emoticon)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_name.Location = new System.Drawing.Point(338, 13);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(63, 20);
            this.lb_name.TabIndex = 5;
            this.lb_name.Text = "label1";
            // 
            // pb_Emoticon
            // 
            this.pb_Emoticon.BackColor = System.Drawing.Color.Transparent;
            this.pb_Emoticon.Location = new System.Drawing.Point(290, 39);
            this.pb_Emoticon.Margin = new System.Windows.Forms.Padding(2);
            this.pb_Emoticon.Name = "pb_Emoticon";
            this.pb_Emoticon.Size = new System.Drawing.Size(116, 109);
            this.pb_Emoticon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Emoticon.TabIndex = 4;
            this.pb_Emoticon.TabStop = false;
            // 
            // chatSendImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.pb_Emoticon);
            this.Name = "chatSendImage";
            this.Size = new System.Drawing.Size(408, 150);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Emoticon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.PictureBox pb_Emoticon;
    }
}
