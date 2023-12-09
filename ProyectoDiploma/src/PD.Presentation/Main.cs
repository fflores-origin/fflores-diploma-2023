using Microsoft.Extensions.Configuration;
using PD.Core.Interfaces;
using PD.Entities;
using PD.Presentation.Forms.Articulos;
using PD.Presentation.Forms.Configuracion;
using PD.Presentation.Forms.Pedidos;
using PD.Presentation.Helpers;
using PD.Services;
using PD.Services.Interfaces;

namespace PD.Presentation
{
    public partial class Main : Form, ILanguageObserver
    {
        #region Fields

        private readonly IConfiguration _configuration;
        private readonly IUsuarioManager _usuarioManager;
        private readonly IIdiomaManager _idiomaManager;
        private readonly GestionArticulos _gestionArticulosForm;
        private readonly GestionarPermisos _gestionarPermisosFrom;
        private readonly GestionCategorias _gestionCategoriasForm;
        private readonly GestionListas _gestionListasForm;
        private readonly GestionarClientes _gestionarClientesForm;
        private readonly GestionarPedidos _gestionarPedidosForm;

        #endregion Fields

        #region CTOR

        public Main(
            IConfiguration configuration,
            GestionArticulos gestionArticulosForm,
            GestionarPermisos gestionarPermisosFrom,
            GestionCategorias gestionCategoriasForm,
            GestionListas gestionListasForm,
            IUsuarioManager usuarioManager,
            IIdiomaManager idiomaManager,
            GestionarClientes gestionarClientesForm,
            GestionarPedidos gestionarPedidosForm)
        {
            InitializeComponent();
            _configuration = configuration;
            _usuarioManager = usuarioManager;
            _idiomaManager = idiomaManager;

            _gestionArticulosForm = gestionArticulosForm;
            _gestionarPermisosFrom = gestionarPermisosFrom;
            _gestionCategoriasForm = gestionCategoriasForm;
            _gestionListasForm = gestionListasForm;
            _gestionarClientesForm = gestionarClientesForm;
            _gestionarPedidosForm = gestionarPedidosForm;

            _gestionArticulosForm.MdiParent = this;
            _gestionarPermisosFrom.MdiParent = this;
            _gestionCategoriasForm.MdiParent = this;
            _gestionListasForm.MdiParent = this;
            _gestionarClientesForm.MdiParent = this;
            _gestionarPedidosForm.MdiParent = this;
        }

        #endregion CTOR

        private void Btn_gestionarArticulos_Click(object sender, EventArgs e)
        {
            _gestionArticulosForm.ShowAndLoad();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Sesion.SubscribeObserver(this);
            LoadLanguages();
            SetLanguage();
            Translate();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            _gestionArticulosForm.Dispose();
            _gestionCategoriasForm.Dispose();
            _gestionarPermisosFrom.Dispose();
            _gestionarClientesForm.Dispose();
            _gestionarPedidosForm.Dispose();
            _gestionListasForm.Dispose();
            _gestionArticulosForm.Dispose();

            Application.Exit();
        }

        private void gestionarPermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _gestionarPermisosFrom.Show();
        }

        private void OpenCategoriasForm(object sender, EventArgs e)
        {
            _gestionCategoriasForm.Show();
        }

        private void listasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _gestionListasForm.Show();
        }

        private void tsc_idioma_Click(object sender, EventArgs e)
        {
        }

        private void LoadLanguages()
        {
            var languages = _idiomaManager.GetIdiomas();

            foreach (var language in languages)
            {
                var item = new ToolStripMenuItem()
                {
                    Text = language.Nombre.ToString(),
                    Tag = language,
                    Name = $"btn_menu_{language.IsoCode}"
                };

                tsc_idioma.DropDownItems.Add(item);

                item.Click += IdiomaChangeClick;
            }
        }

        private void IdiomaChangeClick(object? sender, EventArgs e)
        {
            if (sender != null)
            {
                var idioma = (Idioma)((ToolStripMenuItem)sender).Tag;
                Sesion.ChangeLanguage(idioma);
                SetLanguage();
            }
        }

        private void SetLanguage()
        {
            if (!UserSesion.Session.IsLogged())
            {
                foreach (var item in tsc_idioma.DropDownItems)
                {
                    var i = ((Idioma)((ToolStripMenuItem)item).Tag);
                    ((ToolStripMenuItem)item).Checked = i.IsDefault;
                    ((ToolStripMenuItem)item).Enabled = false;
                }
            }
            else
            {
                foreach (var item in tsc_idioma.DropDownItems)
                {
                    ((ToolStripMenuItem)item).Enabled = true;
                    ((ToolStripMenuItem)item).Checked = UserSesion.Session.Usuario.Idioma.Id.Equals(((Idioma)((ToolStripMenuItem)item).Tag).Id);
                }
            }
        }

        public void OnLanguageChanged(Idioma idioma)
        {
            SetLanguage();
            Translate();
        }

        private void Translate()
        {
            Idioma? idioma = null;
            if (UserSesion.Session.IsLogged()) { idioma = UserSesion.Session.Usuario.Idioma; }
            var traducciones = _idiomaManager.GetTraducciones(idioma);
            this.Controls.TranslateAll(traducciones);
        }

        private void gestionarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _gestionarClientesForm.ShowAndLoad();
        }

        private void gestionarPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _gestionarPedidosForm.ShowAndLoad();
        }

        private void tsb_ordenesDeCompra_Click(object sender, EventArgs e)
        {
        }
    }
}