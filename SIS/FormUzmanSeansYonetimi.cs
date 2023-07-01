using SIN = SISSiniflar;
using ISK = SISIsKatmani;

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

        }

        private void BilgileriYukle()
        {

        }

        private bool SeansNotuKaydet(int seansNo, string seansNotu)
        {
            return true;
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
            gecmisSeans = (SIN.Seans) listBoxSeanslar.SelectedItem;
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
