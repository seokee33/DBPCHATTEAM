
namespace DBUI
{
    partial class AddFriendID
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
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddFriendID = new System.Windows.Forms.Button();
            this.myTextBoxFriendID = new DBUI.UIControls.MyTextBox();
            this.panelBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBorder
            // 
            this.panelBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panelBorder.Controls.Add(this.pictureBoxClose);
            this.panelBorder.Location = new System.Drawing.Point(0, -1);
            this.panelBorder.Name = "panelBorder";
            this.panelBorder.Size = new System.Drawing.Size(366, 60);
            this.panelBorder.TabIndex = 1;
            this.panelBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBorder_MouseDown);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxClose.Image = global::DBUI.Properties.Resources.window_close_icon_135015;
            this.pictureBoxClose.Location = new System.Drawing.Point(344, 3);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(15, 15);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 5;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(25, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // buttonAddFriendID
            // 
            this.buttonAddFriendID.BackColor = System.Drawing.Color.White;
            this.buttonAddFriendID.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonAddFriendID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddFriendID.Location = new System.Drawing.Point(33, 130);
            this.buttonAddFriendID.Name = "buttonAddFriendID";
            this.buttonAddFriendID.Size = new System.Drawing.Size(297, 29);
            this.buttonAddFriendID.TabIndex = 4;
            this.buttonAddFriendID.Text = "친구 추가";
            this.buttonAddFriendID.UseVisualStyleBackColor = false;
            this.buttonAddFriendID.Click += new System.EventHandler(this.buttonAddFriendID_Click);
            // 
            // myTextBoxFriendID
            // 
            this.myTextBoxFriendID.BorderColor = System.Drawing.Color.LightGray;
            this.myTextBoxFriendID.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.myTextBoxFriendID.Location = new System.Drawing.Point(33, 97);
            this.myTextBoxFriendID.Name = "myTextBoxFriendID";
            this.myTextBoxFriendID.Size = new System.Drawing.Size(297, 27);
            this.myTextBoxFriendID.TabIndex = 8;
            // 
            // AddFriendID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(364, 210);
            this.Controls.Add(this.myTextBoxFriendID);
            this.Controls.Add(this.buttonAddFriendID);
            this.Controls.Add(this.panelBorder);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddFriendID";
            this.Text = "AddFriendID";
            this.panelBorder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBorder;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddFriendID;
        private UIControls.MyTextBox myTextBoxFriendID;
    }
}