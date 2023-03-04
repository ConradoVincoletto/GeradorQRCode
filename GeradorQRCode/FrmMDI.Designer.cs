namespace GeradorQRCode
{
    partial class FrmMDI
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMDI));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnWifiType = new System.Windows.Forms.Button();
            this.BtnEmailType = new System.Windows.Forms.Button();
            this.BtnEventType = new System.Windows.Forms.Button();
            this.BtnGelocationType = new System.Windows.Forms.Button();
            this.BtnCallType = new System.Windows.Forms.Button();
            this.BtnSmsType = new System.Windows.Forms.Button();
            this.BtnVcardType = new System.Windows.Forms.Button();
            this.BtnTextType = new System.Windows.Forms.Button();
            this.BtnUrlType = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlMenu.Controls.Add(this.tableLayoutPanel1);
            this.pnlMenu.Location = new System.Drawing.Point(0, 2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 465);
            this.pnlMenu.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.BtnWifiType, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.BtnEmailType, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.BtnEventType, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.BtnGelocationType, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.BtnCallType, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.BtnSmsType, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.BtnVcardType, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnTextType, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnUrlType, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 465);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // BtnWifiType
            // 
            this.BtnWifiType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnWifiType.Image = global::GeradorQRCode.Properties.Resources.wifi;
            this.BtnWifiType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnWifiType.Location = new System.Drawing.Point(3, 411);
            this.BtnWifiType.Name = "BtnWifiType";
            this.BtnWifiType.Size = new System.Drawing.Size(194, 51);
            this.BtnWifiType.TabIndex = 8;
            this.BtnWifiType.Text = "Wi - Fi";
            this.BtnWifiType.UseVisualStyleBackColor = true;
            // 
            // BtnEmailType
            // 
            this.BtnEmailType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnEmailType.Image = global::GeradorQRCode.Properties.Resources.email;
            this.BtnEmailType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEmailType.Location = new System.Drawing.Point(3, 360);
            this.BtnEmailType.Name = "BtnEmailType";
            this.BtnEmailType.Size = new System.Drawing.Size(194, 45);
            this.BtnEmailType.TabIndex = 7;
            this.BtnEmailType.Text = "Email";
            this.BtnEmailType.UseVisualStyleBackColor = true;
            // 
            // BtnEventType
            // 
            this.BtnEventType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnEventType.Image = global::GeradorQRCode.Properties.Resources._event;
            this.BtnEventType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEventType.Location = new System.Drawing.Point(3, 309);
            this.BtnEventType.Name = "BtnEventType";
            this.BtnEventType.Size = new System.Drawing.Size(194, 45);
            this.BtnEventType.TabIndex = 6;
            this.BtnEventType.Text = "Event";
            this.BtnEventType.UseVisualStyleBackColor = true;
            // 
            // BtnGelocationType
            // 
            this.BtnGelocationType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnGelocationType.Image = global::GeradorQRCode.Properties.Resources.geolocalization;
            this.BtnGelocationType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGelocationType.Location = new System.Drawing.Point(3, 258);
            this.BtnGelocationType.Name = "BtnGelocationType";
            this.BtnGelocationType.Size = new System.Drawing.Size(194, 45);
            this.BtnGelocationType.TabIndex = 5;
            this.BtnGelocationType.Text = "GeLocation";
            this.BtnGelocationType.UseVisualStyleBackColor = true;
            // 
            // BtnCallType
            // 
            this.BtnCallType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCallType.Image = global::GeradorQRCode.Properties.Resources.call;
            this.BtnCallType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCallType.Location = new System.Drawing.Point(3, 207);
            this.BtnCallType.Name = "BtnCallType";
            this.BtnCallType.Size = new System.Drawing.Size(194, 45);
            this.BtnCallType.TabIndex = 4;
            this.BtnCallType.Text = "Call";
            this.BtnCallType.UseVisualStyleBackColor = true;
            // 
            // BtnSmsType
            // 
            this.BtnSmsType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSmsType.Image = global::GeradorQRCode.Properties.Resources.sms;
            this.BtnSmsType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSmsType.Location = new System.Drawing.Point(3, 156);
            this.BtnSmsType.Name = "BtnSmsType";
            this.BtnSmsType.Size = new System.Drawing.Size(194, 45);
            this.BtnSmsType.TabIndex = 3;
            this.BtnSmsType.Text = "SMS";
            this.BtnSmsType.UseVisualStyleBackColor = true;
            // 
            // BtnVcardType
            // 
            this.BtnVcardType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnVcardType.Image = global::GeradorQRCode.Properties.Resources.vcard;
            this.BtnVcardType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVcardType.Location = new System.Drawing.Point(3, 105);
            this.BtnVcardType.Name = "BtnVcardType";
            this.BtnVcardType.Size = new System.Drawing.Size(194, 45);
            this.BtnVcardType.TabIndex = 2;
            this.BtnVcardType.Text = "Vcard";
            this.BtnVcardType.UseVisualStyleBackColor = true;
            // 
            // BtnTextType
            // 
            this.BtnTextType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnTextType.Image = global::GeradorQRCode.Properties.Resources.text;
            this.BtnTextType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTextType.Location = new System.Drawing.Point(3, 54);
            this.BtnTextType.Name = "BtnTextType";
            this.BtnTextType.Size = new System.Drawing.Size(194, 45);
            this.BtnTextType.TabIndex = 1;
            this.BtnTextType.Text = "Text";
            this.BtnTextType.UseVisualStyleBackColor = true;
            // 
            // BtnUrlType
            // 
            this.BtnUrlType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnUrlType.Image = global::GeradorQRCode.Properties.Resources.url;
            this.BtnUrlType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUrlType.Location = new System.Drawing.Point(3, 3);
            this.BtnUrlType.Name = "BtnUrlType";
            this.BtnUrlType.Size = new System.Drawing.Size(194, 45);
            this.BtnUrlType.TabIndex = 0;
            this.BtnUrlType.Text = "URL";
            this.BtnUrlType.UseVisualStyleBackColor = true;
            this.BtnUrlType.Click += new System.EventHandler(this.BtnUrlType_Click);
            // 
            // FrmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 469);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrmMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador QRCode";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlMenu.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BtnWifiType;
        private System.Windows.Forms.Button BtnEmailType;
        private System.Windows.Forms.Button BtnEventType;
        private System.Windows.Forms.Button BtnGelocationType;
        private System.Windows.Forms.Button BtnCallType;
        private System.Windows.Forms.Button BtnSmsType;
        private System.Windows.Forms.Button BtnVcardType;
        private System.Windows.Forms.Button BtnTextType;
        private System.Windows.Forms.Button BtnUrlType;
    }
}

