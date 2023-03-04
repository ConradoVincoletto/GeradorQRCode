using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Configurations
{
    public class QRConfig
    {
        public string Size { get; set; }
        public string CharsetSource { get; set; }
        public string  CharsetTarget { get; set; }
        public char Ecc { get; set; }
        public string Color { get; set; }
        public string BgColor { get; set; }
        public int Margin { get; set; }
        public int QZone { get; set; }
        public string Format { get; set; }
    }
}
