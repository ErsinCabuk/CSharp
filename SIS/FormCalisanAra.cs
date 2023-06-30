using SISSiniflar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            CalisanlariListele();
        }

        private void listBoxCalisanlar_DoubleClick(object sender, EventArgs e)
        {
            int indeks = listBoxCalisanlar.SelectedIndex;
            Calisan calisan = (Calisan)listBoxCalisanlar.SelectedItem;
            if (calisan.CalisanTipi == CalisanTipleri.Sekreter)
            {
                FormSekreterBilgisi form = new FormSekreterBilgisi();
                form.calisan = calisan;
                form.ShowDialog();
            }
            else if (calisan.CalisanTipi == CalisanTipleri.Uzman)
            {
                FormUzmanBilgisi form = new FormUzmanBilgisi();
                form.calisan = calisan;
                form.ShowDialog();
            }

            CalisanlariListele();
            listBoxCalisanlar.SelectedIndex = indeks;
        }
    }
}
