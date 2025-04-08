using SmartStock.BLL;
using SmartStock.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace SmartStock.Forms
{
    public partial class Setting : Form
    {
        bool IsPasswordVerified = false;
        public Setting()
        {
            InitializeComponent();
        }
        

        private void Setting_Load(object sender, EventArgs e)
        {
            pnlGeneralSetting.Visible = true;
            pnlGeneralSetting.Dock = DockStyle.Fill;
            pnlUserPermission.Visible = false;
            pnlSecurity.Visible = false;
            pnlDataManagement.Visible = false;


            pnlSecurityQuestionShowOrHide();  //ShowORHide The Security Question Panel

            GetGeneralSettingData();
            LoadRoles();
            LoadPermissions();
        }


        private void LoadRoles()
        {
            Setting_Methods sm = new Setting_Methods();
            drpdwnRoles.DataSource = sm.GetRoles();
            drpdwnRoles.DisplayMember = "RoleName";
            drpdwnRoles.ValueMember = "RoleID";
        }


        private void LoadPermissions()
        {
            Setting_Methods sm = new Setting_Methods();
            DataTable dt = sm.GetPermissionTypes();

            if (dt != null && dt.Rows.Count > 0)
            {
                chkPermissionType.DataSource = dt;
                chkPermissionType.DisplayMember = "PermissionName";
                chkPermissionType.ValueMember = "PermissionTypeID";
            }
        }



        private void btnUploadLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PicBoxCompanyLogo.Image = Image.FromFile(openFileDialog.FileName);
            }
        }



        private void ShowPanels(Panel pnl)
        {
            pnlGeneralSetting.Visible = false;
            pnlUserPermission.Visible = false;
            pnlSecurity.Visible = false;
            pnlDataManagement.Visible = false;

            pnl.Visible = true;
            pnl.Dock = DockStyle.Fill;
        }

        private void btnGeneralSetting_Click(object sender, EventArgs e)
        {
            ShowPanels(pnlGeneralSetting);
        }

        private void btnUserPermission_Click(object sender, EventArgs e)
        {
            ShowPanels(pnlUserPermission);
        }

        private void btnSecuritySetting_Click(object sender, EventArgs e)
        {
            ShowPanels(pnlSecurity);
        }

        private void btnDataManagement_Click(object sender, EventArgs e)
        {
            ShowPanels(pnlDataManagement);
        }

        private void chkEnable2FA_CheckedChanged(object sender, EventArgs e)
        {
            pnlSecurityQuestionShowOrHide();
        }


        private void pnlSecurityQuestionShowOrHide()
        {
            if (chkEnable2FA.Checked)
            {
                pnlSecurityQuestions.Visible = true;
            }
            else
            {
                pnlSecurityQuestions.Visible = false;
            }
        }


        private bool GeneralSettingValidateForm()
        {
            bool isvalid = true;
            if (string.IsNullOrWhiteSpace(txtCompanyName.Text))
            {
                MessageBox.Show("Company Name is required.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isvalid = false;
            }
            else if (string.IsNullOrWhiteSpace(txtTaxPercentage.Text))
            {
                MessageBox.Show("Tax Percentage is required.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isvalid = false;
            }
            else if (drpdwnSelectCurrency.SelectedIndex == -1)
            {
                MessageBox.Show("Currency is required, Select any Currency.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isvalid = false;
            }

            return isvalid;
        }

        private void GetGeneralSettingData()
        {
            Setting_Methods sm = new Setting_Methods();
            Settings s = sm.GetSettingData();

            txtCompanyName.Text = s.CompanyName;
            txtTaxPercentage.Text = Convert.ToString(s.TaxPercentage);
            drpdwnSelectCurrency.SelectedItem = s.Currency;
            PicBoxCompanyLogo.Image = ImageHelper.Base64ToImage(s.CompanyLogo);
        }

        private void btnSaveGeneralSetting_Click(object sender, EventArgs e)
        {
            if (GeneralSettingValidateForm())
            {
                Settings s = new Settings();
                Setting_Methods sm = new Setting_Methods();

                s.CompanyName = txtCompanyName.Text;
                s.TaxPercentage = Convert.ToDecimal(txtTaxPercentage.Text);
                s.Currency = drpdwnSelectCurrency.Text;
                if (PicBoxCompanyLogo.Image != null)
                {
                    s.CompanyLogo = ImageHelper.ImageToBase64(PicBoxCompanyLogo.Image);
                }
                else
                {
                    s.CompanyLogo = null;
                }

                bool isInserted = sm.InsertOrUpdate(s);
                if (isInserted)
                {
                    MessageBox.Show("Settings have been saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Settings have been Updated.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                GetGeneralSettingData();

            }
        }

        private bool PermissionSettingValidateForm()
        {
            bool isvalid = true;
            if (drpdwnRoles.SelectedIndex == -1)
            {
                MessageBox.Show("Role is required, Please select any role.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isvalid = false;
            }
            else if (chkPermissionType.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select at least one permission.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isvalid = false;
            }
            return isvalid;
        }

        private void btnSaveUserPermissions_Click(object sender, EventArgs e)
        {
            if (PermissionSettingValidateForm())
            {
                int roleID = Convert.ToInt32(drpdwnRoles.SelectedValue);
                List<int> selectedPermissions = new List<int>();

                foreach (DataRowView row in chkPermissionType.CheckedItems)
                {
                    selectedPermissions.Add(Convert.ToInt32(row["PermissionTypeID"]));
                }

                Setting_Methods sm = new Setting_Methods();
                bool success = sm.SaveRolePermission(roleID, selectedPermissions);

                MessageBox.Show(success ? "Permissions saved successfully!" : "Error saving permissions.");
            }
        }


        //----------------------------------------------

        private void btnVerifyCurrentPassword_Click(object sender, EventArgs e)
        {
            User u = new User();

            string enteredpassword = txtCurrentPassword.Text;

            User_Methods um = new User_Methods();
            u = um.GetDataByID(Session.UserId);
            if (u != null && string.IsNullOrWhiteSpace(txtCurrentPassword.Text))
            {
                if (BCrypt.Net.BCrypt.Verify(enteredpassword, u.PasswordHash))
                {
                    MessageBox.Show("Password Verified.", "Password Verification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    IsPasswordVerified = true;
                }
                else
                {
                    MessageBox.Show("Password Incorrect", "Password Verification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if(IsPasswordVerified)
            {
                if (string.IsNullOrWhiteSpace(txtNewPassword.Text))
                {
                    MessageBox.Show("New Password is required.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    User_Methods um = new User_Methods();
                    bool isreset = um.ResetPassword(Session.UserId, BCrypt.Net.BCrypt.HashPassword(txtNewPassword.Text));
                    
                    if (isreset)
                    {
                        MessageBox.Show("Password reset successfully.", "Reset password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please verify your current password.", "Password Verification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool ValidateSecurityForm()
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
                isvalid = false;
            }
            else if (drpdwnForSecurityQuestion2.SelectedIndex == -1)
            {
                MessageBox.Show("Select Security Question2.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isvalid = false;
            }
            else if (string.IsNullOrWhiteSpace(txtSecurityAnswer2.Text))
            {
                MessageBox.Show("Enter your answer for security question2.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isvalid = false;
            }

            return isvalid;
        }

        private void btnSaveSecurityQuestions_Click(object sender, EventArgs e)
        {
            if (ValidateSecurityForm())
            {
                User u = new User();
                u.SecurityQuestion1 = Convert.ToString(drpdwnForSecurityQuestion1.SelectedItem);
                u.SecurityAnswer1 = Convert.ToString(txtSecurityAnswer1.Text);
                u.SecurityQuestion2 = Convert.ToString(drpdwnForSecurityQuestion2.SelectedItem);
                u.SecurityAnswer2 = Convert.ToString(txtSecurityAnswer2.Text);
                u.UserID = Session.UserId;


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

        private void btnLocation_Click(object sender, EventArgs e)
        {
            using(FolderBrowserDialog folderdialog=new FolderBrowserDialog())
            {
                if (folderdialog.ShowDialog() == DialogResult.OK)
                {
                    txtDatabaseBackupLocation.Text = folderdialog.SelectedPath;
                }
            }
        }

        private void btnBackupNow_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDatabaseBackupLocation.Text))
            {
                MessageBox.Show("Please select a backup location.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string backupPath = Path.Combine(txtDatabaseBackupLocation.Text, "SmartStockDB_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".bak");
            string connectionString = "Server=DESKTOP-USIKR4F;Database=SmartStockDB;Integrated Security=True;";
            string query = $"BACKUP DATABASE SmartStockDB TO DISK = '{backupPath}'";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Database backup completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Backup Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRestoreBackup_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Select Backup File",
                Filter = "Backup Files (*.bak)|*.bak|All Files (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string backupFile = openFileDialog.FileName;
                string connectionString = "Server=DESKTOP-USIKR4F;Database=SmartStockDB;Integrated Security=True;";
                string query = $@"
                    ALTER DATABASE SmartStockDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
                    RESTORE DATABASE SmartStockDB FROM DISK = '{backupFile}' WITH REPLACE;
                    ALTER DATABASE SmartStockDB SET MULTI_USER;";

                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Database restored successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Restore Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClearSaleHistory_Click(object sender, EventArgs e)
        {
            DateTime startDate = datetimeSaleHistoryStartDate.Value.Date;
            DateTime endDate = datetimeSaleHistoryEndDate.Value.Date;

            if (startDate > endDate)
            {
                MessageBox.Show("Start date cannot be later than the end date.", "Invalid Dates", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete sale history between " +
                startDate.ToShortDateString() + " and " + endDate.ToShortDateString() + "?",
                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                string connectionString = "Server=DESKTOP-USIKR4F;Database=SmartStockDB;Integrated Security=True;";
                string query = "DELETE FROM Sales WHERE SaleDate BETWEEN @StartDate AND @EndDate";

                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@StartDate", startDate);
                            cmd.Parameters.AddWithValue("@EndDate", endDate);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            MessageBox.Show(rowsAffected + " sales records deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnResetAppData_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to reset all application data? " +
                "This action cannot be undone!", "Confirm Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            

            if (result == DialogResult.Yes)
            {
                string connectionString = "Server=DESKTOP-USIKR4F;Database=SmartStockDB;Integrated Security=True;";

                string resetQuery = @"
                    EXEC sp_MSforeachtable 'ALTER TABLE ? NOCHECK CONSTRAINT ALL';
                    
                    DELETE FROM dbo.SaleDetails;
                    DELETE FROM dbo.Sales;
                    DELETE FROM dbo.Customers;
                    DELETE FROM dbo.Products;
                    DELETE FROM dbo.Suppliers;
                    DELETE FROM dbo.Transactions;
                    DELETE FROM dbo.Purchases;

                    DBCC CHECKIDENT ('dbo.SaleDetails', RESEED, 0);
                    DBCC CHECKIDENT ('dbo.Sales', RESEED, 0);
                    DBCC CHECKIDENT ('dbo.Customers', RESEED, 0);
                    DBCC CHECKIDENT ('dbo.Products', RESEED, 0);
                    DBCC CHECKIDENT ('dbo.Suppliers', RESEED, 0);
                    DBCC CHECKIDENT ('dbo.Transactions', RESEED, 0);
                    
                    EXEC sp_MSforeachtable 'ALTER TABLE ? CHECK CONSTRAINT ALL';
                ";

                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand(resetQuery, con))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Application data has been reset successfully!", "Reset Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Reset Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
        
}
