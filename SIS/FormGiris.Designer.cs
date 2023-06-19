namespace SIS
{
    partial class FormGiris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBoxKullanici = new TextBox();
            textBoxSifre = new TextBox();
            labelSifre = new Label();
            buttonGiris = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(71, 21);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı:";
            // 
            // textBoxKullanici
            // 
            textBoxKullanici.Location = new Point(89, 12);
            textBoxKullanici.Name = "textBoxKullanici";
            textBoxKullanici.Size = new Size(150, 29);
            textBoxKullanici.TabIndex = 1;
            // 
            // textBoxSifre
            // 
            textBoxSifre.Location = new Point(89, 47);
            textBoxSifre.Name = "textBoxSifre";
            textBoxSifre.PasswordChar = '*';
            textBoxSifre.Size = new Size(150, 29);
            textBoxSifre.TabIndex = 3;
            // 
            // labelSifre
            // 
            labelSifre.AutoSize = true;
            labelSifre.Location = new Point(12, 47);
            labelSifre.Name = "labelSifre";
            labelSifre.Size = new Size(45, 21);
            labelSifre.TabIndex = 2;
            labelSifre.Text = "Şifre:";
            // 
            // buttonGiris
            // 
            buttonGiris.Location = new Point(12, 82);
            buttonGiris.Name = "buttonGiris";
            buttonGiris.Size = new Size(227, 29);
            buttonGiris.TabIndex = 4;
            buttonGiris.Text = "Giriş";
            buttonGiris.UseVisualStyleBackColor = true;
            // 
            // FormGiris
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(249, 119);
            Controls.Add(buttonGiris);
            Controls.Add(textBoxSifre);
            Controls.Add(labelSifre);
            Controls.Add(textBoxKullanici);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FormGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxKullanici;
        private TextBox textBoxSifre;
        private Label labelSifre;
        private Button buttonGiris;
    }
}