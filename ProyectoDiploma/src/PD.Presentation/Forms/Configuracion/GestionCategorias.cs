using PD.Core.Interfaces;

namespace PD.Presentation.Forms.Configuracion
{
    public partial class GestionCategorias : Form
    {
        private readonly ICategoriaManager _manager;

        public GestionCategorias(
            ICategoriaManager manager)
        {
            InitializeComponent();
            _manager = manager;
        }

        private void GestionCategorias_Load(object sender, EventArgs e)
        {
            _manager.
        }
    }
}