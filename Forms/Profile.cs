using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartStock.BLL;
using System.Text.RegularExpressions;
using SmartStock.Helpers;

namespace SmartStock.Forms
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            if (Session.IsSecurityQuestionsCompleted)
            {
                btnSetSecurityQuestions.Visible = false;
            }


            MyData();
        }


        //To Load the User Data After Login Into the Profile Form
        private void MyData()
        {
            User_Methods um = new User_Methods();

            User u = um.GetDataByID(Session.UserId);

            if (u != null)
            {
                txtEmail.Text = u.Email;
                txtName.Text = u.FullName;
                lblcreatedAt.Text = u.CreatedAt.ToString("dd-MMM-yyyy");

                if (u.ProfileImage != null && u.ProfileImage != "")
                {
                    picboxForProfilePicture.Image = ImageHelper.Base64ToImage(u.ProfileImage);
                }
                else
                {
                    picboxForProfilePicture.Image = Image.FromFile(@"E:\Projects\SmartStock\User iconGIF.gif");
                }

                if (u.Contact == null)
                {
                    txtPhone.Text = "Not Updated.";
                }
                else
                {
                    txtPhone.Text = u.Contact;
                }

                if (u.RoleID > 0)
                {
                    lblRole.Text = Convert.ToString(u.RoleID);
                }


            }

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

        private void btnChangePassword_MouseEnter(object sender, EventArgs e)
        {
            btnChangePassword.BackColor = Color.AliceBlue;
        }

        private void btnUpdateProfile_MouseEnter(object sender, EventArgs e)
        {
            btnUpdateProfile.BackColor = Color.AliceBlue;
        }

        private void btnSetSecurityQuestions_MouseEnter(object sender, EventArgs e)
        {
            btnSetSecurityQuestions.BackColor = Color.AliceBlue;
        }

        private void btnUploadProfilePicture_MouseEnter(object sender, EventArgs e)
        {
            btnUploadProfilePicture.BackColor = Color.AliceBlue;
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

        private void btnChangePassword_MouseLeave(object sender, EventArgs e)
        {
            btnChangePassword.BackColor = Color.White;
        }

        private void btnUpdateProfile_MouseLeave(object sender, EventArgs e)
        {
            btnUpdateProfile.BackColor = Color.White;
        }

        private void btnSetSecurityQuestions_MouseLeave(object sender, EventArgs e)
        {
            btnSetSecurityQuestions.BackColor = Color.White;
        }

        private void btnUploadProfilePicture_MouseLeave(object sender, EventArgs e)
        {
            btnUploadProfilePicture.BackColor = Color.White;
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
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                toolTip1.Show("❌ Invalid! Only numbers (0-9) are allowed.", txtPhone, 0, txtPhone.Height, 2000);
            }

        }


        // ------------------------------------------ Clicks on Buttons ----------------------------------------------

            

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            Changepassword cp = new Changepassword();
            cp.Show();
        }

        private void btnUploadProfilePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog filedialog = new OpenFileDialog();
            filedialog.Filter= "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (filedialog.ShowDialog() == DialogResult.OK)
            {
                picboxForProfilePicture.Image = Image.FromFile(filedialog.FileName);
            }
        }

               

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name is required.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email is required.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else {

                if (Session.UserId == 0)
                {
                    MessageBox.Show("Session expired. Please login again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                User u = new User();
                u.UserID = Session.UserId;
                u.FullName = txtName.Text;
                u.Email = txtEmail.Text;
                u.Contact = txtPhone.Text;
                if (picboxForProfilePicture.Image != null)
                {
                    u.ProfileImage = ImageHelper.ImageToBase64(picboxForProfilePicture.Image);
                }
                else
                {
                    u.ProfileImage = null;
                }


                User_Methods um = new User_Methods();
                bool isupdated = um.UpdateProfile(u);
                if (isupdated)
                {
                    MessageBox.Show("Profile updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MyData();
                }
            }
            
        }

        private void btnSetSecurityQuestions_Click(object sender, EventArgs e)
        {
            this.Hide();
            SecurityQuestionForm sqf = new SecurityQuestionForm(Session.UserId);
            sqf.Show();
        }

        

    }
}
