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
    public partial class FormSekreterBilgisi : Form
    {
        public FormSekreterBilgisi()
        {
            InitializeComponent();
        }

        public Calisan calisan;

        private void UzmanYükle()
        {
            textBoxAd.Text = calisan.Ad;
            textBoxSoyad.Text = calisan.Soyad;
            textBoxEPosta.Text = calisan.EPosta;
            textBoxTelefonNo.Text = calisan.TelefonNo;
            textBoxTCKimlikNo.Text = calisan.TCKimlikNo;
        }

        private bool KullanıcıGirdisiDogrula()
        {
            if (string.IsNullOrEmpty(textBoxAd.Text) || string.IsNullOrEmpty(textBoxSoyad.Text))
            {
                MessageBox.Show("Ad ve soyad girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAd.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(textBoxEPosta.Text))
            {
                MessageBox.Show("EPosta girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAd.Focus();
                return false;
            }

            return true;
        }

        private void FormSekreterBilgisi_Load(object sender, EventArgs e)
        {

        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {

        }
    }
}
