namespace SIS
{
    partial class FormSeansIptal
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
            labelUzmanBaslik = new Label();
            labelSeans = new Label();
            labelSeansBaslik = new Label();
            labelIptalNedeniBaslik = new Label();
            textBoxIptalNedeni = new TextBox();
            buttonIptalEt = new Button();
            SuspendLayout();
            // 
            // labelUzman
            // 
            labelUzman.BorderStyle = BorderStyle.Fixed3D;
            labelUzman.Location = new Point(115, 9);
            labelUzman.Name = "labelUzman";
            labelUzman.Size = new Size(150, 23);
            labelUzman.TabIndex = 6;
            // 
            // labelUzmanBaslik
            // 
            labelUzmanBaslik.AutoSize = true;
            labelUzmanBaslik.Location = new Point(12, 11);
            labelUzmanBaslik.Name = "labelUzmanBaslik";
            labelUzmanBaslik.Size = new Size(62, 21);
            labelUzmanBaslik.TabIndex = 5;
            labelUzmanBaslik.Text = "Uzman:";
            // 
            // labelSeans
            // 
            labelSeans.BorderStyle = BorderStyle.Fixed3D;
            labelSeans.Location = new Point(115, 42);
            labelSeans.Name = "labelSeans";
            labelSeans.Size = new Size(150, 23);
            labelSeans.TabIndex = 8;
            // 
            // labelSeansBaslik
            // 
            labelSeansBaslik.AutoSize = true;
            labelSeansBaslik.Location = new Point(12, 42);
            labelSeansBaslik.Name = "labelSeansBaslik";
            labelSeansBaslik.Size = new Size(54, 21);
            labelSeansBaslik.TabIndex = 7;
            labelSeansBaslik.Text = "Seans:";
            // 
            // labelIptalNedeniBaslik
            // 
            labelIptalNedeniBaslik.AutoSize = true;
            labelIptalNedeniBaslik.Location = new Point(12, 79);
            labelIptalNedeniBaslik.Name = "labelIptalNedeniBaslik";
            labelIptalNedeniBaslik.Size = new Size(97, 21);
            labelIptalNedeniBaslik.TabIndex = 9;
            labelIptalNedeniBaslik.Text = "İptal Nedeni:";
            // 
            // textBoxIptalNedeni
            // 
            textBoxIptalNedeni.Location = new Point(115, 79);
            textBoxIptalNedeni.Multiline = true;
            textBoxIptalNedeni.Name = "textBoxIptalNedeni";
            textBoxIptalNedeni.Size = new Size(200, 58);
            textBoxIptalNedeni.TabIndex = 10;
            // 
            // buttonIptalEt
            // 
            buttonIptalEt.Location = new Point(12, 143);
            buttonIptalEt.Name = "buttonIptalEt";
            buttonIptalEt.Size = new Size(303, 29);
            buttonIptalEt.TabIndex = 11;
            buttonIptalEt.Text = "İptal Et";
            buttonIptalEt.UseVisualStyleBackColor = true;
            buttonIptalEt.Click += buttonIptalEt_Click;
            // 
            // FormSeansIptal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 182);
            Controls.Add(buttonIptalEt);
            Controls.Add(textBoxIptalNedeni);
            Controls.Add(labelIptalNedeniBaslik);
            Controls.Add(labelSeans);
            Controls.Add(labelSeansBaslik);
            Controls.Add(labelUzman);
            Controls.Add(labelUzmanBaslik);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FormSeansIptal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormSeansIptal";
            Load += FormSeansIptal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUzman;
        private Label labelUzmanBaslik;
        private Label labelSeans;
        private Label labelSeansBaslik;
        private Label labelIptalNedeniBaslik;
        private TextBox textBoxIptalNedeni;
        private Button buttonIptalEt;
    }
}