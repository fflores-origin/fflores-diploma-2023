using PD.Core.Interfaces;

namespace PD.Presentation.Forms.Configuracion
{
    public partial class GestionarIdiomas : FormBase
    {
        private readonly IIdiomaManager _idiomaManager;

        public GestionarIdiomas(
            IIdiomaManager idiomaManager)
        {
            InitializeComponent();
            _idiomaManager = idiomaManager;
        }

        private void GestionarIdiomas_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void FillGrid()
        {

        }

        private void btn_new_Click(object sender, EventArgs e)
        {

        }
    }
}