using PD.Core.Interfaces;
using PD.Entities;

namespace PD.Presentation.Forms.Articulos
{
    public partial class GestionArticulos : Form
    {
        private readonly IArticulosManager _articuloManager;
        private List<ArticuloListaDTO> _articulos;

        public GestionArticulos(IArticulosManager articuloManager)
        {
            InitializeComponent();
            _articuloManager = articuloManager;
        }

        private void GestionArticulos_Load(object sender, EventArgs e)
        {
            _articulos = _articuloManager.GetList();
            dgv_articulos.DataSource = _articulos;
        }
    }
}