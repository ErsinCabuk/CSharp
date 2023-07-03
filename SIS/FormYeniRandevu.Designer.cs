namespace SIS
{
    partial class FormYeniRandevu
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
            labelHastaBaslik = new Label();
            labelHasta = new Label();
            labelUzman = new Label();
            comboBoxUzman = new ComboBox();
            comboBoxSeans = new ComboBox();
            labelSeans = new Label();
            buttonKaydet = new Button();
            SuspendLayout();
            // 
            // labelHastaBaslik
            // 
            labelHastaBaslik.AutoSize = true;
            labelHastaBaslik.Location = new Point(12, 9);
            labelHastaBaslik.Name = "labelHastaBaslik";
            labelHastaBaslik.Size = new Size(52, 21);
            labelHastaBaslik.TabIndex = 0;
            labelHastaBaslik.Text = "Hasta:";
            // 
            // labelHasta
            // 
            labelHasta.BorderStyle = BorderStyle.Fixed3D;
            labelHasta.Location = new Point(80, 9);
            labelHasta.Name = "labelHasta";
            labelHasta.Size = new Size(322, 21);
            labelHasta.TabIndex = 1;
            // 
            // labelUzman
            // 
            labelUzman.AutoSize = true;
            labelUzman.Location = new Point(12, 41);
            labelUzman.Name = "labelUzman";
            labelUzman.Size = new Size(62, 21);
            labelUzman.TabIndex = 2;
            labelUzman.Text = "Uzman:";
            // 
            // comboBoxUzman
            // 
            comboBoxUzman.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUzman.FormattingEnabled = true;
            comboBoxUzman.Location = new Point(80, 38);
            comboBoxUzman.Name = "comboBoxUzman";
            comboBoxUzman.Size = new Size(322, 29);
            comboBoxUzman.TabIndex = 3;
            comboBoxUzman.SelectedIndexChanged += comboBoxUzman_SelectedIndexChanged;
            // 
            // comboBoxSeans
            // 
            comboBoxSeans.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSeans.FormattingEnabled = true;
            comboBoxSeans.Location = new Point(80, 73);
            comboBoxSeans.Name = "comboBoxSeans";
            comboBoxSeans.Size = new Size(322, 29);
            comboBoxSeans.TabIndex = 5;
            comboBoxSeans.SelectedIndexChanged += comboBoxSeans_SelectedIndexChanged;
            // 
            // labelSeans
            // 
            labelSeans.AutoSize = true;
            labelSeans.Location = new Point(12, 76);
            labelSeans.Name = "labelSeans";
            labelSeans.Size = new Size(54, 21);
            labelSeans.TabIndex = 4;
            labelSeans.Text = "Seans:";
            // 
            // buttonKaydet
            // 
            buttonKaydet.Location = new Point(12, 108);
            buttonKaydet.Name = "buttonKaydet";
            buttonKaydet.Size = new Size(390, 29);
            buttonKaydet.TabIndex = 6;
            buttonKaydet.Text = "Kaydet";
            buttonKaydet.UseVisualStyleBackColor = true;
            buttonKaydet.Click += buttonKaydet_Click;
            // 
            // FormYeniRandevu
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 149);
            Controls.Add(buttonKaydet);
            Controls.Add(comboBoxSeans);
            Controls.Add(labelSeans);
            Controls.Add(comboBoxUzman);
            Controls.Add(labelUzman);
            Controls.Add(labelHasta);
            Controls.Add(labelHastaBaslik);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FormYeniRandevu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormYeniRandevu";
            Load += FormYeniRandevu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHastaBaslik;
        private Label labelHasta;
        private Label labelUzman;
        private ComboBox comboBoxUzman;
        private ComboBox comboBoxSeans;
        private Label labelSeans;
        private Button buttonKaydet;
    }
}