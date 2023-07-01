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

        }

        private void UzmanSeanslariniYukle()
        {
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
            uzman = (SIN.Calisan) comboBoxUzman.SelectedItem;
            UzmanSeanslariniYukle();
        }

        private void comboBoxSeans_SelectedIndexChanged(object sender, EventArgs e)
        {
            seans = (SIN.Seans) comboBoxSeans.SelectedItem;
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {

        }
    }
}
