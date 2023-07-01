using SIN = SISSiniflar;
using ISK = SISIsKatmani;

namespace SIS
{
    public partial class FormSifreDegistir : Form
    {
        public FormSifreDegistir()
        {
            InitializeComponent();
        }

        public SIN.Calisan calisan;

        private bool KullaniciGirdisiDogrula()
        {
            if(string.IsNullOrEmpty(textBoxEskiSifre.Text))
            {
                MessageBox.Show("Eski şifrenizi girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEskiSifre.Focus();
                return false;
            }

            if(string.IsNullOrEmpty(textBoxYeniSifre.Text))
            {
                MessageBox.Show("Yeni şifrenizi girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxYeniSifre.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(textBoxYeniSifreTekrar.Text))
            {
                MessageBox.Show("Yeni şifrenizi tekrar girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxYeniSifreTekrar.Focus();
                return false;
            }

            if(textBoxYeniSifre.Text != textBoxYeniSifreTekrar.Text)
            {
                MessageBox.Show("Yeni şifreniz ve tekrarı aynı değil.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxYeniSifreTekrar.Focus();
                return false;
            }

            return true;
        }

        private void buttonDegistir_Click(object sender, EventArgs e)
        {
            bool dogruMu = KullaniciGirdisiDogrula();

            if (!dogruMu) return;

            bool sonuc = false;
            try
            {
                sonuc = ISK.Calisan.SifreDegistir(calisan.No, textBoxYeniSifre.Text);
            }
            catch (Exception hata)
            {
                Yardimci.HataKaydet(hata);
                MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (sonuc)
            {
                MessageBox.Show("Kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
