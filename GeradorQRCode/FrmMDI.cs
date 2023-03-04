using GeradorQRCode.Forms;
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
    public partial class FrmMDI : Form
    {
        public FrmMDI()
        {
            InitializeComponent();
        }
        private void AbrirFormulario(Form oFrm)
        {
            oFrm.MdiParent= this;
            oFrm.Top = 0;
            oFrm.Left = 0;
            oFrm.Show();
        }

        private void BtnUrlType_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmQRCodeURL());
        }
    }
}
