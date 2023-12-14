using PD.Core.Interfaces;
using PD.Entities;
using PD.Presentation.Helpers;

namespace PD.Presentation.Forms.Configuracion
{
    public partial class GestionarIdiomas : FormBase
    {
        private readonly IIdiomaManager _idiomaManager;
        private Idioma _selected = new();

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
            if (IsValid()) { return; }

            var action = _selected.Id != Guid.Empty ? "Create" : "Updatre";

            _selected = _idiomaManager.Save(_selected);

            MsgBoxHelpers.ShowInfo($"Idioma {action}");
        }

        private void ClearInputs()
        {
            _selected = new();

            txt_codigo.Clear();
            txt_id.Clear();
            txt_valor.Clear();
            txt_isoCode.Clear();
        }

        private bool IsValid()
        {
            var errors = new List<string>();

            if (txt_codigo.IsTextInvalid()) { errors.Add(StringExtensions.GetMessageFieldEmptyError("Codigo")); }
            if (txt_valor.IsTextInvalid()) { errors.Add(StringExtensions.GetMessageFieldEmptyError("Valor")); }
            if (txt_isoCode.IsTextInvalid()) { errors.Add(StringExtensions.GetMessageFieldEmptyError("IsoCode")); }

            return StringExtensions.ValidateAndShowMessageFieldsError(errors);
        }
    }
}