using SIN = SISSiniflar;
using ISK = SISIsKatmani;
using System.Security.Authentication;

namespace SIS
{
    public partial class FormHastaBilgisi : Form
    {
        public FormHastaBilgisi()
        {
            InitializeComponent();
        }

        public SIN.Hasta hasta;

        private void HastaYukle()
        {
            textBoxAd.Text = hasta.Ad;
            textBoxSoyad.Text = hasta.Soyad;
            textBoxTelefonNo.Text = hasta.TelefonNo;
            textBoxTCKimlikNo.Text = hasta.TCKimlikNo;
            textBoxAdres.Text = hasta.Adres;
            textBoxEPosta.Text = hasta.EPosta;
            comboBoxCinsiyet.SelectedText = hasta.Cinsiyet;
            dateTimePickerDogumTarihi.Value = hasta.DogumTarihi;
        }

        private bool KullanıcıGirdisiDogrula()
        {
            if (string.IsNullOrEmpty(textBoxAd.Text) || string.IsNullOrEmpty(textBoxSoyad.Text))
            {
                MessageBox.Show("Ad ve soyad girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAd.Focus();
                return false;
            }

            return true;
        }

        private void FormHastaBilgisi_Load(object sender, EventArgs e)
        {
            dateTimePickerDogumTarihi.Value = DateTime.Now;
            comboBoxCinsiyet.SelectedIndex = 0;

            if(hasta != null) HastaYukle();
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            bool dogruMu = KullanıcıGirdisiDogrula();
            if (!dogruMu) return;
            if(hasta == null) hasta = new SIN.Hasta();

            hasta.Ad = textBoxAd.Text;
            hasta.Adres = textBoxAdres.Text;
            hasta.Soyad = textBoxSoyad.Text;
            hasta.TCKimlikNo = textBoxTCKimlikNo.Text;
            hasta.EPosta = textBoxEPosta.Text;
            hasta.TelefonNo = textBoxTelefonNo.Text;
            hasta.Cinsiyet = comboBoxCinsiyet.Items[comboBoxCinsiyet.SelectedIndex].ToString();
            hasta.DogumTarihi = dateTimePickerDogumTarihi.Value;

            int sonuc = 0;

            try
            {
                sonuc = ISK.Hasta.Kaydet(hasta);
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
