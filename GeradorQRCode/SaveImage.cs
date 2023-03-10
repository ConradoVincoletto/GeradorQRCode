using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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
                sfDialog.Filter = "PNG Image |*.png";
            }
            else if (format.Equals("gif"))
            {
                sfDialog.Filter = "GIF Image |*.gif";
            }
            else if (format.Equals("jpeg"))
            {
                sfDialog.Filter = "JPEG Image |*.jpeg";
            }
            else if (format.Equals("jpg"))
            {
                sfDialog.Filter = "JPG Image |*.jpg";
            }

            sfDialog.Title = "Save QRCode";
            sfDialog.FileName = "QRCode";
            sfDialog.InitialDirectory = @"C:\Users\conra\OneDrive\Imagens\Saved Pictures";

            sfDialog.ShowDialog();

            if (!sfDialog.FileName.Equals(string.Empty))
            {
                FileStream fs = (FileStream)sfDialog.OpenFile();
                if (format.Equals("png"))
                {
                    imgQRCode.Save(fs, ImageFormat.Png);
                }
                else if (format.Equals("gif"))
                {
                    imgQRCode.Save(fs, ImageFormat.Gif);
                }
                else
                {
                    imgQRCode.Save(fs, ImageFormat.Jpeg);
                }

                fs.Close();

            }
        }
    }
}
