
namespace DBUI.UIControls
{
    partial class Chatmsg
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
            this.tb_msg = new System.Windows.Forms.TextBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_msg
            // 
            this.tb_msg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tb_msg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_msg.Font = new System.Drawing.Font("굴림", 15F);
            this.tb_msg.Location = new System.Drawing.Point(13, 25);
            this.tb_msg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_msg.Multiline = true;
            this.tb_msg.Name = "tb_msg";
            this.tb_msg.ReadOnly = true;
            this.tb_msg.Size = new System.Drawing.Size(251, 37);
            this.tb_msg.TabIndex = 2;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_name.Location = new System.Drawing.Point(10, 1);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(63, 20);
            this.lb_name.TabIndex = 4;
            this.lb_name.Text = "label1";
            // 
            // Chatmsg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.tb_msg);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Chatmsg";
            this.Size = new System.Drawing.Size(399, 80);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_msg;
        private System.Windows.Forms.Label lb_name;
    }
}
