using PD.Core.DTOs;
using PD.Core.Interfaces;
using PD.Presentation.Helpers;

namespace PD.Presentation.Forms.Configuracion
{
    public partial class GestionCategorias : Form
    {
        private readonly ICategoriaManager _manager;
        private IList<CategoriaDto> _categorias;
        private CategoriaDto _categoriaSelected = null;

        public GestionCategorias(
            ICategoriaManager manager)
        {
            InitializeComponent();
            _manager = manager;
        }

        private void GestionCategorias_Load(object sender, EventArgs e)
        {
            //TODO: multiidioma
            //TODO: permisos

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
            if (txt_nombre.IsTextInvalid())
            {
                MessageBox.Show("El valor de la categoria no puede ser vacio");
            }

            _manager.Save(new CategoriaDto() { Nombre = txt_nombre.Text });
        }
    }
}