using SIN = SISSiniflar;
using ISK = SISIsKatmani;

namespace SIS
{
    public partial class FormCalisanAra : Form
    {
        public FormCalisanAra()
        {
            InitializeComponent();
        }

        private void CalisanlariListele()
        {
            SIN.Calisan[] calisanlar = null;
            listBoxCalisanlar.DisplayMember = "GoruntuMetni";

            try
            {
                calisanlar = ISK.Calisan.CalisanlariListele(textBoxAd.Text, textBoxSoyad.Text);
            }
            catch (Exception hata)
            {
                Yardimci.HataKaydet(hata);
                MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                listBoxCalisanlar.DataSource = calisanlar;
            }
        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            CalisanlariListele();
        }

        private void listBoxCalisanlar_DoubleClick(object sender, EventArgs e)
        {
            int indeks = listBoxCalisanlar.SelectedIndex;
            SIN.Calisan calisan = (SIN.Calisan)listBoxCalisanlar.SelectedItem;
            if (calisan.CalisanTipi == SIN.Calisan.CalisanTipleri.Sekreter)
            {
                FormSekreterBilgisi form = new FormSekreterBilgisi();
                form.calisan = calisan;
                form.ShowDialog();
            }
            else if (calisan.CalisanTipi == SIN.Calisan.CalisanTipleri.Uzman)
            {
                FormUzmanBilgisi form = new FormUzmanBilgisi();
                form.calisan = calisan;
                form.ShowDialog();
            }

            CalisanlariListele();
            listBoxCalisanlar.SelectedIndex = indeks;
        }

        private void FormCalisanAra_Load(object sender, EventArgs e)
        {
            CalisanlariListele();
        }
    }
}
