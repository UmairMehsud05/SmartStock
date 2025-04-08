namespace SmartStock.Forms
{
    partial class Changepassword
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblResetPassword = new System.Windows.Forms.Label();
            this.logintitle = new System.Windows.Forms.Label();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.picboxForCompanyLogo = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblForCompanyName = new System.Windows.Forms.Label();
            this.btnBack = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.eyeimgconfirmpassword = new System.Windows.Forms.PictureBox();
            this.txtConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.eyeimg = new System.Windows.Forms.PictureBox();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.eyeimgNewPassword = new System.Windows.Forms.PictureBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picboxForCompanyLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eyeimgconfirmpassword)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eyeimg)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eyeimgNewPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // lblResetPassword
            // 
            this.lblResetPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResetPassword.AutoSize = true;
            this.lblResetPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResetPassword.Location = new System.Drawing.Point(62, 42);
            this.lblResetPassword.Name = "lblResetPassword";
            this.lblResetPassword.Size = new System.Drawing.Size(138, 21);
            this.lblResetPassword.TabIndex = 2;
            this.lblResetPassword.Text = "Current Password";
            // 
            // logintitle
            // 
            this.logintitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logintitle.AutoSize = true;
            this.logintitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logintitle.Location = new System.Drawing.Point(118, 40);
            this.logintitle.Name = "logintitle";
            this.logintitle.Size = new System.Drawing.Size(242, 37);
            this.logintitle.TabIndex = 8;
            this.logintitle.Text = "Change Password";
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetPassword.BackColor = System.Drawing.Color.PowderBlue;
            this.btnResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPassword.Location = new System.Drawing.Point(63, 287);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(284, 38);
            this.btnResetPassword.TabIndex = 23;
            this.btnResetPassword.Text = "Reset Password";
            this.btnResetPassword.UseVisualStyleBackColor = false;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            this.btnResetPassword.MouseEnter += new System.EventHandler(this.btnResetPassword_MouseEnter);
            // 
            // picboxForCompanyLogo
            // 
            this.picboxForCompanyLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.picboxForCompanyLogo.Image = global::SmartStock.Properties.Resources.download_removebg_preview;
            this.picboxForCompanyLogo.Location = new System.Drawing.Point(33, 129);
            this.picboxForCompanyLogo.Name = "picboxForCompanyLogo";
            this.picboxForCompanyLogo.Size = new System.Drawing.Size(377, 180);
            this.picboxForCompanyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxForCompanyLogo.TabIndex = 0;
            this.picboxForCompanyLogo.TabStop = false;
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
            this.splitContainer1.Panel1.Controls.Add(this.lblForCompanyName);
            this.splitContainer1.Panel1.Controls.Add(this.picboxForCompanyLogo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Teal;
            this.splitContainer1.Panel2.Controls.Add(this.btnBack);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.logintitle);
            this.splitContainer1.Size = new System.Drawing.Size(842, 555);
            this.splitContainer1.SplitterDistance = 397;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 2;
            // 
            // lblForCompanyName
            // 
            this.lblForCompanyName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblForCompanyName.AutoSize = true;
            this.lblForCompanyName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForCompanyName.Location = new System.Drawing.Point(-53, 321);
            this.lblForCompanyName.Name = "lblForCompanyName";
            this.lblForCompanyName.Size = new System.Drawing.Size(574, 21);
            this.lblForCompanyName.TabIndex = 2;
            this.lblForCompanyName.Text = "Welcome to SmartStock - Advanced Inventory & Sales Management System";
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
            this.btnBack.Location = new System.Drawing.Point(22, 80);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(101, 41);
            this.btnBack.TabIndex = 50;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.btnResetPassword);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblResetPassword);
            this.groupBox1.Location = new System.Drawing.Point(26, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 413);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel3.Controls.Add(this.eyeimgconfirmpassword);
            this.panel3.Controls.Add(this.txtConfirmNewPassword);
            this.panel3.Location = new System.Drawing.Point(66, 215);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(281, 38);
            this.panel3.TabIndex = 28;
            // 
            // eyeimgconfirmpassword
            // 
            this.eyeimgconfirmpassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.eyeimgconfirmpassword.BackColor = System.Drawing.Color.White;
            this.eyeimgconfirmpassword.Image = global::SmartStock.Properties.Resources.Open_eyeicon;
            this.eyeimgconfirmpassword.Location = new System.Drawing.Point(235, 2);
            this.eyeimgconfirmpassword.Name = "eyeimgconfirmpassword";
            this.eyeimgconfirmpassword.Size = new System.Drawing.Size(35, 32);
            this.eyeimgconfirmpassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eyeimgconfirmpassword.TabIndex = 3;
            this.eyeimgconfirmpassword.TabStop = false;
            this.eyeimgconfirmpassword.Click += new System.EventHandler(this.eyeimgconfirmpassword_Click);
            // 
            // txtConfirmNewPassword
            // 
            this.txtConfirmNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmNewPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConfirmNewPassword.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmNewPassword.Location = new System.Drawing.Point(0, 0);
            this.txtConfirmNewPassword.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txtConfirmNewPassword.MaximumSize = new System.Drawing.Size(0, 120);
            this.txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            this.txtConfirmNewPassword.Size = new System.Drawing.Size(281, 36);
            this.txtConfirmNewPassword.TabIndex = 3;
            this.txtConfirmNewPassword.UseSystemPasswordChar = true;
            this.txtConfirmNewPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConfirmNewPassword_KeyPress);
            this.txtConfirmNewPassword.MouseEnter += new System.EventHandler(this.txtConfirmNewPassword_MouseEnter);
            this.txtConfirmNewPassword.MouseLeave += new System.EventHandler(this.txtConfirmNewPassword_MouseLeave);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 21);
            this.label2.TabIndex = 27;
            this.label2.Text = "Confirm Password";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.Controls.Add(this.eyeimg);
            this.panel1.Controls.Add(this.txtCurrentPassword);
            this.panel1.Location = new System.Drawing.Point(66, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 38);
            this.panel1.TabIndex = 27;
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
            this.eyeimg.Click += new System.EventHandler(this.eyeimg_Click_1);
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCurrentPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCurrentPassword.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPassword.Location = new System.Drawing.Point(0, 0);
            this.txtCurrentPassword.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txtCurrentPassword.MaximumSize = new System.Drawing.Size(0, 120);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.Size = new System.Drawing.Size(281, 36);
            this.txtCurrentPassword.TabIndex = 3;
            this.txtCurrentPassword.UseSystemPasswordChar = true;
            this.txtCurrentPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCurrentPassword_KeyPress);
            this.txtCurrentPassword.MouseEnter += new System.EventHandler(this.txtCurrentPassword_MouseEnter);
            this.txtCurrentPassword.MouseLeave += new System.EventHandler(this.txtCurrentPassword_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel2.Controls.Add(this.eyeimgNewPassword);
            this.panel2.Controls.Add(this.txtNewPassword);
            this.panel2.Location = new System.Drawing.Point(66, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 38);
            this.panel2.TabIndex = 26;
            // 
            // eyeimgNewPassword
            // 
            this.eyeimgNewPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.eyeimgNewPassword.BackColor = System.Drawing.Color.White;
            this.eyeimgNewPassword.Image = global::SmartStock.Properties.Resources.Open_eyeicon;
            this.eyeimgNewPassword.Location = new System.Drawing.Point(235, 2);
            this.eyeimgNewPassword.Name = "eyeimgNewPassword";
            this.eyeimgNewPassword.Size = new System.Drawing.Size(35, 32);
            this.eyeimgNewPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eyeimgNewPassword.TabIndex = 3;
            this.eyeimgNewPassword.TabStop = false;
            this.eyeimgNewPassword.Click += new System.EventHandler(this.eyeimgNewPassword_Click_1);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(0, 0);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txtNewPassword.MaximumSize = new System.Drawing.Size(0, 120);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(281, 36);
            this.txtNewPassword.TabIndex = 3;
            this.txtNewPassword.UseSystemPasswordChar = true;
            this.txtNewPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewPassword_KeyPress);
            this.txtNewPassword.MouseEnter += new System.EventHandler(this.txtNewPassword_MouseEnter);
            this.txtNewPassword.MouseLeave += new System.EventHandler(this.txtNewPassword_MouseLeave);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 21);
            this.label3.TabIndex = 24;
            this.label3.Text = "New Password";
            // 
            // Changepassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 555);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Changepassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Changepassword";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Changepassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxForCompanyLogo)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eyeimgconfirmpassword)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eyeimg)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eyeimgNewPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblResetPassword;
        private System.Windows.Forms.Label logintitle;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.PictureBox picboxForCompanyLogo;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox eyeimg;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox eyeimgNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private FontAwesome.Sharp.IconButton btnBack;
        private System.Windows.Forms.Label lblForCompanyName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox eyeimgconfirmpassword;
        private System.Windows.Forms.TextBox txtConfirmNewPassword;
        private System.Windows.Forms.Label label2;
    }
}