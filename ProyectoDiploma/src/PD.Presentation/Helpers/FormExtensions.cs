using PD.Entities;

namespace PD.Presentation.Helpers
{
    public static class FormExtensions
    {
        public static void TranslateForm(this Form form, IDictionary<string, Traduccion> traducciones)
        {
            if (!traducciones.Any()) return;
            if (form.Tag != null && traducciones.ContainsKey(form.Tag.ToString())) { form.Text = traducciones[form.Tag.ToString()].Valor; }
        }
    }
}