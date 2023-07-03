namespace SIS
{
    partial class FormCalisanAra
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
            textBoxAd = new TextBox();
            labelAd = new Label();
            buttonAra = new Button();
            listBoxCalisanlar = new ListBox();
            label1 = new Label();
            labelCalisanlar = new Label();
            textBoxSoyad = new TextBox();
            labelSoyad = new Label();
            SuspendLayout();
            // 
            // textBoxAd
            // 
            textBoxAd.Location = new Point(75, 12);
            textBoxAd.MaxLength = 50;
            textBoxAd.Name = "textBoxAd";
            textBoxAd.Size = new Size(173, 29);
            textBoxAd.TabIndex = 2;
            // 
            // labelAd
            // 
            labelAd.AutoSize = true;
            labelAd.Location = new Point(13, 15);
            labelAd.Name = "labelAd";
            labelAd.Size = new Size(32, 21);
            labelAd.TabIndex = 5;
            labelAd.Text = "Ad:";
            // 
            // buttonAra
            // 
            buttonAra.Location = new Point(13, 82);
            buttonAra.Name = "buttonAra";
            buttonAra.Size = new Size(235, 29);
            buttonAra.TabIndex = 6;
            buttonAra.Text = "Ara";
            buttonAra.UseVisualStyleBackColor = true;
            buttonAra.Click += buttonAra_Click;
            // 
            // listBoxCalisanlar
            // 
            listBoxCalisanlar.FormattingEnabled = true;
            listBoxCalisanlar.ItemHeight = 21;
            listBoxCalisanlar.Location = new Point(13, 179);
            listBoxCalisanlar.Name = "listBoxCalisanlar";
            listBoxCalisanlar.Size = new Size(235, 172);
            listBoxCalisanlar.TabIndex = 8;
            listBoxCalisanlar.DoubleClick += listBoxCalisanlar_DoubleClick;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(13, 134);
            label1.Name = "label1";
            label1.Size = new Size(235, 2);
            label1.TabIndex = 9;
            // 
            // labelCalisanlar
            // 
            labelCalisanlar.AutoSize = true;
            labelCalisanlar.Location = new Point(88, 149);
            labelCalisanlar.Name = "labelCalisanlar";
            labelCalisanlar.Size = new Size(78, 21);
            labelCalisanlar.TabIndex = 10;
            labelCalisanlar.Text = "Çalışanlar";
            // 
            // textBoxSoyad
            // 
            textBoxSoyad.Location = new Point(75, 47);
            textBoxSoyad.MaxLength = 50;
            textBoxSoyad.Name = "textBoxSoyad";
            textBoxSoyad.Size = new Size(173, 29);
            textBoxSoyad.TabIndex = 4;
            // 
            // labelSoyad
            // 
            labelSoyad.AutoSize = true;
            labelSoyad.Location = new Point(13, 50);
            labelSoyad.Name = "labelSoyad";
            labelSoyad.Size = new Size(56, 21);
            labelSoyad.TabIndex = 11;
            labelSoyad.Text = "Soyad:";
            // 
            // FormCalisanAra
            // 
            AcceptButton = buttonAra;
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(262, 373);
            Controls.Add(textBoxSoyad);
            Controls.Add(labelSoyad);
            Controls.Add(labelCalisanlar);
            Controls.Add(label1);
            Controls.Add(listBoxCalisanlar);
            Controls.Add(buttonAra);
            Controls.Add(textBoxAd);
            Controls.Add(labelAd);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FormCalisanAra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Çalışan Ara";
            Load += FormCalisanAra_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAd;
        private Label labelAd;
        private Button buttonAra;
        private ListBox listBoxCalisanlar;
        private Label label1;
        private Label labelCalisanlar;
        private TextBox textBoxSoyad;
        private Label labelSoyad;
    }
}