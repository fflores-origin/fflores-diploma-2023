using PD.Core.Interfaces;

namespace PD.Presentation.Forms.Articulos
{
    public partial class GestionListas : FormBase
    {

        private readonly IListasManager _manager;
        private readonly IArticulosManager _managerArticulosManager;

        public GestionListas(IListasManager manager)
        {
            InitializeComponent();
            _manager = manager;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }

        private void GestionListas_Load(object sender, EventArgs e)
        {
            var listas = _manager.GetAll();

        }
    }
}