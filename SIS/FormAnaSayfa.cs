using SISSiniflar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIS
{
    public partial class FormAnaSayfa : Form
    {
        public FormAnaSayfa()
        {
            InitializeComponent();
        }

        public Calisan calisan;

        private void SaatYaz()
        {
            statusItemTarih.Text = DateTime.Now.ToLongDateString();
            statusItemSaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void MenuYukle()
        {
            menuItemCikis.Visible = true;
            menuItemSifreDegistir.Visible = true;

            switch (calisan.CalisanTipi)
            {
                case CalisanTipleri.SistemYoneticisi:
                    menuItemSekreterEkle.Visible = true;
                    menuItemSifreSifirla.Visible = true;
                    statusItemKullanici.Text += " (Sistem Yöneticisi)";
                    break;

                case CalisanTipleri.Sekreter:
                    menuItemRandevuYonet.Visible = true;
                    menuItemSeansYonetSekreter.Visible = true;
                    menuItemUzmanEkle.Visible = true;
                    statusItemKullanici.Text += " (Sekreter)";
                    break;

                case CalisanTipleri.Uzman:
                    menuItemSeansYonetUzman.Visible = true;
                    statusItemKullanici.Text += " (Uzman)";
                    break;

                default:
                    break;
            }
        }

        private void menuItemMenu_Click(object sender, EventArgs e)
        {

        }

        private void menuItemSifreDegistir_Click(object sender, EventArgs e)
        {
            FormSifreDegistir form = new FormSifreDegistir();
            form.calisan = this.calisan;
            form.ShowDialog();
        }

        private void menuItemSifreSifirla_Click(object sender, EventArgs e)
        {
            FormSifreSifirla form = new FormSifreSifirla();
            form.ShowDialog();
        }

        private void menuItemUzmanEkle_Click(object sender, EventArgs e)
        {
            FormUzmanBilgisi form = new FormUzmanBilgisi();
            form.ShowDialog();
        }

        private void menuItemSekreterEkle_Click(object sender, EventArgs e)
        {
            FormSekreterBilgisi form = new FormSekreterBilgisi();
            form.ShowDialog();
        }

        private void menuItemCalisanAra_Click(object sender, EventArgs e)
        {
            FormCalisanAra form = new FormCalisanAra();
            form.ShowDialog();
        }

        private void menuItemRandevuYonet_Click(object sender, EventArgs e)
        {
            FormHastaRandevuYonetimi form = new FormHastaRandevuYonetimi();
            form.ShowDialog();
        }

        private void menuItemSeansYonetSekreter_Click(object sender, EventArgs e)
        {
            FormSeansYonetimi form = new FormSeansYonetimi();
            form.ShowDialog();
        }

        private void menuItemSeansYonetUzman_Click(object sender, EventArgs e)
        {
            FormUzmanSeansYonetimi form = new FormUzmanSeansYonetimi();
            form.ShowDialog();
        }

        private void menuItemAyrac_Click(object sender, EventArgs e)
        {

        }

        private void menuItemCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timerSaat_Tick(object sender, EventArgs e)
        {
            SaatYaz();
        }

        private void FormAnaSayfa_Load(object sender, EventArgs e)
        {
            SaatYaz();
            
        }
    }
}
