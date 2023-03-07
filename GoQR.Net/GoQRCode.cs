using Entidades.Configurations;
using System.Drawing;
using System.IO;
using System.Net;

namespace GoQR.Net
{
    public class GoQRCode
    {
        public Image GetQRCode(string data, QRConfig config)
        {
            Image imgQRCode = null;
            
            string URLGoQR = "http://api.qrserver.com/v1/create-qr-code/?data={0}&size={1}&charsetsource={2}&charsettarget={3}&ecc={4}&color={5}&bgcolor={6}&margin={7}&qzone={8}&format={9}";
            
            string urlRquestData = string.Format(URLGoQR, data, config.Size, config.CharsetSource, config.CharsetTarget, config.Ecc, config.Color, config.BgColor, config.Margin, config.QZone, config.Format);

            WebRequest request = WebRequest.Create(urlRquestData);

            using(WebResponse response = request.GetResponse())
            {
                Stream st = response.GetResponseStream();
                imgQRCode = Bitmap.FromStream(st);
            }


            return imgQRCode;
        }
    }
}
