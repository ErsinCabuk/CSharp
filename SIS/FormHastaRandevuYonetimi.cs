using SISSiniflar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIS
{
    public partial class FormHastaRandevuYonetimi : Form
    {
        public FormHastaRandevuYonetimi()
        {
            InitializeComponent();
        }

        public Hasta hasta = null;
        private Seans sonRandevu = null;
        private Seans sonSeans = null;

        private void RandevuBilgisiYukle()
        {

        }

        private void HastalariListele()
        {

        }

        private void HastaBilgisiYukle()
        {
            HastaBilgisiTemizle();

            labelTCKimlikNo.Text = hasta.TCKimlikNo;
            labelAd.Text = hasta.Ad;
            labelSoyad.Text = hasta.Soyad;
            labelAdres.Text = hasta.Adres;
            labelCinsiyet.Text = hasta.Cinsiyet;
            labelDogumTarihi.Text = hasta.DogumTarihi.ToShortDateString();
            labelEPosta.Text = hasta.EPosta;
            labelTelefonNo.Text = hasta.TelefonNo;
        }

        private void HastaBilgisiTemizle()
        {
            labelTCKimlikNo.Text = "";
            labelAd.Text = "";
            labelSoyad.Text = "";
            labelAdres.Text = "";
            labelCinsiyet.Text = "";
            labelDogumTarihi.Text = "";
            labelEPosta.Text = "";
            labelTelefonNo.Text = "";
        }

        private void RandevuBilgisiTemizle()
        {
            labelSonRandevuSeans.Text = "";
            labelSonRandevuUzman.Text = "";
            labelSonSeansNot.Text = "";
            labelSonSeansSeans.Text = "";
            labelSonSeansUzman.Text = "";

            buttonYeniRandevu.Enabled = false;
            buttonRandevuIptalEt.Enabled = false;
        }

        private void FormHastaRandevuYonetimi_Load(object sender, EventArgs e)
        {
            HastaBilgisiTemizle();
            RandevuBilgisiTemizle();
        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            HastalariListele();
        }

        private void buttonYeniHasta_Click(object sender, EventArgs e)
        {
            FormHastaBilgisi form = new FormHastaBilgisi();
            DialogResult cevap = form.ShowDialog();
            if (cevap == DialogResult.OK)
            {
                textBoxAd.Text = form.hasta.Ad;
                textBoxSoyad.Text = form.hasta.Soyad;
                HastalariListele();
                if (listBoxHastalar.Items.Count > 0) listBoxHastalar.SelectedIndex = 0;
            }
        }

        private void listBoxHastalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            hasta = (Hasta)listBoxHastalar.Items[listBoxHastalar.SelectedIndex];
            HastaBilgisiYukle();
            RandevuBilgisiYukle();
        }

        private void buttonHastaBilgileriniDuzenle_Click(object sender, EventArgs e)
        {
            int indeks = listBoxHastalar.SelectedIndex;
            FormHastaBilgisi form = new FormHastaBilgisi();
            form.hasta = this.hasta;
            form.ShowDialog();

            HastalariListele();
            listBoxHastalar.SelectedIndex = indeks;
        }

        private void buttonYeniRandevu_Click(object sender, EventArgs e)
        {
            FormYeniRandevu form = new FormYeniRandevu();
            form.hasta = this.hasta;
            form.ShowDialog();
        }

        private void buttonRandevuIptalEt_Click(object sender, EventArgs e)
        {

        }
    }
}
