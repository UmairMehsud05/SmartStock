using SmartStock.BLL;
using SmartStock.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartStock.Forms
{
    public partial class Signup : Form
    {

        public Signup()
        {
            InitializeComponent();            
        }


        private void Signup_Load(object sender, EventArgs e)
        {
            txtName.Focus();
            picboxForCompanyLogo.Image = CompanyProfile.CompanyLogo;
            lblForCompanyName.Text = CompanyProfile.CompanyName;
        }


        // ------------------------------------------ Hover For Input Fields ----------------------------------------------
        private void txtName_MouseEnter(object sender, EventArgs e)
        {
            txtName.BackColor = Color.AliceBlue;
        }

        private void txtEmail_MouseEnter(object sender, EventArgs e)
        {
            txtEmail.BackColor = Color.AliceBlue;
        }

        private void txtPhone_MouseEnter(object sender, EventArgs e)
        {
            txtPhone.BackColor = Color.AliceBlue;
        }

        private void txtPassword_MouseEnter(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.AliceBlue;
        }

        private void txtConfirmPassword_MouseEnter(object sender, EventArgs e)
        {
            txtConfirmPassword.BackColor = Color.AliceBlue;
        }

        private void txtName_MouseLeave(object sender, EventArgs e)
        {
            txtName.BackColor = Color.White;
        }

        private void txtEmail_MouseLeave(object sender, EventArgs e)
        {
            txtEmail.BackColor = Color.White;
        }

        private void txtPhone_MouseLeave(object sender, EventArgs e)
        {
            txtPhone.BackColor = Color.White;
        }

        private void txtPassword_MouseLeave(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.White;
        }

        private void btnsignup_MouseEnter(object sender, EventArgs e)
        {
            btnsignup.BackColor = Color.AliceBlue;
        }

        private void ExistsAccountLink_MouseEnter(object sender, EventArgs e)
        {
            ExistsAccountLink.ForeColor = Color.LightBlue;
            ExistsAccountLink.Font = new Font(ExistsAccountLink.Font, FontStyle.Underline);
        }

        private void ExistsAccountLink_MouseLeave(object sender, EventArgs e)
        {
            ExistsAccountLink.ForeColor = Color.FromArgb(0, 123, 255); // Default color
            ExistsAccountLink.Font = new Font(ExistsAccountLink.Font, FontStyle.Italic);
        }


        // ------------------------------------------ Characters Restriction For Input Fields ----------------------------------------------
        
        
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //On Enter button Focus on to the Next Field
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Prevent beep sound
                txtEmail.Focus(); // Move focus to next TextBox
                return; // Skip the validation below
            }

            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                toolTip1.Show("❌ Invalid! Only alphabets and spaces are allowed.", txtName, 0, txtName.Height, 2000);
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Prevent beep sound
                txtPhone.Focus(); // Move focus to next TextBox
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

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Prevent beep sound
                txtPassword.Focus(); // Move focus to next TextBox
                return; // Skip the validation below
            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                toolTip1.Show("❌ Invalid! Only numbers (0-9) are allowed.", txtPhone, 0, txtPhone.Height, 2000);
            }
            
        }


        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Prevent beep sound
                txtConfirmPassword.Focus(); // Move focus to next TextBox
                return; // Skip the validation below
            }

            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true; // Stop the space from being entered
                toolTip1.Show("❌ Invalid! Spaces are not allowed in the password.", txtPassword, 0, txtPassword.Height, 2000);
            }

        }

        //Eye Icon to show or hide password
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

        private void txtConfirmPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Prevent beep sound
                btnsignup.Focus(); // Move focus to next TextBox
                return; // Skip the validation below
            }

            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true; // Stop the space from being entered
                toolTip1.Show("❌ Invalid! Spaces are not allowed in the password.", txtConfirmPassword, 0, txtConfirmPassword.Height, 2000);
            }

        }
        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text == txtPassword.Text)
            {
                lblMessage.Text = "✅ Passwords Match!";
                lblMessage.ForeColor = Color.Green;
            }
            else
            {
                lblMessage.Text = "❌ Passwords do not match!";
                lblMessage.ForeColor = Color.Red;
            }
        }
        
        //Eye Icon to show or hide password for Confirm Password field
        private void cnfrmeyeimage_Click(object sender, EventArgs e)
        {
            if (txtConfirmPassword.UseSystemPasswordChar)
            {
                txtConfirmPassword.UseSystemPasswordChar = false;
                cnfrmeyeimage.Image = Properties.Resources.Close_eyeicon;
            }
            else
            {
                txtConfirmPassword.UseSystemPasswordChar = true;
                cnfrmeyeimage.Image = Properties.Resources.Open_eyeicon;
            }
        }

        //LInk for already registered account and lead you to login form

        private void ExistsAccountLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login li = new Login();
            li.Show();
        }


        // ------------------------------------------Check Validation for Input Fields if Empty or not ----------------------------------------------

            
        private bool ValidateForm()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name is required.");
                isValid = false;
            }else if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email is required.");
                isValid = false;
            }else if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Password is required.");
                isValid = false;
            }else if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                MessageBox.Show("Confirm Password is required.");
                isValid = false;
            }else if (!string.IsNullOrWhiteSpace(txtPassword.Text) &&
                !string.IsNullOrWhiteSpace(txtConfirmPassword.Text) &&
                txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match.");
                isValid = false;
            }

            return isValid;
        }

        // ------------------------------------------ Clear Fields ----------------------------------------------

        private void ClearFields()
        {
            txtName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtConfirmPassword.Text = string.Empty;
        }

        // ------------------------------------------ Register Account button ----------------------------------------------

        private void btnsignup_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                User u = new User
                {
                    FullName = txtName.Text,
                    Email = txtEmail.Text,
                    Contact = txtPhone.Text,
                    PasswordHash = BCrypt.Net.BCrypt.HashPassword(txtPassword.Text), // Store the hashedPassword in your database (MS SQL).
                    CreatedAt = DateTime.Now,
                    LastUpdatedAt = DateTime.Now,
                    IsSecurityQuestionSet = false,
                    IsDeleted = false
                };
                

                User_Methods um = new User_Methods();
                bool isEmailExists = false;
                
                isEmailExists = um.isEmailExist(u.Email);

                if (!isEmailExists)
                {
                    um.RegisterOrUpdate(u);

                    ClearFields();
                    MessageBox.Show("Sign-Up Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();

                    using(LoadingForm loadform=new LoadingForm())
                    {
                        loadform.ShowDialog();
                    }


                    Login login = new Login();
                    login.Show();
                }
                else
                {
                    ClearFields();
                    MessageBox.Show("Email already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        
    }
}
