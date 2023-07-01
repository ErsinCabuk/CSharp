using SIN = SISSiniflar;
using ISK = SISIsKatmani;

namespace SIS
{
    public partial class FormUzmanBilgisi : Form
    {
        public FormUzmanBilgisi()
        {
            InitializeComponent();
        }

        public SIN.Calisan calisan;

        private void UzmanYukle()
        {
            textBoxAd.Text = calisan.Ad;
            textBoxSoyad.Text = calisan.Soyad;
            textBoxEPosta.Text = calisan.EPosta;
            textBoxTelefonNo.Text = calisan.TelefonNo;
            textBoxTCKimlikNo.Text = calisan.TCKimlikNo;
        }

        private bool KullanıcıGirdisiDogrula()
        {
            if (string.IsNullOrEmpty(textBoxAd.Text) || string.IsNullOrEmpty(textBoxSoyad.Text))
            {
                MessageBox.Show("Ad ve soyad girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAd.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(textBoxEPosta.Text))
            {
                MessageBox.Show("EPosta girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAd.Focus();
                return false;
            }

            return true;
        }

        private void FormUzmanBilgisi_Load(object sender, EventArgs e)
        {
            if (calisan != null) UzmanYukle();
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            bool dogruMu = KullanıcıGirdisiDogrula();

            if (!dogruMu) return;

            if (calisan == null) calisan = new SIN.Calisan();

            calisan.Ad = textBoxAd.Text;
            calisan.Soyad = textBoxSoyad.Text;
            calisan.TCKimlikNo = textBoxTCKimlikNo.Text;
            calisan.Unvan = textBoxUnvan.Text;
            calisan.EPosta = textBoxEPosta.Text;
            calisan.TelefonNo = textBoxTelefonNo.Text;
            calisan.CalisanTipi = SIN.Calisan.CalisanTipleri.Uzman;

            int sonuc = 0;
            try
            {
                sonuc = ISK.Calisan.Kaydet(calisan);
            }
            catch (Exception hata)
            {
                Yardimci.HataKaydet(hata);
                MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (sonuc > 0)
            {
                MessageBox.Show("Kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
