namespace SIS
{
    partial class FormUzmanBilgisi
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
            buttonKaydet = new Button();
            textBoxTelefonNo = new TextBox();
            labelTelefonNo = new Label();
            textBoxEPosta = new TextBox();
            labelEPosta = new Label();
            textBoxAd = new TextBox();
            labelAd = new Label();
            textBoxTCKimlikNo = new TextBox();
            labelTCKimlikNo = new Label();
            textBoxUnvan = new TextBox();
            labelUnvan = new Label();
            textBoxSoyad = new TextBox();
            labelSoyad = new Label();
            SuspendLayout();
            // 
            // buttonKaydet
            // 
            buttonKaydet.Location = new Point(12, 222);
            buttonKaydet.Name = "buttonKaydet";
            buttonKaydet.Size = new Size(258, 29);
            buttonKaydet.TabIndex = 27;
            buttonKaydet.Text = "Kaydet";
            buttonKaydet.UseVisualStyleBackColor = true;
            buttonKaydet.Click += buttonKaydet_Click;
            // 
            // textBoxTelefonNo
            // 
            textBoxTelefonNo.Location = new Point(120, 187);
            textBoxTelefonNo.MaxLength = 50;
            textBoxTelefonNo.Name = "textBoxTelefonNo";
            textBoxTelefonNo.Size = new Size(150, 29);
            textBoxTelefonNo.TabIndex = 26;
            // 
            // labelTelefonNo
            // 
            labelTelefonNo.AutoSize = true;
            labelTelefonNo.Location = new Point(12, 190);
            labelTelefonNo.Name = "labelTelefonNo";
            labelTelefonNo.Size = new Size(87, 21);
            labelTelefonNo.TabIndex = 20;
            labelTelefonNo.Text = "Telefon No:";
            // 
            // textBoxEPosta
            // 
            textBoxEPosta.Location = new Point(120, 152);
            textBoxEPosta.MaxLength = 50;
            textBoxEPosta.Name = "textBoxEPosta";
            textBoxEPosta.Size = new Size(150, 29);
            textBoxEPosta.TabIndex = 25;
            // 
            // labelEPosta
            // 
            labelEPosta.AutoSize = true;
            labelEPosta.Location = new Point(12, 155);
            labelEPosta.Name = "labelEPosta";
            labelEPosta.Size = new Size(64, 21);
            labelEPosta.TabIndex = 18;
            labelEPosta.Text = "E-Posta:";
            // 
            // textBoxAd
            // 
            textBoxAd.Location = new Point(120, 47);
            textBoxAd.MaxLength = 50;
            textBoxAd.Name = "textBoxAd";
            textBoxAd.Size = new Size(150, 29);
            textBoxAd.TabIndex = 17;
            // 
            // labelAd
            // 
            labelAd.AutoSize = true;
            labelAd.Location = new Point(12, 50);
            labelAd.Name = "labelAd";
            labelAd.Size = new Size(32, 21);
            labelAd.TabIndex = 16;
            labelAd.Text = "Ad:";
            // 
            // textBoxTCKimlikNo
            // 
            textBoxTCKimlikNo.Location = new Point(120, 12);
            textBoxTCKimlikNo.MaxLength = 11;
            textBoxTCKimlikNo.Name = "textBoxTCKimlikNo";
            textBoxTCKimlikNo.Size = new Size(150, 29);
            textBoxTCKimlikNo.TabIndex = 15;
            // 
            // labelTCKimlikNo
            // 
            labelTCKimlikNo.AutoSize = true;
            labelTCKimlikNo.Location = new Point(12, 15);
            labelTCKimlikNo.Name = "labelTCKimlikNo";
            labelTCKimlikNo.Size = new Size(102, 21);
            labelTCKimlikNo.TabIndex = 14;
            labelTCKimlikNo.Text = "TC Kimlik No:";
            // 
            // textBoxUnvan
            // 
            textBoxUnvan.Location = new Point(120, 117);
            textBoxUnvan.MaxLength = 50;
            textBoxUnvan.Name = "textBoxUnvan";
            textBoxUnvan.Size = new Size(150, 29);
            textBoxUnvan.TabIndex = 21;
            // 
            // labelUnvan
            // 
            labelUnvan.AutoSize = true;
            labelUnvan.Location = new Point(12, 120);
            labelUnvan.Name = "labelUnvan";
            labelUnvan.Size = new Size(58, 21);
            labelUnvan.TabIndex = 25;
            labelUnvan.Text = "Ünvan:";
            // 
            // textBoxSoyad
            // 
            textBoxSoyad.Location = new Point(120, 82);
            textBoxSoyad.MaxLength = 50;
            textBoxSoyad.Name = "textBoxSoyad";
            textBoxSoyad.Size = new Size(150, 29);
            textBoxSoyad.TabIndex = 19;
            // 
            // labelSoyad
            // 
            labelSoyad.AutoSize = true;
            labelSoyad.Location = new Point(12, 85);
            labelSoyad.Name = "labelSoyad";
            labelSoyad.Size = new Size(56, 21);
            labelSoyad.TabIndex = 27;
            labelSoyad.Text = "Soyad:";
            // 
            // FormUzmanBilgisi
            // 
            AcceptButton = buttonKaydet;
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 257);
            Controls.Add(textBoxSoyad);
            Controls.Add(labelSoyad);
            Controls.Add(textBoxUnvan);
            Controls.Add(labelUnvan);
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
            Name = "FormUzmanBilgisi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Uzman";
            Load += FormUzmanBilgisi_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonKaydet;
        private TextBox textBoxTelefonNo;
        private Label labelTelefonNo;
        private TextBox textBoxEPosta;
        private Label labelEPosta;
        private TextBox textBoxAd;
        private Label labelAd;
        private TextBox textBoxTCKimlikNo;
        private Label labelTCKimlikNo;
        private TextBox textBoxUnvan;
        private Label labelUnvan;
        private TextBox textBoxSoyad;
        private Label labelSoyad;
    }
}