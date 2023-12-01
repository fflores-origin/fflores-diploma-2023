using PD.Core.Interfaces;
using PD.Entities;

namespace PD.Presentation.Forms.Pedidos
{
    public partial class GestionarPedidos : Form
    {
        private readonly IPedidosManager _pedidosManager;
        private readonly IClienteManager _clienteManager;
        private readonly IListasManager _listasManager;
        private List<Cliente> _clientes;
        private List<Lista> _listas;
        private List<Pedido> _pedidos = new List<Pedido>();
        private Pedido _pedido;

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
            FillComboCliente();
            FillComboLista();
            FillGrid();
        }

        private void FillGrid()
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
                var listado = _listas.Select(x => new { Value = x.Nombre, Key = x.Id });
                cbx_lista.DataSource = listado;
                cbx_lista.DisplayMember = "Value";
                cbx_lista.ValueMember = "Key";
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            _pedido = new Pedido();
            txt_fecha.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void btn_bill_Click(object sender, EventArgs e)
        {
        }

        public void ShowAndLoad()
        {
            this.Show();
        }
    }
}