using PD.Core.DTOs;
using PD.Core.DTOs.Articulo;
using PD.Core.DTOs.Pedido;
using PD.Core.Interfaces;
using PD.Entities;
using PD.Presentation.Helpers;
using PD.Services;
using PD.Services.Interfaces;

namespace PD.Presentation.Forms.Pedidos
{
    public partial class GestionarPedidos : FormBase, ILanguageObserver
    {
        private readonly IPedidosManager _pedidosManager;
        private readonly IClienteManager _clienteManager;
        private readonly IListasManager _listasManager;
        private readonly IIdiomaManager _idiomaManager;
        private List<Cliente> _clientes;
        private List<Lista> _listas;
        private List<Pedido> _pedidos = new List<Pedido>();
        private Pedido _pedido;
        private Lista? _listaSeleccionada;
        private ArticuloPrecioDTO? _productoSeleccionado = null;
        private List<ArticuloPrecioDTO> _articulosPedido;
        private bool _shouldShow = true;

        public GestionarPedidos(
            IPedidosManager pedidosManager,
            IClienteManager clienteManager,
            IListasManager listasManager,
            IIdiomaManager idiomaManager)
        {
            InitializeComponent();
            _pedidosManager = pedidosManager;
            _clienteManager = clienteManager;
            _listasManager = listasManager;
            _idiomaManager = idiomaManager;
        }

        private void GestionarPedidos_Load(object sender, EventArgs e)
        {
            Sesion.SubscribeObserver(this);

            FormatGridPedido();
            FormatGridPrecios();
            //InitPedido();
            FormLoad();
        }

        private void FormLoad()
        {
            FillComboCliente();
            FillComboLista();
            FillGridListaPedidos();
            FillGridProductos();
            FillGridPedido();
        }

        private void FillGridProductos()
        {
            dgv_productos.DataSource = null;
            dgv_productos.AutoGenerateColumns = false;

            if (_listaSeleccionada != null)
            {
                var listaId = _listaSeleccionada.Id;
                var lista = _listas.Where(x => x.Id == listaId).FirstOrDefault();

                var precios = lista?.Articulos.Select(x => new ArticuloPrecioDTO()
                {
                    Id = x.Id,
                    ListaId = x.ListaId,
                    ArticuloId = x.ArticuloId,
                    Nombre = x.Articulo.Nombre,
                    PrecioLista = x.Precio,
                    PrecioUnitario = x.Articulo.PrecioUnitario
                }).ToList();

                dgv_productos.DataSource = precios;
            }
        }

        private void FillGridListaPedidos()
        {
            dgv_lista_pedidos.DataSource = null;
            _pedidos = _pedidosManager.GetAll();

            if (_pedidos != null && _pedidos.Any())
            {
                var listado = _pedidos.Select(x => new PedidoDTO()
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

        private void FillGridPedido()
        {
            dgv_pedido.DataSource = null;
            dgv_pedido.AutoGenerateColumns = false;

            if (_pedido != null && _pedido.Detalles.Any())
            {
                var source = _pedido.Detalles
                   .Select(x => new PedidoItemDTO()
                   {
                       Id = x.ArticuloId,
                       Nombre = x.Articulo.Nombre,
                       Cantidad = x.Cantidad,
                       PrecioLista = x.Precio,
                       Total = x.Precio * x.Cantidad
                   })
                   .ToList();

                txt_total.Text = source.Sum(x => x.Total).ToString();

                dgv_pedido.DataSource = source;
            }
        }

        private void FillComboCliente()
        {
            _clientes = _clienteManager.GetAll();
            if (_clientes.Any())
            {
                var listado = _clientes.Select(x => new ComboItemDTO() { Value = $"{x.Nombre} - {x.Documento}", Key = x.Id }).ToList();
                cbx_clientes.DataSource = listado;
                cbx_clientes.DisplayMember = "Value";
                cbx_clientes.ValueMember = "Key";
            }
            else
            {
                _shouldShow = false;
            }
        }

        private void FillComboLista()
        {
            _listas = _listasManager.GetAll().ToList();
            if (_listas.Any())
            {
                var listado = _listas.Select(x => new ComboItemDTO() { Value = x.Nombre, Key = x.Id }).ToList();
                cbx_lista.DataSource = listado;
                cbx_lista.DisplayMember = "Value";
                cbx_lista.ValueMember = "Key";
                _listaSeleccionada = _listas.FirstOrDefault();
            }
        }

        private void FormatGridPrecios()
        {
            dgv_productos.RowTemplate.Height = 30;
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
                Width = 100,
            });

            dgv_productos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Precio Lista",
                DataPropertyName = "PrecioLista",
                Width = 100,
            });
        }

        private void FormatGridPedido()
        {
            dgv_pedido.RowTemplate.Height = 30;
            dgv_pedido.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Nombre",
                DataPropertyName = "Nombre",
                Width = 150,
            });

            dgv_pedido.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Cantidad",
                DataPropertyName = "Cantidad",
                Width = 80,
            });

            dgv_pedido.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "PrecioLista",
                DataPropertyName = "PrecioLista",
                Width = 80,
            });

            dgv_pedido.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Total",
                DataPropertyName = "Total",
                Width = 80,
            });
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            InitPedido();
            cbx_clientes.Enabled = true;
            cbx_lista.Enabled = true;
        }

        private void InitPedido()
        {
            dgv_pedido.DataSource = null;

            _pedido = new Pedido()
            {
                Id = Guid.NewGuid(),
                Fecha = DateTime.Now
            };

            txt_pedido_id.Text = _pedido.Id.ToString();
            txt_fecha.Text = _pedido.Fecha.ToString("yyyy-MM-dd HH:mm:ss");
            txt_total.Clear();
            txt_cantidad.Clear();
        }

        private void btn_bill_Click(object sender, EventArgs e)
        {
        }

        public void ShowAndLoad()
        {
            FormLoad();
            InitPedido();
            if (_shouldShow) this.Show();
            else MsgBoxHelpers.ShowWarning("No hay clientes disponibles para generar pedidos.");
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_cantidad.IsTextInvalid())
            {
                MsgBoxHelpers.ShowWarning("No se puede agregar al pedido \nsi no se especifica cantidad.");
                return;
            }

            if (Convert.ToInt32(txt_cantidad.Text) <= 0)
            {
                MsgBoxHelpers.ShowWarning("La cantidad no puede ser 0 o menor a 0.");
                return;
            }

            if (dgv_productos.SelectedRows.Count != 0)
            {
                ArticuloPrecioDTO selected = (ArticuloPrecioDTO)dgv_productos.SelectedRows[0].DataBoundItem;

                var lista = _listas.Where(x => x.Id == selected.ListaId).First();
                var articulo = lista.Articulos.Where(x => x.Id == selected.Id).First();

                cbx_clientes.Enabled = false;
                cbx_lista.Enabled = false;

                if (_pedido == null) { InitPedido(); }

                // TODO: validar cantidad

                

                if (_pedido != null)
                {
                    var detalle = new PedidoDetalle()
                    {
                        Cantidad = Convert.ToInt32(txt_cantidad.Text),
                        ArticuloId = articulo.Id,
                        Articulo = articulo.Articulo,
                        PedidoId = _pedido.Id,
                        Precio = selected.PrecioLista
                    };

                    _pedido.Detalles.Add(detalle);
                }

                FillGridPedido();
            }
            else
            {
                MsgBoxHelpers.ShowWarning("No hay productos para seleccionar");
            }
        }

        private void OnSelectionListaChange(object sender, EventArgs e)
        {
            ComboItemDTO selected = (ComboItemDTO)cbx_lista.SelectedItem;
            if (selected != null)
            {
                _listaSeleccionada = _listas.Where(x => x.Id == selected.Key).FirstOrDefault();
                FillGridProductos();
            }
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