namespace SIS
{
    partial class FormAnaSayfa
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
            menu = new MenuStrip();
            menuItemMenu = new ToolStripMenuItem();
            menuItemSifreDegistir = new ToolStripMenuItem();
            menuItemSifreSifirla = new ToolStripMenuItem();
            menuItemUzmanEkle = new ToolStripMenuItem();
            menuItemSekreterEkle = new ToolStripMenuItem();
            menuItemCalisanAra = new ToolStripMenuItem();
            menuItemRandevuYonet = new ToolStripMenuItem();
            menuItemSeansYonetSekreter = new ToolStripMenuItem();
            menuItemSeansYonetUzman = new ToolStripMenuItem();
            menuItemAyrac = new ToolStripSeparator();
            menuItemCikis = new ToolStripMenuItem();
            status = new StatusStrip();
            statusItemKullanici = new ToolStripStatusLabel();
            statusItemTarih = new ToolStripStatusLabel();
            statusItemSaat = new ToolStripStatusLabel();
            menu.SuspendLayout();
            status.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.Items.AddRange(new ToolStripItem[] { menuItemMenu });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Padding = new Padding(8, 3, 0, 3);
            menu.Size = new Size(636, 25);
            menu.TabIndex = 0;
            menu.Text = "menuStrip1";
            // 
            // menuItemMenu
            // 
            menuItemMenu.DropDownItems.AddRange(new ToolStripItem[] { menuItemSifreDegistir, menuItemSifreSifirla, menuItemUzmanEkle, menuItemSekreterEkle, menuItemCalisanAra, menuItemRandevuYonet, menuItemSeansYonetSekreter, menuItemSeansYonetUzman, menuItemAyrac, menuItemCikis });
            menuItemMenu.Name = "menuItemMenu";
            menuItemMenu.Size = new Size(50, 19);
            menuItemMenu.Text = "&Menü";
            // 
            // menuItemSifreDegistir
            // 
            menuItemSifreDegistir.Name = "menuItemSifreDegistir";
            menuItemSifreDegistir.Size = new Size(190, 22);
            menuItemSifreDegistir.Text = "Şifre &Değiştir";
            // 
            // menuItemSifreSifirla
            // 
            menuItemSifreSifirla.Name = "menuItemSifreSifirla";
            menuItemSifreSifirla.Size = new Size(190, 22);
            menuItemSifreSifirla.Text = "Şif&re Sıfırla";
            // 
            // menuItemUzmanEkle
            // 
            menuItemUzmanEkle.Name = "menuItemUzmanEkle";
            menuItemUzmanEkle.Size = new Size(190, 22);
            menuItemUzmanEkle.Text = "&Uzman Ekle";
            // 
            // menuItemSekreterEkle
            // 
            menuItemSekreterEkle.Name = "menuItemSekreterEkle";
            menuItemSekreterEkle.Size = new Size(190, 22);
            menuItemSekreterEkle.Text = "&Sekreter Ekle";
            // 
            // menuItemCalisanAra
            // 
            menuItemCalisanAra.Name = "menuItemCalisanAra";
            menuItemCalisanAra.Size = new Size(190, 22);
            menuItemCalisanAra.Text = "Çalışan &Ara";
            // 
            // menuItemRandevuYonet
            // 
            menuItemRandevuYonet.Name = "menuItemRandevuYonet";
            menuItemRandevuYonet.Size = new Size(190, 22);
            menuItemRandevuYonet.Text = "&Randevu Yönet";
            // 
            // menuItemSeansYonetSekreter
            // 
            menuItemSeansYonetSekreter.Name = "menuItemSeansYonetSekreter";
            menuItemSeansYonetSekreter.Size = new Size(190, 22);
            menuItemSeansYonetSekreter.Text = "&Seans Yönet (Sekreter)";
            // 
            // menuItemSeansYonetUzman
            // 
            menuItemSeansYonetUzman.Name = "menuItemSeansYonetUzman";
            menuItemSeansYonetUzman.Size = new Size(190, 22);
            menuItemSeansYonetUzman.Text = "&Seans Yönet (Uzman)";
            // 
            // menuItemAyrac
            // 
            menuItemAyrac.Name = "menuItemAyrac";
            menuItemAyrac.Size = new Size(187, 6);
            // 
            // menuItemCikis
            // 
            menuItemCikis.Name = "menuItemCikis";
            menuItemCikis.Size = new Size(190, 22);
            menuItemCikis.Text = "&Çıkış";
            // 
            // status
            // 
            status.Items.AddRange(new ToolStripItem[] { statusItemKullanici, statusItemTarih, statusItemSaat });
            status.Location = new Point(0, 301);
            status.Name = "status";
            status.Padding = new Padding(1, 0, 18, 0);
            status.Size = new Size(636, 22);
            status.SizingGrip = false;
            status.TabIndex = 1;
            status.Text = "statusStrip1";
            // 
            // statusItemKullanici
            // 
            statusItemKullanici.Name = "statusItemKullanici";
            statusItemKullanici.Size = new Size(494, 17);
            statusItemKullanici.Spring = true;
            statusItemKullanici.Text = "Sistem Yöneticisi";
            // 
            // statusItemTarih
            // 
            statusItemTarih.Name = "statusItemTarih";
            statusItemTarih.Size = new Size(89, 17);
            statusItemTarih.Text = "11 Haziran 2023";
            // 
            // statusItemSaat
            // 
            statusItemSaat.Name = "statusItemSaat";
            statusItemSaat.Size = new Size(34, 17);
            statusItemSaat.Text = "18:09";
            // 
            // FormAnaSayfa
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 323);
            Controls.Add(status);
            Controls.Add(menu);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            Name = "FormAnaSayfa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SIS Ana Sayfa";
            menu.ResumeLayout(false);
            menu.PerformLayout();
            status.ResumeLayout(false);
            status.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu;
        private ToolStripMenuItem menuItemMenu;
        private ToolStripMenuItem menuItemSifreDegistir;
        private ToolStripMenuItem menuItemSifreSifirla;
        private ToolStripMenuItem menuItemUzmanEkle;
        private ToolStripMenuItem menuItemSekreterEkle;
        private ToolStripMenuItem menuItemCalisanAra;
        private ToolStripMenuItem menuItemRandevuYonet;
        private ToolStripMenuItem menuItemSeansYonetSekreter;
        private ToolStripMenuItem menuItemSeansYonetUzman;
        private ToolStripSeparator menuItemAyrac;
        private ToolStripMenuItem menuItemCikis;
        private StatusStrip status;
        private ToolStripStatusLabel statusItemKullanici;
        private ToolStripStatusLabel statusItemTarih;
        private ToolStripStatusLabel statusItemSaat;
    }
}