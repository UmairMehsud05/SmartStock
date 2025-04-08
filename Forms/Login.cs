using SmartStock.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartStock.Forms
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtEmail.Focus();

            picboxForCompanyLogo.Image = CompanyProfile.CompanyLogo;

            txtEmail.Text = Properties.Settings.Default.SavedEmail;

            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                checkboxRememberMe.Checked = true;
            }

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(checkboxRememberMe, "Only your Email will be remembered for your convenience.\n Your password is securely protected and will NOT be saved, as per security best practices.");

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


        private void txtPassword_MouseEnter(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.AliceBlue;
        }


        private void txtPassword_MouseLeave(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.White;
        }

        private void btnlogin_MouseEnter(object sender, EventArgs e)
        {
            btnlogin.BackColor = Color.AliceBlue;
        }

        private void PasswordForgotLink_MouseEnter(object sender, EventArgs e)
        {
            PasswordForgotLink.ForeColor = Color.LightBlue;
            PasswordForgotLink.Font = new Font(PasswordForgotLink.Font, FontStyle.Underline);

        }

        private void PasswordForgotLink_MouseLeave(object sender, EventArgs e)
        {
            PasswordForgotLink.ForeColor = Color.FromArgb(0, 123, 255); // Default color
            PasswordForgotLink.Font = new Font(PasswordForgotLink.Font, FontStyle.Italic);

        }

        private void NewUserLink_MouseEnter(object sender, EventArgs e)
        {
            NewUserLink.ForeColor = Color.LightBlue;
            NewUserLink.Font = new Font(NewUserLink.Font, FontStyle.Underline);
        }

        private void NewUserLink_MouseLeave(object sender, EventArgs e)
        {
            NewUserLink.ForeColor = Color.FromArgb(0, 123, 255); // Default color
            NewUserLink.Font = new Font(NewUserLink.Font, FontStyle.Italic);
        }


        // ------------------------------------------ Characters Restriction For Input Fields ----------------------------------------------


        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Prevent beep sound
                txtPassword.Focus(); // Move focus to next TextBox
                return; // Skip the validation below
            }

            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '@' && e.KeyChar != '.' &&
            e.KeyChar != '-' && e.KeyChar != '_' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                toolTip1.Show("❌ Invalid! Only letters, numbers, '@', '.', '-', and '_' are allowed.", txtEmail, 0, txtEmail.Height, 2000);

            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                toolTip1.Show("❌ Invalid! Email format! Example: user@example.com", txtEmail, 0, txtEmail.Height, 2000);
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Prevent beep sound
                btnlogin.Focus(); // Move focus to next TextBox
                return; // Skip the validation below
            }

            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true; // Stop the space from being entered
                toolTip1.Show("❌ Invalid! Spaces are not allowed in the password.", txtPassword, 0, txtPassword.Height, 2000);
            }
        }

        //eye icon to show or hide password text
        private void eyeimg_Click_1(object sender, EventArgs e)
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



        // ------------------------------------------ Clicks on Buttons or Links ----------------------------------------------

        //lead to the forgot password form
        private void PasswordForgotLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgotPassword fp = new ForgotPassword();
            fp.Show();
        }


        //lead to the Sign up Form if a user doesnot have registered account.
        private void NewUserLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            Signup su = new Signup();
            su.Show();
        }


        // ------------------------------------------Check Validation for Input Fields if Empty or not ----------------------------------------------
        private bool ValidateForm()
        {
            bool isvalid = true;
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email is required.");
                isvalid = false;
            }
            else if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Password is required.");
                isvalid = false;
            }

            return isvalid;
        }

        //After successful login a popup shows
        private async void ShowSuccessMessage(string message)
        {
            Form popup = new Form();
            popup.FormBorderStyle = FormBorderStyle.None;
            popup.StartPosition = FormStartPosition.CenterScreen;
            popup.BackColor = Color.Teal;
            popup.Size = new Size(300, 100);

            Label lbl = new Label();
            lbl.Text = message;
            lbl.Font = new Font("Arial", 12, FontStyle.Bold);
            lbl.ForeColor = Color.White;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.Dock = DockStyle.Fill;
            popup.Controls.Add(lbl);

            popup.Show();
            await Task.Delay(2000); // Show for 2 seconds
            popup.Close();
        }


        private async void ShowErrorMessage(string message)
        {
            Form popup = new Form();
            popup.FormBorderStyle = FormBorderStyle.None;
            popup.StartPosition = FormStartPosition.CenterScreen;
            popup.BackColor = Color.Red;
            popup.Size = new Size(300, 100);

            Label lbl = new Label();
            lbl.Text = message;
            lbl.Font = new Font("Arial", 12, FontStyle.Bold);
            lbl.ForeColor = Color.White;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.Dock = DockStyle.Fill;
            popup.Controls.Add(lbl);

            popup.Show();
            await Task.Delay(2000); // Show for 2 seconds
            popup.Close();
        }

        // ------------------------------------------ Clear Fields ----------------------------------------------

        private void ClearFields()
        {
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            checkboxRememberMe.Checked = false;
        }

        // ------------------------------------------ Login button ----------------------------------------------

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {

                User_Methods um = new User_Methods();
                User u = um.GetDataByEmail(txtEmail.Text);

                if (u != null)
                {
                    string password = Convert.ToString(txtPassword.Text);
                    string hashpassword = u.PasswordHash;

                    if (BCrypt.Net.BCrypt.Verify(password, hashpassword))
                    {

                        if (checkboxRememberMe.Checked)
                        {
                            Properties.Settings.Default.SavedEmail = u.Email;
                            Properties.Settings.Default.Save();
                        }
                        else
                        {
                            Properties.Settings.Default.SavedEmail = string.Empty;
                            Properties.Settings.Default.Save();
                        }

                        ClearFields();
                        ShowSuccessMessage("✅ You have logged in successfully!");

                        Session.UserId = u.UserID;
                        Session.Name = u.FullName;
                        Session.ProfilePic = u.ProfileImage;
                        Session.Email = u.Email;
                        Session.IsSecurityQuestionsCompleted = u.IsSecurityQuestionSet;

                        this.Hide();
                        Main m = new Main(true);
                        m.Show();
                    }
                    else
                    {
                        ClearFields();
                        ShowErrorMessage("Invalid Username or Password");
                    }
                }
                else
                {
                    ClearFields();
                    ShowErrorMessage("Invalid Username or Password, or create new account");
                }

            }
        }


    }
}
