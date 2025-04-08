using FontAwesome.Sharp;
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
using System.IO;
using SmartStock.Helpers;

namespace SmartStock.Forms
{
    public partial class Main : Form
    {
        private bool isLogIn = false;
        public Main(bool islogin = false)
        {
            InitializeComponent();
            isLogIn = islogin;
        }

        private async void Main_Load(object sender, EventArgs e)
        {
            lblWelcomeMessage.Text = "Welcome '" + Session.Name + "' To SmartStock";
            LoadForm(new Dashboard());

            drpdwnForUserName.Text = Session.Name;

            //Load Company Logo and Name
            picboxForCompanyLogo.Image = CompanyProfile.CompanyLogo;
            lblForCompanyName.Text = CompanyProfile.CompanyName;

            if (Session.ProfilePic != null && Session.ProfilePic != "")
            {
                picboxProfilePicture.Image = ImageHelper.Base64ToImage(Session.ProfilePic);
            }
            else
            {
                picboxProfilePicture.Image = Image.FromFile(@"E:\Projects\SmartStock\User iconGIF.gif");
            }


            if (isLogIn && !Session.IsSecurityQuestionsCompleted)
            {
                // Optional: Friendly Non-blocking popup for attention
                await ShowReminderPopup("⚠ Important: Please set your Security Questions for Account Recovery.");

                // Then show professional MessageBox
                DialogResult result = MessageBox.Show(
                    "For your account safety, we recommend setting up your Security Questions.\n" +
                    "Would you like to set them now?",
                    "Security Reminder",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    SecurityQuestionForm sqf = new SecurityQuestionForm(Session.UserId);
                    sqf.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No worries! You can complete it later from your Profile settings.",
                                    "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


        }

        private async Task ShowReminderPopup(string message)
        {
            Form popup = new Form
            {
                FormBorderStyle = FormBorderStyle.None,
                StartPosition = FormStartPosition.CenterScreen,
                BackColor = Color.LightYellow,
                Size = new Size(400, 120),
                TopMost = true
            };

            Label lbl = new Label
            {
                Text = message,
                Font = new Font("Arial", 12, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };

            popup.Controls.Add(lbl);
            popup.Show();
            await Task.Delay(3000); // 3 seconds
            popup.Close();
        }


        public void LoadForm(Form form)
        {
            pnlContent.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Size = pnlContent.ClientSize;  // Match the panel size
            form.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom; // Resize with panel


            pnlContent.Controls.Add(form);
            form.Show();
        }



        bool SidebarExpanded = true;

        private void picboxProfilePicture_Click(object sender, EventArgs e)
        {
            contextmenuForDropDownList.Show(picboxProfilePicture, new Point(0, picboxProfilePicture.Height));
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (SidebarExpanded)
            {
                pnlLeftSide.Width = 80;  // Collapse
                btnMenu.IconChar = IconChar.CaretLeft;
                SidebarExpanded = false;
                btnMenu.Text = "";
                btnDashboard.Text = "";
                btnProfile.Text = "";

                lblDashboard.Text = "📊";
                lblDashboard.Font = new Font(lblDashboard.Font.FontFamily, 20, lblDashboard.Font.Style);
                lblProfile.Text = "👤";
                lblProfile.Font = new Font(lblDashboard.Font.FontFamily, 20, lblDashboard.Font.Style);
                lblSalesAndTransaction.Text = "🛒";
                lblSalesAndTransaction.Font = new Font(lblDashboard.Font.FontFamily, 20, lblDashboard.Font.Style);
                lblInventoryAndStock.Text = "📦";
                lblInventoryAndStock.Font = new Font(lblDashboard.Font.FontFamily, 20, lblDashboard.Font.Style);
                lblCustomer.Text = "👥";
                lblCustomer.Font = new Font(lblDashboard.Font.FontFamily, 20, lblDashboard.Font.Style);
                lblSetting.Text = "⚙️";
                lblSetting.Font = new Font(lblDashboard.Font.FontFamily, 20, lblDashboard.Font.Style);
            }
            else
            {
                pnlLeftSide.Width = 230;  // Expand
                btnMenu.IconChar = IconChar.CaretRight; // Change back
                SidebarExpanded = true;
                btnMenu.Text = "Menu";
                btnDashboard.Text = "Dashboard";
                btnProfile.Text = "Profile";
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadForm(new Dashboard());
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            LoadForm(new Profile());
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            LoadForm(new Sale());
        }

        private void btnSalesHistory_Click(object sender, EventArgs e)
        {
            SalesHistory sh = new SalesHistory(this);
            LoadForm(sh);
        }

        private void btnSaleReports_Click(object sender, EventArgs e)
        {
            LoadForm(new SalesReport(0));
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            LoadForm(new Payment());
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            Product p = new Product(this);
            LoadForm(p);
        }

        private void btnProductDetails_Click(object sender, EventArgs e)
        {
            LoadForm(new ProductDetails(0, this));
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            LoadForm(new Purchase());
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            LoadForm(new Category());
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            LoadForm(new Supplier());
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            LoadForm(new Customer());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            LoadForm(new Setting());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            LoadForm(new ManageUser());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation",
                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure want to Logout?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Session.UserId = 0;
                Session.Name = null;
                Session.ProfilePic = null;
                Session.Email = null;
                Session.IsSecurityQuestionsCompleted = false;


                Properties.Settings.Default.SavedEmail = string.Empty;
                Properties.Settings.Default.Save();


                this.Hide();
                Login li = new Login();
                li.Show();
            }
        }

        private void drpdwnForProfile_Click(object sender, EventArgs e)
        {
            LoadForm(new Profile());
        }

        private void drpdwnForSetting_Click(object sender, EventArgs e)
        {
            LoadForm(new Setting());
        }

        private void drpdwnForLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure want to Logout?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Session.UserId = 0;
                Session.Name = null;
                Session.ProfilePic = null;
                Session.Email = null;
                Session.IsSecurityQuestionsCompleted = false;


                Properties.Settings.Default.SavedEmail = string.Empty;
                Properties.Settings.Default.Save();


                this.Hide();
                Login li = new Login();
                li.Show();
            }
        }


    }
}
