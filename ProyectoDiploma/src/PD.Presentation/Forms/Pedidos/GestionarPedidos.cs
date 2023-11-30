using PD.Core.Interfaces;

namespace PD.Presentation.Forms.Pedidos
{
    public partial class GestionarPedidos : Form
    {
        private readonly IPedidosManager _pedidosManager;

        public GestionarPedidos(
            IPedidosManager pedidosManager)
        {
            InitializeComponent();
            _pedidosManager = pedidosManager;
        }

        private void GestionarPedidos_Load(object sender, EventArgs e)
        {
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
        }

        private void btn_bill_Click(object sender, EventArgs e)
        {
        }
    }
}