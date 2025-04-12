namespace SmartStock.Forms
{
    partial class ForgotPassword
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
            this.logintitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.picboxForCompanyLogo = new System.Windows.Forms.PictureBox();
            this.btnBack = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlSecurityQuestions = new System.Windows.Forms.Panel();
            this.txtSecurityQuestion2 = new System.Windows.Forms.TextBox();
            this.txtSecurityQuestion1 = new System.Windows.Forms.TextBox();
            this.btnVerifyQuestions = new System.Windows.Forms.Button();
            this.txtSecurityAnswer2 = new System.Windows.Forms.TextBox();
            this.txtSecurityAnswer1 = new System.Windows.Forms.TextBox();
            this.lblSecurityAnswer2 = new System.Windows.Forms.Label();
            this.lblSecurityAnswer1 = new System.Windows.Forms.Label();
            this.lblSecurityQuestion1 = new System.Windows.Forms.Label();
            this.lblSecurityQuestion2 = new System.Windows.Forms.Label();
            this.lblSecurityQuestionInfo = new System.Windows.Forms.Label();
            this.btnFindMyAccount = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.eyeimg = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxForCompanyLogo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnlSecurityQuestions.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eyeimg)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // logintitle
            // 
            this.logintitle.AutoSize = true;
            this.logintitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logintitle.Location = new System.Drawing.Point(120, 42);
            this.logintitle.Name = "logintitle";
            this.logintitle.Size = new System.Drawing.Size(233, 37);
            this.logintitle.TabIndex = 8;
            this.logintitle.Text = "Forgot Password";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome Back to SmartStock!";
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
            this.splitContainer1.Panel2.Controls.Add(this.btnBack);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.logintitle);
            this.splitContainer1.Size = new System.Drawing.Size(961, 726);
            this.splitContainer1.SplitterDistance = 454;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 1;
            // 
            // picboxForCompanyLogo
            // 
            this.picboxForCompanyLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.picboxForCompanyLogo.Image = global::SmartStock.Properties.Resources.download_removebg_preview;
            this.picboxForCompanyLogo.Location = new System.Drawing.Point(33, 215);
            this.picboxForCompanyLogo.Name = "picboxForCompanyLogo";
            this.picboxForCompanyLogo.Size = new System.Drawing.Size(433, 180);
            this.picboxForCompanyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxForCompanyLogo.TabIndex = 0;
            this.picboxForCompanyLogo.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightBlue;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Teal;
            this.btnBack.IconChar = FontAwesome.Sharp.IconChar.CaretRight;
            this.btnBack.IconColor = System.Drawing.Color.Teal;
            this.btnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBack.IconSize = 40;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(13, 58);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(101, 41);
            this.btnBack.TabIndex = 49;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.pnlSecurityQuestions);
            this.groupBox1.Controls.Add(this.lblSecurityQuestionInfo);
            this.groupBox1.Controls.Add(this.btnFindMyAccount);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.btnResetPassword);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.lblpassword);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(29, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 609);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // pnlSecurityQuestions
            // 
            this.pnlSecurityQuestions.Controls.Add(this.txtSecurityQuestion2);
            this.pnlSecurityQuestions.Controls.Add(this.txtSecurityQuestion1);
            this.pnlSecurityQuestions.Controls.Add(this.btnVerifyQuestions);
            this.pnlSecurityQuestions.Controls.Add(this.txtSecurityAnswer2);
            this.pnlSecurityQuestions.Controls.Add(this.txtSecurityAnswer1);
            this.pnlSecurityQuestions.Controls.Add(this.lblSecurityAnswer2);
            this.pnlSecurityQuestions.Controls.Add(this.lblSecurityAnswer1);
            this.pnlSecurityQuestions.Controls.Add(this.lblSecurityQuestion1);
            this.pnlSecurityQuestions.Controls.Add(this.lblSecurityQuestion2);
            this.pnlSecurityQuestions.Location = new System.Drawing.Point(78, 179);
            this.pnlSecurityQuestions.Name = "pnlSecurityQuestions";
            this.pnlSecurityQuestions.Size = new System.Drawing.Size(321, 300);
            this.pnlSecurityQuestions.TabIndex = 45;
            // 
            // txtSecurityQuestion2
            // 
            this.txtSecurityQuestion2.BackColor = System.Drawing.Color.White;
            this.txtSecurityQuestion2.Enabled = false;
            this.txtSecurityQuestion2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecurityQuestion2.Location = new System.Drawing.Point(17, 159);
            this.txtSecurityQuestion2.Name = "txtSecurityQuestion2";
            this.txtSecurityQuestion2.ReadOnly = true;
            this.txtSecurityQuestion2.Size = new System.Drawing.Size(279, 35);
            this.txtSecurityQuestion2.TabIndex = 40;
            this.txtSecurityQuestion2.MouseEnter += new System.EventHandler(this.txtSecurityQuestion2_MouseEnter);
            this.txtSecurityQuestion2.MouseLeave += new System.EventHandler(this.txtSecurityQuestion2_MouseLeave);
            // 
            // txtSecurityQuestion1
            // 
            this.txtSecurityQuestion1.BackColor = System.Drawing.Color.White;
            this.txtSecurityQuestion1.Enabled = false;
            this.txtSecurityQuestion1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecurityQuestion1.Location = new System.Drawing.Point(15, 40);
            this.txtSecurityQuestion1.Name = "txtSecurityQuestion1";
            this.txtSecurityQuestion1.ReadOnly = true;
            this.txtSecurityQuestion1.Size = new System.Drawing.Size(281, 35);
            this.txtSecurityQuestion1.TabIndex = 39;
            this.txtSecurityQuestion1.MouseEnter += new System.EventHandler(this.txtSecurityQuestion1_MouseEnter);
            this.txtSecurityQuestion1.MouseLeave += new System.EventHandler(this.txtSecurityQuestion1_MouseLeave);
            // 
            // btnVerifyQuestions
            // 
            this.btnVerifyQuestions.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnVerifyQuestions.BackColor = System.Drawing.Color.PowderBlue;
            this.btnVerifyQuestions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerifyQuestions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerifyQuestions.Location = new System.Drawing.Point(17, 257);
            this.btnVerifyQuestions.Name = "btnVerifyQuestions";
            this.btnVerifyQuestions.Size = new System.Drawing.Size(280, 38);
            this.btnVerifyQuestions.TabIndex = 38;
            this.btnVerifyQuestions.Text = "Verify ";
            this.btnVerifyQuestions.UseVisualStyleBackColor = false;
            this.btnVerifyQuestions.Click += new System.EventHandler(this.btnVerifyQuestions_Click);
            this.btnVerifyQuestions.MouseEnter += new System.EventHandler(this.btnVerifyQuestions_MouseEnter);
            // 
            // txtSecurityAnswer2
            // 
            this.txtSecurityAnswer2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecurityAnswer2.Location = new System.Drawing.Point(17, 219);
            this.txtSecurityAnswer2.Name = "txtSecurityAnswer2";
            this.txtSecurityAnswer2.Size = new System.Drawing.Size(280, 35);
            this.txtSecurityAnswer2.TabIndex = 0;
            this.txtSecurityAnswer2.MouseEnter += new System.EventHandler(this.txtSecurityAnswer2_MouseEnter);
            this.txtSecurityAnswer2.MouseLeave += new System.EventHandler(this.txtSecurityAnswer2_MouseLeave);
            // 
            // txtSecurityAnswer1
            // 
            this.txtSecurityAnswer1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecurityAnswer1.Location = new System.Drawing.Point(17, 99);
            this.txtSecurityAnswer1.Name = "txtSecurityAnswer1";
            this.txtSecurityAnswer1.Size = new System.Drawing.Size(280, 35);
            this.txtSecurityAnswer1.TabIndex = 0;
            this.txtSecurityAnswer1.MouseEnter += new System.EventHandler(this.txtSecurityAnswer1_MouseEnter);
            this.txtSecurityAnswer1.MouseLeave += new System.EventHandler(this.txtSecurityAnswer1_MouseLeave);
            // 
            // lblSecurityAnswer2
            // 
            this.lblSecurityAnswer2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSecurityAnswer2.AutoSize = true;
            this.lblSecurityAnswer2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecurityAnswer2.Location = new System.Drawing.Point(13, 197);
            this.lblSecurityAnswer2.Name = "lblSecurityAnswer2";
            this.lblSecurityAnswer2.Size = new System.Drawing.Size(105, 21);
            this.lblSecurityAnswer2.TabIndex = 37;
            this.lblSecurityAnswer2.Text = "Your Answer";
            // 
            // lblSecurityAnswer1
            // 
            this.lblSecurityAnswer1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSecurityAnswer1.AutoSize = true;
            this.lblSecurityAnswer1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecurityAnswer1.Location = new System.Drawing.Point(13, 75);
            this.lblSecurityAnswer1.Name = "lblSecurityAnswer1";
            this.lblSecurityAnswer1.Size = new System.Drawing.Size(105, 21);
            this.lblSecurityAnswer1.TabIndex = 35;
            this.lblSecurityAnswer1.Text = "Your Answer";
            // 
            // lblSecurityQuestion1
            // 
            this.lblSecurityQuestion1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSecurityQuestion1.AutoSize = true;
            this.lblSecurityQuestion1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecurityQuestion1.Location = new System.Drawing.Point(13, 16);
            this.lblSecurityQuestion1.Name = "lblSecurityQuestion1";
            this.lblSecurityQuestion1.Size = new System.Drawing.Size(208, 21);
            this.lblSecurityQuestion1.TabIndex = 33;
            this.lblSecurityQuestion1.Text = "Select Security Question 1";
            // 
            // lblSecurityQuestion2
            // 
            this.lblSecurityQuestion2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSecurityQuestion2.AutoSize = true;
            this.lblSecurityQuestion2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecurityQuestion2.Location = new System.Drawing.Point(13, 139);
            this.lblSecurityQuestion2.Name = "lblSecurityQuestion2";
            this.lblSecurityQuestion2.Size = new System.Drawing.Size(208, 21);
            this.lblSecurityQuestion2.TabIndex = 31;
            this.lblSecurityQuestion2.Text = "Select Security Question 2";
            // 
            // lblSecurityQuestionInfo
            // 
            this.lblSecurityQuestionInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecurityQuestionInfo.ForeColor = System.Drawing.Color.White;
            this.lblSecurityQuestionInfo.Location = new System.Drawing.Point(74, 139);
            this.lblSecurityQuestionInfo.Name = "lblSecurityQuestionInfo";
            this.lblSecurityQuestionInfo.Size = new System.Drawing.Size(335, 39);
            this.lblSecurityQuestionInfo.TabIndex = 44;
            this.lblSecurityQuestionInfo.Text = "To verify your identity, please answer the following security questions exactly a" +
    "s you set them.";
            // 
            // btnFindMyAccount
            // 
            this.btnFindMyAccount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFindMyAccount.BackColor = System.Drawing.Color.PowderBlue;
            this.btnFindMyAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindMyAccount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindMyAccount.Location = new System.Drawing.Point(97, 89);
            this.btnFindMyAccount.Name = "btnFindMyAccount";
            this.btnFindMyAccount.Size = new System.Drawing.Size(280, 38);
            this.btnFindMyAccount.TabIndex = 22;
            this.btnFindMyAccount.Text = "Find my account";
            this.btnFindMyAccount.UseVisualStyleBackColor = false;
            this.btnFindMyAccount.Click += new System.EventHandler(this.btnFindMyAccount_Click);
            this.btnFindMyAccount.MouseEnter += new System.EventHandler(this.btnFindMyAccount_MouseEnter);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel2.Controls.Add(this.eyeimg);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Location = new System.Drawing.Point(93, 513);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 38);
            this.panel2.TabIndex = 15;
            // 
            // eyeimg
            // 
            this.eyeimg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.eyeimg.BackColor = System.Drawing.Color.White;
            this.eyeimg.Image = global::SmartStock.Properties.Resources.Open_eyeicon;
            this.eyeimg.Location = new System.Drawing.Point(235, 2);
            this.eyeimg.Name = "eyeimg";
            this.eyeimg.Size = new System.Drawing.Size(35, 32);
            this.eyeimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eyeimg.TabIndex = 3;
            this.eyeimg.TabStop = false;
            this.eyeimg.Click += new System.EventHandler(this.eyeimg_Click);
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
            this.txtPassword.Size = new System.Drawing.Size(281, 36);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            this.txtPassword.MouseEnter += new System.EventHandler(this.txtPassword_MouseEnter);
            this.txtPassword.MouseLeave += new System.EventHandler(this.txtPassword_MouseLeave);
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnResetPassword.BackColor = System.Drawing.Color.PowderBlue;
            this.btnResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPassword.Location = new System.Drawing.Point(94, 556);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(280, 38);
            this.btnResetPassword.TabIndex = 5;
            this.btnResetPassword.Text = "Reset Password";
            this.btnResetPassword.UseVisualStyleBackColor = false;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            this.btnResetPassword.MouseEnter += new System.EventHandler(this.btnResetPassword_MouseEnter);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel4.Controls.Add(this.pictureBox6);
            this.panel4.Controls.Add(this.txtEmail);
            this.panel4.Location = new System.Drawing.Point(97, 45);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(280, 38);
            this.panel4.TabIndex = 17;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Image = global::SmartStock.Properties.Resources.Emailicon;
            this.pictureBox6.Location = new System.Drawing.Point(236, 3);
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
            this.txtEmail.TabIndex = 1;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            this.txtEmail.MouseEnter += new System.EventHandler(this.txtEmail_MouseEnter);
            this.txtEmail.MouseLeave += new System.EventHandler(this.txtEmail_MouseLeave);
            // 
            // lblpassword
            // 
            this.lblpassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.Location = new System.Drawing.Point(91, 489);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(158, 21);
            this.lblpassword.TabIndex = 13;
            this.lblpassword.Text = "Enter New Password";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(86, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email";
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 726);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(600, 726);
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPassword";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ForgotPassword_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxForCompanyLogo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlSecurityQuestions.ResumeLayout(false);
            this.pnlSecurityQuestions.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eyeimg)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label logintitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picboxForCompanyLogo;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFindMyAccount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox eyeimg;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlSecurityQuestions;
        private System.Windows.Forms.Button btnVerifyQuestions;
        private System.Windows.Forms.TextBox txtSecurityAnswer2;
        private System.Windows.Forms.TextBox txtSecurityAnswer1;
        private System.Windows.Forms.Label lblSecurityAnswer2;
        private System.Windows.Forms.Label lblSecurityAnswer1;
        private System.Windows.Forms.Label lblSecurityQuestion1;
        private System.Windows.Forms.Label lblSecurityQuestion2;
        private System.Windows.Forms.Label lblSecurityQuestionInfo;
        private FontAwesome.Sharp.IconButton btnBack;
        private System.Windows.Forms.TextBox txtSecurityQuestion2;
        private System.Windows.Forms.TextBox txtSecurityQuestion1;
    }
}