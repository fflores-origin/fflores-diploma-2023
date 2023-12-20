using PD.Core.Interfaces;
using PD.Entities.Enums;
using PD.Entities.Permisos;
using PD.Presentation.Helpers;

namespace PD.Presentation.Forms.Configuracion
{
    public partial class GestionarPatentes : FormBase
    {
        private readonly IUsuarioManager _usuarioManager;

        private Familia _familiaSeleccionada;

        public GestionarPatentes(IUsuarioManager usuarioManager)
        {
            InitializeComponent();
            _usuarioManager = usuarioManager;
        }

        private void GestionarPatentes_Load(object sender, EventArgs e)
        {
            FillPermisos();
            LoadBase();
        }

        private void LoadBase()
        {
            FillCombos();
        }

        private void FillPermisos()
        {
            var permisos = _usuarioManager.GetAllPermisos();
            cbx_permisos.DataSource = permisos;
        }

        private void FillCombos()
        {
            List<Familia> familas = _usuarioManager.GetAllFamilias();
            cbx_familias.DataSource = familas;
            cbx_familias.DisplayMember = "Nombre";
            cbx_familias.ValueMember = "Id";

            List<Patente> patentes = _usuarioManager.GetAllPatentes();
            cbx_patentes.DataSource = patentes;
            cbx_patentes.DisplayMember = "Nombre";
            cbx_patentes.ValueMember = "Id";
        }

        internal void ShowAndLoad()
        {
            this.Show();
        }

        private void btn_guardar_patente_Click(object sender, EventArgs e)
        {
            Patente patente = new()
            {
                Id = Guid.NewGuid(),
                Nombre = txt_nombre_patente.Text,
                Tipo = (TipoPermiso)cbx_permisos.SelectedItem
            };

            _usuarioManager.SaveComponent(patente, false);
            FillCombos();

            MsgBoxHelpers.ShowInfo("Guardada Exitosamente");
        }

        private void btn_guardar_famila_Click(object sender, EventArgs e)
        {
            Familia familia = new()
            {
                Nombre = txt_nombre_familia.Text,
            };

            _usuarioManager.SaveComponent(familia, true);
            FillCombos();
            MsgBoxHelpers.ShowInfo("Guardada Exitosamente");
        }


        private void ShowFamilia(bool init)
        {

        }

        private void FillTreeView(TreeNode tree, PermisoBase component)
        {
            TreeNode node = new TreeNode(component.Nombre);
            tree.Tag = component;
            tree.Nodes.Add(node);
            component
                    .ObtenerHijos()?
                    .ToList()
                    .ForEach(x => { FillTreeView(node, x); });
        }
    }
}