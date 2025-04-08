namespace SmartStock.Forms
{
    partial class Login
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.picboxForCompanyLogo = new System.Windows.Forms.PictureBox();
            this.grpboxLogin = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.eyeimg = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NewUserLink = new System.Windows.Forms.LinkLabel();
            this.PasswordForgotLink = new System.Windows.Forms.LinkLabel();
            this.btnlogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.checkboxRememberMe = new System.Windows.Forms.CheckBox();
            this.logintitle = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxForCompanyLogo)).BeginInit();
            this.grpboxLogin.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyeimg)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.LightBlue;
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.picboxForCompanyLogo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Teal;
            this.splitContainer1.Panel2.Controls.Add(this.grpboxLogin);
            this.splitContainer1.Panel2.Controls.Add(this.logintitle);
            this.splitContainer1.Size = new System.Drawing.Size(1289, 726);
            this.splitContainer1.SplitterDistance = 610;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to SmartStock! Please Login to Continue.";
            // 
            // picboxForCompanyLogo
            // 
            this.picboxForCompanyLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.picboxForCompanyLogo.Image = global::SmartStock.Properties.Resources.download_removebg_preview;
            this.picboxForCompanyLogo.Location = new System.Drawing.Point(33, 202);
            this.picboxForCompanyLogo.Name = "picboxForCompanyLogo";
            this.picboxForCompanyLogo.Size = new System.Drawing.Size(588, 180);
            this.picboxForCompanyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxForCompanyLogo.TabIndex = 0;
            this.picboxForCompanyLogo.TabStop = false;
            // 
            // grpboxLogin
            // 
            this.grpboxLogin.Controls.Add(this.panel4);
            this.grpboxLogin.Controls.Add(this.panel2);
            this.grpboxLogin.Controls.Add(this.label3);
            this.grpboxLogin.Controls.Add(this.NewUserLink);
            this.grpboxLogin.Controls.Add(this.PasswordForgotLink);
            this.grpboxLogin.Controls.Add(this.btnlogin);
            this.grpboxLogin.Controls.Add(this.label2);
            this.grpboxLogin.Controls.Add(this.checkboxRememberMe);
            this.grpboxLogin.Location = new System.Drawing.Point(119, 166);
            this.grpboxLogin.Name = "grpboxLogin";
            this.grpboxLogin.Size = new System.Drawing.Size(458, 429);
            this.grpboxLogin.TabIndex = 10;
            this.grpboxLogin.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.pictureBox6);
            this.panel4.Controls.Add(this.txtEmail);
            this.panel4.Location = new System.Drawing.Point(97, 80);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(280, 35);
            this.panel4.TabIndex = 18;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Image = global::SmartStock.Properties.Resources.Emailicon;
            this.pictureBox6.Location = new System.Drawing.Point(235, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(41, 31);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 2;
            this.pictureBox6.TabStop = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(0, 0);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txtEmail.MaximumSize = new System.Drawing.Size(0, 120);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(280, 36);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            this.txtEmail.MouseEnter += new System.EventHandler(this.txtEmail_MouseEnter);
            this.txtEmail.MouseLeave += new System.EventHandler(this.txtEmail_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.eyeimg);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Location = new System.Drawing.Point(98, 149);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 36);
            this.panel2.TabIndex = 19;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = global::SmartStock.Properties.Resources.Passwordicon;
            this.pictureBox3.Location = new System.Drawing.Point(231, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // eyeimg
            // 
            this.eyeimg.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.eyeimg.BackColor = System.Drawing.Color.White;
            this.eyeimg.Image = global::SmartStock.Properties.Resources.Open_eyeicon;
            this.eyeimg.Location = new System.Drawing.Point(189, 2);
            this.eyeimg.Name = "eyeimg";
            this.eyeimg.Size = new System.Drawing.Size(35, 32);
            this.eyeimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eyeimg.TabIndex = 3;
            this.eyeimg.TabStop = false;
            this.eyeimg.Click += new System.EventHandler(this.eyeimg_Click_1);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(0, 0);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txtPassword.MaximumSize = new System.Drawing.Size(0, 120);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(279, 36);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            this.txtPassword.MouseEnter += new System.EventHandler(this.txtPassword_MouseEnter);
            this.txtPassword.MouseLeave += new System.EventHandler(this.txtPassword_MouseLeave);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // NewUserLink
            // 
            this.NewUserLink.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.NewUserLink.AutoSize = true;
            this.NewUserLink.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewUserLink.LinkColor = System.Drawing.Color.White;
            this.NewUserLink.Location = new System.Drawing.Point(143, 294);
            this.NewUserLink.Name = "NewUserLink";
            this.NewUserLink.Size = new System.Drawing.Size(179, 21);
            this.NewUserLink.TabIndex = 5;
            this.NewUserLink.TabStop = true;
            this.NewUserLink.Text = "New User? Sign Up Here";
            this.NewUserLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NewUserLink_LinkClicked);
            this.NewUserLink.MouseEnter += new System.EventHandler(this.NewUserLink_MouseEnter);
            this.NewUserLink.MouseLeave += new System.EventHandler(this.NewUserLink_MouseLeave);
            // 
            // PasswordForgotLink
            // 
            this.PasswordForgotLink.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PasswordForgotLink.AutoSize = true;
            this.PasswordForgotLink.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordForgotLink.LinkColor = System.Drawing.Color.White;
            this.PasswordForgotLink.Location = new System.Drawing.Point(168, 319);
            this.PasswordForgotLink.Name = "PasswordForgotLink";
            this.PasswordForgotLink.Size = new System.Drawing.Size(133, 21);
            this.PasswordForgotLink.TabIndex = 4;
            this.PasswordForgotLink.TabStop = true;
            this.PasswordForgotLink.Text = "Forgot Password?";
            this.PasswordForgotLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PasswordForgotLink_LinkClicked);
            this.PasswordForgotLink.MouseEnter += new System.EventHandler(this.PasswordForgotLink_MouseEnter);
            this.PasswordForgotLink.MouseLeave += new System.EventHandler(this.PasswordForgotLink_MouseLeave);
            // 
            // btnlogin
            // 
            this.btnlogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnlogin.BackColor = System.Drawing.Color.PowderBlue;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(98, 231);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(279, 38);
            this.btnlogin.TabIndex = 3;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            this.btnlogin.MouseEnter += new System.EventHandler(this.btnlogin_MouseEnter);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email";
            // 
            // checkboxRememberMe
            // 
            this.checkboxRememberMe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkboxRememberMe.AutoSize = true;
            this.checkboxRememberMe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxRememberMe.Location = new System.Drawing.Point(98, 198);
            this.checkboxRememberMe.Name = "checkboxRememberMe";
            this.checkboxRememberMe.Size = new System.Drawing.Size(131, 25);
            this.checkboxRememberMe.TabIndex = 2;
            this.checkboxRememberMe.Text = "Remember me";
            this.checkboxRememberMe.UseVisualStyleBackColor = true;
            // 
            // logintitle
            // 
            this.logintitle.AutoSize = true;
            this.logintitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logintitle.Location = new System.Drawing.Point(296, 100);
            this.logintitle.Name = "logintitle";
            this.logintitle.Size = new System.Drawing.Size(104, 45);
            this.logintitle.TabIndex = 8;
            this.logintitle.Text = "Login";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1289, 726);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(600, 726);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Login_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxForCompanyLogo)).EndInit();
            this.grpboxLogin.ResumeLayout(false);
            this.grpboxLogin.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyeimg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.LinkLabel NewUserLink;
        private System.Windows.Forms.LinkLabel PasswordForgotLink;
        private System.Windows.Forms.CheckBox checkboxRememberMe;
        private System.Windows.Forms.Label logintitle;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox eyeimg;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.GroupBox grpboxLogin;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picboxForCompanyLogo;
    }
}