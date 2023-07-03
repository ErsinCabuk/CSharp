namespace SIS
{
    partial class FormSekreterBilgisi
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
            labelTCKimlikNo = new Label();
            textBoxTCKimlikNo = new TextBox();
            textBoxAd = new TextBox();
            labelAd = new Label();
            textBoxEPosta = new TextBox();
            labelEPosta = new Label();
            textBoxTelefonNo = new TextBox();
            labelTelefonNo = new Label();
            buttonKaydet = new Button();
            textBoxSoyad = new TextBox();
            labelSoyad = new Label();
            SuspendLayout();
            // 
            // labelTCKimlikNo
            // 
            labelTCKimlikNo.AutoSize = true;
            labelTCKimlikNo.Location = new Point(12, 15);
            labelTCKimlikNo.Name = "labelTCKimlikNo";
            labelTCKimlikNo.Size = new Size(102, 21);
            labelTCKimlikNo.TabIndex = 1;
            labelTCKimlikNo.Text = "TC Kimlik No:";
            // 
            // textBoxTCKimlikNo
            // 
            textBoxTCKimlikNo.Location = new Point(120, 12);
            textBoxTCKimlikNo.MaxLength = 11;
            textBoxTCKimlikNo.Name = "textBoxTCKimlikNo";
            textBoxTCKimlikNo.Size = new Size(150, 29);
            textBoxTCKimlikNo.TabIndex = 2;
            // 
            // textBoxAd
            // 
            textBoxAd.Location = new Point(120, 47);
            textBoxAd.MaxLength = 50;
            textBoxAd.Name = "textBoxAd";
            textBoxAd.Size = new Size(150, 29);
            textBoxAd.TabIndex = 4;
            // 
            // labelAd
            // 
            labelAd.AutoSize = true;
            labelAd.Location = new Point(12, 50);
            labelAd.Name = "labelAd";
            labelAd.Size = new Size(32, 21);
            labelAd.TabIndex = 3;
            labelAd.Text = "Ad:";
            // 
            // textBoxEPosta
            // 
            textBoxEPosta.Location = new Point(120, 117);
            textBoxEPosta.MaxLength = 50;
            textBoxEPosta.Name = "textBoxEPosta";
            textBoxEPosta.Size = new Size(150, 29);
            textBoxEPosta.TabIndex = 8;
            // 
            // labelEPosta
            // 
            labelEPosta.AutoSize = true;
            labelEPosta.Location = new Point(12, 120);
            labelEPosta.Name = "labelEPosta";
            labelEPosta.Size = new Size(64, 21);
            labelEPosta.TabIndex = 7;
            labelEPosta.Text = "E-Posta:";
            // 
            // textBoxTelefonNo
            // 
            textBoxTelefonNo.Location = new Point(120, 152);
            textBoxTelefonNo.MaxLength = 50;
            textBoxTelefonNo.Name = "textBoxTelefonNo";
            textBoxTelefonNo.Size = new Size(150, 29);
            textBoxTelefonNo.TabIndex = 10;
            // 
            // labelTelefonNo
            // 
            labelTelefonNo.AutoSize = true;
            labelTelefonNo.Location = new Point(12, 155);
            labelTelefonNo.Name = "labelTelefonNo";
            labelTelefonNo.Size = new Size(87, 21);
            labelTelefonNo.TabIndex = 9;
            labelTelefonNo.Text = "Telefon No:";
            // 
            // buttonKaydet
            // 
            buttonKaydet.Location = new Point(12, 187);
            buttonKaydet.Name = "buttonKaydet";
            buttonKaydet.Size = new Size(258, 29);
            buttonKaydet.TabIndex = 12;
            buttonKaydet.Text = "Kaydet";
            buttonKaydet.UseVisualStyleBackColor = true;
            buttonKaydet.Click += buttonKaydet_Click;
            // 
            // textBoxSoyad
            // 
            textBoxSoyad.Location = new Point(120, 82);
            textBoxSoyad.MaxLength = 50;
            textBoxSoyad.Name = "textBoxSoyad";
            textBoxSoyad.Size = new Size(150, 29);
            textBoxSoyad.TabIndex = 6;
            // 
            // labelSoyad
            // 
            labelSoyad.AutoSize = true;
            labelSoyad.Location = new Point(12, 85);
            labelSoyad.Name = "labelSoyad";
            labelSoyad.Size = new Size(56, 21);
            labelSoyad.TabIndex = 14;
            labelSoyad.Text = "Soyad:";
            // 
            // FormSekreterBilgisi
            // 
            AcceptButton = buttonKaydet;
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 226);
            Controls.Add(textBoxSoyad);
            Controls.Add(labelSoyad);
            Controls.Add(buttonKaydet);
            Controls.Add(textBoxTelefonNo);
            Controls.Add(labelTelefonNo);
            Controls.Add(textBoxEPosta);
            Controls.Add(labelEPosta);
            Controls.Add(textBoxAd);
            Controls.Add(labelAd);
            Controls.Add(textBoxTCKimlikNo);
            Controls.Add(labelTCKimlikNo);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FormSekreterBilgisi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sekreter";
            Load += FormSekreterBilgisi_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelTCKimlikNo;
        private TextBox textBoxTCKimlikNo;
        private TextBox textBoxAd;
        private Label labelAd;
        private TextBox textBoxEPosta;
        private Label labelEPosta;
        private TextBox textBoxTelefonNo;
        private Label labelTelefonNo;
        private Button buttonKaydet;
        private TextBox textBoxSoyad;
        private Label labelSoyad;
    }
}