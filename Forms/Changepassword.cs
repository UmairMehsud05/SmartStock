using SmartStock.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartStock.Forms
{
    public partial class Changepassword : Form
    {
        public Changepassword()
        {
            InitializeComponent();
        }


        private void Changepassword_Load(object sender, EventArgs e)
        {
            picboxForCompanyLogo.Image = CompanyProfile.CompanyLogo;
            lblForCompanyName.Text = "Welcome to "+ CompanyProfile.CompanyName;
        }

        // ------------------------------------------ Hover For Input Fields ----------------------------------------------

        private void txtCurrentPassword_MouseEnter(object sender, EventArgs e)
        {
            txtCurrentPassword.BackColor = Color.AliceBlue;
        }

        private void txtNewPassword_MouseEnter(object sender, EventArgs e)
        {
            txtNewPassword.BackColor = Color.AliceBlue;
        }

        private void txtConfirmNewPassword_MouseEnter(object sender, EventArgs e)
        {
            txtConfirmNewPassword.BackColor = Color.AliceBlue;
        }

        private void btnResetPassword_MouseEnter(object sender, EventArgs e)
        {
            btnResetPassword.BackColor = Color.AliceBlue;
        }

        private void txtCurrentPassword_MouseLeave(object sender, EventArgs e)
        {
            txtCurrentPassword.BackColor = Color.White;
        }

        private void txtNewPassword_MouseLeave(object sender, EventArgs e)
        {
            txtNewPassword.BackColor = Color.White;
        }

        private void txtConfirmNewPassword_MouseLeave(object sender, EventArgs e)
        {
            txtConfirmNewPassword.BackColor = Color.White;
        }


        // ------------------------------------------ Characters Restriction For Input Fields ----------------------------------------------


        private void txtCurrentPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true; // Stop the space from being entered
                toolTip1.Show("❌ Invalid! Spaces are not allowed in the password.", txtCurrentPassword, 0, txtCurrentPassword.Height, 2000);
            }
        }

        private void eyeimg_Click_1(object sender, EventArgs e)
        {
            if (txtCurrentPassword.UseSystemPasswordChar)
            {
                txtCurrentPassword.UseSystemPasswordChar = false;
                eyeimg.Image = Properties.Resources.Close_eyeicon;
            }
            else
            {
                txtCurrentPassword.UseSystemPasswordChar = true;
                eyeimg.Image = Properties.Resources.Open_eyeicon;
            }
        }

        

        private void txtNewPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true; // Stop the space from being entered
                toolTip1.Show("❌ Invalid! Spaces are not allowed in the password.", txtNewPassword, 0, txtNewPassword.Height, 2000);
            }
        }


        private void eyeimgNewPassword_Click_1(object sender, EventArgs e)
        {
            if (txtNewPassword.UseSystemPasswordChar)
            {
                txtNewPassword.UseSystemPasswordChar = false;
                eyeimgNewPassword.Image = Properties.Resources.Close_eyeicon;
            }
            else
            {
                txtNewPassword.UseSystemPasswordChar = true;
                eyeimgNewPassword.Image = Properties.Resources.Open_eyeicon;
            }
        }

        private void txtConfirmNewPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true; // Stop the space from being entered
                toolTip1.Show("❌ Invalid! Spaces are not allowed in the password.", txtNewPassword, 0, txtNewPassword.Height, 2000);
            }
        }


        private void eyeimgconfirmpassword_Click(object sender, EventArgs e)
        {
            if (txtConfirmNewPassword.UseSystemPasswordChar)
            {
                txtConfirmNewPassword.UseSystemPasswordChar = false;
                eyeimgconfirmpassword.Image = Properties.Resources.Close_eyeicon;
            }
            else
            {
                txtConfirmNewPassword.UseSystemPasswordChar = true;
                eyeimgconfirmpassword.Image = Properties.Resources.Open_eyeicon;
            }
        }
        



        // ------------------------------------------ Clicks on Buttons ----------------------------------------------


        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCurrentPassword.Text))
            {
                MessageBox.Show("Current is required.");
                txtCurrentPassword.Focus();
                return;
            }
            else if(string.IsNullOrWhiteSpace(txtNewPassword.Text))
            {
                MessageBox.Show("New Password is required.");
                txtNewPassword.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtConfirmNewPassword.Text))
            {
                MessageBox.Show("Confirm Password is required.");
                txtConfirmNewPassword.Focus();
                return;
            }
            else if (txtNewPassword.Text != txtConfirmNewPassword.Text)
            {
                MessageBox.Show("Passwords do not match.");
            }
            else
            {
                string enteredpassword = txtCurrentPassword.Text;
                User_Methods um = new User_Methods();
                if(Session.UserId > 0)
                {
                    User u = um.GetDataByID(Session.UserId);

                    if (u != null)
                    {
                        if (BCrypt.Net.BCrypt.Verify(enteredpassword, u.PasswordHash))
                        {
                            u.PasswordHash = BCrypt.Net.BCrypt.HashPassword(txtNewPassword.Text);

                            bool isreset = um.ResetPassword(u.UserID, u.PasswordHash);

                            if (isreset)
                            {
                                MessageBox.Show("Password reset successfully.", "Reset password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Current Password, Please enter correct password", "Incorrect Current password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("User not found. Please login again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Session Expired. Please login again.", "Session Expired", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main m = new Main();
            m.Show();
        }

        
    }
}
