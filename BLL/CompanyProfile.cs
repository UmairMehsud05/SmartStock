using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartStock.Helpers;
using System.Drawing;

namespace SmartStock.BLL
{
    public static class CompanyProfile
    {
        public static string CompanyName { get; set; }
        public static Image CompanyLogo { get; set; }

        public static void LoadCompanySettings()
        {
            Setting_Methods sm = new Setting_Methods();
            Settings s = sm.GetSettingData();

            CompanyName = s.CompanyName;
            CompanyLogo = ImageHelper.Base64ToImage(s.CompanyLogo);
        }

    }
}
