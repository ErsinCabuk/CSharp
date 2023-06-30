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
    public partial class FormSeansYonetimi : Form
    {
        public FormSeansYonetimi()
        {
            InitializeComponent();
        }

        Calisan uzman = null;

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
            this.uzman = (Calisan) comboBoxUzman.SelectedItem;
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
            Seans seans = (Seans) listBoxSeanslar.SelectedItem;

            FormSeansIptal form = new FormSeansIptal();
            form.seans = seans;
            form.ShowDialog();
            UzmanSeanslariniYukle();
        }
    }
}
