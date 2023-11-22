using Newtonsoft.Json;
using PD.Core.DTOs.Articulo;
using PD.Core.Interfaces;
using PD.Entities;
using PD.Presentation.Helpers;
using PD.Services;
using System.Text.Json.Serialization;

namespace PD.Presentation.Forms.Articulos
{
    public partial class EdicionArticulo : FormBase
    {
        private readonly ICategoriaManager _categoriaManager;
        private readonly IListasManager _listasManager;
        private readonly IArticulosManager _articulosManager;
        private ArticuloDTO _articuloDto;
        private string _filePath = "";
        private Guid _productoId = Guid.Empty;
        private Articulo _articulo = null;

        private GestionArticulos _parentForm;

        public EdicionArticulo(
            ICategoriaManager categoriaManager,
            IListasManager listasManager,
            IArticulosManager articulosManager)
            : base()
        {
            InitializeComponent();
            _categoriaManager = categoriaManager;
            _listasManager = listasManager;
            _articulosManager = articulosManager;

            txt_precio.KeyPress += ValidateDecimalInput;
        }

        private void EdicionArticulo_Load(object sender, EventArgs e)
        {
            FillListas();
            FillCategorias();

            InitializeValues();
        }

        private void InitializeValues()
        {
            txt_cantidad.Text = "0";
            txt_ubicacion.Text = "";
            txt_precio.Text = "0.00";
            txt_nombre.Text = "";
            txt_descripcion.Text = "";
            txt_marca.Text = "";
            pic_base.BackgroundImage = Properties.Resources.no_image;
        }

        private void ValidateDecimalInput(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;

            if ((e.KeyChar == '.') && sender != null && (((TextBox)sender).Text.IndexOf('.') > -1))
                e.Handled = true;
        }

        private void GenerateQR()
        {
            var image = QRCodeGeneratorService.GenerateQR(JsonConvert.SerializeObject(_articulo));
            pic_qr.BackgroundImage = image;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (HasInvalidInputs()) return;

                var dto = new ArticuloDTO
                {
                    Id = _productoId,
                    Nombre = txt_nombre.Text,
                    PrecioUnitario = Convert.ToDecimal(txt_precio.Text.Replace('.', ',')),
                    Descripcion = txt_descripcion.Text,
                    Cantidad = Convert.ToInt32(txt_cantidad.Text),
                    Codigo = txt_codigo.Text,
                    CategoriaId = cbx_categoria.GetSelectedValueGuid(),
                    Marca = txt_marca.Text,
                    Ubicacion = txt_ubicacion.Text,
                    ImagePath = _filePath
                };

                _articulo = _articulosManager.CrearArticulo(dto);
                _productoId = _articulo.Id;
                txt_id.Text = _articulo.Id.ToString();

                GenerateQR();

                _parentForm.LoadGrid();

                MessageBox.Show("Articulo Creado");

                //((GestionArticulos)this.Parent).LoadGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: \n{ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool HasInvalidInputs()
        {
            if (txt_nombre.IsTextInvalid())
            { ShowEmptyFieldMessage("Nombre"); return true; }

            if (txt_precio.IsTextInvalid())
            { ShowEmptyFieldMessage("Precio Unitario"); return true; }

            if (string.IsNullOrEmpty(txt_cantidad.Text)) txt_cantidad.Text = "0";

            return false;
        }

        private void ShowEmptyFieldMessage(string fieldName)
            => MessageBox.Show($"{fieldName} no puede quedar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        private void btn_image_change_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Todos los archivos|*.*",
                Title = "Seleccionar imagen"
            };

            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                _filePath = openFileDialog.FileName;

                pic_base.BackgroundImage = new Bitmap(_filePath);
            }
        }

        #region Utils

        public void ClearAndOpen(GestionArticulos parentForm = null)
        {
            // limpiar variables
            InitializeValues();

            _parentForm = parentForm;

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