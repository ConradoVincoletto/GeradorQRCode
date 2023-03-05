using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorQRCode
{
    public static class SaveImage
    {
        public static void Save(Image imgQRCode, string format)
        {
            SaveFileDialog sfDialog = new SaveFileDialog();

            if (format.Equals("png"))
            {

            }
            else if (format.Equals("gif"))
            {

            }
            else if (format.Equals("jpeg"))
            {

            }
            else if (format.Equals("jpg"))
            {

            }
        }
    }
}
