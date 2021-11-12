
namespace DBUI
{
    partial class NewChat
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.pictureBoxMax = new System.Windows.Forms.PictureBox();
            this.pictureBoxMini = new System.Windows.Forms.PictureBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.pictureBoxMax2 = new System.Windows.Forms.PictureBox();
            this.panelFriendList = new System.Windows.Forms.Panel();
            this.panelBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMax2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBorder
            // 
            this.panelBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panelBorder.Controls.Add(this.pictureBoxMax);
            this.panelBorder.Controls.Add(this.pictureBoxMini);
            this.panelBorder.Controls.Add(this.pictureBoxClose);
            this.panelBorder.Controls.Add(this.pictureBoxMax2);
            this.panelBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBorder.Location = new System.Drawing.Point(0, 0);
            this.panelBorder.Name = "panelBorder";
            this.panelBorder.Size = new System.Drawing.Size(406, 60);
            this.panelBorder.TabIndex = 9;
            this.panelBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBorder_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "대화상대 선택";
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConfirm.BackColor = System.Drawing.Color.White;
            this.buttonConfirm.FlatAppearance.BorderSize = 0;
            this.buttonConfirm.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirm.Location = new System.Drawing.Point(29, 619);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(332, 32);
            this.buttonConfirm.TabIndex = 15;
            this.buttonConfirm.Text = "확인";
            this.buttonConfirm.UseVisualStyleBackColor = false;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // pictureBoxMax
            // 
            this.pictureBoxMax.Image = global::DBUI.Properties.Resources.window_maximize_icon_137012;
            this.pictureBoxMax.Location = new System.Drawing.Point(370, 6);
            this.pictureBoxMax.Name = "pictureBoxMax";
            this.pictureBoxMax.Size = new System.Drawing.Size(15, 15);
            this.pictureBoxMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMax.TabIndex = 8;
            this.pictureBoxMax.TabStop = false;
            this.pictureBoxMax.Click += new System.EventHandler(this.pictureBoxMax_Click);
            // 
            // pictureBoxMini
            // 
            this.pictureBoxMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMini.Image = global::DBUI.Properties.Resources.window_minimize_icon_138009;
            this.pictureBoxMini.Location = new System.Drawing.Point(353, 6);
            this.pictureBoxMini.Name = "pictureBoxMini";
            this.pictureBoxMini.Size = new System.Drawing.Size(15, 15);
            this.pictureBoxMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMini.TabIndex = 5;
            this.pictureBoxMini.TabStop = false;
            this.pictureBoxMini.Click += new System.EventHandler(this.pictureBoxMini_Click);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxClose.Image = global::DBUI.Properties.Resources.window_close_icon_135015;
            this.pictureBoxClose.Location = new System.Drawing.Point(387, 6);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(15, 15);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 6;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // pictureBoxMax2
            // 
            this.pictureBoxMax2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMax2.Image = global::DBUI.Properties.Resources.window_maximize_icon_181228;
            this.pictureBoxMax2.Location = new System.Drawing.Point(370, 6);
            this.pictureBoxMax2.Name = "pictureBoxMax2";
            this.pictureBoxMax2.Size = new System.Drawing.Size(15, 15);
            this.pictureBoxMax2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMax2.TabIndex = 7;
            this.pictureBoxMax2.TabStop = false;
            this.pictureBoxMax2.Visible = false;
            this.pictureBoxMax2.Click += new System.EventHandler(this.pictureBoxMax2_Click);
            // 
            // panelFriendList
            // 
            this.panelFriendList.Location = new System.Drawing.Point(0, 88);
            this.panelFriendList.Name = "panelFriendList";
            this.panelFriendList.Size = new System.Drawing.Size(406, 525);
            this.panelFriendList.TabIndex = 16;
            // 
            // NewChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(406, 686);
            this.Controls.Add(this.panelFriendList);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewChat";
            this.Text = "NewChat";
            this.panelBorder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMax2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMax2;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.PictureBox pictureBoxMini;
        private System.Windows.Forms.PictureBox pictureBoxMax;
        private System.Windows.Forms.Panel panelBorder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Panel panelFriendList;
    }
}