using PD.Core.DTO;
using PD.Core.Interfaces;
using System.Windows.Forms;

namespace PD.Presentation.Forms.Articulos
{
    public partial class GestionArticulos : FormBase
    {
        private readonly IArticulosManager _articuloManager;
        private List<ArticuloListaDTO> _articulos;
        private EdicionArticulo _edicionArticuloForm;

        public GestionArticulos(
            IArticulosManager articuloManager,
            EdicionArticulo edicionArticuloForm) : base()
        {
            InitializeComponent();
            _articuloManager = articuloManager;
            _edicionArticuloForm = edicionArticuloForm;

            dgv_articulos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            _edicionArticuloForm.ClearAndOpen(this);
            _edicionArticuloForm.MdiParent = this.MdiParent;
        }

        private void GestionArticulos_Load(object sender, EventArgs e)
        {
            LoadGrid();
            FormatGrid();
        }

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
                Name = "Nombre",
                DataPropertyName = "Nombre",
                Width = 200,
            });

            dgv_articulos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Codigo",
                DataPropertyName = "Codigo",
            });

            dgv_articulos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Descripcion",
                DataPropertyName = "Descripcion",
                Width = 400
            });

            dgv_articulos.Columns.Add(new DataGridViewImageColumn()
            {
                Name = "Imagen",
                DataPropertyName = "Imagen",
                Width = 100,
            });

            dgv_articulos.Columns.Add(new DataGridViewButtonColumn()
            {
                Name = "Acciones",
                UseColumnTextForButtonValue = true,
                Text = "Editar",
                DataPropertyName = "Id",
                FlatStyle = FlatStyle.Flat,

            });
        }

        private void OnSelectionChanged(object sender, EventArgs e)
        {
            if (dgv_articulos.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_articulos.SelectedRows[0];
                ArticuloListaDTO productoSeleccionado = (ArticuloListaDTO)selectedRow.DataBoundItem;
                Console.WriteLine($"Producto seleccionado: {productoSeleccionado.Nombre}, ID: {productoSeleccionado.Id}");
            }
        }

        private void DGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_articulos.Columns[e.ColumnIndex].Name == "Imagen" && e.Value != null)
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
            if (e.ColumnIndex >= 0 && dgv_articulos.Columns[e.ColumnIndex].Name == "Imagen" && e.RowIndex >= 0)
            {
                ArticuloListaDTO producto = (ArticuloListaDTO)dgv_articulos.Rows[e.RowIndex].DataBoundItem;

                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                Image img;

                if (string.IsNullOrEmpty(producto.Imagen))
                {
                    img = Properties.Resources.no_image;
                }
                else
                {
                    img = Image.FromFile(producto.Imagen);
                }

                int x = e.CellBounds.Left;
                int y = e.CellBounds.Top;
                int width = e.CellBounds.Width;
                int height = e.CellBounds.Height;

                e.Graphics.DrawImage(img, new Rectangle(x, y, width, height));
                e.Handled = true;
            }
        }

        private void DGV_CellClick(object? sender, DataGridViewCellEventArgs e)
        {

            // Verifica si la celda clicada pertenece a la columna de botones
            if (dgv_articulos.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {

                ArticuloListaDTO producto = (ArticuloListaDTO)dgv_articulos.Rows[e.RowIndex].DataBoundItem;

                _edicionArticuloForm.ClearAndOpen(id: producto.Id);
                // Aquí puedes realizar la acción deseada
                // Por ejemplo, obtener el valor de la celda en la misma fila
                //object valorCelda = dgv_articulos.Rows[e.RowIndex].Cells["Editar"].Value;
                //MessageBox.Show($"Botón clicado en la fila {e.RowIndex + 1}, valor de la celda: {producto.Id}");
            }
        }

        private void GestionArticulos_Load_1(object sender, EventArgs e)
        {
            LoadGrid();
            FormatGrid();
        }
    }
}