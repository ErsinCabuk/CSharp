namespace SIS
{
    partial class FormSeansYonetimi
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
            labelUzman = new Label();
            comboBoxUzman = new ComboBox();
            labelAyrac = new Label();
            labelSeanslar = new Label();
            listBoxSeanslar = new ListBox();
            buttonYeniSeansEkle = new Button();
            buttonSeansIptal = new Button();
            SuspendLayout();
            // 
            // labelUzman
            // 
            labelUzman.AutoSize = true;
            labelUzman.Location = new Point(12, 15);
            labelUzman.Name = "labelUzman";
            labelUzman.Size = new Size(62, 21);
            labelUzman.TabIndex = 0;
            labelUzman.Text = "Uzman:";
            // 
            // comboBoxUzman
            // 
            comboBoxUzman.FormattingEnabled = true;
            comboBoxUzman.Location = new Point(80, 12);
            comboBoxUzman.Name = "comboBoxUzman";
            comboBoxUzman.Size = new Size(332, 29);
            comboBoxUzman.TabIndex = 1;
            comboBoxUzman.SelectedIndexChanged += comboBoxUzman_SelectedIndexChanged;
            // 
            // labelAyrac
            // 
            labelAyrac.BorderStyle = BorderStyle.Fixed3D;
            labelAyrac.Location = new Point(12, 53);
            labelAyrac.Name = "labelAyrac";
            labelAyrac.Size = new Size(400, 2);
            labelAyrac.TabIndex = 2;
            // 
            // labelSeanslar
            // 
            labelSeanslar.AutoSize = true;
            labelSeanslar.Location = new Point(174, 65);
            labelSeanslar.Name = "labelSeanslar";
            labelSeanslar.Size = new Size(69, 21);
            labelSeanslar.TabIndex = 3;
            labelSeanslar.Text = "Seanslar";
            // 
            // listBoxSeanslar
            // 
            listBoxSeanslar.FormattingEnabled = true;
            listBoxSeanslar.ItemHeight = 21;
            listBoxSeanslar.Location = new Point(12, 89);
            listBoxSeanslar.Name = "listBoxSeanslar";
            listBoxSeanslar.Size = new Size(400, 193);
            listBoxSeanslar.TabIndex = 4;
            // 
            // buttonYeniSeansEkle
            // 
            buttonYeniSeansEkle.Location = new Point(12, 288);
            buttonYeniSeansEkle.Name = "buttonYeniSeansEkle";
            buttonYeniSeansEkle.Size = new Size(195, 29);
            buttonYeniSeansEkle.TabIndex = 5;
            buttonYeniSeansEkle.Text = "Yeni Seans Ekle";
            buttonYeniSeansEkle.UseVisualStyleBackColor = true;
            buttonYeniSeansEkle.Click += buttonYeniSeansEkle_Click;
            // 
            // buttonSeansIptal
            // 
            buttonSeansIptal.Location = new Point(217, 288);
            buttonSeansIptal.Name = "buttonSeansIptal";
            buttonSeansIptal.Size = new Size(195, 29);
            buttonSeansIptal.TabIndex = 6;
            buttonSeansIptal.Text = "Seçili Seansı İptal Et";
            buttonSeansIptal.UseVisualStyleBackColor = true;
            buttonSeansIptal.Click += buttonSeansIptal_Click;
            // 
            // FormSeansYonetimi
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 329);
            Controls.Add(buttonSeansIptal);
            Controls.Add(buttonYeniSeansEkle);
            Controls.Add(listBoxSeanslar);
            Controls.Add(labelSeanslar);
            Controls.Add(labelAyrac);
            Controls.Add(comboBoxUzman);
            Controls.Add(labelUzman);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FormSeansYonetimi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Seans Yönetimi";
            Load += FormSeansYonetimi_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUzman;
        private ComboBox comboBoxUzman;
        private Label labelAyrac;
        private Label labelSeanslar;
        private ListBox listBoxSeanslar;
        private Button buttonYeniSeansEkle;
        private Button buttonSeansIptal;
    }
}