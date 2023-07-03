using ISK = SISIsKatmani;
using SIN = SISSiniflar;

namespace SIS
{
    public partial class FormSeansIptal : Form
    {
        public FormSeansIptal()
        {
            InitializeComponent();
        }

        public SIN.Seans seans;

        private bool KullanıcıGirdisiDogrula()
        {
            if (string.IsNullOrEmpty(textBoxIptalNedeni.Text))
            {
                MessageBox.Show("İptal nedenini girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxIptalNedeni.Focus();
                return false;
            }

            return true;
        }

        private void FormSeansIptal_Load(object sender, EventArgs e)
        {
            labelUzman.Text = seans.UzmanBilgisi;
            labelSeans.Text = seans.GoruntuMetni;
            seans.IptalEdenNo = Yardimci.KullaniciNo;
        }

        private void buttonIptalEt_Click(object sender, EventArgs e)
        {
            bool dogruMu = KullanıcıGirdisiDogrula();
            if (!dogruMu) return;

            bool sonuc = false;

            try
            {
                sonuc = ISK.Seans.IptalEt(seans);
            }
            catch (Exception hata)
            {
                Yardimci.HataKaydet(hata);
                MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (sonuc)
            {
                MessageBox.Show("Seans iptal edildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
