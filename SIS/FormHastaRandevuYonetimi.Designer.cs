namespace SIS
{
    partial class FormHastaRandevuYonetimi
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
            groupBoxArama = new GroupBox();
            labelAramaAdSoyadBaslik = new Label();
            textBoxAdSoyad = new TextBox();
            buttonAra = new Button();
            labelAyrac = new Label();
            labelHastalar = new Label();
            listBoxHastalar = new ListBox();
            buttonYeniHasta = new Button();
            groupBoxHastaBilgileri = new GroupBox();
            labelTCKimlikNoBaslik = new Label();
            labelTCKimlikNo = new Label();
            labelAdSoyad = new Label();
            labelHastaBilgileriAdSoyadBaslik = new Label();
            labelEPosta = new Label();
            labelEPostaBaslik = new Label();
            labelCinsiyet = new Label();
            labelCinsiyetBaslik = new Label();
            labelAdres = new Label();
            labelAdresBaslik = new Label();
            labelDogumTarihi = new Label();
            labelDogumTarihiBaslik = new Label();
            labelGSMNo = new Label();
            labelGSMNoBaslik = new Label();
            labelTelefonNo = new Label();
            labelTelefonNoBaslik = new Label();
            buttonHastaBilgileriniDuzenle = new Button();
            groupBoxRandevuBilgileri = new GroupBox();
            labelSonRandevuBilgileri = new Label();
            labelSonRandevuUzmanBaslik = new Label();
            labelSonRandevuUzman = new Label();
            labelSonRandevuSeans = new Label();
            labelSonRandevuSeansBaslik = new Label();
            buttonYeniRandevu = new Button();
            buttonIptalEt = new Button();
            labelSonSeansSeans = new Label();
            labelSonSeansSeansBaslik = new Label();
            labelSonSeansUzman = new Label();
            labelSonSeansUzmanBaslik = new Label();
            labelSonSeansBilgileri = new Label();
            labelNot = new Label();
            labelNotBaslik = new Label();
            groupBoxArama.SuspendLayout();
            groupBoxHastaBilgileri.SuspendLayout();
            groupBoxRandevuBilgileri.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxArama
            // 
            groupBoxArama.Controls.Add(buttonYeniHasta);
            groupBoxArama.Controls.Add(listBoxHastalar);
            groupBoxArama.Controls.Add(labelHastalar);
            groupBoxArama.Controls.Add(labelAyrac);
            groupBoxArama.Controls.Add(buttonAra);
            groupBoxArama.Controls.Add(textBoxAdSoyad);
            groupBoxArama.Controls.Add(labelAramaAdSoyadBaslik);
            groupBoxArama.Location = new Point(12, 12);
            groupBoxArama.Name = "groupBoxArama";
            groupBoxArama.Size = new Size(250, 315);
            groupBoxArama.TabIndex = 0;
            groupBoxArama.TabStop = false;
            groupBoxArama.Text = "Arama";
            // 
            // labelAramaAdSoyadBaslik
            // 
            labelAramaAdSoyadBaslik.AutoSize = true;
            labelAramaAdSoyadBaslik.Location = new Point(6, 31);
            labelAramaAdSoyadBaslik.Name = "labelAramaAdSoyadBaslik";
            labelAramaAdSoyadBaslik.Size = new Size(79, 21);
            labelAramaAdSoyadBaslik.TabIndex = 0;
            labelAramaAdSoyadBaslik.Text = "Ad Soyad:";
            // 
            // textBoxAdSoyad
            // 
            textBoxAdSoyad.Location = new Point(91, 28);
            textBoxAdSoyad.Name = "textBoxAdSoyad";
            textBoxAdSoyad.Size = new Size(150, 29);
            textBoxAdSoyad.TabIndex = 1;
            // 
            // buttonAra
            // 
            buttonAra.Location = new Point(6, 63);
            buttonAra.Name = "buttonAra";
            buttonAra.Size = new Size(235, 29);
            buttonAra.TabIndex = 2;
            buttonAra.Text = "Ara";
            buttonAra.UseVisualStyleBackColor = true;
            // 
            // labelAyrac
            // 
            labelAyrac.BorderStyle = BorderStyle.Fixed3D;
            labelAyrac.Location = new Point(6, 105);
            labelAyrac.Name = "labelAyrac";
            labelAyrac.Size = new Size(235, 2);
            labelAyrac.TabIndex = 3;
            // 
            // labelHastalar
            // 
            labelHastalar.AutoSize = true;
            labelHastalar.Location = new Point(91, 115);
            labelHastalar.Name = "labelHastalar";
            labelHastalar.Size = new Size(67, 21);
            labelHastalar.TabIndex = 4;
            labelHastalar.Text = "Hastalar";
            // 
            // listBoxHastalar
            // 
            listBoxHastalar.FormattingEnabled = true;
            listBoxHastalar.ItemHeight = 21;
            listBoxHastalar.Location = new Point(6, 139);
            listBoxHastalar.Name = "listBoxHastalar";
            listBoxHastalar.Size = new Size(235, 130);
            listBoxHastalar.TabIndex = 5;
            // 
            // buttonYeniHasta
            // 
            buttonYeniHasta.Location = new Point(6, 275);
            buttonYeniHasta.Name = "buttonYeniHasta";
            buttonYeniHasta.Size = new Size(235, 29);
            buttonYeniHasta.TabIndex = 6;
            buttonYeniHasta.Text = "Yeni Hasta Ekle";
            buttonYeniHasta.UseVisualStyleBackColor = true;
            // 
            // groupBoxHastaBilgileri
            // 
            groupBoxHastaBilgileri.Controls.Add(buttonHastaBilgileriniDuzenle);
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
            groupBoxHastaBilgileri.Location = new Point(268, 12);
            groupBoxHastaBilgileri.Name = "groupBoxHastaBilgileri";
            groupBoxHastaBilgileri.Size = new Size(330, 315);
            groupBoxHastaBilgileri.TabIndex = 1;
            groupBoxHastaBilgileri.TabStop = false;
            groupBoxHastaBilgileri.Text = "Hasta Bilgileri";
            // 
            // labelTCKimlikNoBaslik
            // 
            labelTCKimlikNoBaslik.AutoSize = true;
            labelTCKimlikNoBaslik.Location = new Point(6, 25);
            labelTCKimlikNoBaslik.Name = "labelTCKimlikNoBaslik";
            labelTCKimlikNoBaslik.Size = new Size(106, 21);
            labelTCKimlikNoBaslik.TabIndex = 0;
            labelTCKimlikNoBaslik.Text = "TC Kimlik No: ";
            // 
            // labelTCKimlikNo
            // 
            labelTCKimlikNo.BorderStyle = BorderStyle.Fixed3D;
            labelTCKimlikNo.Location = new Point(118, 25);
            labelTCKimlikNo.Name = "labelTCKimlikNo";
            labelTCKimlikNo.Size = new Size(150, 21);
            labelTCKimlikNo.TabIndex = 1;
            // 
            // labelAdSoyad
            // 
            labelAdSoyad.BorderStyle = BorderStyle.Fixed3D;
            labelAdSoyad.Location = new Point(118, 51);
            labelAdSoyad.Name = "labelAdSoyad";
            labelAdSoyad.Size = new Size(150, 21);
            labelAdSoyad.TabIndex = 3;
            // 
            // labelHastaBilgileriAdSoyadBaslik
            // 
            labelHastaBilgileriAdSoyadBaslik.AutoSize = true;
            labelHastaBilgileriAdSoyadBaslik.Location = new Point(6, 51);
            labelHastaBilgileriAdSoyadBaslik.Name = "labelHastaBilgileriAdSoyadBaslik";
            labelHastaBilgileriAdSoyadBaslik.Size = new Size(79, 21);
            labelHastaBilgileriAdSoyadBaslik.TabIndex = 2;
            labelHastaBilgileriAdSoyadBaslik.Text = "Ad Soyad:";
            // 
            // labelEPosta
            // 
            labelEPosta.BorderStyle = BorderStyle.Fixed3D;
            labelEPosta.Location = new Point(118, 104);
            labelEPosta.Name = "labelEPosta";
            labelEPosta.Size = new Size(150, 21);
            labelEPosta.TabIndex = 7;
            // 
            // labelEPostaBaslik
            // 
            labelEPostaBaslik.AutoSize = true;
            labelEPostaBaslik.Location = new Point(6, 104);
            labelEPostaBaslik.Name = "labelEPostaBaslik";
            labelEPostaBaslik.Size = new Size(64, 21);
            labelEPostaBaslik.TabIndex = 6;
            labelEPostaBaslik.Text = "E-Posta:";
            // 
            // labelCinsiyet
            // 
            labelCinsiyet.BorderStyle = BorderStyle.Fixed3D;
            labelCinsiyet.Location = new Point(118, 77);
            labelCinsiyet.Name = "labelCinsiyet";
            labelCinsiyet.Size = new Size(150, 21);
            labelCinsiyet.TabIndex = 5;
            // 
            // labelCinsiyetBaslik
            // 
            labelCinsiyetBaslik.AutoSize = true;
            labelCinsiyetBaslik.Location = new Point(6, 77);
            labelCinsiyetBaslik.Name = "labelCinsiyetBaslik";
            labelCinsiyetBaslik.Size = new Size(68, 21);
            labelCinsiyetBaslik.TabIndex = 4;
            labelCinsiyetBaslik.Text = "Cinsiyet:";
            // 
            // labelAdres
            // 
            labelAdres.BorderStyle = BorderStyle.Fixed3D;
            labelAdres.Location = new Point(118, 209);
            labelAdres.Name = "labelAdres";
            labelAdres.Size = new Size(200, 63);
            labelAdres.TabIndex = 15;
            // 
            // labelAdresBaslik
            // 
            labelAdresBaslik.AutoSize = true;
            labelAdresBaslik.Location = new Point(6, 209);
            labelAdresBaslik.Name = "labelAdresBaslik";
            labelAdresBaslik.Size = new Size(53, 21);
            labelAdresBaslik.TabIndex = 14;
            labelAdresBaslik.Text = "Adres:";
            // 
            // labelDogumTarihi
            // 
            labelDogumTarihi.BorderStyle = BorderStyle.Fixed3D;
            labelDogumTarihi.Location = new Point(118, 182);
            labelDogumTarihi.Name = "labelDogumTarihi";
            labelDogumTarihi.Size = new Size(150, 21);
            labelDogumTarihi.TabIndex = 13;
            // 
            // labelDogumTarihiBaslik
            // 
            labelDogumTarihiBaslik.AutoSize = true;
            labelDogumTarihiBaslik.Location = new Point(6, 182);
            labelDogumTarihiBaslik.Name = "labelDogumTarihiBaslik";
            labelDogumTarihiBaslik.Size = new Size(106, 21);
            labelDogumTarihiBaslik.TabIndex = 12;
            labelDogumTarihiBaslik.Text = "Doğum Tarihi:";
            // 
            // labelGSMNo
            // 
            labelGSMNo.BorderStyle = BorderStyle.Fixed3D;
            labelGSMNo.Location = new Point(118, 156);
            labelGSMNo.Name = "labelGSMNo";
            labelGSMNo.Size = new Size(150, 21);
            labelGSMNo.TabIndex = 11;
            // 
            // labelGSMNoBaslik
            // 
            labelGSMNoBaslik.AutoSize = true;
            labelGSMNoBaslik.Location = new Point(6, 156);
            labelGSMNoBaslik.Name = "labelGSMNoBaslik";
            labelGSMNoBaslik.Size = new Size(72, 21);
            labelGSMNoBaslik.TabIndex = 10;
            labelGSMNoBaslik.Text = "GSM No:";
            // 
            // labelTelefonNo
            // 
            labelTelefonNo.BorderStyle = BorderStyle.Fixed3D;
            labelTelefonNo.Location = new Point(118, 130);
            labelTelefonNo.Name = "labelTelefonNo";
            labelTelefonNo.Size = new Size(150, 21);
            labelTelefonNo.TabIndex = 9;
            // 
            // labelTelefonNoBaslik
            // 
            labelTelefonNoBaslik.AutoSize = true;
            labelTelefonNoBaslik.Location = new Point(6, 130);
            labelTelefonNoBaslik.Name = "labelTelefonNoBaslik";
            labelTelefonNoBaslik.Size = new Size(87, 21);
            labelTelefonNoBaslik.TabIndex = 8;
            labelTelefonNoBaslik.Text = "Telefon No:";
            // 
            // buttonHastaBilgileriniDuzenle
            // 
            buttonHastaBilgileriniDuzenle.Location = new Point(6, 280);
            buttonHastaBilgileriniDuzenle.Name = "buttonHastaBilgileriniDuzenle";
            buttonHastaBilgileriniDuzenle.Size = new Size(312, 29);
            buttonHastaBilgileriniDuzenle.TabIndex = 16;
            buttonHastaBilgileriniDuzenle.Text = "Hasta Bilgilerini Duzenle";
            buttonHastaBilgileriniDuzenle.UseVisualStyleBackColor = true;
            // 
            // groupBoxRandevuBilgileri
            // 
            groupBoxRandevuBilgileri.Controls.Add(labelNot);
            groupBoxRandevuBilgileri.Controls.Add(labelNotBaslik);
            groupBoxRandevuBilgileri.Controls.Add(labelSonSeansSeans);
            groupBoxRandevuBilgileri.Controls.Add(labelSonSeansSeansBaslik);
            groupBoxRandevuBilgileri.Controls.Add(labelSonSeansUzman);
            groupBoxRandevuBilgileri.Controls.Add(labelSonSeansUzmanBaslik);
            groupBoxRandevuBilgileri.Controls.Add(labelSonSeansBilgileri);
            groupBoxRandevuBilgileri.Controls.Add(buttonIptalEt);
            groupBoxRandevuBilgileri.Controls.Add(buttonYeniRandevu);
            groupBoxRandevuBilgileri.Controls.Add(labelSonRandevuSeans);
            groupBoxRandevuBilgileri.Controls.Add(labelSonRandevuSeansBaslik);
            groupBoxRandevuBilgileri.Controls.Add(labelSonRandevuUzman);
            groupBoxRandevuBilgileri.Controls.Add(labelSonRandevuUzmanBaslik);
            groupBoxRandevuBilgileri.Controls.Add(labelSonRandevuBilgileri);
            groupBoxRandevuBilgileri.Location = new Point(604, 19);
            groupBoxRandevuBilgileri.Name = "groupBoxRandevuBilgileri";
            groupBoxRandevuBilgileri.Size = new Size(294, 308);
            groupBoxRandevuBilgileri.TabIndex = 2;
            groupBoxRandevuBilgileri.TabStop = false;
            groupBoxRandevuBilgileri.Text = "Randevu Bilgileri";
            // 
            // labelSonRandevuBilgileri
            // 
            labelSonRandevuBilgileri.AutoSize = true;
            labelSonRandevuBilgileri.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            labelSonRandevuBilgileri.Location = new Point(6, 25);
            labelSonRandevuBilgileri.Name = "labelSonRandevuBilgileri";
            labelSonRandevuBilgileri.Size = new Size(174, 21);
            labelSonRandevuBilgileri.TabIndex = 0;
            labelSonRandevuBilgileri.Text = "Son Randevu Bilgileri";
            // 
            // labelSonRandevuUzmanBaslik
            // 
            labelSonRandevuUzmanBaslik.AutoSize = true;
            labelSonRandevuUzmanBaslik.Location = new Point(16, 51);
            labelSonRandevuUzmanBaslik.Name = "labelSonRandevuUzmanBaslik";
            labelSonRandevuUzmanBaslik.Size = new Size(62, 21);
            labelSonRandevuUzmanBaslik.TabIndex = 1;
            labelSonRandevuUzmanBaslik.Text = "Uzman:";
            // 
            // labelSonRandevuUzman
            // 
            labelSonRandevuUzman.BorderStyle = BorderStyle.Fixed3D;
            labelSonRandevuUzman.Location = new Point(84, 51);
            labelSonRandevuUzman.Name = "labelSonRandevuUzman";
            labelSonRandevuUzman.Size = new Size(150, 21);
            labelSonRandevuUzman.TabIndex = 17;
            // 
            // labelSonRandevuSeans
            // 
            labelSonRandevuSeans.BorderStyle = BorderStyle.Fixed3D;
            labelSonRandevuSeans.Location = new Point(84, 77);
            labelSonRandevuSeans.Name = "labelSonRandevuSeans";
            labelSonRandevuSeans.Size = new Size(150, 21);
            labelSonRandevuSeans.TabIndex = 19;
            // 
            // labelSonRandevuSeansBaslik
            // 
            labelSonRandevuSeansBaslik.AutoSize = true;
            labelSonRandevuSeansBaslik.Location = new Point(16, 77);
            labelSonRandevuSeansBaslik.Name = "labelSonRandevuSeansBaslik";
            labelSonRandevuSeansBaslik.Size = new Size(54, 21);
            labelSonRandevuSeansBaslik.TabIndex = 18;
            labelSonRandevuSeansBaslik.Text = "Seans:";
            // 
            // buttonYeniRandevu
            // 
            buttonYeniRandevu.Location = new Point(6, 106);
            buttonYeniRandevu.Name = "buttonYeniRandevu";
            buttonYeniRandevu.Size = new Size(112, 29);
            buttonYeniRandevu.TabIndex = 20;
            buttonYeniRandevu.Text = "Yeni Randevu";
            buttonYeniRandevu.UseVisualStyleBackColor = true;
            // 
            // buttonIptalEt
            // 
            buttonIptalEt.Location = new Point(122, 106);
            buttonIptalEt.Name = "buttonIptalEt";
            buttonIptalEt.Size = new Size(112, 29);
            buttonIptalEt.TabIndex = 21;
            buttonIptalEt.Text = "İptal Et";
            buttonIptalEt.UseVisualStyleBackColor = true;
            // 
            // labelSonSeansSeans
            // 
            labelSonSeansSeans.BorderStyle = BorderStyle.Fixed3D;
            labelSonSeansSeans.Location = new Point(84, 210);
            labelSonSeansSeans.Name = "labelSonSeansSeans";
            labelSonSeansSeans.Size = new Size(150, 21);
            labelSonSeansSeans.TabIndex = 26;
            // 
            // labelSonSeansSeansBaslik
            // 
            labelSonSeansSeansBaslik.AutoSize = true;
            labelSonSeansSeansBaslik.Location = new Point(16, 210);
            labelSonSeansSeansBaslik.Name = "labelSonSeansSeansBaslik";
            labelSonSeansSeansBaslik.Size = new Size(54, 21);
            labelSonSeansSeansBaslik.TabIndex = 25;
            labelSonSeansSeansBaslik.Text = "Seans:";
            // 
            // labelSonSeansUzman
            // 
            labelSonSeansUzman.BorderStyle = BorderStyle.Fixed3D;
            labelSonSeansUzman.Location = new Point(84, 184);
            labelSonSeansUzman.Name = "labelSonSeansUzman";
            labelSonSeansUzman.Size = new Size(150, 21);
            labelSonSeansUzman.TabIndex = 24;
            // 
            // labelSonSeansUzmanBaslik
            // 
            labelSonSeansUzmanBaslik.AutoSize = true;
            labelSonSeansUzmanBaslik.Location = new Point(16, 184);
            labelSonSeansUzmanBaslik.Name = "labelSonSeansUzmanBaslik";
            labelSonSeansUzmanBaslik.Size = new Size(62, 21);
            labelSonSeansUzmanBaslik.TabIndex = 23;
            labelSonSeansUzmanBaslik.Text = "Uzman:";
            // 
            // labelSonSeansBilgileri
            // 
            labelSonSeansBilgileri.AutoSize = true;
            labelSonSeansBilgileri.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            labelSonSeansBilgileri.Location = new Point(6, 158);
            labelSonSeansBilgileri.Name = "labelSonSeansBilgileri";
            labelSonSeansBilgileri.Size = new Size(151, 21);
            labelSonSeansBilgileri.TabIndex = 22;
            labelSonSeansBilgileri.Text = "Son Seans Bilgileri";
            // 
            // labelNot
            // 
            labelNot.BorderStyle = BorderStyle.Fixed3D;
            labelNot.Location = new Point(84, 236);
            labelNot.Name = "labelNot";
            labelNot.Size = new Size(200, 63);
            labelNot.TabIndex = 18;
            // 
            // labelNotBaslik
            // 
            labelNotBaslik.AutoSize = true;
            labelNotBaslik.Location = new Point(17, 237);
            labelNotBaslik.Name = "labelNotBaslik";
            labelNotBaslik.Size = new Size(39, 21);
            labelNotBaslik.TabIndex = 17;
            labelNotBaslik.Text = "Not:";
            // 
            // FormHastaRandevuYonetimi
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 334);
            Controls.Add(groupBoxRandevuBilgileri);
            Controls.Add(groupBoxHastaBilgileri);
            Controls.Add(groupBoxArama);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            Name = "FormHastaRandevuYonetimi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hasta ve Randevu Yönetimi";
            groupBoxArama.ResumeLayout(false);
            groupBoxArama.PerformLayout();
            groupBoxHastaBilgileri.ResumeLayout(false);
            groupBoxHastaBilgileri.PerformLayout();
            groupBoxRandevuBilgileri.ResumeLayout(false);
            groupBoxRandevuBilgileri.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxArama;
        private Label labelHastalar;
        private Label labelAyrac;
        private Button buttonAra;
        private TextBox textBoxAdSoyad;
        private Label labelAramaAdSoyadBaslik;
        private Button buttonYeniHasta;
        private ListBox listBoxHastalar;
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
        private Button buttonHastaBilgileriniDuzenle;
        private GroupBox groupBoxRandevuBilgileri;
        private Button buttonIptalEt;
        private Button buttonYeniRandevu;
        private Label labelSonRandevuSeans;
        private Label labelSonRandevuSeansBaslik;
        private Label labelSonRandevuUzman;
        private Label labelSonRandevuUzmanBaslik;
        private Label labelSonRandevuBilgileri;
        private Label labelSonSeansSeans;
        private Label labelSonSeansSeansBaslik;
        private Label labelSonSeansUzman;
        private Label labelSonSeansUzmanBaslik;
        private Label labelSonSeansBilgileri;
        private Label labelNot;
        private Label labelNotBaslik;
    }
}