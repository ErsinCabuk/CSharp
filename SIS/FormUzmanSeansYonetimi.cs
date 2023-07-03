using SIN = SISSiniflar;
using ISK = SISIsKatmani;
using System.Diagnostics;

namespace SIS
{
    public partial class FormUzmanSeansYonetimi : Form
    {
        public FormUzmanSeansYonetimi()
        {
            InitializeComponent();
        }

        public SIN.Calisan uzman = null;
        private SIN.Hasta hasta = null;
        private SIN.Seans aktifSeans = null;
        private SIN.Seans gecmisSeans = null;

        private void UzmanSeanslariniYukle()
        {
            SIN.Seans[] seanslar = null;

            try
            {
                seanslar = ISK.Seans.UzmanSeanslariniListele(uzman.No);
            }
            catch (Exception hata)
            {
                Yardimci.HataKaydet(hata);
                MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            comboBoxSeanslar.DataSource = seanslar;
            comboBoxSeanslar.DisplayMember = "GoruntuMetni";
        }

        private void BilgileriYukle()
        {
            if(hasta != null)
            {
                labelAd.Text = hasta.Ad;
                labelAdres.Text = hasta.Adres;
                labelTelefonNo.Text = hasta.TelefonNo;
                labelCinsiyet.Text = hasta.Cinsiyet;
                labelDogumTarihi.Text = hasta.DogumTarihi.ToShortDateString();
                labelEPosta.Text = hasta.EPosta;
                labelSoyad.Text = hasta.Soyad;
                labelTCKimlikNo.Text = hasta.TCKimlikNo;

                textBoxSeansNotu.Text = aktifSeans.SeansNotu;

                SIN.Seans[] hastaSeanslari = null;

                try
                {
                    hastaSeanslari = ISK.Seans.HastaSeanslariniListele(hasta.No);
                }
                catch (Exception hata)
                {
                    Yardimci.HataKaydet(hata);
                    MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                listBoxSeanslar.DataSource = hastaSeanslari;
                listBoxSeanslar.DisplayMember = "GoruntuMetni";
            }
        }

        private bool SeansNotuKaydet(int seansNo, string seansNotu)
        {
            bool sonuc = false;

            try
            {
                sonuc = ISK.Seans.NotGuncelle(seansNo, seansNotu);
            }
            catch (Exception hata)
            {
                Yardimci.HataKaydet(hata);
                MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return sonuc;
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
            EkraniTemizle();

            try
            {
                uzman = ISK.Calisan.CalisanGetir(Yardimci.KullaniciNo);
            } catch (Exception hata) 
            {
                Yardimci.HataKaydet(hata);
                MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            UzmanSeanslariniYukle();
        }

        private void listBoxSeanslar_SelectedIndexChanged(object sender, EventArgs e)
        {
            gecmisSeans = (SIN.Seans) listBoxSeanslar.SelectedItem;
            if (gecmisSeans != null) textBoxGecmisSeansNotu.Text = gecmisSeans.SeansNotu;
        }

        private void comboBoxSeanslar_SelectedIndexChanged(object sender, EventArgs e)
        {
            EkraniTemizle();

            aktifSeans = (SIN.Seans) comboBoxSeanslar.SelectedItem;

            if(aktifSeans.HastaNo > 0)
            {
                try
                {
                    hasta = ISK.Hasta.HastaGetir(aktifSeans.HastaNo);
                }
                catch (Exception hata)
                {
                    Yardimci.HataKaydet(hata);
                    MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            BilgileriYukle();
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
