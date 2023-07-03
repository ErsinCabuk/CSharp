using SIN = SISSiniflar;
using ISK = SISIsKatmani;

namespace SIS
{
    public partial class FormYeniRandevu : Form
    {
        public FormYeniRandevu()
        {
            InitializeComponent();
        }

        public SIN.Hasta hasta;
        private SIN.Calisan uzman;
        private SIN.Seans seans;

        private void UzmanlariYukle()
        {
            SIN.Calisan[] calisanlar = null;

            try
            {
                calisanlar = ISK.Calisan.UzmanlariListele();
            }
            catch (Exception hata)
            {
                Yardimci.HataKaydet(hata);
                MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            comboBoxUzman.DataSource = calisanlar;
            comboBoxUzman.DisplayMember = "GoruntuMetni";
        }

        private void UzmanSeanslariniYukle()
        {
            SIN.Seans[] seanslar = null;

            try
            {
                seanslar = ISK.Seans.UzmanSeanslariniListele(uzman.No);
            }
            catch (Exception hata)
            {
                Yardimci.HataKaydet(hata);
                MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            comboBoxSeans.DataSource = seanslar;
            comboBoxSeans.DisplayMember = "GoruntuMetni";
        }

        private bool KullanıcıGirdisiDogrula()
        {
            if (uzman == null)
            {
                MessageBox.Show("Uzman seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxUzman.Focus();
                return false;
            }

            if (seans == null)
            {
                MessageBox.Show("Seans seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxSeans.Focus();
                return false;
            }

            return true;
        }

        private void FormYeniRandevu_Load(object sender, EventArgs e)
        {
            labelHasta.Text = hasta.GoruntuMetni;
            UzmanlariYukle();
        }

        private void comboBoxUzman_SelectedIndexChanged(object sender, EventArgs e)
        {
            uzman = (SIN.Calisan)comboBoxUzman.SelectedItem;
            UzmanSeanslariniYukle();
        }

        private void comboBoxSeans_SelectedIndexChanged(object sender, EventArgs e)
        {
            seans = (SIN.Seans)comboBoxSeans.SelectedItem;
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            bool dogruMu = KullanıcıGirdisiDogrula();
            if (!dogruMu) return;

            bool sonuc = false;

            try
            {
                seans.HastaNo = hasta.No;
                sonuc = ISK.Seans.RandevuKaydet(seans.No, hasta.No);
            }
            catch (Exception hata)
            {
                Yardimci.HataKaydet(hata);
                MessageBox.Show("Servisde hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
