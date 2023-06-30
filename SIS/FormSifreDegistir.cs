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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SIS
{
    public partial class FormSifreDegistir : Form
    {
        public FormSifreDegistir()
        {
            InitializeComponent();
        }

        public Calisan calisan;

        private bool KullaniciGirdisiDogrula()
        {
            if(string.IsNullOrEmpty(textBoxEskiSifre.Text))
            {
                MessageBox.Show("Eski şifrenizi girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEskiSifre.Focus();
                return false;
            }

            if(string.IsNullOrEmpty(textBoxYeniSifre.Text))
            {
                MessageBox.Show("Yeni şifrenizi girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxYeniSifre.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(textBoxYeniSifreTekrar.Text))
            {
                MessageBox.Show("Yeni şifrenizi tekrar girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxYeniSifreTekrar.Focus();
                return false;
            }

            if(textBoxYeniSifre.Text != textBoxYeniSifreTekrar.Text)
            {
                MessageBox.Show("Yeni şifreniz ve tekrarı aynı değil.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxYeniSifreTekrar.Focus();
                return false;
            }

            return true;
        }

        private void buttonDegistir_Click(object sender, EventArgs e)
        {

        }
    }
}
