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
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        private async void LoadingForm_Load(object sender, EventArgs e)
        {
            picboxForCompanyLogo.Image = CompanyProfile.CompanyLogo;
            lblForCompanyName.Text = CompanyProfile.CompanyName;

            Loading_Pic.Image = Image.FromFile(@"E:\Projects\SmartStock\LoadingImage.gif");
            await Task.Delay(3000);  // Show for 5 seconds

            FadeOut(); // Smooth fade out
            this.Close();  // Close after fade
        }

        public void FadeOut()
        {
            for (double i = 1.0; i >= 0; i -= 0.05)
            {
                this.Opacity = i;
                this.Refresh();
                System.Threading.Thread.Sleep(50); // Controls fade-out speed
            }
        }


    }
}
