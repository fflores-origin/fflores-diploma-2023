using PD.Core.Interfaces;

namespace PD.Presentation.Forms.Pedidos
{
    public partial class GestionarClientes : FormBase
    {
        private readonly IClienteManager clientesManager;
        public GestionarClientes()
        {
            InitializeComponent();
        }

        private void GestionarClientes_Load(object sender, EventArgs e)
        {

        }
    }
}