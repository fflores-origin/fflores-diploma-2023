using PD.Core.Interfaces;
using PD.Entities.Permisos;

namespace PD.Presentation.Forms.Configuracion
{
    public partial class GestionarPatentes : FormBase
    {
        private readonly IUsuarioManager _usuarioManager;

        public GestionarPatentes(IUsuarioManager usuarioManager)
        {
            InitializeComponent();
            _usuarioManager = usuarioManager;
        }

        private void GestionarPatentes_Load(object sender, EventArgs e)
        {
            LoadBase();
        }

        private void LoadBase()
        {
            FillCombos();
        }

        private void FillCombos()
        {
            List<Patente> permisos = _usuarioManager.GetAllPatentes();
            List<Familia> familas = _usuarioManager.GetAllFamilias();

            cbx_familias.DataSource = familas;

            cbx_familias.DisplayMember = "Nombre";
            cbx_familias.ValueMember = "Id";

            cbx_patentes.DataSource = permisos;

            cbx_patentes.DisplayMember = "Nombre";
            cbx_patentes.ValueMember = "Id";
        }

        internal void ShowAndLoad()
        {
            this.Show();
        }
    }
}