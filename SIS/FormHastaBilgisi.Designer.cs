﻿namespace SIS
{
    partial class FormHastaBilgisi
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
            textBoxGSMNo = new TextBox();
            labelGSMNo = new Label();
            textBoxTelefonNo = new TextBox();
            labelTelefonNo = new Label();
            textBoxEPosta = new TextBox();
            labelEPosta = new Label();
            textBoxAdSoyad = new TextBox();
            labelAdSoyad = new Label();
            textBoxTCKimlikNo = new TextBox();
            labelTCKimlikNo = new Label();
            textBoxAdres = new TextBox();
            labelAdres = new Label();
            labelCinsiyet = new Label();
            labelDogumTarihi = new Label();
            comboBoxCinsiyet = new ComboBox();
            dateTimePickerDogumTarihi = new DateTimePicker();
            SuspendLayout();
            // 
            // buttonKaydet
            // 
            buttonKaydet.Location = new Point(12, 324);
            buttonKaydet.Name = "buttonKaydet";
            buttonKaydet.Size = new Size(312, 29);
            buttonKaydet.TabIndex = 37;
            buttonKaydet.Text = "Kaydet";
            buttonKaydet.UseVisualStyleBackColor = true;
            // 
            // textBoxGSMNo
            // 
            textBoxGSMNo.Location = new Point(124, 222);
            textBoxGSMNo.Name = "textBoxGSMNo";
            textBoxGSMNo.Size = new Size(150, 29);
            textBoxGSMNo.TabIndex = 36;
            // 
            // labelGSMNo
            // 
            labelGSMNo.AutoSize = true;
            labelGSMNo.Location = new Point(12, 225);
            labelGSMNo.Name = "labelGSMNo";
            labelGSMNo.Size = new Size(72, 21);
            labelGSMNo.TabIndex = 35;
            labelGSMNo.Text = "GSM No:";
            // 
            // textBoxTelefonNo
            // 
            textBoxTelefonNo.Location = new Point(124, 187);
            textBoxTelefonNo.Name = "textBoxTelefonNo";
            textBoxTelefonNo.Size = new Size(150, 29);
            textBoxTelefonNo.TabIndex = 34;
            // 
            // labelTelefonNo
            // 
            labelTelefonNo.AutoSize = true;
            labelTelefonNo.Location = new Point(12, 190);
            labelTelefonNo.Name = "labelTelefonNo";
            labelTelefonNo.Size = new Size(87, 21);
            labelTelefonNo.TabIndex = 33;
            labelTelefonNo.Text = "Telefon No:";
            // 
            // textBoxEPosta
            // 
            textBoxEPosta.Location = new Point(124, 152);
            textBoxEPosta.Name = "textBoxEPosta";
            textBoxEPosta.Size = new Size(150, 29);
            textBoxEPosta.TabIndex = 32;
            // 
            // labelEPosta
            // 
            labelEPosta.AutoSize = true;
            labelEPosta.Location = new Point(12, 155);
            labelEPosta.Name = "labelEPosta";
            labelEPosta.Size = new Size(64, 21);
            labelEPosta.TabIndex = 31;
            labelEPosta.Text = "E-Posta:";
            // 
            // textBoxAdSoyad
            // 
            textBoxAdSoyad.Location = new Point(124, 47);
            textBoxAdSoyad.Name = "textBoxAdSoyad";
            textBoxAdSoyad.Size = new Size(150, 29);
            textBoxAdSoyad.TabIndex = 30;
            // 
            // labelAdSoyad
            // 
            labelAdSoyad.AutoSize = true;
            labelAdSoyad.Location = new Point(12, 50);
            labelAdSoyad.Name = "labelAdSoyad";
            labelAdSoyad.Size = new Size(79, 21);
            labelAdSoyad.TabIndex = 29;
            labelAdSoyad.Text = "Ad Soyad:";
            // 
            // textBoxTCKimlikNo
            // 
            textBoxTCKimlikNo.Location = new Point(124, 12);
            textBoxTCKimlikNo.Name = "textBoxTCKimlikNo";
            textBoxTCKimlikNo.Size = new Size(150, 29);
            textBoxTCKimlikNo.TabIndex = 28;
            // 
            // labelTCKimlikNo
            // 
            labelTCKimlikNo.AutoSize = true;
            labelTCKimlikNo.Location = new Point(12, 15);
            labelTCKimlikNo.Name = "labelTCKimlikNo";
            labelTCKimlikNo.Size = new Size(102, 21);
            labelTCKimlikNo.TabIndex = 27;
            labelTCKimlikNo.Text = "TC Kimlik No:";
            // 
            // textBoxAdres
            // 
            textBoxAdres.Location = new Point(124, 260);
            textBoxAdres.Multiline = true;
            textBoxAdres.Name = "textBoxAdres";
            textBoxAdres.Size = new Size(200, 58);
            textBoxAdres.TabIndex = 39;
            // 
            // labelAdres
            // 
            labelAdres.AutoSize = true;
            labelAdres.Location = new Point(12, 260);
            labelAdres.Name = "labelAdres";
            labelAdres.Size = new Size(53, 21);
            labelAdres.TabIndex = 38;
            labelAdres.Text = "Adres:";
            // 
            // labelCinsiyet
            // 
            labelCinsiyet.AutoSize = true;
            labelCinsiyet.Location = new Point(12, 120);
            labelCinsiyet.Name = "labelCinsiyet";
            labelCinsiyet.Size = new Size(68, 21);
            labelCinsiyet.TabIndex = 42;
            labelCinsiyet.Text = "Cinsiyet:";
            // 
            // labelDogumTarihi
            // 
            labelDogumTarihi.AutoSize = true;
            labelDogumTarihi.Location = new Point(12, 85);
            labelDogumTarihi.Name = "labelDogumTarihi";
            labelDogumTarihi.Size = new Size(106, 21);
            labelDogumTarihi.TabIndex = 40;
            labelDogumTarihi.Text = "Doğum Tarihi:";
            // 
            // comboBoxCinsiyet
            // 
            comboBoxCinsiyet.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCinsiyet.FormattingEnabled = true;
            comboBoxCinsiyet.Items.AddRange(new object[] { "Erkek", "Kadın" });
            comboBoxCinsiyet.Location = new Point(124, 117);
            comboBoxCinsiyet.Name = "comboBoxCinsiyet";
            comboBoxCinsiyet.Size = new Size(150, 29);
            comboBoxCinsiyet.TabIndex = 44;
            // 
            // dateTimePickerDogumTarihi
            // 
            dateTimePickerDogumTarihi.Format = DateTimePickerFormat.Short;
            dateTimePickerDogumTarihi.Location = new Point(124, 82);
            dateTimePickerDogumTarihi.Name = "dateTimePickerDogumTarihi";
            dateTimePickerDogumTarihi.Size = new Size(150, 29);
            dateTimePickerDogumTarihi.TabIndex = 45;
            // 
            // FormHastaBilgisi
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 367);
            Controls.Add(dateTimePickerDogumTarihi);
            Controls.Add(comboBoxCinsiyet);
            Controls.Add(labelCinsiyet);
            Controls.Add(labelDogumTarihi);
            Controls.Add(textBoxAdres);
            Controls.Add(labelAdres);
            Controls.Add(buttonKaydet);
            Controls.Add(textBoxGSMNo);
            Controls.Add(labelGSMNo);
            Controls.Add(textBoxTelefonNo);
            Controls.Add(labelTelefonNo);
            Controls.Add(textBoxEPosta);
            Controls.Add(labelEPosta);
            Controls.Add(textBoxAdSoyad);
            Controls.Add(labelAdSoyad);
            Controls.Add(textBoxTCKimlikNo);
            Controls.Add(labelTCKimlikNo);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            Name = "FormHastaBilgisi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hasta Bilgisi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonKaydet;
        private TextBox textBoxGSMNo;
        private Label labelGSMNo;
        private TextBox textBoxTelefonNo;
        private Label labelTelefonNo;
        private TextBox textBoxEPosta;
        private Label labelEPosta;
        private TextBox textBoxAdSoyad;
        private Label labelAdSoyad;
        private TextBox textBoxTCKimlikNo;
        private Label labelTCKimlikNo;
        private TextBox textBoxAdres;
        private Label labelAdres;
        private Label labelCinsiyet;
        private Label labelDogumTarihi;
        private ComboBox comboBoxCinsiyet;
        private DateTimePicker dateTimePickerDogumTarihi;
    }
}