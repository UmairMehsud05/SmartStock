namespace SmartStock.Forms
{
    partial class SecurityQuestionForm
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
            this.picboxForCompanyLogo = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblForCompanyName = new System.Windows.Forms.Label();
            this.btnBack = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSubmitQuestions = new System.Windows.Forms.Button();
            this.lblSecurityAnswer1 = new System.Windows.Forms.Label();
            this.txtSecurityAnswer2 = new System.Windows.Forms.TextBox();
            this.lblSecurityQuestion1 = new System.Windows.Forms.Label();
            this.lblSecurityAnswer2 = new System.Windows.Forms.Label();
            this.txtSecurityAnswer1 = new System.Windows.Forms.TextBox();
            this.lblSecurityQuestion2 = new System.Windows.Forms.Label();
            this.drpdwnForSecurityQuestion1 = new System.Windows.Forms.ComboBox();
            this.drpdwnForSecurityQuestion2 = new System.Windows.Forms.ComboBox();
            this.lblSecurityQuestionInfo = new System.Windows.Forms.Label();
            this.logintitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picboxForCompanyLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picboxForCompanyLogo
            // 
            this.picboxForCompanyLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.picboxForCompanyLogo.Image = global::SmartStock.Properties.Resources.download_removebg_preview;
            this.picboxForCompanyLogo.Location = new System.Drawing.Point(33, 136);
            this.picboxForCompanyLogo.Name = "picboxForCompanyLogo";
            this.picboxForCompanyLogo.Size = new System.Drawing.Size(476, 180);
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
            this.splitContainer1.Panel2.Controls.Add(this.lblSecurityQuestionInfo);
            this.splitContainer1.Panel2.Controls.Add(this.logintitle);
            this.splitContainer1.Size = new System.Drawing.Size(1054, 569);
            this.splitContainer1.SplitterDistance = 497;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 2;
            // 
            // lblForCompanyName
            // 
            this.lblForCompanyName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblForCompanyName.AutoSize = true;
            this.lblForCompanyName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForCompanyName.Location = new System.Drawing.Point(-31, 332);
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
            this.btnBack.Location = new System.Drawing.Point(42, 60);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(101, 41);
            this.btnBack.TabIndex = 48;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnSubmitQuestions);
            this.groupBox1.Controls.Add(this.lblSecurityAnswer1);
            this.groupBox1.Controls.Add(this.txtSecurityAnswer2);
            this.groupBox1.Controls.Add(this.lblSecurityQuestion1);
            this.groupBox1.Controls.Add(this.lblSecurityAnswer2);
            this.groupBox1.Controls.Add(this.txtSecurityAnswer1);
            this.groupBox1.Controls.Add(this.lblSecurityQuestion2);
            this.groupBox1.Controls.Add(this.drpdwnForSecurityQuestion1);
            this.groupBox1.Controls.Add(this.drpdwnForSecurityQuestion2);
            this.groupBox1.Location = new System.Drawing.Point(50, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 384);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            // 
            // btnSubmitQuestions
            // 
            this.btnSubmitQuestions.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSubmitQuestions.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSubmitQuestions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitQuestions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitQuestions.Location = new System.Drawing.Point(106, 310);
            this.btnSubmitQuestions.Name = "btnSubmitQuestions";
            this.btnSubmitQuestions.Size = new System.Drawing.Size(280, 38);
            this.btnSubmitQuestions.TabIndex = 38;
            this.btnSubmitQuestions.Text = "Submit";
            this.btnSubmitQuestions.UseVisualStyleBackColor = false;
            this.btnSubmitQuestions.Click += new System.EventHandler(this.btnSubmitQuestions_Click);
            this.btnSubmitQuestions.MouseEnter += new System.EventHandler(this.btnSubmitQuestions_MouseEnter);
            // 
            // lblSecurityAnswer1
            // 
            this.lblSecurityAnswer1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSecurityAnswer1.AutoSize = true;
            this.lblSecurityAnswer1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecurityAnswer1.Location = new System.Drawing.Point(102, 101);
            this.lblSecurityAnswer1.Name = "lblSecurityAnswer1";
            this.lblSecurityAnswer1.Size = new System.Drawing.Size(105, 21);
            this.lblSecurityAnswer1.TabIndex = 35;
            this.lblSecurityAnswer1.Text = "Your Answer";
            // 
            // txtSecurityAnswer2
            // 
            this.txtSecurityAnswer2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecurityAnswer2.Location = new System.Drawing.Point(106, 256);
            this.txtSecurityAnswer2.Name = "txtSecurityAnswer2";
            this.txtSecurityAnswer2.Size = new System.Drawing.Size(280, 35);
            this.txtSecurityAnswer2.TabIndex = 0;
            this.txtSecurityAnswer2.MouseEnter += new System.EventHandler(this.txtSecurityAnswer2_MouseEnter);
            this.txtSecurityAnswer2.MouseLeave += new System.EventHandler(this.txtSecurityAnswer2_MouseLeave);
            // 
            // lblSecurityQuestion1
            // 
            this.lblSecurityQuestion1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSecurityQuestion1.AutoSize = true;
            this.lblSecurityQuestion1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecurityQuestion1.Location = new System.Drawing.Point(102, 35);
            this.lblSecurityQuestion1.Name = "lblSecurityQuestion1";
            this.lblSecurityQuestion1.Size = new System.Drawing.Size(208, 21);
            this.lblSecurityQuestion1.TabIndex = 33;
            this.lblSecurityQuestion1.Text = "Select Security Question 1";
            // 
            // lblSecurityAnswer2
            // 
            this.lblSecurityAnswer2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSecurityAnswer2.AutoSize = true;
            this.lblSecurityAnswer2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecurityAnswer2.Location = new System.Drawing.Point(102, 232);
            this.lblSecurityAnswer2.Name = "lblSecurityAnswer2";
            this.lblSecurityAnswer2.Size = new System.Drawing.Size(105, 21);
            this.lblSecurityAnswer2.TabIndex = 37;
            this.lblSecurityAnswer2.Text = "Your Answer";
            // 
            // txtSecurityAnswer1
            // 
            this.txtSecurityAnswer1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecurityAnswer1.Location = new System.Drawing.Point(106, 127);
            this.txtSecurityAnswer1.Name = "txtSecurityAnswer1";
            this.txtSecurityAnswer1.Size = new System.Drawing.Size(280, 35);
            this.txtSecurityAnswer1.TabIndex = 0;
            this.txtSecurityAnswer1.MouseEnter += new System.EventHandler(this.txtSecurityAnswer1_MouseEnter);
            this.txtSecurityAnswer1.MouseLeave += new System.EventHandler(this.txtSecurityAnswer1_MouseLeave);
            // 
            // lblSecurityQuestion2
            // 
            this.lblSecurityQuestion2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSecurityQuestion2.AutoSize = true;
            this.lblSecurityQuestion2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecurityQuestion2.Location = new System.Drawing.Point(102, 168);
            this.lblSecurityQuestion2.Name = "lblSecurityQuestion2";
            this.lblSecurityQuestion2.Size = new System.Drawing.Size(208, 21);
            this.lblSecurityQuestion2.TabIndex = 31;
            this.lblSecurityQuestion2.Text = "Select Security Question 2";
            // 
            // drpdwnForSecurityQuestion1
            // 
            this.drpdwnForSecurityQuestion1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpdwnForSecurityQuestion1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpdwnForSecurityQuestion1.FormattingEnabled = true;
            this.drpdwnForSecurityQuestion1.Items.AddRange(new object[] {
            "What is your pet\'s name?,",
            "What is your favorite movie?,",
            "What is your dream job?"});
            this.drpdwnForSecurityQuestion1.Location = new System.Drawing.Point(106, 61);
            this.drpdwnForSecurityQuestion1.Name = "drpdwnForSecurityQuestion1";
            this.drpdwnForSecurityQuestion1.Size = new System.Drawing.Size(280, 31);
            this.drpdwnForSecurityQuestion1.TabIndex = 1;
            this.drpdwnForSecurityQuestion1.MouseEnter += new System.EventHandler(this.drpdwnForSecurityQuestion1_MouseEnter);
            this.drpdwnForSecurityQuestion1.MouseLeave += new System.EventHandler(this.drpdwnForSecurityQuestion1_MouseLeave);
            // 
            // drpdwnForSecurityQuestion2
            // 
            this.drpdwnForSecurityQuestion2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpdwnForSecurityQuestion2.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpdwnForSecurityQuestion2.FormattingEnabled = true;
            this.drpdwnForSecurityQuestion2.Items.AddRange(new object[] {
            "What is your favorite color?,",
            "What city were you born in?,",
            "What is your favorite food?"});
            this.drpdwnForSecurityQuestion2.Location = new System.Drawing.Point(106, 194);
            this.drpdwnForSecurityQuestion2.Name = "drpdwnForSecurityQuestion2";
            this.drpdwnForSecurityQuestion2.Size = new System.Drawing.Size(280, 31);
            this.drpdwnForSecurityQuestion2.TabIndex = 1;
            this.drpdwnForSecurityQuestion2.MouseEnter += new System.EventHandler(this.drpdwnForSecurityQuestion2_MouseEnter);
            this.drpdwnForSecurityQuestion2.MouseLeave += new System.EventHandler(this.drpdwnForSecurityQuestion2_MouseLeave);
            // 
            // lblSecurityQuestionInfo
            // 
            this.lblSecurityQuestionInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSecurityQuestionInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecurityQuestionInfo.ForeColor = System.Drawing.Color.White;
            this.lblSecurityQuestionInfo.Location = new System.Drawing.Point(56, 122);
            this.lblSecurityQuestionInfo.Name = "lblSecurityQuestionInfo";
            this.lblSecurityQuestionInfo.Size = new System.Drawing.Size(515, 29);
            this.lblSecurityQuestionInfo.TabIndex = 46;
            this.lblSecurityQuestionInfo.Text = "For your account safety, please set up your security questions.";
            // 
            // logintitle
            // 
            this.logintitle.AutoSize = true;
            this.logintitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logintitle.Location = new System.Drawing.Point(170, 36);
            this.logintitle.Name = "logintitle";
            this.logintitle.Size = new System.Drawing.Size(255, 37);
            this.logintitle.TabIndex = 8;
            this.logintitle.Text = "Security Questions";
            // 
            // SecurityQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 569);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SecurityQuestionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SecurityQuestionForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SecurityQuestionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxForCompanyLogo)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox picboxForCompanyLogo;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnSubmitQuestions;
        private System.Windows.Forms.TextBox txtSecurityAnswer2;
        private System.Windows.Forms.TextBox txtSecurityAnswer1;
        private System.Windows.Forms.ComboBox drpdwnForSecurityQuestion1;
        private System.Windows.Forms.ComboBox drpdwnForSecurityQuestion2;
        private System.Windows.Forms.Label lblSecurityAnswer2;
        private System.Windows.Forms.Label lblSecurityAnswer1;
        private System.Windows.Forms.Label lblSecurityQuestion1;
        private System.Windows.Forms.Label lblSecurityQuestion2;
        private System.Windows.Forms.Label lblSecurityQuestionInfo;
        private System.Windows.Forms.Label logintitle;
        private System.Windows.Forms.Label lblForCompanyName;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btnBack;
    }
}