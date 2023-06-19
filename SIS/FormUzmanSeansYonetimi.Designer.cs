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
            comboBox1 = new ComboBox();
            groupBoxHastaBilgileri = new GroupBox();
            labelAdres = new Label();
            labelAdresBaslik = new Label();
            labelDogumTarihi = new Label();
            labelDogumTarihiBaslik = new Label();
            labelGSMNo = new Label();
            labelGSMNoBaslik = new Label();
            labelTelefonNo = new Label();
            labelTelefonNoBaslik = new Label();
            labelEPosta = new Label();
            labelEPostaBaslik = new Label();
            labelCinsiyet = new Label();
            labelCinsiyetBaslik = new Label();
            labelAdSoyad = new Label();
            labelHastaBilgileriAdSoyadBaslik = new Label();
            labelTCKimlikNo = new Label();
            labelTCKimlikNoBaslik = new Label();
            groupBoxHastaGecmisi = new GroupBox();
            labelSeanslar2 = new Label();
            listBoxSeanslar = new ListBox();
            textBoxGecmisSeansNotu = new TextBox();
            buttonGecmisSeansNotuDuzenle = new Button();
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
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(90, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(249, 29);
            comboBox1.TabIndex = 1;
            // 
            // groupBoxHastaBilgileri
            // 
            groupBoxHastaBilgileri.Controls.Add(labelAdres);
            groupBoxHastaBilgileri.Controls.Add(labelAdresBaslik);
            groupBoxHastaBilgileri.Controls.Add(labelDogumTarihi);
            groupBoxHastaBilgileri.Controls.Add(labelDogumTarihiBaslik);
            groupBoxHastaBilgileri.Controls.Add(labelGSMNo);
            groupBoxHastaBilgileri.Controls.Add(labelGSMNoBaslik);
            groupBoxHastaBilgileri.Controls.Add(labelTelefonNo);
            groupBoxHastaBilgileri.Controls.Add(labelTelefonNoBaslik);
            groupBoxHastaBilgileri.Controls.Add(labelEPosta);
            groupBoxHastaBilgileri.Controls.Add(labelEPostaBaslik);
            groupBoxHastaBilgileri.Controls.Add(labelCinsiyet);
            groupBoxHastaBilgileri.Controls.Add(labelCinsiyetBaslik);
            groupBoxHastaBilgileri.Controls.Add(labelAdSoyad);
            groupBoxHastaBilgileri.Controls.Add(labelHastaBilgileriAdSoyadBaslik);
            groupBoxHastaBilgileri.Controls.Add(labelTCKimlikNo);
            groupBoxHastaBilgileri.Controls.Add(labelTCKimlikNoBaslik);
            groupBoxHastaBilgileri.Location = new Point(12, 47);
            groupBoxHastaBilgileri.Name = "groupBoxHastaBilgileri";
            groupBoxHastaBilgileri.Size = new Size(327, 281);
            groupBoxHastaBilgileri.TabIndex = 2;
            groupBoxHastaBilgileri.TabStop = false;
            groupBoxHastaBilgileri.Text = "Hasta Bilgileri";
            // 
            // labelAdres
            // 
            labelAdres.BorderStyle = BorderStyle.Fixed3D;
            labelAdres.Location = new Point(118, 209);
            labelAdres.Name = "labelAdres";
            labelAdres.Size = new Size(200, 63);
            labelAdres.TabIndex = 31;
            // 
            // labelAdresBaslik
            // 
            labelAdresBaslik.AutoSize = true;
            labelAdresBaslik.Location = new Point(6, 209);
            labelAdresBaslik.Name = "labelAdresBaslik";
            labelAdresBaslik.Size = new Size(53, 21);
            labelAdresBaslik.TabIndex = 30;
            labelAdresBaslik.Text = "Adres:";
            // 
            // labelDogumTarihi
            // 
            labelDogumTarihi.BorderStyle = BorderStyle.Fixed3D;
            labelDogumTarihi.Location = new Point(118, 182);
            labelDogumTarihi.Name = "labelDogumTarihi";
            labelDogumTarihi.Size = new Size(150, 21);
            labelDogumTarihi.TabIndex = 29;
            // 
            // labelDogumTarihiBaslik
            // 
            labelDogumTarihiBaslik.AutoSize = true;
            labelDogumTarihiBaslik.Location = new Point(6, 182);
            labelDogumTarihiBaslik.Name = "labelDogumTarihiBaslik";
            labelDogumTarihiBaslik.Size = new Size(106, 21);
            labelDogumTarihiBaslik.TabIndex = 28;
            labelDogumTarihiBaslik.Text = "Doğum Tarihi:";
            // 
            // labelGSMNo
            // 
            labelGSMNo.BorderStyle = BorderStyle.Fixed3D;
            labelGSMNo.Location = new Point(118, 156);
            labelGSMNo.Name = "labelGSMNo";
            labelGSMNo.Size = new Size(150, 21);
            labelGSMNo.TabIndex = 27;
            // 
            // labelGSMNoBaslik
            // 
            labelGSMNoBaslik.AutoSize = true;
            labelGSMNoBaslik.Location = new Point(6, 156);
            labelGSMNoBaslik.Name = "labelGSMNoBaslik";
            labelGSMNoBaslik.Size = new Size(72, 21);
            labelGSMNoBaslik.TabIndex = 26;
            labelGSMNoBaslik.Text = "GSM No:";
            // 
            // labelTelefonNo
            // 
            labelTelefonNo.BorderStyle = BorderStyle.Fixed3D;
            labelTelefonNo.Location = new Point(118, 130);
            labelTelefonNo.Name = "labelTelefonNo";
            labelTelefonNo.Size = new Size(150, 21);
            labelTelefonNo.TabIndex = 25;
            // 
            // labelTelefonNoBaslik
            // 
            labelTelefonNoBaslik.AutoSize = true;
            labelTelefonNoBaslik.Location = new Point(6, 130);
            labelTelefonNoBaslik.Name = "labelTelefonNoBaslik";
            labelTelefonNoBaslik.Size = new Size(87, 21);
            labelTelefonNoBaslik.TabIndex = 24;
            labelTelefonNoBaslik.Text = "Telefon No:";
            // 
            // labelEPosta
            // 
            labelEPosta.BorderStyle = BorderStyle.Fixed3D;
            labelEPosta.Location = new Point(118, 104);
            labelEPosta.Name = "labelEPosta";
            labelEPosta.Size = new Size(150, 21);
            labelEPosta.TabIndex = 23;
            // 
            // labelEPostaBaslik
            // 
            labelEPostaBaslik.AutoSize = true;
            labelEPostaBaslik.Location = new Point(6, 104);
            labelEPostaBaslik.Name = "labelEPostaBaslik";
            labelEPostaBaslik.Size = new Size(64, 21);
            labelEPostaBaslik.TabIndex = 22;
            labelEPostaBaslik.Text = "E-Posta:";
            // 
            // labelCinsiyet
            // 
            labelCinsiyet.BorderStyle = BorderStyle.Fixed3D;
            labelCinsiyet.Location = new Point(118, 77);
            labelCinsiyet.Name = "labelCinsiyet";
            labelCinsiyet.Size = new Size(150, 21);
            labelCinsiyet.TabIndex = 21;
            // 
            // labelCinsiyetBaslik
            // 
            labelCinsiyetBaslik.AutoSize = true;
            labelCinsiyetBaslik.Location = new Point(6, 77);
            labelCinsiyetBaslik.Name = "labelCinsiyetBaslik";
            labelCinsiyetBaslik.Size = new Size(68, 21);
            labelCinsiyetBaslik.TabIndex = 20;
            labelCinsiyetBaslik.Text = "Cinsiyet:";
            // 
            // labelAdSoyad
            // 
            labelAdSoyad.BorderStyle = BorderStyle.Fixed3D;
            labelAdSoyad.Location = new Point(118, 51);
            labelAdSoyad.Name = "labelAdSoyad";
            labelAdSoyad.Size = new Size(150, 21);
            labelAdSoyad.TabIndex = 19;
            // 
            // labelHastaBilgileriAdSoyadBaslik
            // 
            labelHastaBilgileriAdSoyadBaslik.AutoSize = true;
            labelHastaBilgileriAdSoyadBaslik.Location = new Point(6, 51);
            labelHastaBilgileriAdSoyadBaslik.Name = "labelHastaBilgileriAdSoyadBaslik";
            labelHastaBilgileriAdSoyadBaslik.Size = new Size(79, 21);
            labelHastaBilgileriAdSoyadBaslik.TabIndex = 18;
            labelHastaBilgileriAdSoyadBaslik.Text = "Ad Soyad:";
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
            groupBoxHastaGecmisi.Size = new Size(355, 316);
            groupBoxHastaGecmisi.TabIndex = 3;
            groupBoxHastaGecmisi.TabStop = false;
            groupBoxHastaGecmisi.Text = "Hasta Geçmişi";
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
            // listBoxSeanslar
            // 
            listBoxSeanslar.FormattingEnabled = true;
            listBoxSeanslar.ItemHeight = 21;
            listBoxSeanslar.Location = new Point(6, 49);
            listBoxSeanslar.Name = "listBoxSeanslar";
            listBoxSeanslar.Size = new Size(343, 109);
            listBoxSeanslar.TabIndex = 1;
            // 
            // textBoxGecmisSeansNotu
            // 
            textBoxGecmisSeansNotu.Location = new Point(6, 165);
            textBoxGecmisSeansNotu.Multiline = true;
            textBoxGecmisSeansNotu.Name = "textBoxGecmisSeansNotu";
            textBoxGecmisSeansNotu.ScrollBars = ScrollBars.Vertical;
            textBoxGecmisSeansNotu.Size = new Size(343, 111);
            textBoxGecmisSeansNotu.TabIndex = 2;
            // 
            // buttonGecmisSeansNotuDuzenle
            // 
            buttonGecmisSeansNotuDuzenle.Location = new Point(6, 282);
            buttonGecmisSeansNotuDuzenle.Name = "buttonGecmisSeansNotuDuzenle";
            buttonGecmisSeansNotuDuzenle.Size = new Size(343, 29);
            buttonGecmisSeansNotuDuzenle.TabIndex = 3;
            buttonGecmisSeansNotuDuzenle.Text = "Düzenle";
            buttonGecmisSeansNotuDuzenle.UseVisualStyleBackColor = true;
            // 
            // groupBoxSeansNotu
            // 
            groupBoxSeansNotu.Controls.Add(buttonSeansNotuKaydet);
            groupBoxSeansNotu.Controls.Add(textBoxSeansNotu);
            groupBoxSeansNotu.Location = new Point(706, 12);
            groupBoxSeansNotu.Name = "groupBoxSeansNotu";
            groupBoxSeansNotu.Size = new Size(358, 316);
            groupBoxSeansNotu.TabIndex = 4;
            groupBoxSeansNotu.TabStop = false;
            groupBoxSeansNotu.Text = "Seans Notu";
            // 
            // buttonSeansNotuKaydet
            // 
            buttonSeansNotuKaydet.Location = new Point(6, 282);
            buttonSeansNotuKaydet.Name = "buttonSeansNotuKaydet";
            buttonSeansNotuKaydet.Size = new Size(343, 29);
            buttonSeansNotuKaydet.TabIndex = 5;
            buttonSeansNotuKaydet.Text = "Kaydet";
            buttonSeansNotuKaydet.UseVisualStyleBackColor = true;
            // 
            // textBoxSeansNotu
            // 
            textBoxSeansNotu.Location = new Point(6, 28);
            textBoxSeansNotu.Multiline = true;
            textBoxSeansNotu.Name = "textBoxSeansNotu";
            textBoxSeansNotu.ScrollBars = ScrollBars.Vertical;
            textBoxSeansNotu.Size = new Size(343, 248);
            textBoxSeansNotu.TabIndex = 4;
            // 
            // FormUzmanSeansYonetimi
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 334);
            Controls.Add(groupBoxSeansNotu);
            Controls.Add(groupBoxHastaGecmisi);
            Controls.Add(groupBoxHastaBilgileri);
            Controls.Add(comboBox1);
            Controls.Add(labelSeanslar);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            Name = "FormUzmanSeansYonetimi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormUzmanSeansYonetimi";
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
        private ComboBox comboBox1;
        private GroupBox groupBoxHastaBilgileri;
        private Label labelAdres;
        private Label labelAdresBaslik;
        private Label labelDogumTarihi;
        private Label labelDogumTarihiBaslik;
        private Label labelGSMNo;
        private Label labelGSMNoBaslik;
        private Label labelTelefonNo;
        private Label labelTelefonNoBaslik;
        private Label labelEPosta;
        private Label labelEPostaBaslik;
        private Label labelCinsiyet;
        private Label labelCinsiyetBaslik;
        private Label labelAdSoyad;
        private Label labelHastaBilgileriAdSoyadBaslik;
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
    }
}