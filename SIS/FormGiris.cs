using ISK = SISIsKatmani;
using SIN = SISSiniflar;

namespace SIS
{
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }

        private void buttonGiris_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxKullanici.Text))
            {
                MessageBox.Show("Kullanıcı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxKullanici.Focus();
                return;
            }

            if (string.IsNullOrEmpty(textBoxSifre.Text))
            {
                MessageBox.Show("Şifre girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxKullanici.Focus();
                return;
            }

            int calisanNo = 0;

            try { calisanNo = ISK.Calisan.KullaniciGirisiniDogrula(textBoxKullanici.Text, textBoxSifre.Text); }
            catch (Exception hata)
            {
                Yardimci.HataKaydet(hata);
                MessageBox.Show("Servisde bir hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (calisanNo > 0)
            {
                Yardimci.KullaniciNo = calisanNo;
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı veya şifre yanlış.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxKullanici.SelectAll();
                textBoxKullanici.Focus();
            }
        }
    }
}