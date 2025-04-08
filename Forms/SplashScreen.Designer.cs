namespace SmartStock.Forms
{
    partial class SplashScreen
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Loading_Pic = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblForCompanyName = new System.Windows.Forms.Label();
            this.picboxForCompanyLogo = new System.Windows.Forms.PictureBox();
            this.timerFadeIn = new System.Windows.Forms.Timer(this.components);
            this.timerClose = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Loading_Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxForCompanyLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Loading_Pic);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblForCompanyName);
            this.panel1.Controls.Add(this.picboxForCompanyLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 495);
            this.panel1.TabIndex = 0;
            // 
            // Loading_Pic
            // 
            this.Loading_Pic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Loading_Pic.BackColor = System.Drawing.Color.Transparent;
            this.Loading_Pic.Image = global::SmartStock.Properties.Resources.LoadingImage;
            this.Loading_Pic.Location = new System.Drawing.Point(304, 167);
            this.Loading_Pic.Name = "Loading_Pic";
            this.Loading_Pic.Size = new System.Drawing.Size(234, 155);
            this.Loading_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Loading_Pic.TabIndex = 14;
            this.Loading_Pic.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(325, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Loading... Please wait";
            // 
            // lblForCompanyName
            // 
            this.lblForCompanyName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblForCompanyName.AutoSize = true;
            this.lblForCompanyName.BackColor = System.Drawing.Color.Transparent;
            this.lblForCompanyName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForCompanyName.ForeColor = System.Drawing.Color.Black;
            this.lblForCompanyName.Location = new System.Drawing.Point(136, 134);
            this.lblForCompanyName.Name = "lblForCompanyName";
            this.lblForCompanyName.Size = new System.Drawing.Size(617, 30);
            this.lblForCompanyName.TabIndex = 12;
            this.lblForCompanyName.Text = "SmartStock - Advanced Inventory & Sales Management System";
            // 
            // picboxForCompanyLogo
            // 
            this.picboxForCompanyLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picboxForCompanyLogo.BackColor = System.Drawing.Color.White;
            this.picboxForCompanyLogo.Image = global::SmartStock.Properties.Resources.download_removebg_preview;
            this.picboxForCompanyLogo.Location = new System.Drawing.Point(329, 12);
            this.picboxForCompanyLogo.Name = "picboxForCompanyLogo";
            this.picboxForCompanyLogo.Size = new System.Drawing.Size(194, 97);
            this.picboxForCompanyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxForCompanyLogo.TabIndex = 11;
            this.picboxForCompanyLogo.TabStop = false;
            // 
            // timerFadeIn
            // 
            this.timerFadeIn.Enabled = true;
            this.timerFadeIn.Interval = 50;
            this.timerFadeIn.Tick += new System.EventHandler(this.timerFadeIn_Tick);
            // 
            // timerClose
            // 
            this.timerClose.Enabled = true;
            this.timerClose.Interval = 3000;
            this.timerClose.Tick += new System.EventHandler(this.timerClose_Tick);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(840, 495);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Loading_Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxForCompanyLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timerFadeIn;
        private System.Windows.Forms.Timer timerClose;
        private System.Windows.Forms.PictureBox Loading_Pic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblForCompanyName;
        private System.Windows.Forms.PictureBox picboxForCompanyLogo;
    }
}