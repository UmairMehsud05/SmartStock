using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartStock.Forms;
using SmartStock.BLL;

namespace SmartStock
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            //Company Profile Load once at startup
            CompanyProfile.LoadCompanySettings();


            Application.Run(new SplashScreen());
        }
    }
}
