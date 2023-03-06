using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorQRCode.Forms
{
    public partial class FrmQRCodeURL : Form
    {
        private Image _imgQrCode;
        private string _format;
        public FrmQRCodeURL()
        {
            InitializeComponent();
           
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            _imgQrCode = null;
            _format = string.Empty;
            txtURL.Text = string.Empty;
            picImage.Image = null;
            oUcQRconfig.SetDefaultOptions();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveImage.Save(_imgQrCode, _format);
        }

        private void FrmQRCodeURL_Load(object sender, EventArgs e)
        {
            btnClean_Click(btnClean, new EventArgs());
        }
    }
}
