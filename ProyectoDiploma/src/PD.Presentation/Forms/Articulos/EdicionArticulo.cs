using PD.Core.DTOs.Articulo;
using PD.Core.Interfaces;
using PD.Presentation.Helpers;
using PD.Services;

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

            txt_precio.KeyPress += ValidateDecimalInput;
        }

        private void ValidateDecimalInput(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;

            if ((e.KeyChar == '.') && sender != null && (((TextBox)sender).Text.IndexOf('.') > -1))
                e.Handled = true;
        }

        private void btn_qr_Click(object sender, EventArgs e)
        {
            var image = QRCodeGeneratorService.GenerateQR("hola");
            //pic_qr.Image = image;
            pic_qr.BackgroundImage = image;

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

            //if ()

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

        public void ClearAndOpen()
        {
            // limpiar variables
            // mostrar
            this.Show();
        }

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