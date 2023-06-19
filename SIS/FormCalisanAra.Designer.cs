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
            textBoxAdSoyad = new TextBox();
            labelAdSoyad = new Label();
            buttonAra = new Button();
            listBoxCalisanlar = new ListBox();
            label1 = new Label();
            labelCalisanlar = new Label();
            SuspendLayout();
            // 
            // textBoxAdSoyad
            // 
            textBoxAdSoyad.Location = new Point(98, 12);
            textBoxAdSoyad.Name = "textBoxAdSoyad";
            textBoxAdSoyad.Size = new Size(150, 29);
            textBoxAdSoyad.TabIndex = 6;
            // 
            // labelAdSoyad
            // 
            labelAdSoyad.AutoSize = true;
            labelAdSoyad.Location = new Point(13, 15);
            labelAdSoyad.Name = "labelAdSoyad";
            labelAdSoyad.Size = new Size(79, 21);
            labelAdSoyad.TabIndex = 5;
            labelAdSoyad.Text = "Ad Soyad:";
            // 
            // buttonAra
            // 
            buttonAra.Location = new Point(13, 47);
            buttonAra.Name = "buttonAra";
            buttonAra.Size = new Size(235, 29);
            buttonAra.TabIndex = 7;
            buttonAra.Text = "Ara";
            buttonAra.UseVisualStyleBackColor = true;
            buttonAra.Click += buttonAra_Click;
            // 
            // listBoxCalisanlar
            // 
            listBoxCalisanlar.FormattingEnabled = true;
            listBoxCalisanlar.ItemHeight = 21;
            listBoxCalisanlar.Location = new Point(13, 134);
            listBoxCalisanlar.Name = "listBoxCalisanlar";
            listBoxCalisanlar.Size = new Size(235, 172);
            listBoxCalisanlar.TabIndex = 8;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(13, 89);
            label1.Name = "label1";
            label1.Size = new Size(235, 2);
            label1.TabIndex = 9;
            // 
            // labelCalisanlar
            // 
            labelCalisanlar.AutoSize = true;
            labelCalisanlar.Location = new Point(88, 104);
            labelCalisanlar.Name = "labelCalisanlar";
            labelCalisanlar.Size = new Size(78, 21);
            labelCalisanlar.TabIndex = 10;
            labelCalisanlar.Text = "Çalışanlar";
            // 
            // FormCalisanAra
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(262, 318);
            Controls.Add(labelCalisanlar);
            Controls.Add(label1);
            Controls.Add(listBoxCalisanlar);
            Controls.Add(buttonAra);
            Controls.Add(textBoxAdSoyad);
            Controls.Add(labelAdSoyad);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FormCalisanAra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Çalışan Ara";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAdSoyad;
        private Label labelAdSoyad;
        private Button buttonAra;
        private ListBox listBoxCalisanlar;
        private Label label1;
        private Label labelCalisanlar;
    }
}