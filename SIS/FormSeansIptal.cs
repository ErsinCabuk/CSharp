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
    public partial class FormSeansIptal : Form
    {
        public FormSeansIptal()
        {
            InitializeComponent();
        }

        public Seans seans;

        private bool KullanıcıGirdisiDogrula()
        {
            if (string.IsNullOrEmpty(textBoxIptalNedeni.Text))
            {
                MessageBox.Show("İptal nedenini girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxIptalNedeni.Focus();
                return false;
            }

            return true;
        }

        private void FormSeansIptal_Load(object sender, EventArgs e)
        {
            labelUzman.Text = seans.UzmanBilgisi;
            labelSeans.Text = seans.GoruntuMetni;
            seans.IptalEdenNo = Program.KullaniciNo;
        }

        private void buttonIptalEt_Click(object sender, EventArgs e)
        {

        }
    }
}
