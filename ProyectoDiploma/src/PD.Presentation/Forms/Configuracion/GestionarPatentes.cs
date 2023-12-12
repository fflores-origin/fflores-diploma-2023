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
        }
    }
}