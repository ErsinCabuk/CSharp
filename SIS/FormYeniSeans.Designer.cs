namespace SIS
{
    partial class FormYeniSeans
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
            labelUzmanBaslik = new Label();
            labelTarih = new Label();
            labelBaslangicSaati = new Label();
            labelBitisSaati = new Label();
            labelUzman = new Label();
            dateTimePickerTarih = new DateTimePicker();
            dateTimePickerBaslangicSaati = new DateTimePicker();
            dateTimePickerBitisSaati = new DateTimePicker();
            buttonKaydet = new Button();
            SuspendLayout();
            // 
            // labelUzmanBaslik
            // 
            labelUzmanBaslik.AutoSize = true;
            labelUzmanBaslik.Location = new Point(12, 9);
            labelUzmanBaslik.Name = "labelUzmanBaslik";
            labelUzmanBaslik.Size = new Size(62, 21);
            labelUzmanBaslik.TabIndex = 0;
            labelUzmanBaslik.Text = "Uzman:";
            // 
            // labelTarih
            // 
            labelTarih.AutoSize = true;
            labelTarih.Location = new Point(12, 47);
            labelTarih.Name = "labelTarih";
            labelTarih.Size = new Size(46, 21);
            labelTarih.TabIndex = 1;
            labelTarih.Text = "Tarih:";
            // 
            // labelBaslangicSaati
            // 
            labelBaslangicSaati.AutoSize = true;
            labelBaslangicSaati.Location = new Point(12, 82);
            labelBaslangicSaati.Name = "labelBaslangicSaati";
            labelBaslangicSaati.Size = new Size(116, 21);
            labelBaslangicSaati.TabIndex = 2;
            labelBaslangicSaati.Text = "Başlangıç Saati:";
            // 
            // labelBitisSaati
            // 
            labelBitisSaati.AutoSize = true;
            labelBitisSaati.Location = new Point(12, 116);
            labelBitisSaati.Name = "labelBitisSaati";
            labelBitisSaati.Size = new Size(80, 21);
            labelBitisSaati.TabIndex = 3;
            labelBitisSaati.Text = "Bitiş Saati:";
            // 
            // labelUzman
            // 
            labelUzman.BorderStyle = BorderStyle.Fixed3D;
            labelUzman.Location = new Point(134, 9);
            labelUzman.Name = "labelUzman";
            labelUzman.Size = new Size(150, 23);
            labelUzman.TabIndex = 4;
            // 
            // dateTimePickerTarih
            // 
            dateTimePickerTarih.Format = DateTimePickerFormat.Short;
            dateTimePickerTarih.Location = new Point(134, 41);
            dateTimePickerTarih.Name = "dateTimePickerTarih";
            dateTimePickerTarih.Size = new Size(150, 29);
            dateTimePickerTarih.TabIndex = 5;
            // 
            // dateTimePickerBaslangicSaati
            // 
            dateTimePickerBaslangicSaati.CustomFormat = "HH:mm";
            dateTimePickerBaslangicSaati.Format = DateTimePickerFormat.Custom;
            dateTimePickerBaslangicSaati.Location = new Point(134, 76);
            dateTimePickerBaslangicSaati.Name = "dateTimePickerBaslangicSaati";
            dateTimePickerBaslangicSaati.Size = new Size(150, 29);
            dateTimePickerBaslangicSaati.TabIndex = 6;
            // 
            // dateTimePickerBitisSaati
            // 
            dateTimePickerBitisSaati.CustomFormat = "HH:mm";
            dateTimePickerBitisSaati.Format = DateTimePickerFormat.Custom;
            dateTimePickerBitisSaati.Location = new Point(134, 111);
            dateTimePickerBitisSaati.Name = "dateTimePickerBitisSaati";
            dateTimePickerBitisSaati.Size = new Size(150, 29);
            dateTimePickerBitisSaati.TabIndex = 7;
            // 
            // buttonKaydet
            // 
            buttonKaydet.Location = new Point(12, 146);
            buttonKaydet.Name = "buttonKaydet";
            buttonKaydet.Size = new Size(272, 29);
            buttonKaydet.TabIndex = 8;
            buttonKaydet.Text = "Kaydet";
            buttonKaydet.UseVisualStyleBackColor = true;
            buttonKaydet.Click += buttonKaydet_Click;
            // 
            // FormYeniSeans
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 182);
            Controls.Add(buttonKaydet);
            Controls.Add(dateTimePickerBitisSaati);
            Controls.Add(dateTimePickerBaslangicSaati);
            Controls.Add(dateTimePickerTarih);
            Controls.Add(labelUzman);
            Controls.Add(labelBitisSaati);
            Controls.Add(labelBaslangicSaati);
            Controls.Add(labelTarih);
            Controls.Add(labelUzmanBaslik);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FormYeniSeans";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yeni Seans";
            Load += FormYeniSeans_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUzmanBaslik;
        private Label labelTarih;
        private Label labelBaslangicSaati;
        private Label labelBitisSaati;
        private Label labelUzman;
        private DateTimePicker dateTimePickerTarih;
        private DateTimePicker dateTimePickerBaslangicSaati;
        private DateTimePicker dateTimePickerBitisSaati;
        private Button buttonKaydet;
    }
}