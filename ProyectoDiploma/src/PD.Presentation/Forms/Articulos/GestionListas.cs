using PD.Core.DTOs;
using PD.Core.DTOs.Articulo;
using PD.Core.Interfaces;
using PD.Entities;
using PD.Presentation.Helpers;

namespace PD.Presentation.Forms.Articulos
{
    public partial class GestionListas : FormBase
    {
        #region Fields

        private readonly IListasManager _manager;
        private readonly IArticulosManager _managerArticulosManager;

        private List<Lista> _listas;

        private Lista _lista;

        #endregion Fields

        #region CTOR

        public GestionListas(
            IListasManager manager,
            IArticulosManager managerArticulosManager)
        {
            InitializeComponent();
            _manager = manager;
            _managerArticulosManager = managerArticulosManager;

            //this.Load += GestionListas_Load;
        }

        #endregion CTOR

        #region Fill Grids

        private void FillLista()
        {
            dgv_listas.DataSource = null;
            var listaDeListas = _listas.Select(x => new ListaDTO() { Id = x.Id, Nombre = x.Nombre, Porcentaje = x.Porcentaje }).ToList();
            dgv_listas.AutoGenerateColumns = false;
            dgv_listas.DataSource = listaDeListas;
        }

        private void FillPrecios(Guid listaId)
        {
            dgv_precios.DataSource = null;

            var dic = new Dictionary<Guid, IEnumerable<ArticuloPrecioDTO>>();

            foreach (var item in _listas)
            {
                var precios = item.Articulos.Select(x => new ArticuloPrecioDTO()
                {
                    Id = x.Id,
                    ListaId = x.ListaId,
                    ArticuloId = x.ArticuloId,
                    Nombre = x.Articulo.Nombre,
                    PrecioLista = x.Precio,
                    PrecioUnitario = x.Articulo.PrecioUnitario
                });

                dic.Add(item.Id, precios);
            }

            dgv_precios.AutoGenerateColumns = false;

            dic.TryGetValue(listaId, out var data);

            dgv_precios.DataSource = data;
        }

        #endregion Fill Grids

        #region Grids

        private void FormatGridLista()
        {
            dgv_listas.RowTemplate.Height = 50;
            dgv_listas.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Nombre",
                DataPropertyName = "Nombre",
                Width = 200,
            });

            dgv_listas.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "%",
                DataPropertyName = "Porcentaje",
                Width = 200,
            });
        }

        private void FormatGridPrecios()
        {
            dgv_precios.RowTemplate.Height = 50;
            dgv_precios.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Nombre",
                DataPropertyName = "Nombre",
                Width = 200,
            });

            dgv_precios.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Precio unitario",
                DataPropertyName = "PrecioUnitario",
                Width = 200,
            });

            dgv_precios.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Precio Lista",
                DataPropertyName = "PrecioLista",
                Width = 200,
            });
        }

        private void AddGridEvents()
        {
            dgv_listas.SelectionChanged += OnSelectionChangedLista;
            dgv_listas.CellContentClick += OnCellContentClickLista;
        }

        private void OnCellContentClickLista(object? sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnSelectionChangedLista(object sender, EventArgs e)
        {
            if (dgv_listas.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_listas.SelectedRows[0];
                ListaDTO selected = (ListaDTO)selectedRow.DataBoundItem;

                if (_listas.Any())
                {
                    _lista = _listas.Where(x => selected.Id == x.Id).FirstOrDefault();
                    txt_ganancia.Text = _lista?.Porcentaje.ToString();
                    txt_nombre.Text = _lista?.Nombre.ToString();
                }
            }
        }

        #endregion Grids

        private void btn_add_Click_1(object sender, EventArgs e)
        {
        }

        private void GestionListas_Load(object sender, EventArgs e)
        {
            _listas = _manager.GetAll().ToList();

            FillLista();
            if (_listas.Count > 0)
            {
                FillPrecios(_listas[0].Id);
            }

            FormatGridLista();
            FormatGridPrecios();
            AddGridEvents();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (IsValid()) { return; }

            try
            {
                string? action;

                if (_lista.Id == Guid.Empty)
                {
                    action = "CREADO";

                    _lista = new Lista()
                    {
                        Nombre = txt_nombre.Text,
                        Porcentaje = decimal.Parse(txt_ganancia.Text)
                    };
                }
                else
                {
                    action = "ACTUALIZADO";

                    _lista.Nombre = txt_nombre.Text;
                    _lista.Porcentaje = decimal.Parse(txt_ganancia.Text);
                }


                _manager.Save(_lista);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private bool IsValid()
        {
            var errores = new List<string>();

            if (txt_nombre.IsTextInvalid())
            {
                errores.Add(GetMessageFieldEmptyError("Nombre"));
            }

            if (txt_ganancia.IsTextInvalid())
            {
                errores.Add(GetMessageFieldEmptyError("Ganancia"));
            }
            else
            {
                decimal.TryParse(txt_ganancia.Text, out var parsed);

                if (parsed == 0)
                {
                    errores.Add("Valor invalido para Ganancias");
                }
            }

            if (errores.Any()) { ShowMessageFieldsEmptyError(errores); }

            return errores.Any();
        }

        private void ShowMessageFieldsEmptyError(List<string> fields)
        {
            var messages = string.Join("\n", fields);
            MessageBox.Show(messages, "Error en los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private string GetMessageFieldEmptyError(string value)
        {
            return $"{value} no puede estar vacio";
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            _lista = new Lista();
            txt_nombre.Text = string.Empty;
            txt_ganancia.Text = string.Empty;
        }
    }
}