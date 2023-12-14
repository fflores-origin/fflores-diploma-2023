using PD.Core.DTOs;
using PD.Core.DTOs.Articulo;
using PD.Core.Interfaces;
using PD.Entities;
using PD.Presentation.Helpers;
using PD.Services;
using PD.Services.Interfaces;

namespace PD.Presentation.Forms.Articulos
{
    public partial class GestionListas : FormBase, ILanguageObserver
    {
        #region Fields

        private readonly IListasManager _manager;
        private readonly IArticulosManager _managerArticulosManager;
        private readonly IIdiomaManager _idiomaManager;

        private List<Lista> _listas;
        private Lista _lista;

        #endregion Fields

        #region CTOR

        public GestionListas(
            IListasManager manager,
            IArticulosManager managerArticulosManager,
            IIdiomaManager idiomaManager)
        {
            InitializeComponent();
            _manager = manager;
            _managerArticulosManager = managerArticulosManager;
            _idiomaManager = idiomaManager;

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

            if (data != null)
                dgv_precios.DataSource = data.ToList();
        }

        #endregion Fill Grids

        #region Grids

        private void FormatGridLista()
        {
            dgv_listas.RowTemplate.Height = 35;
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
            dgv_precios.RowTemplate.Height = 35;
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

            dgv_precios.Columns.Add(new DataGridViewButtonColumn()
            {
                Name = "Editar",
                UseColumnTextForButtonValue = true,
                Text = "Editar",
                HeaderText = "",
                DataPropertyName = "Id",
                Width = 50,
                FlatStyle = FlatStyle.Flat
            });
        }

        private void AddGridEvents()
        {
            dgv_listas.SelectionChanged += OnSelectionChangedLista;
            dgv_listas.CellContentClick += OnCellContentClickLista;
        }

        private void OnCellContentClickLista(object? sender, DataGridViewCellEventArgs e)
        {
            GetSelected();
        }

        private void OnSelectionChangedLista(object sender, EventArgs e)
        {
            GetSelected();
        }

        private void GetSelected()
        {
            if (dgv_listas.SelectedRows.Count > 0)
            {
                var select = (ListaDTO)dgv_listas.SelectedRows[0].DataBoundItem;
                _lista = _listas.Where(x => x.Id == select.Id).FirstOrDefault();
                FillInputs();
            }
        }

        private void FillInputs()
        {
            FillPrecios(_lista.Id);
            if (_lista != null) txt_id.Text = _lista?.Id.ToString();
            txt_ganancia.Text = _lista?.Porcentaje.ToString();
            txt_nombre.Text = _lista?.Nombre.ToString();
        }

        #endregion Grids

        private void GestionListas_Load(object sender, EventArgs e)
        {
            Sesion.SubscribeObserver(this);

            LoadForm();

            FormatGridLista();
            FormatGridPrecios();
            AddGridEvents();
        }

        private void RecargarListas() => _listas = _manager.GetAll().ToList();

        private void LoadForm()
        {
            RecargarListas();

            FillLista();
            if (_listas.Count > 0)
            {
                FillPrecios(_listas[0].Id);
            }
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

                LoadForm();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private bool IsValid()
        {
            var errores = new List<string>();

            if (txt_nombre.IsTextInvalid()) { errores.Add(StringExtensions.GetMessageFieldEmptyError("Nombre")); }

            if (txt_ganancia.IsTextInvalid()) { errores.Add(StringExtensions.GetMessageFieldEmptyError("Ganancia")); }
            else
            {
                decimal.TryParse(txt_ganancia.Text, out var parsed);

                if (parsed == 0)
                {
                    errores.Add(StringExtensions.GetMessageFieldInvalidValueError("Ganancias"));
                }
            }

            if (errores.Any()) { StringExtensions.ValidateAndShowMessageFieldsError(errores); }

            return errores.Any();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            _lista = new Lista();
            txt_id.Clear();
            txt_nombre.Clear();
            txt_ganancia.Clear();
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