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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SIS
{
    public partial class FormUzmanSeansYonetimi : Form
    {
        public FormUzmanSeansYonetimi()
        {
            InitializeComponent();
        }

        public Calisan uzman = null;
        private Hasta hasta = null;
        private Seans aktifSeans = null;
        private Seans gecmisSeans = null;

        private void UzmanSeanslariniYukle()
        {

        }

        private void BilgileriYukle()
        {

        }

        private bool SeansNotuKaydet(int seansNo, string seansNotu)
        {

        }

        private void EkraniTemizle()
        {
            hasta = null;

            labelTCKimlikNo.Text = "";
            labelAd.Text = "";
            labelSoyad.Text = "";
            labelAdres.Text = "";
            labelCinsiyet.Text = "";
            labelDogumTarihi.Text = "";
            labelEPosta.Text = "";
            labelTelefonNo.Text = "";
        }

        private void FormUzmanSeansYonetimi_Load(object sender, EventArgs e)
        {

        }

        private void listBoxSeanslar_SelectedIndexChanged(object sender, EventArgs e)
        {
            gecmisSeans = (Seans) listBoxSeanslar.SelectedItem;
            if (gecmisSeans != null) textBoxGecmisSeansNotu.Text = gecmisSeans.SeansNotu;
        }

        private void comboBoxSeanslar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonGecmisSeansNotuDuzenle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxGecmisSeansNotu.Text))
            {
                MessageBox.Show("Eski seans için seans notunu girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxGecmisSeansNotu.Focus();
                return;
            }

            bool sonuc = SeansNotuKaydet(gecmisSeans.No, textBoxGecmisSeansNotu.Text);
            if (sonuc)
            {
                gecmisSeans.SeansNotu = textBoxGecmisSeansNotu.Text;
                MessageBox.Show("Seans notu güncellendi.", "Güncelledi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("İşlem yapılamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonSeansNotuKaydet_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxSeansNotu.Text))
            {
                MessageBox.Show("Seans notu girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxSeansNotu.Focus();
                return;
            }

            bool sonuc = SeansNotuKaydet(aktifSeans.No, textBoxSeansNotu.Text);
            if (sonuc)
            {
                aktifSeans.SeansNotu = textBoxSeansNotu.Text;
                EkraniTemizle();
                UzmanSeanslariniYukle();
                MessageBox.Show("Seans notu kaydedildi.", "Kaydedildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("İşlem yapılamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
