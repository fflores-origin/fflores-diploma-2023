using PD.Core.DTOs.Articulo;
using PD.Core.Interfaces;
using PD.Entities;

namespace PD.Presentation.Forms.Articulos
{
    public partial class GestionListas : FormBase
    {
        #region Fields

        private readonly IListasManager _manager;
        private readonly IArticulosManager _managerArticulosManager;

        private List<Lista> _listas;

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
            var listaDeListas = _listas.Select(x => new { x.Id, x.Nombre, x.Porcentaje }).ToList();
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

        #region Format Grids

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

        #endregion Format Grids

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
        }
    }
}