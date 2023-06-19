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
            label1 = new Label();
            labelUzman = new Label();
            comboBoxUzman = new ComboBox();
            comboBoxSeans = new ComboBox();
            labelSeans = new Label();
            button1 = new Button();
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
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(80, 9);
            label1.Name = "label1";
            label1.Size = new Size(150, 21);
            label1.TabIndex = 1;
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
            comboBoxUzman.Size = new Size(150, 29);
            comboBoxUzman.TabIndex = 3;
            // 
            // comboBoxSeans
            // 
            comboBoxSeans.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSeans.FormattingEnabled = true;
            comboBoxSeans.Location = new Point(80, 73);
            comboBoxSeans.Name = "comboBoxSeans";
            comboBoxSeans.Size = new Size(150, 29);
            comboBoxSeans.TabIndex = 5;
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
            // button1
            // 
            button1.Location = new Point(12, 108);
            button1.Name = "button1";
            button1.Size = new Size(218, 29);
            button1.TabIndex = 6;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            // 
            // FormYeniRandevu
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(240, 149);
            Controls.Add(button1);
            Controls.Add(comboBoxSeans);
            Controls.Add(labelSeans);
            Controls.Add(comboBoxUzman);
            Controls.Add(labelUzman);
            Controls.Add(label1);
            Controls.Add(labelHastaBaslik);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            Name = "FormYeniRandevu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormYeniRandevu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHastaBaslik;
        private Label label1;
        private Label labelUzman;
        private ComboBox comboBoxUzman;
        private ComboBox comboBoxSeans;
        private Label labelSeans;
        private Button button1;
    }
}