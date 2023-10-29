using Microsoft.Extensions.Configuration;
using PD.Presentation.Forms.Articulos;
using PD.Presentation.Forms.Configuracion;

namespace PD.Presentation
{
    public partial class Main : Form
    {
        private readonly IConfiguration _configuration;
        private readonly GestionArticulos _gestionArticulosForm;
        private readonly GestionarPermisos _gestionarPermisosFrom;
        private readonly GestionCategorias _gestionCategoriasForm;

        public Main(
            IConfiguration configuration,
            GestionArticulos gestionArticulosForm,
            GestionarPermisos gestionarPermisosFrom,
            GestionCategorias gestionCategoriasForm)
        {
            InitializeComponent();
            _configuration = configuration;
            _gestionArticulosForm = gestionArticulosForm;
            _gestionarPermisosFrom = gestionarPermisosFrom;
            _gestionCategoriasForm = gestionCategoriasForm;

            _gestionArticulosForm.MdiParent = this;
            _gestionarPermisosFrom.MdiParent = this;
            _gestionCategoriasForm.MdiParent = this;
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
            _gestionCategoriasForm.Dispose();
            _gestionarPermisosFrom.Dispose();
            Application.Exit();
        }

        private void gestionarPermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _gestionarPermisosFrom.Show();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
        }

        private void OpenCategoriasForm(object sender, EventArgs e)
        {
            _gestionCategoriasForm.Show();
        }
    }
}