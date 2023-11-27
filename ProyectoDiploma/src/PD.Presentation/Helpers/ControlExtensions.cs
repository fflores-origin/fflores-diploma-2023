using PD.Entities;
using static System.Windows.Forms.Control;

namespace PD.Presentation.Helpers
{
    public static class ControlExtensions
    {
        public static Guid GetSelectedValueGuid(this ComboBox control)
        {
            _ = Guid.TryParse(control.SelectedValue.ToString(), out var result);
            return result;
        }

        private static IDictionary<string, Traduccion> dic;

        public static void Translate(this Control control, IDictionary<string, Traduccion> traducciones)
        {
            if (!traducciones.Any()) return;

            dic = traducciones;

            /// --------- TOOLSTRIPS ---------
            if (control.GetType() == typeof(MenuStrip)) { ((MenuStrip)control).Items.OfType<ToolStripDropDownItem>().ToList().ForEach(item => { item.TranslateToolStrips(); }); return; }

            /// --------- GROUPBOX ---------
            if (control.GetType() == typeof(GroupBox)) { ((GroupBox)control).TranslateGroupBox(); return; }

            /// --------- BOTONES | LABELS ---------
            if (control.Tag != null && dic.ContainsKey(control.Tag.ToString())) { control.Text = dic[control.Tag.ToString()].Valor; }
        }

        private static void TranslateGroupBox(this GroupBox groupbox)
        {
            if (groupbox.Tag != null && dic.ContainsKey(groupbox.Tag.ToString())) { groupbox.Text = dic[groupbox.Tag.ToString()].Valor; };
            if (groupbox.Controls.Count > 0) { groupbox.Controls.TranslateAll(dic); }
        }

        // traduzco cada item del toolstrip - llamada recursiva
        private static void TranslateToolStrips(this ToolStripDropDownItem item)
        {
            if (item.Tag != null && dic.ContainsKey(item.Tag.ToString())) { item.Text = dic[item.Tag.ToString()].Valor; };

            if (item.DropDownItems.Count > 0)
            {
                item.DropDownItems.OfType<ToolStripDropDownItem>().ToList().ForEach(subItem => { subItem.TranslateToolStrips(); });
            }
        }

        public static void TranslateAll(this ControlCollection controls, IDictionary<string, Traduccion> traducciones)
        {
            if (!traducciones.Any()) return;

            dic = traducciones;

            foreach (Control control in controls) { control.Translate(dic); }
        }
    }
}