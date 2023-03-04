namespace GeradorQRCode
{
    partial class ucQRconfig
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.cmbCharsetSource = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCharsetTarget = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbECC = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbFormat = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbQZone = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbMargin = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbBGColor = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Configurantions";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Size:";
            // 
            // cmbSize
            // 
            this.cmbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Location = new System.Drawing.Point(3, 78);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(217, 39);
            this.cmbSize.TabIndex = 2;
            // 
            // cmbCharsetSource
            // 
            this.cmbCharsetSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCharsetSource.FormattingEnabled = true;
            this.cmbCharsetSource.Location = new System.Drawing.Point(3, 158);
            this.cmbCharsetSource.Name = "cmbCharsetSource";
            this.cmbCharsetSource.Size = new System.Drawing.Size(217, 39);
            this.cmbCharsetSource.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-1, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Charset Source:";
            // 
            // cmbCharsetTarget
            // 
            this.cmbCharsetTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCharsetTarget.FormattingEnabled = true;
            this.cmbCharsetTarget.Location = new System.Drawing.Point(3, 229);
            this.cmbCharsetTarget.Name = "cmbCharsetTarget";
            this.cmbCharsetTarget.Size = new System.Drawing.Size(217, 39);
            this.cmbCharsetTarget.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 5;
            // 
            // cmbECC
            // 
            this.cmbECC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbECC.FormattingEnabled = true;
            this.cmbECC.Location = new System.Drawing.Point(3, 297);
            this.cmbECC.Name = "cmbECC";
            this.cmbECC.Size = new System.Drawing.Size(217, 39);
            this.cmbECC.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "ECC: ";
            // 
            // cmbColor
            // 
            this.cmbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(3, 365);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(217, 39);
            this.cmbColor.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Color:";
            // 
            // cmbFormat
            // 
            this.cmbFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormat.FormattingEnabled = true;
            this.cmbFormat.Location = new System.Drawing.Point(243, 297);
            this.cmbFormat.Name = "cmbFormat";
            this.cmbFormat.Size = new System.Drawing.Size(217, 39);
            this.cmbFormat.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(243, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Format:";
            // 
            // cmbQZone
            // 
            this.cmbQZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQZone.FormattingEnabled = true;
            this.cmbQZone.Location = new System.Drawing.Point(243, 229);
            this.cmbQZone.Name = "cmbQZone";
            this.cmbQZone.Size = new System.Drawing.Size(217, 39);
            this.cmbQZone.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(243, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "QZone:";
            // 
            // cmbMargin
            // 
            this.cmbMargin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMargin.FormattingEnabled = true;
            this.cmbMargin.Location = new System.Drawing.Point(243, 158);
            this.cmbMargin.Name = "cmbMargin";
            this.cmbMargin.Size = new System.Drawing.Size(217, 39);
            this.cmbMargin.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(239, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Margin:";
            // 
            // cmbBGColor
            // 
            this.cmbBGColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBGColor.FormattingEnabled = true;
            this.cmbBGColor.Location = new System.Drawing.Point(243, 78);
            this.cmbBGColor.Name = "cmbBGColor";
            this.cmbBGColor.Size = new System.Drawing.Size(217, 39);
            this.cmbBGColor.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(243, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "BGColor:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(-1, 206);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Charset Target:";
            // 
            // ucQRconfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbFormat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbQZone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbMargin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbBGColor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbECC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbCharsetTarget);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbCharsetSource);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Name = "ucQRconfig";
            this.Size = new System.Drawing.Size(470, 471);
            this.Load += new System.EventHandler(this.ucQRconfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.ComboBox cmbCharsetSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCharsetTarget;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbECC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbFormat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbQZone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbMargin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbBGColor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}
