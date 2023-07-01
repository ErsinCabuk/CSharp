using SIN = SISSiniflar;
using ISK = SISIsKatmani;

namespace SIS
{
    public partial class FormSeansYonetimi : Form
    {
        public FormSeansYonetimi()
        {
            InitializeComponent();
        }

        SIN.Calisan uzman = null;

        private void UzmanlariYukle()
        {

        }

        private void UzmanSeanslariniYukle()
        {

        }

        private void FormSeansYonetimi_Load(object sender, EventArgs e)
        {
            UzmanlariYukle();
        }

        private void comboBoxUzman_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.uzman = (SIN.Calisan) comboBoxUzman.SelectedItem;
            UzmanSeanslariniYukle();
        }

        private void buttonYeniSeansEkle_Click(object sender, EventArgs e)
        {
            FormYeniSeans form = new FormYeniSeans();
            form.uzman = this.uzman;
            form.ShowDialog();
            UzmanSeanslariniYukle();
        }

        private void buttonSeansIptal_Click(object sender, EventArgs e)
        {
            SIN.Seans seans = (SIN.Seans)listBoxSeanslar.SelectedItem;

            FormSeansIptal form = new FormSeansIptal();
            form.seans = seans;
            form.ShowDialog();
            UzmanSeanslariniYukle();
        }
    }
}
