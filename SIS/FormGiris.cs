namespace SIS
{
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }

        private void buttonGiris_Click(object sender, EventArgs e)
        {

        }

        private void FormGiris_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Ad soyad girin.", "Uyar?!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}