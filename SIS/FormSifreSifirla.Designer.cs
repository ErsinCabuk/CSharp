namespace SIS
{
    partial class FormSifreSifirla
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
            labelEPosta = new Label();
            textBoxEPosta = new TextBox();
            textBoxYeniSifre = new TextBox();
            labelYeniSifre = new Label();
            buttonSifirla = new Button();
            SuspendLayout();
            // 
            // labelEPosta
            // 
            labelEPosta.AutoSize = true;
            labelEPosta.Location = new Point(12, 15);
            labelEPosta.Name = "labelEPosta";
            labelEPosta.Size = new Size(64, 21);
            labelEPosta.TabIndex = 0;
            labelEPosta.Text = "E-Posta:";
            // 
            // textBoxEPosta
            // 
            textBoxEPosta.Location = new Point(96, 12);
            textBoxEPosta.MaxLength = 50;
            textBoxEPosta.Name = "textBoxEPosta";
            textBoxEPosta.Size = new Size(150, 29);
            textBoxEPosta.TabIndex = 1;
            // 
            // textBoxYeniSifre
            // 
            textBoxYeniSifre.Location = new Point(96, 47);
            textBoxYeniSifre.MaxLength = 10;
            textBoxYeniSifre.Name = "textBoxYeniSifre";
            textBoxYeniSifre.PasswordChar = '*';
            textBoxYeniSifre.Size = new Size(150, 29);
            textBoxYeniSifre.TabIndex = 3;
            // 
            // labelYeniSifre
            // 
            labelYeniSifre.AutoSize = true;
            labelYeniSifre.Location = new Point(12, 50);
            labelYeniSifre.Name = "labelYeniSifre";
            labelYeniSifre.Size = new Size(78, 21);
            labelYeniSifre.TabIndex = 2;
            labelYeniSifre.Text = "Yeni Şifre:";
            // 
            // buttonSifirla
            // 
            buttonSifirla.Location = new Point(12, 82);
            buttonSifirla.Name = "buttonSifirla";
            buttonSifirla.Size = new Size(234, 29);
            buttonSifirla.TabIndex = 4;
            buttonSifirla.Text = "Sıfırla";
            buttonSifirla.UseVisualStyleBackColor = true;
            buttonSifirla.Click += buttonSifirla_Click;
            // 
            // FormSifreSifirla
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(261, 123);
            Controls.Add(buttonSifirla);
            Controls.Add(textBoxYeniSifre);
            Controls.Add(labelYeniSifre);
            Controls.Add(textBoxEPosta);
            Controls.Add(labelEPosta);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FormSifreSifirla";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormSifreSifirla";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelEPosta;
        private TextBox textBoxEPosta;
        private TextBox textBoxYeniSifre;
        private Label labelYeniSifre;
        private Button buttonSifirla;
    }
}