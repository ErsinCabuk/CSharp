using SIN = SISSiniflar;
using ISK = SISIsKatmani;

namespace SIS
{
    public partial class FormSifreSifirla : Form
    {
        public FormSifreSifirla()
        {
            InitializeComponent();
        }

        private bool KullaniciGirdisiDogrula()
        {
            if (string.IsNullOrEmpty(textBoxEPosta.Text))
            {
                MessageBox.Show("Epostanızı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEPosta.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(textBoxYeniSifre.Text))
            {
                MessageBox.Show("Yeni şifrenizi girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxYeniSifre.Focus();
                return false;
            }

            return true;
        }

        private void buttonSifirla_Click(object sender, EventArgs e)
        {
            bool dogruMu = KullaniciGirdisiDogrula();

            if (!dogruMu) return;

            bool sonuc = false;
            try
            {
                sonuc = ISK.Calisan.SifreSifirla(textBoxEPosta.Text, textBoxYeniSifre.Text);
            }
            catch (Exception hata)
            {
                Yardimci.HataKaydet(hata);
                MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            /*if (sonuc)
            {
                MessageBox.Show("Kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);*/
        }
    }
}
