using Microsoft.Extensions.Configuration;
using PD.Presentation.Forms.Articulos;

namespace PD.Presentation
{
    public partial class Main : Form
    {
        private readonly IConfiguration _configuration;
        private readonly GestionArticulos _gestionArticulosForm;

        public Main(
            IConfiguration configuration,
            GestionArticulos gestionArticulosForm)
        {
            InitializeComponent();
            _configuration = configuration;
            _gestionArticulosForm = gestionArticulosForm;
            _gestionArticulosForm.MdiParent = this;
        }

        private void Btn_gestionarArticulos_Click(object sender, EventArgs e)
        {
            _gestionArticulosForm.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }
    }
}