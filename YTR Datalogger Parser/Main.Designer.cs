namespace YTR_Datalogger_Parser
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAbout = new WindowsUI.WinButton();
            this.pnlDragDrop = new WindowsUI.WinPanel();
            this.picCSV = new System.Windows.Forms.PictureBox();
            this.pnlTop.SuspendLayout();
            this.pnlDragDrop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCSV)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnMinimaze);
            this.pnlTop.Controls.Add(this.btnMaximize);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Size = new System.Drawing.Size(800, 44);
            this.pnlTop.Controls.SetChildIndex(this.btnClose, 0);
            this.pnlTop.Controls.SetChildIndex(this.btnMaximize, 0);
            this.pnlTop.Controls.SetChildIndex(this.btnMinimaze, 0);
            // 
            // btnMinimaze
            // 
            this.btnMinimaze.BackColor = System.Drawing.Color.Black;
            this.btnMinimaze.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimaze.FlatAppearance.BorderSize = 0;
            this.btnMinimaze.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnMinimaze.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnMinimaze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimaze.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMinimaze.ForeColor = System.Drawing.Color.White;
            this.btnMinimaze.Location = new System.Drawing.Point(696, 0);
            this.btnMinimaze.Size = new System.Drawing.Size(52, 44);
            this.btnMinimaze.Text = "─";
            this.btnMinimaze.UseVisualStyleBackColor = false;
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackColor = System.Drawing.Color.Black;
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Location = new System.Drawing.Point(196, 0);
            this.btnMaximize.Size = new System.Drawing.Size(52, 44);
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.Text = "◻";
            this.btnMaximize.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(748, 0);
            this.btnClose.Size = new System.Drawing.Size(52, 44);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "✕";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnAbout
            // 
            this.btnAbout.Border = System.Drawing.Color.Gray;
            this.btnAbout.BorderSize = 1F;
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Image = null;
            this.btnAbout.ImageAnchor = WindowsUI.Enums.ButtonImageAnchor.Left;
            this.btnAbout.Location = new System.Drawing.Point(696, 398);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Normal = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnAbout.Press = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnAbout.Selected = false;
            this.btnAbout.SelectedBorderSize = 2;
            this.btnAbout.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnAbout.SelectedStyle = WindowsUI.Enums.SelectedStyle.Left;
            this.btnAbout.Size = new System.Drawing.Size(92, 40);
            this.btnAbout.TabIndex = 2;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // pnlDragDrop
            // 
            this.pnlDragDrop.BackColor = System.Drawing.Color.Transparent;
            this.pnlDragDrop.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.pnlDragDrop.BorderRadius = 1;
            this.pnlDragDrop.BorderSize = 2;
            this.pnlDragDrop.Controls.Add(this.picCSV);
            this.pnlDragDrop.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlDragDrop.ForeColor = System.Drawing.Color.White;
            this.pnlDragDrop.Location = new System.Drawing.Point(12, 50);
            this.pnlDragDrop.Name = "pnlDragDrop";
            this.pnlDragDrop.Normal = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pnlDragDrop.Opacity = 128;
            this.pnlDragDrop.SeperatorWidth = 1;
            this.pnlDragDrop.ShowBorder = false;
            this.pnlDragDrop.Size = new System.Drawing.Size(776, 342);
            this.pnlDragDrop.TabIndex = 3;
            this.pnlDragDrop.Title = "PLEASE DRAG THE *.CSV FILE TO HERE";
            // 
            // picCSV
            // 
            this.picCSV.Image = global::YTR_Datalogger_Parser.Properties.Resources.csv_icon;
            this.picCSV.Location = new System.Drawing.Point(290, 87);
            this.picCSV.Name = "picCSV";
            this.picCSV.Size = new System.Drawing.Size(200, 200);
            this.picCSV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCSV.TabIndex = 4;
            this.picCSV.TabStop = false;
            // 
            // Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlDragDrop);
            this.Controls.Add(this.btnAbout);
            this.MaximizeButton = false;
            this.Name = "Main";
            this.Text = "Main";
            this.Title = "YTR Datalogger Parser";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.btnAbout, 0);
            this.Controls.SetChildIndex(this.pnlDragDrop, 0);
            this.pnlTop.ResumeLayout(false);
            this.pnlDragDrop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCSV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WindowsUI.WinButton btnAbout;
        private WindowsUI.WinPanel pnlDragDrop;
        private PictureBox picCSV;
    }
}