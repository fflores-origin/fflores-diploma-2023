using Newtonsoft.Json;
using PD.Core.DTOs;
using PD.Core.DTOs.Articulo;
using PD.Core.Interfaces;
using PD.Entities;
using PD.Presentation.Helpers;
using PD.Services;
using PD.Services.Interfaces;

namespace PD.Presentation.Forms.Articulos
{
    public partial class EdicionArticulo : FormBase, ILanguageObserver
    {
        private const string LIBRO_ID = "882F8085-B15A-41DE-A905-124893068B8E";

        private readonly ICategoriaManager _categoriaManager;
        private readonly IListasManager _listasManager;
        private readonly IArticulosManager _articulosManager;
        private readonly IIdiomaManager _idiomaManager;
        private GestionArticulos _parentForm;

        private string _filePath = "";
        private Guid _productoId = Guid.Empty;
        private Articulo _articulo = null;

        #region CTOR

        public EdicionArticulo(
            ICategoriaManager categoriaManager,
            IListasManager listasManager,
            IArticulosManager articulosManager,
            IIdiomaManager idiomaManager)
            : base()
        {
            InitializeComponent();
            _categoriaManager = categoriaManager;
            _listasManager = listasManager;
            _articulosManager = articulosManager;

            txt_precio.KeyPress += ValidateDecimalInput;
            _idiomaManager = idiomaManager;
        }

        #endregion CTOR

        public void SetParentForm(GestionArticulos form)
        {
            _parentForm = form;
            this.MdiParent = form.MdiParent;
        }

        public void ClearAndOpen(Guid? id = null)
        {
            InitializeValues();

            if (id != null) SetObjectInitial(id.Value);

            this.Show();
        }

        private void EdicionArticulo_Load(object sender, EventArgs e)
        {
            FillListas();
            FillCategorias();
            InitializeValues();
        }

        private void HideTextboxConditionals(bool shouldHide = true)
        {
            lbl_title_libros.Visible = !shouldHide;
            txt_autor.Visible = txt_isbn.Visible = !shouldHide;
            lbl_isbn.Visible = lbl_autor.Visible = !shouldHide;
        }

        private void InitializeValues()
        {
            txt_id.Clear();
            txt_cantidad.Text = "0";
            txt_ubicacion.Clear();
            txt_precio.Text = "0.00";
            txt_nombre.Clear();
            txt_descripcion.Clear();
            txt_marca.Clear();
            txt_codigo.Clear();
            txt_isbn.Clear();
            txt_autor.Clear();

            pic_qr.BackgroundImage = null;
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

                var action = _productoId == Guid.Empty ? "Creado" : "Actualizado";
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
                    ImagePath = _filePath,
                    Ubicacion = txt_ubicacion.Text,
                    ISBN = txt_isbn.Text,
                    Autor = txt_autor.Text,
                };

                _articulo = _articulosManager.CrearArticulo(dto);
                _productoId = _articulo.Id;
                txt_id.Text = _articulo.Id.ToString();

                GenerateQR();

                _parentForm?.LoadGrid();

                MessageBox.Show("Articulo ");
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

        private void SetObjectInitial(Guid id)
        {
            _articulo = _articulosManager.GetById(id);

            if (_articulo != null)
            {
                txt_codigo.Text = _articulo.Codigo;
                txt_descripcion.Text = _articulo.Descripcion;
                txt_marca.Text = _articulo.Marca;
                txt_id.Text = _articulo.Id.ToString();
                txt_precio.Text = _articulo.PrecioUnitario.ToString().Replace(',', '.');
                txt_nombre.Text = _articulo.Nombre;
                txt_autor.Text = _articulo.Autor;
                txt_isbn.Text = _articulo.ISBN;
                txt_cantidad.Text = _articulo.Cantidad.ToString();
                txt_ubicacion.Text = _articulo.Ubicacion;

                if (_articulo.HasImage()) { pic_base.BackgroundImage = new Bitmap(_articulo.Imagen); }
                GenerateQR();
            }
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

        private void btn_help_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this.btn_help, help_provider_articulo.HelpNamespace, HelpNavigator.TopicId);
        }

        private void btn_assign_Click(object sender, EventArgs e)
        {
            if (dgv_listas.SelectedRows.Count != 0)
            {
                var selected = dgv_listas.SelectedRows[0].DataBoundItem;
            }
            else
            {
                MsgBoxHelpers.ShowWarning("No hay listas para actualizar");
            }
        }

        private void OnCategoriaChange(object sender, EventArgs e)
        {
            var seleccionado = (CategoriaDto)cbx_categoria.SelectedItem;

            if (seleccionado != null)
            {
                var shouldHide = seleccionado.Id != Guid.Parse(LIBRO_ID);
                HideTextboxConditionals(shouldHide);
            }
        }

        #region IDIOMA

        public void OnLanguageChanged(Idioma idioma)
        {
            Translate();
        }

        private void Translate()
        {
            Idioma? idioma = null;
            if (UserSesion.Session.IsLogged()) { idioma = UserSesion.Session.Usuario.Idioma; }
            var traducciones = _idiomaManager.GetTraducciones(idioma);
            this.Controls.TranslateAll(traducciones);
        }

        #endregion IDIOMA
    }
}