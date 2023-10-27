using PD.Core.DTO;
using PD.Core.Interfaces;

namespace PD.Presentation.Forms.Articulos
{
    public partial class GestionArticulos : Form
    {
        private readonly IArticulosManager _articuloManager;
        private List<ArticuloListaDTO> _articulos;
        private EdicionArticulo _edicionArticuloForm;


        public GestionArticulos(
            IArticulosManager articuloManager,
            EdicionArticulo edicionArticuloForm)
        {
            InitializeComponent();
            _articuloManager = articuloManager;
            _edicionArticuloForm = edicionArticuloForm;
        }

        private void GestionArticulos_Load(object sender, EventArgs e)
        {
            //_articulos = _articuloManager.GetList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _edicionArticuloForm.Show();

        }
    }
}