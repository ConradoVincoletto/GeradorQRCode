using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorQRCode
{
    public partial class ucQRconfig : UserControl
    {
        public ucQRconfig()
        {
            InitializeComponent();
        }

        private void ucQRconfig_Load(object sender, EventArgs e)
        {
            if (this.DesignMode) return;

            //Size
            cmbSize.Items.Clear();
            for(int i = 1; i <= 10; i++)
                cmbSize.Items.Add(string.Format("{0}x{0}", i*100));

            //charset-source
            cmbCharsetSource.Items.Clear();
            cmbCharsetSource.Items.Add("ISO-8859-1");
            cmbCharsetSource.Items.Add("UTF-8");

            //charset-target
            cmbCharsetTarget.Items.Clear();
            cmbCharsetTarget.Items.Add("ISO-8859-1");
            cmbCharsetTarget.Items.Add("UTF-8");

            //ecc
            cmbECC.Items.Clear();
            cmbECC.Items.Add("L");
            cmbECC.Items.Add("M");
            cmbECC.Items.Add("Q");
            cmbECC.Items.Add("H");

            //color
            cmbColor.Items.Clear();
            cmbColor.Items.Add("000000");
            cmbColor.Items.Add("FFFFFF");
            cmbColor.Items.Add("FF0000");
            cmbColor.Items.Add("00FF00");
            cmbColor.Items.Add("0000FF");

            //BgColor
            cmbBGColor.Items.Clear();
            cmbBGColor.Items.Add("FFFFFF");
            cmbBGColor.Items.Add("FF0000");
            cmbBGColor.Items.Add("00FF00");
            cmbBGColor.Items.Add("000000");
            cmbBGColor.Items.Add("0000FF");

            //Margin
            cmbMargin.Items.Clear();
            for(int i = 0; i <= 50; i++)
                cmbMargin.Items.Add(i);

            //QZone

            cmbQZone.Items.Clear();
            for (int i = 0; i < 100; i++)
                cmbQZone.Items.Add(i);

            //Format
            cmbFormat.Items.Clear();
            cmbFormat.Items.Add("png");
            cmbFormat.Items.Add("gif");
            cmbFormat.Items.Add("jpeg");
            cmbFormat.Items.Add("jpg");

            SetDefaultOptions();
        }
        public void SetDefaultOptions()
        {
            cmbSize.SelectedIndex = 1;
            cmbCharsetSource.SelectedIndex = 1 ;
            cmbCharsetTarget.SelectedIndex = 1 ;
            cmbECC.SelectedIndex = 0;
            cmbColor.SelectedIndex = 0;
            cmbBGColor.SelectedIndex = 1;
            cmbMargin.SelectedIndex = 1;
            cmbQZone.SelectedIndex = 0;
            cmbFormat.SelectedIndex = 0;
        }
    }
}
