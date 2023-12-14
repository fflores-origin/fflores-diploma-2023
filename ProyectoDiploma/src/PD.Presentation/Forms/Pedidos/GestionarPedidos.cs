using PD.Core.DTOs.Articulo;
using PD.Core.Interfaces;
using PD.Entities;

namespace PD.Presentation.Forms.Pedidos
{
    public partial class GestionarPedidos : FormBase
    {
        private readonly IPedidosManager _pedidosManager;
        private readonly IClienteManager _clienteManager;
        private readonly IListasManager _listasManager;
        private List<Cliente> _clientes;
        private List<Lista> _listas;
        private List<Pedido> _pedidos = new List<Pedido>();
        private Pedido _pedido;
        private Lista? _listaSeleccionada;

        public GestionarPedidos(
            IPedidosManager pedidosManager,
            IClienteManager clienteManager,
            IListasManager listasManager)
        {
            InitializeComponent();
            _pedidosManager = pedidosManager;
            _clienteManager = clienteManager;
            _listasManager = listasManager;
        }

        private void GestionarPedidos_Load(object sender, EventArgs e)
        {
            FormatGridPrecios();
            FormLoad();
        }

        private void FormLoad()
        {
            FillComboCliente();
            FillComboLista();
            FillGridPedidos();
            FillGridProductos();
        }

        private void FillGridProductos()
        {
            dgv_productos.DataSource = null;
            var productos = _listasManager.GetAll();

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

            dgv_productos.AutoGenerateColumns = false;

            IEnumerable<ArticuloPrecioDTO>? data = null;

            if (_listaSeleccionada != null) dic.TryGetValue(_listaSeleccionada.Id, out data);

            if (data != null) dgv_productos.DataSource = data.ToList();
        }

        private void FillGridPedidos()
        {
            dgv_lista_pedidos.DataSource = null;
            _pedidos = _pedidosManager.GetAll();

            if (_pedidos != null && _pedidos.Any())
            {
                var listado = _pedidos.Select(x => new
                {
                    NroPedido = x.Id,
                    Fecha = x.Fecha,
                    CantidadItems = x.Detalles.Count(),
                    Cliente = x.Cliente.Nombre.ToString(),
                    Total = x.Detalles.Sum(x => x.Precio)
                });

                dgv_lista_pedidos.DataSource = listado;
            }
        }

        private void FillComboCliente()
        {
            _clientes = _clienteManager.GetAll();
            if (_clientes.Any())
            {
                var listado = _clientes.Select(x => new { Value = $"{x.Nombre} - {x.Documento}", Key = x.Id }).ToList();
                cbx_clientes.DataSource = listado;
                cbx_clientes.DisplayMember = "Value";
                cbx_clientes.ValueMember = "Key";
            }
        }

        private void FillComboLista()
        {
            _listas = _listasManager.GetAll().ToList();
            if (_listas.Any())
            {
                var listado = _listas.Select(x => new { Value = x.Nombre, Key = x.Id }).ToList();
                cbx_lista.DataSource = listado;
                cbx_lista.DisplayMember = "Value";
                cbx_lista.ValueMember = "Key";
                _listaSeleccionada = _listas.FirstOrDefault();
            }
        }

        private void FormatGridPrecios()
        {
            dgv_productos.RowTemplate.Height = 35;
            dgv_productos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Nombre",
                DataPropertyName = "Nombre",
                Width = 200,
            });

            dgv_productos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Precio unitario",
                DataPropertyName = "PrecioUnitario",
                Width = 200,
            });

            dgv_productos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Precio Lista",
                DataPropertyName = "PrecioLista",
                Width = 200,
            });

            dgv_productos.Columns.Add(new DataGridViewButtonColumn()
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

        private void btn_new_Click(object sender, EventArgs e)
        {
            _pedido = new Pedido();
            txt_fecha.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void InitDate() => txt_fecha.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        private void btn_bill_Click(object sender, EventArgs e)
        {
        }

        public void ShowAndLoad()
        {
            FormLoad();
            InitDate();
            this.Show();
        }
    }
}