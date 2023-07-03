namespace SIS
{
    partial class FormUzmanSeansYonetimi
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
            labelSeanslar = new Label();
            comboBoxSeanslar = new ComboBox();
            groupBoxHastaBilgileri = new GroupBox();
            labelSoyad = new Label();
            labelSoyadBaslik = new Label();
            labelAdres = new Label();
            labelAdresBaslik = new Label();
            labelDogumTarihi = new Label();
            labelDogumTarihiBaslik = new Label();
            labelTelefonNo = new Label();
            labelTelefonNoBaslik = new Label();
            labelEPosta = new Label();
            labelEPostaBaslik = new Label();
            labelCinsiyet = new Label();
            labelCinsiyetBaslik = new Label();
            labelAd = new Label();
            labelAdBaslik = new Label();
            labelTCKimlikNo = new Label();
            labelTCKimlikNoBaslik = new Label();
            groupBoxHastaGecmisi = new GroupBox();
            buttonGecmisSeansNotuDuzenle = new Button();
            textBoxGecmisSeansNotu = new TextBox();
            listBoxSeanslar = new ListBox();
            labelSeanslar2 = new Label();
            groupBoxSeansNotu = new GroupBox();
            buttonSeansNotuKaydet = new Button();
            textBoxSeansNotu = new TextBox();
            groupBoxHastaBilgileri.SuspendLayout();
            groupBoxHastaGecmisi.SuspendLayout();
            groupBoxSeansNotu.SuspendLayout();
            SuspendLayout();
            // 
            // labelSeanslar
            // 
            labelSeanslar.AutoSize = true;
            labelSeanslar.Location = new Point(12, 15);
            labelSeanslar.Name = "labelSeanslar";
            labelSeanslar.Size = new Size(72, 21);
            labelSeanslar.TabIndex = 0;
            labelSeanslar.Text = "Seanslar:";
            // 
            // comboBoxSeanslar
            // 
            comboBoxSeanslar.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSeanslar.FormattingEnabled = true;
            comboBoxSeanslar.Location = new Point(90, 12);
            comboBoxSeanslar.Name = "comboBoxSeanslar";
            comboBoxSeanslar.Size = new Size(249, 29);
            comboBoxSeanslar.TabIndex = 1;
            comboBoxSeanslar.SelectedIndexChanged += comboBoxSeanslar_SelectedIndexChanged;
            // 
            // groupBoxHastaBilgileri
            // 
            groupBoxHastaBilgileri.Controls.Add(labelSoyad);
            groupBoxHastaBilgileri.Controls.Add(labelSoyadBaslik);
            groupBoxHastaBilgileri.Controls.Add(labelAdres);
            groupBoxHastaBilgileri.Controls.Add(labelAdresBaslik);
            groupBoxHastaBilgileri.Controls.Add(labelDogumTarihi);
            groupBoxHastaBilgileri.Controls.Add(labelDogumTarihiBaslik);
            groupBoxHastaBilgileri.Controls.Add(labelTelefonNo);
            groupBoxHastaBilgileri.Controls.Add(labelTelefonNoBaslik);
            groupBoxHastaBilgileri.Controls.Add(labelEPosta);
            groupBoxHastaBilgileri.Controls.Add(labelEPostaBaslik);
            groupBoxHastaBilgileri.Controls.Add(labelCinsiyet);
            groupBoxHastaBilgileri.Controls.Add(labelCinsiyetBaslik);
            groupBoxHastaBilgileri.Controls.Add(labelAd);
            groupBoxHastaBilgileri.Controls.Add(labelAdBaslik);
            groupBoxHastaBilgileri.Controls.Add(labelTCKimlikNo);
            groupBoxHastaBilgileri.Controls.Add(labelTCKimlikNoBaslik);
            groupBoxHastaBilgileri.Location = new Point(12, 47);
            groupBoxHastaBilgileri.Name = "groupBoxHastaBilgileri";
            groupBoxHastaBilgileri.Size = new Size(327, 283);
            groupBoxHastaBilgileri.TabIndex = 2;
            groupBoxHastaBilgileri.TabStop = false;
            groupBoxHastaBilgileri.Text = "Hasta Bilgileri";
            // 
            // labelSoyad
            // 
            labelSoyad.BorderStyle = BorderStyle.Fixed3D;
            labelSoyad.Location = new Point(118, 76);
            labelSoyad.Name = "labelSoyad";
            labelSoyad.Size = new Size(150, 21);
            labelSoyad.TabIndex = 33;
            // 
            // labelSoyadBaslik
            // 
            labelSoyadBaslik.AutoSize = true;
            labelSoyadBaslik.Location = new Point(6, 76);
            labelSoyadBaslik.Name = "labelSoyadBaslik";
            labelSoyadBaslik.Size = new Size(56, 21);
            labelSoyadBaslik.TabIndex = 32;
            labelSoyadBaslik.Text = "Soyad:";
            // 
            // labelAdres
            // 
            labelAdres.BorderStyle = BorderStyle.Fixed3D;
            labelAdres.Location = new Point(118, 208);
            labelAdres.Name = "labelAdres";
            labelAdres.Size = new Size(200, 63);
            labelAdres.TabIndex = 31;
            // 
            // labelAdresBaslik
            // 
            labelAdresBaslik.AutoSize = true;
            labelAdresBaslik.Location = new Point(6, 208);
            labelAdresBaslik.Name = "labelAdresBaslik";
            labelAdresBaslik.Size = new Size(53, 21);
            labelAdresBaslik.TabIndex = 30;
            labelAdresBaslik.Text = "Adres:";
            // 
            // labelDogumTarihi
            // 
            labelDogumTarihi.BorderStyle = BorderStyle.Fixed3D;
            labelDogumTarihi.Location = new Point(118, 181);
            labelDogumTarihi.Name = "labelDogumTarihi";
            labelDogumTarihi.Size = new Size(150, 21);
            labelDogumTarihi.TabIndex = 29;
            // 
            // labelDogumTarihiBaslik
            // 
            labelDogumTarihiBaslik.AutoSize = true;
            labelDogumTarihiBaslik.Location = new Point(6, 181);
            labelDogumTarihiBaslik.Name = "labelDogumTarihiBaslik";
            labelDogumTarihiBaslik.Size = new Size(106, 21);
            labelDogumTarihiBaslik.TabIndex = 28;
            labelDogumTarihiBaslik.Text = "Doğum Tarihi:";
            // 
            // labelTelefonNo
            // 
            labelTelefonNo.BorderStyle = BorderStyle.Fixed3D;
            labelTelefonNo.Location = new Point(118, 155);
            labelTelefonNo.Name = "labelTelefonNo";
            labelTelefonNo.Size = new Size(150, 21);
            labelTelefonNo.TabIndex = 25;
            // 
            // labelTelefonNoBaslik
            // 
            labelTelefonNoBaslik.AutoSize = true;
            labelTelefonNoBaslik.Location = new Point(6, 155);
            labelTelefonNoBaslik.Name = "labelTelefonNoBaslik";
            labelTelefonNoBaslik.Size = new Size(87, 21);
            labelTelefonNoBaslik.TabIndex = 24;
            labelTelefonNoBaslik.Text = "Telefon No:";
            // 
            // labelEPosta
            // 
            labelEPosta.BorderStyle = BorderStyle.Fixed3D;
            labelEPosta.Location = new Point(118, 129);
            labelEPosta.Name = "labelEPosta";
            labelEPosta.Size = new Size(150, 21);
            labelEPosta.TabIndex = 23;
            // 
            // labelEPostaBaslik
            // 
            labelEPostaBaslik.AutoSize = true;
            labelEPostaBaslik.Location = new Point(6, 129);
            labelEPostaBaslik.Name = "labelEPostaBaslik";
            labelEPostaBaslik.Size = new Size(64, 21);
            labelEPostaBaslik.TabIndex = 22;
            labelEPostaBaslik.Text = "E-Posta:";
            // 
            // labelCinsiyet
            // 
            labelCinsiyet.BorderStyle = BorderStyle.Fixed3D;
            labelCinsiyet.Location = new Point(118, 102);
            labelCinsiyet.Name = "labelCinsiyet";
            labelCinsiyet.Size = new Size(150, 21);
            labelCinsiyet.TabIndex = 21;
            // 
            // labelCinsiyetBaslik
            // 
            labelCinsiyetBaslik.AutoSize = true;
            labelCinsiyetBaslik.Location = new Point(6, 102);
            labelCinsiyetBaslik.Name = "labelCinsiyetBaslik";
            labelCinsiyetBaslik.Size = new Size(68, 21);
            labelCinsiyetBaslik.TabIndex = 20;
            labelCinsiyetBaslik.Text = "Cinsiyet:";
            // 
            // labelAd
            // 
            labelAd.BorderStyle = BorderStyle.Fixed3D;
            labelAd.Location = new Point(118, 51);
            labelAd.Name = "labelAd";
            labelAd.Size = new Size(150, 21);
            labelAd.TabIndex = 19;
            // 
            // labelAdBaslik
            // 
            labelAdBaslik.AutoSize = true;
            labelAdBaslik.Location = new Point(6, 51);
            labelAdBaslik.Name = "labelAdBaslik";
            labelAdBaslik.Size = new Size(32, 21);
            labelAdBaslik.TabIndex = 18;
            labelAdBaslik.Text = "Ad:";
            // 
            // labelTCKimlikNo
            // 
            labelTCKimlikNo.BorderStyle = BorderStyle.Fixed3D;
            labelTCKimlikNo.Location = new Point(118, 25);
            labelTCKimlikNo.Name = "labelTCKimlikNo";
            labelTCKimlikNo.Size = new Size(150, 21);
            labelTCKimlikNo.TabIndex = 17;
            // 
            // labelTCKimlikNoBaslik
            // 
            labelTCKimlikNoBaslik.AutoSize = true;
            labelTCKimlikNoBaslik.Location = new Point(6, 25);
            labelTCKimlikNoBaslik.Name = "labelTCKimlikNoBaslik";
            labelTCKimlikNoBaslik.Size = new Size(106, 21);
            labelTCKimlikNoBaslik.TabIndex = 16;
            labelTCKimlikNoBaslik.Text = "TC Kimlik No: ";
            // 
            // groupBoxHastaGecmisi
            // 
            groupBoxHastaGecmisi.Controls.Add(buttonGecmisSeansNotuDuzenle);
            groupBoxHastaGecmisi.Controls.Add(textBoxGecmisSeansNotu);
            groupBoxHastaGecmisi.Controls.Add(listBoxSeanslar);
            groupBoxHastaGecmisi.Controls.Add(labelSeanslar2);
            groupBoxHastaGecmisi.Location = new Point(345, 12);
            groupBoxHastaGecmisi.Name = "groupBoxHastaGecmisi";
            groupBoxHastaGecmisi.Size = new Size(355, 318);
            groupBoxHastaGecmisi.TabIndex = 3;
            groupBoxHastaGecmisi.TabStop = false;
            groupBoxHastaGecmisi.Text = "Hasta Geçmişi";
            // 
            // buttonGecmisSeansNotuDuzenle
            // 
            buttonGecmisSeansNotuDuzenle.Location = new Point(6, 281);
            buttonGecmisSeansNotuDuzenle.Name = "buttonGecmisSeansNotuDuzenle";
            buttonGecmisSeansNotuDuzenle.Size = new Size(343, 29);
            buttonGecmisSeansNotuDuzenle.TabIndex = 3;
            buttonGecmisSeansNotuDuzenle.Text = "Düzenle";
            buttonGecmisSeansNotuDuzenle.UseVisualStyleBackColor = true;
            buttonGecmisSeansNotuDuzenle.Click += buttonGecmisSeansNotuDuzenle_Click;
            // 
            // textBoxGecmisSeansNotu
            // 
            textBoxGecmisSeansNotu.Location = new Point(6, 164);
            textBoxGecmisSeansNotu.Multiline = true;
            textBoxGecmisSeansNotu.Name = "textBoxGecmisSeansNotu";
            textBoxGecmisSeansNotu.ScrollBars = ScrollBars.Vertical;
            textBoxGecmisSeansNotu.Size = new Size(343, 111);
            textBoxGecmisSeansNotu.TabIndex = 2;
            // 
            // listBoxSeanslar
            // 
            listBoxSeanslar.FormattingEnabled = true;
            listBoxSeanslar.ItemHeight = 21;
            listBoxSeanslar.Location = new Point(6, 49);
            listBoxSeanslar.Name = "listBoxSeanslar";
            listBoxSeanslar.Size = new Size(343, 109);
            listBoxSeanslar.TabIndex = 1;
            listBoxSeanslar.SelectedIndexChanged += listBoxSeanslar_SelectedIndexChanged;
            // 
            // labelSeanslar2
            // 
            labelSeanslar2.AutoSize = true;
            labelSeanslar2.Location = new Point(138, 25);
            labelSeanslar2.Name = "labelSeanslar2";
            labelSeanslar2.Size = new Size(69, 21);
            labelSeanslar2.TabIndex = 0;
            labelSeanslar2.Text = "Seanslar";
            // 
            // groupBoxSeansNotu
            // 
            groupBoxSeansNotu.Controls.Add(buttonSeansNotuKaydet);
            groupBoxSeansNotu.Controls.Add(textBoxSeansNotu);
            groupBoxSeansNotu.Location = new Point(706, 12);
            groupBoxSeansNotu.Name = "groupBoxSeansNotu";
            groupBoxSeansNotu.Size = new Size(358, 318);
            groupBoxSeansNotu.TabIndex = 4;
            groupBoxSeansNotu.TabStop = false;
            groupBoxSeansNotu.Text = "Seans Notu";
            // 
            // buttonSeansNotuKaydet
            // 
            buttonSeansNotuKaydet.Location = new Point(6, 281);
            buttonSeansNotuKaydet.Name = "buttonSeansNotuKaydet";
            buttonSeansNotuKaydet.Size = new Size(343, 29);
            buttonSeansNotuKaydet.TabIndex = 5;
            buttonSeansNotuKaydet.Text = "Kaydet";
            buttonSeansNotuKaydet.UseVisualStyleBackColor = true;
            buttonSeansNotuKaydet.Click += buttonSeansNotuKaydet_Click;
            // 
            // textBoxSeansNotu
            // 
            textBoxSeansNotu.Location = new Point(6, 28);
            textBoxSeansNotu.Multiline = true;
            textBoxSeansNotu.Name = "textBoxSeansNotu";
            textBoxSeansNotu.ScrollBars = ScrollBars.Vertical;
            textBoxSeansNotu.Size = new Size(343, 247);
            textBoxSeansNotu.TabIndex = 4;
            // 
            // FormUzmanSeansYonetimi
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 343);
            Controls.Add(groupBoxSeansNotu);
            Controls.Add(groupBoxHastaGecmisi);
            Controls.Add(groupBoxHastaBilgileri);
            Controls.Add(comboBoxSeanslar);
            Controls.Add(labelSeanslar);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FormUzmanSeansYonetimi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Seans Yönetimi";
            Load += FormUzmanSeansYonetimi_Load;
            groupBoxHastaBilgileri.ResumeLayout(false);
            groupBoxHastaBilgileri.PerformLayout();
            groupBoxHastaGecmisi.ResumeLayout(false);
            groupBoxHastaGecmisi.PerformLayout();
            groupBoxSeansNotu.ResumeLayout(false);
            groupBoxSeansNotu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSeanslar;
        private ComboBox comboBoxSeanslar;
        private GroupBox groupBoxHastaBilgileri;
        private Label labelAdres;
        private Label labelAdresBaslik;
        private Label labelDogumTarihi;
        private Label labelDogumTarihiBaslik;
        private Label labelTelefonNo;
        private Label labelTelefonNoBaslik;
        private Label labelEPosta;
        private Label labelEPostaBaslik;
        private Label labelCinsiyet;
        private Label labelCinsiyetBaslik;
        private Label labelAd;
        private Label labelAdBaslik;
        private Label labelTCKimlikNo;
        private Label labelTCKimlikNoBaslik;
        private GroupBox groupBoxHastaGecmisi;
        private Button buttonGecmisSeansNotuDuzenle;
        private TextBox textBoxGecmisSeansNotu;
        private ListBox listBoxSeanslar;
        private Label labelSeanslar2;
        private GroupBox groupBoxSeansNotu;
        private Button buttonSeansNotuKaydet;
        private TextBox textBoxSeansNotu;
        private Label labelSoyad;
        private Label labelSoyadBaslik;
    }
}