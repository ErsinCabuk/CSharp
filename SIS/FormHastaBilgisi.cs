using SISSiniflar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIS
{
    public partial class FormHastaBilgisi : Form
    {
        public FormHastaBilgisi()
        {
            InitializeComponent();
        }

        public Hasta hasta;

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

        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {

        }
    }
}
