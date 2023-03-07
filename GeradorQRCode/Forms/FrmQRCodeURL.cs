using Entidades.Configurations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorQRCode.Forms
{
    public partial class FrmQRCodeURL : Form
    {
        //private Image _imgQrCode;
        private string _format;
        public FrmQRCodeURL()
        {
            InitializeComponent();
           
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (txtURL.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Informe um valor para o campo 'Data'!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!txtURL.Text.Trim().Contains("http://") && !txtURL.Text.Trim().Contains("https://"))
            {
                MessageBox.Show("Informe um valor para o campo 'Data'!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            QRConfig config = oUcQRconfig.GetConfig();

            string strData = WebUtility.UrlEncode(txtURL.Text.Trim());

            _format = config.Format
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
           // _imgQrCode = null;
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
