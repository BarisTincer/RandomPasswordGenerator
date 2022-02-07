namespace PasswordGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkKucukHarf = new System.Windows.Forms.CheckBox();
            this.chkBuyukHarf = new System.Windows.Forms.CheckBox();
            this.chkRakam = new System.Windows.Forms.CheckBox();
            this.chkOzelKarakter = new System.Windows.Forms.CheckBox();
            this.lblSifreSayisi = new System.Windows.Forms.Label();
            this.lblSifreUzunlugu = new System.Windows.Forms.Label();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.txtSifreler = new System.Windows.Forms.TextBox();
            this.btnUret = new System.Windows.Forms.Button();
            this.nudSifreSayisi = new System.Windows.Forms.NumericUpDown();
            this.nudSifreUzunlugu = new System.Windows.Forms.NumericUpDown();
            this.grpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSifreSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSifreUzunlugu)).BeginInit();
            this.SuspendLayout();
            // 
            // chkKucukHarf
            // 
            this.chkKucukHarf.AutoSize = true;
            this.chkKucukHarf.Location = new System.Drawing.Point(111, 37);
            this.chkKucukHarf.Name = "chkKucukHarf";
            this.chkKucukHarf.Size = new System.Drawing.Size(80, 17);
            this.chkKucukHarf.TabIndex = 0;
            this.chkKucukHarf.Text = "Küçük Harf";
            this.chkKucukHarf.UseVisualStyleBackColor = true;
            // 
            // chkBuyukHarf
            // 
            this.chkBuyukHarf.AutoSize = true;
            this.chkBuyukHarf.Location = new System.Drawing.Point(111, 60);
            this.chkBuyukHarf.Name = "chkBuyukHarf";
            this.chkBuyukHarf.Size = new System.Drawing.Size(79, 17);
            this.chkBuyukHarf.TabIndex = 1;
            this.chkBuyukHarf.Text = "Büyük Harf";
            this.chkBuyukHarf.UseVisualStyleBackColor = true;
            // 
            // chkRakam
            // 
            this.chkRakam.AutoSize = true;
            this.chkRakam.Location = new System.Drawing.Point(111, 83);
            this.chkRakam.Name = "chkRakam";
            this.chkRakam.Size = new System.Drawing.Size(60, 17);
            this.chkRakam.TabIndex = 2;
            this.chkRakam.Text = "Rakam";
            this.chkRakam.UseVisualStyleBackColor = true;
            // 
            // chkOzelKarakter
            // 
            this.chkOzelKarakter.AutoSize = true;
            this.chkOzelKarakter.Location = new System.Drawing.Point(111, 106);
            this.chkOzelKarakter.Name = "chkOzelKarakter";
            this.chkOzelKarakter.Size = new System.Drawing.Size(90, 17);
            this.chkOzelKarakter.TabIndex = 3;
            this.chkOzelKarakter.Text = "Özel Karakter";
            this.chkOzelKarakter.UseVisualStyleBackColor = true;
            // 
            // lblSifreSayisi
            // 
            this.lblSifreSayisi.AutoSize = true;
            this.lblSifreSayisi.Location = new System.Drawing.Point(36, 145);
            this.lblSifreSayisi.Name = "lblSifreSayisi";
            this.lblSifreSayisi.Size = new System.Drawing.Size(61, 13);
            this.lblSifreSayisi.TabIndex = 4;
            this.lblSifreSayisi.Text = "Şifre Sayısı:";
            // 
            // lblSifreUzunlugu
            // 
            this.lblSifreUzunlugu.AutoSize = true;
            this.lblSifreUzunlugu.Location = new System.Drawing.Point(36, 172);
            this.lblSifreUzunlugu.Name = "lblSifreUzunlugu";
            this.lblSifreUzunlugu.Size = new System.Drawing.Size(79, 13);
            this.lblSifreUzunlugu.TabIndex = 5;
            this.lblSifreUzunlugu.Text = "Şifre Uzunluğu:";
            // 
            // grpBox
            // 
            this.grpBox.Controls.Add(this.nudSifreUzunlugu);
            this.grpBox.Controls.Add(this.nudSifreSayisi);
            this.grpBox.Controls.Add(this.btnUret);
            this.grpBox.Controls.Add(this.txtSifreler);
            this.grpBox.Controls.Add(this.chkKucukHarf);
            this.grpBox.Controls.Add(this.chkBuyukHarf);
            this.grpBox.Controls.Add(this.lblSifreUzunlugu);
            this.grpBox.Controls.Add(this.chkRakam);
            this.grpBox.Controls.Add(this.lblSifreSayisi);
            this.grpBox.Controls.Add(this.chkOzelKarakter);
            this.grpBox.Location = new System.Drawing.Point(12, 12);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(451, 259);
            this.grpBox.TabIndex = 7;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "Parametreler";
            // 
            // txtSifreler
            // 
            this.txtSifreler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSifreler.Location = new System.Drawing.Point(244, 19);
            this.txtSifreler.Multiline = true;
            this.txtSifreler.Name = "txtSifreler";
            this.txtSifreler.ReadOnly = true;
            this.txtSifreler.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSifreler.Size = new System.Drawing.Size(198, 234);
            this.txtSifreler.TabIndex = 8;
            // 
            // btnUret
            // 
            this.btnUret.Location = new System.Drawing.Point(144, 191);
            this.btnUret.Name = "btnUret";
            this.btnUret.Size = new System.Drawing.Size(94, 39);
            this.btnUret.TabIndex = 9;
            this.btnUret.Text = "Üret";
            this.btnUret.UseVisualStyleBackColor = true;
            this.btnUret.Click += new System.EventHandler(this.btnUret_Click);
            // 
            // nudSifreSayisi
            // 
            this.nudSifreSayisi.Location = new System.Drawing.Point(144, 138);
            this.nudSifreSayisi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSifreSayisi.Name = "nudSifreSayisi";
            this.nudSifreSayisi.Size = new System.Drawing.Size(94, 20);
            this.nudSifreSayisi.TabIndex = 10;
            this.nudSifreSayisi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudSifreUzunlugu
            // 
            this.nudSifreUzunlugu.Location = new System.Drawing.Point(144, 165);
            this.nudSifreUzunlugu.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSifreUzunlugu.Name = "nudSifreUzunlugu";
            this.nudSifreUzunlugu.Size = new System.Drawing.Size(94, 20);
            this.nudSifreUzunlugu.TabIndex = 11;
            this.nudSifreUzunlugu.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(479, 282);
            this.Controls.Add(this.grpBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Generator";
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSifreSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSifreUzunlugu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkKucukHarf;
        private System.Windows.Forms.CheckBox chkBuyukHarf;
        private System.Windows.Forms.CheckBox chkRakam;
        private System.Windows.Forms.CheckBox chkOzelKarakter;
        private System.Windows.Forms.Label lblSifreSayisi;
        private System.Windows.Forms.Label lblSifreUzunlugu;
        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.TextBox txtSifreler;
        private System.Windows.Forms.Button btnUret;
        private System.Windows.Forms.NumericUpDown nudSifreUzunlugu;
        private System.Windows.Forms.NumericUpDown nudSifreSayisi;
    }
}

