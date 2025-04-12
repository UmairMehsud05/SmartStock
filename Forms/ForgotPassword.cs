using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartStock.BLL;

namespace SmartStock.Forms
{
    public partial class ForgotPassword : Form
    {
        string EnteredEmail;
        int userid;

        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            picboxForCompanyLogo.Image = CompanyProfile.CompanyLogo;

            lblSecurityQuestionInfo.Visible = false;
            pnlSecurityQuestions.Visible = false;
            lblpassword.Visible = false;
            txtPassword.Visible = false;
            eyeimg.Visible = false;
            btnResetPassword.Visible = false;
        }


        // ------------------------------------------ Hover For Input Fields ----------------------------------------------

        private void txtEmail_MouseEnter(object sender, EventArgs e)
        {
            txtEmail.BackColor = Color.AliceBlue;
        }

        private void txtEmail_MouseLeave(object sender, EventArgs e)
        {
            txtEmail.BackColor = Color.White;
        }

        private void btnFindMyAccount_MouseEnter(object sender, EventArgs e)
        {
            btnFindMyAccount.BackColor = Color.AliceBlue;
        }

        private void txtSecurityQuestion1_MouseEnter(object sender, EventArgs e)
        {
            txtSecurityQuestion1.BackColor = Color.AliceBlue;
        }

        private void txtSecurityAnswer1_MouseEnter(object sender, EventArgs e)
        {
            txtSecurityAnswer1.BackColor = Color.AliceBlue;
        }

        private void txtSecurityQuestion2_MouseEnter(object sender, EventArgs e)
        {
            txtSecurityQuestion2.BackColor = Color.AliceBlue;
        }

        private void txtSecurityAnswer2_MouseEnter(object sender, EventArgs e)
        {
            txtSecurityAnswer2.BackColor = Color.AliceBlue;
        }

        private void txtSecurityQuestion1_MouseLeave(object sender, EventArgs e)
        {
            txtSecurityQuestion1.BackColor = Color.White;
        }

        private void txtSecurityAnswer1_MouseLeave(object sender, EventArgs e)
        {
            txtSecurityAnswer1.BackColor = Color.White;
        }

        private void txtSecurityQuestion2_MouseLeave(object sender, EventArgs e)
        {
            txtSecurityQuestion2.BackColor = Color.White;
        }

        private void txtSecurityAnswer2_MouseLeave(object sender, EventArgs e)
        {
            txtSecurityAnswer2.BackColor = Color.White;
        }

        private void btnVerifyQuestions_MouseEnter(object sender, EventArgs e)
        {
            btnVerifyQuestions.BackColor = Color.AliceBlue;
        }


        private void txtPassword_MouseEnter(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.AliceBlue;
        }

        private void txtPassword_MouseLeave(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.White;
        }

        private void btnResetPassword_MouseEnter(object sender, EventArgs e)
        {
            btnResetPassword.BackColor = Color.AliceBlue;
        }


        // ------------------------------------------ Characters Restriction For Input Fields ----------------------------------------------


        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '@' && e.KeyChar != '.' &&
        e.KeyChar != '-' && e.KeyChar != '_' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                toolTip1.Show("❌ Invalid! Only letters, numbers, '@', '.', '-', and '_' are allowed.", txtEmail, 0, txtEmail.Height, 2000);

            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true; // Stop the space from being entered
                toolTip1.Show("❌ Invalid! Spaces are not allowed in the password.", txtPassword, 0, txtPassword.Height, 2000);
            }
        }

        private void eyeimg_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar)
            {
                txtPassword.UseSystemPasswordChar = false;
                eyeimg.Image = Properties.Resources.Close_eyeicon;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                eyeimg.Image = Properties.Resources.Open_eyeicon;
            }
        }

        // ------------------------------------------ Click On buttons ----------------------------------------------


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }


        private void btnFindMyAccount_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Enter Email to find your account.", "Required Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
            else
            {

                EnteredEmail = txtEmail.Text;

                User_Methods um = new User_Methods();
                User u = um.GetDataByEmail(EnteredEmail);
                if (u != null)
                {
                    if (u.IsSecurityQuestionSet)
                    {
                        userid = u.UserID;
                        MessageBox.Show("Account found! Please answer your security questions to verify your identity.", "Account Verification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lblSecurityQuestionInfo.Visible = true;
                        pnlSecurityQuestions.Visible = true;
                        txtSecurityQuestion1.Text = u.SecurityQuestion1;
                        txtSecurityQuestion2.Text = u.SecurityQuestion2;
                    }
                    else
                    {
                        MessageBox.Show("Your account does not have security questions set.\nPlease contact admin to reset your password",
                           "No Security Questions Set", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("Account not found! Please enter correct email or register your account.", "Account Verification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }

        private void btnVerifyQuestions_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtSecurityAnswer1.Text) || string.IsNullOrWhiteSpace(txtSecurityAnswer2.Text))
            {
                MessageBox.Show("Please Answer both security questions.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string question1 = txtSecurityQuestion1.Text;
                string answer1 = txtSecurityAnswer1.Text;
                string question2 = txtSecurityQuestion2.Text;
                string answer2 = txtSecurityAnswer2.Text;


                User_Methods um = new User_Methods();
                User u = um.GetDataByEmail(EnteredEmail);
                if (u.SecurityQuestion1 == question1 && u.SecurityAnswer1 == answer1 && u.SecurityQuestion2 == question2 && u.SecurityAnswer2 == answer2)
                {
                    MessageBox.Show("✅ Security questions verified! Now you can change your password.", "Verification Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblpassword.Visible = true;
                    txtPassword.Visible = true;
                    eyeimg.Visible = true;
                    btnResetPassword.Visible = true;
                }
                else
                {
                    MessageBox.Show("❌ Security question answers did not match. Please try again carefully.", "Verification Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please Enter a new password.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                User_Methods um = new User_Methods();
                bool isreset = um.ResetPassword(userid, BCrypt.Net.BCrypt.HashPassword(txtPassword.Text));
                if (isreset)
                {
                    MessageBox.Show("Password reset successfully.", "Reset password", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    Login login = new Login();
                    login.Show();
                }
            }
            
        }
        

    }
}
