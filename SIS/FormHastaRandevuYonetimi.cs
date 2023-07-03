using ISK = SISIsKatmani;
using SIN = SISSiniflar;

namespace SIS
{
    public partial class FormHastaRandevuYonetimi : Form
    {
        public FormHastaRandevuYonetimi()
        {
            InitializeComponent();
        }

        public SIN.Hasta hasta = null;
        private SIN.Seans sonRandevu = null;
        private SIN.Seans sonSeans = null;

        private void RandevuBilgisiYukle()
        {
            RandevuBilgisiTemizle();

            try
            {
                sonRandevu = ISK.Seans.SonRandevuBilgisiGetir(hasta.No);
            }
            catch (Exception hata)
            {
                Yardimci.HataKaydet(hata);
                MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (sonRandevu != null)
            {
                labelSonRandevuSeans.Text = sonRandevu.GoruntuMetni;
                labelSonRandevuUzman.Text = sonRandevu.UzmanBilgisi;
                buttonRandevuIptalEt.Enabled = true;
            }
            else buttonYeniRandevu.Enabled = true;

            try
            {
                sonSeans = ISK.Seans.SonSeansBilgisiGetir(hasta.No);
            }
            catch (Exception hata)
            {
                Yardimci.HataKaydet(hata);
                MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (sonSeans != null)
            {
                labelSonRandevuSeans.Text = sonSeans.GoruntuMetni;
                labelSonRandevuUzman.Text = sonSeans.UzmanBilgisi;
                labelSonSeansNot.Text = sonSeans.SeansNotu;
            }
        }

        private void HastalariListele()
        {
            listBoxHastalar.DisplayMember = "GoruntuMetni";
            SIN.Hasta[] hastalar = null;

            try
            {
                hastalar = ISK.Hasta.HastalariListele(textBoxAd.Text, textBoxSoyad.Text);
            }
            catch (Exception hata)
            {
                Yardimci.HataKaydet(hata);
                MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                listBoxHastalar.DataSource = hastalar;
            }
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
            HastalariListele();
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
            hasta = (SIN.Hasta)listBoxHastalar.Items[listBoxHastalar.SelectedIndex];
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
            DialogResult karar = MessageBox.Show("Randevu iptal edilsin mi?", "İptal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (karar == DialogResult.Yes)
            {
                bool sonuc = false;

                try
                {
                    sonuc = ISK.Seans.RandevuIptalEt(sonRandevu.No);
                }
                catch (Exception hata)
                {
                    Yardimci.HataKaydet(hata);
                    MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (sonuc) RandevuBilgisiYukle();
            }
        }
    }
}
