using PD.Core.DTOs.Articulo;
using PD.Core.Interfaces;
using PD.Presentation.Helpers;

namespace PD.Presentation.Forms.Articulos
{
    public partial class EdicionArticulo : FormBase
    {
        private readonly ICategoriaManager _categoriaManager;
        private readonly IListasManager _listasManager;
        private ArticuloDTO _articulo;

        public EdicionArticulo(
            ICategoriaManager categoriaManager,
            IListasManager listasManager)
            : base()
        {
            InitializeComponent();
            _categoriaManager = categoriaManager;
            _listasManager = listasManager;
        }

        private void btn_qr_Click(object sender, EventArgs e)
        {
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (HasInvalidInputs()) return;
        }

        private bool HasInvalidInputs()
        {
            if (txt_nombre.IsTextInvalid())
            { ShowEmptyFieldMessage("Nombre"); return true; }

            if (txt_precio.IsTextInvalid())
            { ShowEmptyFieldMessage("Precio Unitario"); return true; }

            return false;
        }

        private void ShowEmptyFieldMessage(string fieldName)
            => MessageBox.Show($"{fieldName} no puede quedar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        private void btn_image_change_Click(object sender, EventArgs e)
        {
        }

        private void EdicionArticulo_Load(object sender, EventArgs e)
        {
            FillListas();
            FillCategorias();
        }

        #region Utils

        private void FillListas()
        {
            _listasManager.GetAll();
        }

        private void FillCategorias()
        {
            var categorias = _categoriaManager.GetList();
            cbx_categoria.DataSource = categorias;
            cbx_categoria.DisplayMember = "Nombre";
            cbx_categoria.ValueMember = "Id";
        }

        #endregion Utils
    }
}