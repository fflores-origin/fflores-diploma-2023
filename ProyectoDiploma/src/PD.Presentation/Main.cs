using Microsoft.Extensions.Configuration;
using PD.Core.Interfaces;
using PD.Presentation.Forms.Articulos;
using PD.Presentation.Forms.Configuracion;

namespace PD.Presentation
{
    public partial class Main : Form
    {
        #region Fields

        private readonly IConfiguration _configuration;
        private readonly IUsuarioManager _usuarioManager;
        private readonly GestionArticulos _gestionArticulosForm;
        private readonly GestionarPermisos _gestionarPermisosFrom;
        private readonly GestionCategorias _gestionCategoriasForm;
        private readonly GestionListas _gestionListasForm;

        #endregion Fields

        #region CTOR

        public Main(
            IConfiguration configuration,
            GestionArticulos gestionArticulosForm,
            GestionarPermisos gestionarPermisosFrom,
            GestionCategorias gestionCategoriasForm,
            GestionListas gestionListasForm,
            IUsuarioManager usuarioManager)
        {
            InitializeComponent();
            _configuration = configuration;
            _gestionArticulosForm = gestionArticulosForm;
            _gestionarPermisosFrom = gestionarPermisosFrom;
            _gestionCategoriasForm = gestionCategoriasForm;
            _gestionListasForm = gestionListasForm;

            _gestionArticulosForm.MdiParent = this;
            _gestionarPermisosFrom.MdiParent = this;
            _gestionCategoriasForm.MdiParent = this;
            _gestionListasForm.MdiParent = this;
            _usuarioManager = usuarioManager;
        }

        #endregion CTOR

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
            _gestionArticulosForm.Dispose();
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

        private void listasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _gestionListasForm.Show();
        }

        private void tsc_idioma_Click(object sender, EventArgs e)
        {
        }

        private void LoadLanguages()
        {

            var languages = _usuarioManager.GetIdiomas();

            foreach (var language in languages) { 
            
                
            }


        }
    }
}