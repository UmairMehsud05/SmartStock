using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock.Helpers
{
    public class ImageHelper
    {

        //Convert Image to String Base 64 for storing in database 
        public static string ImageToBase64(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, img.RawFormat);
                byte[] imagebytes = ms.ToArray();
                return Convert.ToBase64String(imagebytes);
            }
        }

        //Convert Image back to original form from String Base 64 From Database
        public static Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                return Image.FromStream(ms);
            }
        }


    }
}
