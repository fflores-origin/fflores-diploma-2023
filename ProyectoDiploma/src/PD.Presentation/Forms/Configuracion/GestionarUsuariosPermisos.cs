using PD.Core.Interfaces;

namespace PD.Presentation.Forms.Configuracion
{
    public partial class GestionarUsuariosPermisos : FormBase
    {
        private readonly IUsuarioManager _usuarioManager;

        public GestionarUsuariosPermisos(IUsuarioManager usuarioManager)
        {
            InitializeComponent();
            _usuarioManager = usuarioManager;
        }

        public void ListarUsuario()
        {
            var list = _usuarioManager.GetUsuarios();
            dgv_usuarios.DataSource = list;

            var patentes = _usuarioManager.GetPatentes();
        }

        private void GestionarPermisos_Load(object sender, EventArgs e)
        {
            ListarUsuario();
        }

        #region Grid

        private void FormatGrid()
        {

        }

        #endregion
    }
}