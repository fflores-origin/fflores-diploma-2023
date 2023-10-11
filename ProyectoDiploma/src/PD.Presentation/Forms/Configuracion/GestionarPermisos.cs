using PD.Core.Interfaces;

namespace PD.Presentation.Forms.Configuracion
{
    public partial class GestionarPermisos : Form
    {
        private readonly IUsuarioManager _usuarioManager;

        public GestionarPermisos(IUsuarioManager usuarioManager)
        {
            InitializeComponent();
            _usuarioManager = usuarioManager;
        }

        public void ListarUsuario()
        {
            var list = _usuarioManager.GetUsuarios();

            dgv_usuarios.DataSource = list;
        }
    }
}