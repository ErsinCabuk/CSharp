namespace SIS
{
    partial class FormSekreterBilgisi
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
            labelTCKimlikNo = new Label();
            textBoxTCKimlikNo = new TextBox();
            textBoxAdSoyad = new TextBox();
            labelAdSoyad = new Label();
            textBoxEPosta = new TextBox();
            labelEPosta = new Label();
            textBoxTelefonNo = new TextBox();
            labelTelefonNo = new Label();
            textBoxGSMNo = new TextBox();
            labelGSMNo = new Label();
            buttonKaydet = new Button();
            SuspendLayout();
            // 
            // labelTCKimlikNo
            // 
            labelTCKimlikNo.AutoSize = true;
            labelTCKimlikNo.Location = new Point(12, 15);
            labelTCKimlikNo.Name = "labelTCKimlikNo";
            labelTCKimlikNo.Size = new Size(102, 21);
            labelTCKimlikNo.TabIndex = 1;
            labelTCKimlikNo.Text = "TC Kimlik No:";
            // 
            // textBoxTCKimlikNo
            // 
            textBoxTCKimlikNo.Location = new Point(120, 12);
            textBoxTCKimlikNo.Name = "textBoxTCKimlikNo";
            textBoxTCKimlikNo.Size = new Size(150, 29);
            textBoxTCKimlikNo.TabIndex = 2;
            // 
            // textBoxAdSoyad
            // 
            textBoxAdSoyad.Location = new Point(120, 47);
            textBoxAdSoyad.Name = "textBoxAdSoyad";
            textBoxAdSoyad.Size = new Size(150, 29);
            textBoxAdSoyad.TabIndex = 4;
            // 
            // labelAdSoyad
            // 
            labelAdSoyad.AutoSize = true;
            labelAdSoyad.Location = new Point(12, 50);
            labelAdSoyad.Name = "labelAdSoyad";
            labelAdSoyad.Size = new Size(79, 21);
            labelAdSoyad.TabIndex = 3;
            labelAdSoyad.Text = "Ad Soyad:";
            // 
            // textBoxEPosta
            // 
            textBoxEPosta.Location = new Point(120, 82);
            textBoxEPosta.Name = "textBoxEPosta";
            textBoxEPosta.Size = new Size(150, 29);
            textBoxEPosta.TabIndex = 8;
            // 
            // labelEPosta
            // 
            labelEPosta.AutoSize = true;
            labelEPosta.Location = new Point(12, 85);
            labelEPosta.Name = "labelEPosta";
            labelEPosta.Size = new Size(64, 21);
            labelEPosta.TabIndex = 7;
            labelEPosta.Text = "E-Posta:";
            // 
            // textBoxTelefonNo
            // 
            textBoxTelefonNo.Location = new Point(120, 117);
            textBoxTelefonNo.Name = "textBoxTelefonNo";
            textBoxTelefonNo.Size = new Size(150, 29);
            textBoxTelefonNo.TabIndex = 10;
            // 
            // labelTelefonNo
            // 
            labelTelefonNo.AutoSize = true;
            labelTelefonNo.Location = new Point(12, 120);
            labelTelefonNo.Name = "labelTelefonNo";
            labelTelefonNo.Size = new Size(87, 21);
            labelTelefonNo.TabIndex = 9;
            labelTelefonNo.Text = "Telefon No:";
            // 
            // textBoxGSMNo
            // 
            textBoxGSMNo.Location = new Point(120, 152);
            textBoxGSMNo.Name = "textBoxGSMNo";
            textBoxGSMNo.Size = new Size(150, 29);
            textBoxGSMNo.TabIndex = 12;
            // 
            // labelGSMNo
            // 
            labelGSMNo.AutoSize = true;
            labelGSMNo.Location = new Point(12, 155);
            labelGSMNo.Name = "labelGSMNo";
            labelGSMNo.Size = new Size(72, 21);
            labelGSMNo.TabIndex = 11;
            labelGSMNo.Text = "GSM No:";
            // 
            // buttonKaydet
            // 
            buttonKaydet.Location = new Point(12, 187);
            buttonKaydet.Name = "buttonKaydet";
            buttonKaydet.Size = new Size(258, 29);
            buttonKaydet.TabIndex = 13;
            buttonKaydet.Text = "Kaydet";
            buttonKaydet.UseVisualStyleBackColor = true;
            // 
            // FormSekreterBilgisi
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 227);
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
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FormSekreterBilgisi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sekreter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelTCKimlikNo;
        private TextBox textBoxTCKimlikNo;
        private TextBox textBoxAdSoyad;
        private Label labelAdSoyad;
        private TextBox textBoxEPosta;
        private Label labelEPosta;
        private TextBox textBoxTelefonNo;
        private Label labelTelefonNo;
        private TextBox textBoxGSMNo;
        private Label labelGSMNo;
        private Button buttonKaydet;
    }
}