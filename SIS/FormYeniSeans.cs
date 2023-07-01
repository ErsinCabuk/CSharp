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

        }
    }
}
