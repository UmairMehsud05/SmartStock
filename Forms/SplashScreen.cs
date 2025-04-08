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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            picboxForCompanyLogo.Image = CompanyProfile.CompanyLogo;
            lblForCompanyName.Text = CompanyProfile.CompanyName;

            this.Opacity = 0; // Start invisible
            Loading_Pic.Image = Image.FromFile(@"E:\Projects\SmartStock\LoadingImage.gif");

            timerFadeIn.Start(); // Start fade-in animation
            timerClose.Start(); // Start auto-close timer
            

    }

    private void timerFadeIn_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1.0)
            {
                this.Opacity += 0.05;
            }
            else
            {
                timerFadeIn.Stop();
            }
    }

        private void timerClose_Tick(object sender, EventArgs e)
        {
            
            timerClose.Stop(); // Stop timer
            this.Hide(); // Hide splash screen
            Login login = new Login();
            login.Show();
    }

        
    }
}
