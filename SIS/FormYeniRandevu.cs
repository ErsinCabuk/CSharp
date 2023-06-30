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
    public partial class FormYeniRandevu : Form
    {
        public FormYeniRandevu()
        {
            InitializeComponent();
        }

        public Hasta hasta;
        private Calisan uzman;
        private Seans seans;

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
            uzman = (Calisan) comboBoxUzman.SelectedItem;
            UzmanSeanslariniYukle();
        }

        private void comboBoxSeans_SelectedIndexChanged(object sender, EventArgs e)
        {
            seans = (Seans) comboBoxSeans.SelectedItem;
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {

        }
    }
}
