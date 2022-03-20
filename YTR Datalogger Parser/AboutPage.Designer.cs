namespace YTR_Datalogger_Parser
{
    partial class AboutPage
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
            this.picYTRLogo = new System.Windows.Forms.PictureBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lnkLabelGithub = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picYTRLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picYTRLogo
            // 
            this.picYTRLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.picYTRLogo.Image = global::YTR_Datalogger_Parser.Properties.Resources.racing_logo;
            this.picYTRLogo.Location = new System.Drawing.Point(0, 0);
            this.picYTRLogo.Name = "picYTRLogo";
            this.picYTRLogo.Size = new System.Drawing.Size(214, 219);
            this.picYTRLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picYTRLogo.TabIndex = 0;
            this.picYTRLogo.TabStop = false;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(220, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(210, 180);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "by YTR08E VCU Team\r\n\r\nDatalogger analyzer.\r\nIt\'s opensource.\r\n\r\n#13";
            // 
            // lnkLabelGithub
            // 
            this.lnkLabelGithub.AutoSize = true;
            this.lnkLabelGithub.Location = new System.Drawing.Point(727, 150);
            this.lnkLabelGithub.Name = "lnkLabelGithub";
            this.lnkLabelGithub.Size = new System.Drawing.Size(75, 30);
            this.lnkLabelGithub.TabIndex = 2;
            this.lnkLabelGithub.TabStop = true;
            this.lnkLabelGithub.Text = "Github";
            this.lnkLabelGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLabelGithub_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(505, 180);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(297, 30);
            this.linkLabel2.TabIndex = 3;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Mail: candestan13@gmail.com";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // AboutPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 219);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.lnkLabelGithub);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.picYTRLogo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutPage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "About";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.picYTRLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picYTRLogo;
        private Label lblInfo;
        private LinkLabel lnkLabelGithub;
        private LinkLabel linkLabel2;
    }
}