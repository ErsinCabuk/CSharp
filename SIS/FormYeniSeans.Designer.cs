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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 47);
            label1.Name = "label1";
            label1.Size = new Size(46, 21);
            label1.TabIndex = 1;
            label1.Text = "Tarih:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 82);
            label2.Name = "label2";
            label2.Size = new Size(116, 21);
            label2.TabIndex = 2;
            label2.Text = "Başlangıç Saati:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 116);
            label3.Name = "label3";
            label3.Size = new Size(80, 21);
            label3.TabIndex = 3;
            label3.Text = "Bitiş Saati:";
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
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelUzmanBaslik);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FormYeniSeans";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yeni Seans";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUzmanBaslik;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label labelUzman;
        private DateTimePicker dateTimePickerTarih;
        private DateTimePicker dateTimePickerBaslangicSaati;
        private DateTimePicker dateTimePickerBitisSaati;
        private Button buttonKaydet;
    }
}