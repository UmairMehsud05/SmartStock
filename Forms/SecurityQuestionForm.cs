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
    public partial class SecurityQuestionForm : Form
    {
        private int UserId;
        public SecurityQuestionForm(int userid)
        {
            InitializeComponent();
            this.UserId = userid;
        }

        private void SecurityQuestionForm_Load(object sender, EventArgs e)
        {
            picboxForCompanyLogo.Image = CompanyProfile.CompanyLogo;
            lblForCompanyName.Text = CompanyProfile.CompanyName;
        }



        // ------------------------------------------ Hover For Input Fields ----------------------------------------------

        private void drpdwnForSecurityQuestion1_MouseEnter(object sender, EventArgs e)
        {
            drpdwnForSecurityQuestion1.BackColor = Color.AliceBlue;
        }

        private void txtSecurityAnswer1_MouseEnter(object sender, EventArgs e)
        {
            txtSecurityAnswer1.BackColor = Color.AliceBlue;
        }

        private void drpdwnForSecurityQuestion2_MouseEnter(object sender, EventArgs e)
        {
            drpdwnForSecurityQuestion2.BackColor = Color.AliceBlue;
        }

        private void txtSecurityAnswer2_MouseEnter(object sender, EventArgs e)
        {
            txtSecurityAnswer2.BackColor = Color.AliceBlue;
        }

        private void btnSubmitQuestions_MouseEnter(object sender, EventArgs e)
        {
            btnSubmitQuestions.BackColor = Color.AliceBlue;
        }

        private void drpdwnForSecurityQuestion1_MouseLeave(object sender, EventArgs e)
        {
            drpdwnForSecurityQuestion1.BackColor = Color.White;
        }

        private void txtSecurityAnswer1_MouseLeave(object sender, EventArgs e)
        {
            txtSecurityAnswer1.BackColor = Color.White;
        }

        private void drpdwnForSecurityQuestion2_MouseLeave(object sender, EventArgs e)
        {
            drpdwnForSecurityQuestion2.BackColor = Color.White;
        }

        private void txtSecurityAnswer2_MouseLeave(object sender, EventArgs e)
        {
            txtSecurityAnswer2.BackColor = Color.White;
        }

        // ------------------------------------------ Clicks on Buttons ----------------------------------------------

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private bool ValidateForm()
        {
            bool isvalid = true;

            if (drpdwnForSecurityQuestion1.SelectedIndex == -1)
            {
                MessageBox.Show("Select Security Question1.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isvalid = false;
            }
            else if (string.IsNullOrWhiteSpace(txtSecurityAnswer1.Text))
            {
                MessageBox.Show("Enter your answer for security question1.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isvalid=false;
            }
            else if (drpdwnForSecurityQuestion2.SelectedIndex == -1)
            {
                MessageBox.Show("Select Security Question2.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isvalid=false;
            }
            else if (string.IsNullOrWhiteSpace(txtSecurityAnswer2.Text))
            {
                MessageBox.Show("Enter your answer for security question2.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isvalid=false;
            }

            return isvalid;
        }

        private void btnSubmitQuestions_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                User u = new User();
                u.SecurityQuestion1 = Convert.ToString(drpdwnForSecurityQuestion1.SelectedItem);
                u.SecurityAnswer1 = Convert.ToString(txtSecurityAnswer1.Text);
                u.SecurityQuestion2 = Convert.ToString(drpdwnForSecurityQuestion2.SelectedItem);
                u.SecurityAnswer2 = Convert.ToString(txtSecurityAnswer2.Text);
                u.UserID = UserId;


                User_Methods um = new User_Methods();
                bool issubmit = um.SubmitSecurityQuestions(u);

                if (issubmit)
                {
                    MessageBox.Show("Security questions submited successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Session.IsSecurityQuestionsCompleted = true;
                }
                else
                {
                    MessageBox.Show("Security questions cannot submitted successfully, try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        
    }
}
