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
            textBoxUnvan = new TextBox();
            labelUnvan = new Label();
            SuspendLayout();
            // 
            // buttonKaydet
            // 
            buttonKaydet.Location = new Point(12, 222);
            buttonKaydet.Name = "buttonKaydet";
            buttonKaydet.Size = new Size(258, 29);
            buttonKaydet.TabIndex = 24;
            buttonKaydet.Text = "Kaydet";
            buttonKaydet.UseVisualStyleBackColor = true;
            // 
            // textBoxGSMNo
            // 
            textBoxGSMNo.Location = new Point(120, 187);
            textBoxGSMNo.Name = "textBoxGSMNo";
            textBoxGSMNo.Size = new Size(150, 29);
            textBoxGSMNo.TabIndex = 23;
            // 
            // labelGSMNo
            // 
            labelGSMNo.AutoSize = true;
            labelGSMNo.Location = new Point(12, 190);
            labelGSMNo.Name = "labelGSMNo";
            labelGSMNo.Size = new Size(72, 21);
            labelGSMNo.TabIndex = 22;
            labelGSMNo.Text = "GSM No:";
            // 
            // textBoxTelefonNo
            // 
            textBoxTelefonNo.Location = new Point(120, 152);
            textBoxTelefonNo.Name = "textBoxTelefonNo";
            textBoxTelefonNo.Size = new Size(150, 29);
            textBoxTelefonNo.TabIndex = 21;
            // 
            // labelTelefonNo
            // 
            labelTelefonNo.AutoSize = true;
            labelTelefonNo.Location = new Point(12, 155);
            labelTelefonNo.Name = "labelTelefonNo";
            labelTelefonNo.Size = new Size(87, 21);
            labelTelefonNo.TabIndex = 20;
            labelTelefonNo.Text = "Telefon No:";
            // 
            // textBoxEPosta
            // 
            textBoxEPosta.Location = new Point(120, 117);
            textBoxEPosta.Name = "textBoxEPosta";
            textBoxEPosta.Size = new Size(150, 29);
            textBoxEPosta.TabIndex = 19;
            // 
            // labelEPosta
            // 
            labelEPosta.AutoSize = true;
            labelEPosta.Location = new Point(12, 120);
            labelEPosta.Name = "labelEPosta";
            labelEPosta.Size = new Size(64, 21);
            labelEPosta.TabIndex = 18;
            labelEPosta.Text = "E-Posta:";
            // 
            // textBoxAdSoyad
            // 
            textBoxAdSoyad.Location = new Point(120, 47);
            textBoxAdSoyad.Name = "textBoxAdSoyad";
            textBoxAdSoyad.Size = new Size(150, 29);
            textBoxAdSoyad.TabIndex = 17;
            // 
            // labelAdSoyad
            // 
            labelAdSoyad.AutoSize = true;
            labelAdSoyad.Location = new Point(12, 50);
            labelAdSoyad.Name = "labelAdSoyad";
            labelAdSoyad.Size = new Size(79, 21);
            labelAdSoyad.TabIndex = 16;
            labelAdSoyad.Text = "Ad Soyad:";
            // 
            // textBoxTCKimlikNo
            // 
            textBoxTCKimlikNo.Location = new Point(120, 12);
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
            textBoxUnvan.Location = new Point(120, 82);
            textBoxUnvan.Name = "textBoxUnvan";
            textBoxUnvan.Size = new Size(150, 29);
            textBoxUnvan.TabIndex = 26;
            // 
            // labelUnvan
            // 
            labelUnvan.AutoSize = true;
            labelUnvan.Location = new Point(12, 85);
            labelUnvan.Name = "labelUnvan";
            labelUnvan.Size = new Size(58, 21);
            labelUnvan.TabIndex = 25;
            labelUnvan.Text = "Ünvan:";
            // 
            // FormUzmanBilgisi
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 262);
            Controls.Add(textBoxUnvan);
            Controls.Add(labelUnvan);
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
            Name = "FormUzmanBilgisi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Uzman";
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
        private TextBox textBoxUnvan;
        private Label labelUnvan;
    }
}