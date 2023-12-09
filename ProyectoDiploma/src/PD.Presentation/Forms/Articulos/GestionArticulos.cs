using PD.Core.DTO;
using PD.Core.Interfaces;
using PD.Entities;
using PD.Presentation.Helpers;
using PD.Services;
using PD.Services.Interfaces;

namespace PD.Presentation.Forms.Articulos
{
    public partial class GestionArticulos : FormBase, ILanguageObserver
    {
        private readonly IArticulosManager _articuloManager;
        private readonly IIdiomaManager _idiomaManager;
        private readonly EdicionArticulo _edicionArticuloForm;
        private List<ArticuloListaDTO> _articulos = new();

        public GestionArticulos(
            IArticulosManager articuloManager,
            IIdiomaManager idiomaManager,
            EdicionArticulo edicionArticuloForm) : base()
        {
            InitializeComponent();
            _articuloManager = articuloManager;
            _edicionArticuloForm = edicionArticuloForm;

            dgv_articulos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _idiomaManager = idiomaManager;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            _edicionArticuloForm.SetParentForm(this);
            _edicionArticuloForm.ClearAndOpen(null);
        }

        private void GestionArticulos_Load(object sender, EventArgs e)
        {
            Sesion.SubscribeObserver(this);
            LoadGrid();
            FormatGrid();
        }

        public void ShowAndLoad()
        {
            LoadGrid();
            this.Show();
        }

        #region Grids

        public void LoadGrid()
        {
            dgv_articulos.DataSource = null;
            _articulos = _articuloManager.GetList();
            dgv_articulos.AutoGenerateColumns = false;
            dgv_articulos.DataSource = _articulos;

            dgv_articulos.CellPainting += DGV_CellPainting;
            dgv_articulos.CellFormatting += DGV_CellFormatting;
            dgv_articulos.CellContentClick += DGV_CellClick;
        }

        private void FormatGrid()
        {
            dgv_articulos.RowTemplate.Height = 100;
            dgv_articulos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "h_name",
                HeaderText = "Nombre",
                DataPropertyName = "Nombre",
                Width = 200,
            });

            dgv_articulos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "h_code",
                HeaderText = "Codigo",
                DataPropertyName = "Codigo",
            });

            dgv_articulos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "h_description",
                HeaderText = "Descripcion",
                DataPropertyName = "Descripcion",
                Width = 200
            });

            dgv_articulos.Columns.Add(new DataGridViewImageColumn()
            {
                Name = "h_image",
                HeaderText = "Imagen" ,
                DataPropertyName = "Imagen",
                Width = 100,
            });

            dgv_articulos.Columns.Add(new DataGridViewButtonColumn()
            {
                Name = "h_actions",
                Tag = "dgb_edit",
                HeaderText = "Acciones",
                UseColumnTextForButtonValue = true,
                Text = "Editar",
                DataPropertyName = "Id",
                FlatStyle = FlatStyle.Flat,
            });
        }

        #endregion Grids

        private void OnSelectionChanged(object sender, EventArgs e)
        {
            if (dgv_articulos.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_articulos.SelectedRows[0];
                ArticuloListaDTO productoSeleccionado = (ArticuloListaDTO)selectedRow.DataBoundItem;
            }
        }

        private void DGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_articulos.Columns[e.ColumnIndex].Name == "h_image" && e.Value != null)
            {
                ArticuloListaDTO producto = (ArticuloListaDTO)dgv_articulos.Rows[e.RowIndex].DataBoundItem;

                if (!string.IsNullOrEmpty(producto.Imagen))
                {
                    try
                    {
                        Image img = Image.FromFile(producto.Imagen);

                        e.Value = img;
                    }
                    catch (IOException ex)
                    {
                        Console.WriteLine($"Error al cargar la imagen: {ex.Message}");
                    }
                }
                else
                {
                    e.Value = Properties.Resources.no_image;
                }
            }
        }

        private void DGV_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Verifica si la columna actual es la columna "Imagen"
            if (e.ColumnIndex >= 0 && dgv_articulos.Columns[e.ColumnIndex].Name == "h_image" && e.RowIndex >= 0)
            {
                ArticuloListaDTO producto = (ArticuloListaDTO)dgv_articulos.Rows[e.RowIndex].DataBoundItem;
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                Image img = string.IsNullOrEmpty(producto.Imagen)
                    ? Properties.Resources.no_image
                    : Image.FromFile(producto.Imagen);

                int x = e.CellBounds.Left;
                int y = e.CellBounds.Top;
                int width = e.CellBounds.Width;
                int height = e.CellBounds.Height;
                var rect = new Rectangle(x, y, width, height);

                e.Graphics.DrawImage(img, rect);
                e.Handled = true;
            }
        }

        private void DGV_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (dgv_articulos.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                ArticuloListaDTO producto = (ArticuloListaDTO)dgv_articulos.Rows[e.RowIndex].DataBoundItem;
                _edicionArticuloForm.SetParentForm(this);
                _edicionArticuloForm.ClearAndOpen(id: producto.Id);
            }
        }

        private void btn_print_qrs_Click(object sender, EventArgs e)
        {
        }

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
    }
}