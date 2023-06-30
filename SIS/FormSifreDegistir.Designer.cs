namespace SIS
{
    partial class FormSifreDegistir
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
            textBoxEskiSifre = new TextBox();
            labelEskiSifre = new Label();
            textBoxYeniSifre = new TextBox();
            labelYeniSifre = new Label();
            textBoxYeniSifreTekrar = new TextBox();
            labelYeniSifreTekrar = new Label();
            buttonDegistir = new Button();
            SuspendLayout();
            // 
            // textBoxEskiSifre
            // 
            textBoxEskiSifre.Location = new Point(152, 12);
            textBoxEskiSifre.MaxLength = 10;
            textBoxEskiSifre.Name = "textBoxEskiSifre";
            textBoxEskiSifre.PasswordChar = '*';
            textBoxEskiSifre.Size = new Size(150, 29);
            textBoxEskiSifre.TabIndex = 5;
            // 
            // labelEskiSifre
            // 
            labelEskiSifre.AutoSize = true;
            labelEskiSifre.Location = new Point(12, 15);
            labelEskiSifre.Name = "labelEskiSifre";
            labelEskiSifre.Size = new Size(76, 21);
            labelEskiSifre.TabIndex = 4;
            labelEskiSifre.Text = "Eski Şifre:";
            // 
            // textBoxYeniSifre
            // 
            textBoxYeniSifre.Location = new Point(152, 47);
            textBoxYeniSifre.MaxLength = 10;
            textBoxYeniSifre.Name = "textBoxYeniSifre";
            textBoxYeniSifre.PasswordChar = '*';
            textBoxYeniSifre.Size = new Size(150, 29);
            textBoxYeniSifre.TabIndex = 7;
            // 
            // labelYeniSifre
            // 
            labelYeniSifre.AutoSize = true;
            labelYeniSifre.Location = new Point(12, 50);
            labelYeniSifre.Name = "labelYeniSifre";
            labelYeniSifre.Size = new Size(78, 21);
            labelYeniSifre.TabIndex = 6;
            labelYeniSifre.Text = "Yeni Şifre:";
            // 
            // textBoxYeniSifreTekrar
            // 
            textBoxYeniSifreTekrar.Location = new Point(152, 82);
            textBoxYeniSifreTekrar.MaxLength = 10;
            textBoxYeniSifreTekrar.Name = "textBoxYeniSifreTekrar";
            textBoxYeniSifreTekrar.PasswordChar = '*';
            textBoxYeniSifreTekrar.Size = new Size(150, 29);
            textBoxYeniSifreTekrar.TabIndex = 9;
            // 
            // labelYeniSifreTekrar
            // 
            labelYeniSifreTekrar.AutoSize = true;
            labelYeniSifreTekrar.Location = new Point(12, 85);
            labelYeniSifreTekrar.Name = "labelYeniSifreTekrar";
            labelYeniSifreTekrar.Size = new Size(134, 21);
            labelYeniSifreTekrar.TabIndex = 8;
            labelYeniSifreTekrar.Text = "Yeni Şifre (Tekrar):";
            // 
            // buttonDegistir
            // 
            buttonDegistir.Location = new Point(12, 117);
            buttonDegistir.Name = "buttonDegistir";
            buttonDegistir.Size = new Size(290, 29);
            buttonDegistir.TabIndex = 10;
            buttonDegistir.Text = "Değiştir";
            buttonDegistir.UseVisualStyleBackColor = true;
            buttonDegistir.Click += buttonDegistir_Click;
            // 
            // FormSifreDegistir
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 163);
            Controls.Add(buttonDegistir);
            Controls.Add(textBoxYeniSifreTekrar);
            Controls.Add(labelYeniSifreTekrar);
            Controls.Add(textBoxYeniSifre);
            Controls.Add(labelYeniSifre);
            Controls.Add(textBoxEskiSifre);
            Controls.Add(labelEskiSifre);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FormSifreDegistir";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Şifre Değiştir";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxEskiSifre;
        private Label labelEskiSifre;
        private TextBox textBoxYeniSifre;
        private Label labelYeniSifre;
        private TextBox textBoxYeniSifreTekrar;
        private Label labelYeniSifreTekrar;
        private Button buttonDegistir;
    }
}