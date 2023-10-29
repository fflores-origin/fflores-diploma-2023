using PD.Core.DTOs;
using PD.Core.Interfaces;

namespace PD.Presentation.Forms.Configuracion
{
    public partial class GestionCategorias : Form
    {
        private readonly ICategoriaManager _manager;
        private IList<CategoriaDto> _categorias;

        public GestionCategorias(
            ICategoriaManager manager)
        {
            InitializeComponent();
            _manager = manager;
        }

        private void GestionCategorias_Load(object sender, EventArgs e)
        {
            _categorias = _manager.GetList();
            dgv_list.DataSource = _categorias;
        }

        private void HideForm(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_nombre.Text))
            {
                MessageBox.Show("El valor de la categoria no puede ser vacio");
            }
        }
    }
}