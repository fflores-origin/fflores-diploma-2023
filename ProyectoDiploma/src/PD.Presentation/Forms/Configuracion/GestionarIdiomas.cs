namespace PD.Presentation.Forms.Configuracion
{
    public partial class GestionarIdiomas : Form
    {
        public GestionarIdiomas()
        {
            InitializeComponent();
        }

        private void FormHide(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}