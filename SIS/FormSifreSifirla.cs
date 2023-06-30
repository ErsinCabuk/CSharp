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
    public partial class FormSifreSifirla : Form
    {
        public FormSifreSifirla()
        {
            InitializeComponent();
        }

        private bool KullanıcıGirdisiDogrula()
        {
            if (string.IsNullOrEmpty(textBoxEPosta.Text))
            {
                MessageBox.Show("Epostanızı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEPosta.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(textBoxYeniSifre.Text))
            {
                MessageBox.Show("Yeni şifrenizi girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxYeniSifre.Focus();
                return false;
            }

            return true;
        }

        private void buttonSifirla_Click(object sender, EventArgs e)
        {

        }
    }
}
