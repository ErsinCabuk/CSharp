using SIN = SISSiniflar;
using ISK = SISIsKatmani;

namespace SIS
{
    public partial class FormYeniSeans : Form
    {
        public FormYeniSeans()
        {
            InitializeComponent();
        }

        public SIN.Calisan uzman = null;
        private const int enKisaSeansSuresi = 30;

        private bool KullaniciGirdisiDogrula()
        {
            if (dateTimePickerBaslangicSaati.Value > dateTimePickerBitisSaati.Value)
            {
                MessageBox.Show("Bitiş saati başlangıç saatinden önce olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimePickerBaslangicSaati.Focus();
                return false;
            }

            double seansSuresi = dateTimePickerBitisSaati.Value.Subtract(dateTimePickerBaslangicSaati.Value).TotalMinutes;
            if (seansSuresi < enKisaSeansSuresi)
            {
                MessageBox.Show("Seans süresi 30 dakikadan az.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimePickerBitisSaati.Focus();
                return false;
            }

            return true;
        }

        private void FormYeniSeans_Load(object sender, EventArgs e)
        {
            labelUzman.Text = uzman.GoruntuMetni;
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            bool dogruMu = KullaniciGirdisiDogrula();
            if (!dogruMu) return;

            SIN.Seans seans = new SIN.Seans();
            seans.UzmanNo = uzman.No;
            seans.Tarih = dateTimePickerTarih.Value;
            seans.BaslangicSaati = dateTimePickerBaslangicSaati.Value.ToShortTimeString();
            seans.BitisSaati = dateTimePickerBitisSaati.Value.ToShortTimeString();

            int sonuc = 0;

            try
            {
                sonuc = ISK.Seans.Kaydet(seans);
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
            else if (sonuc == -1) MessageBox.Show("Çakışma var.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
