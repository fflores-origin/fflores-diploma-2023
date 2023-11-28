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

            if (control.GetType() == typeof(MenuStrip))
            {
                ((MenuStrip)control).Items.OfType<ToolStripDropDownItem>().ToList().ForEach(item => { item.TranslateToolStrips(); }); return;
            }

            if (control.GetType() == typeof(GroupBox))
            {
                ((GroupBox)control).TranslateGroupBox();
                return;
            }

            if (control.Name != null && dic.ContainsKey(control.Name.ToString()))
            {
                control.Text = dic[control.Name.ToString()].Valor;
            }
        }

        private static void TranslateGroupBox(this GroupBox groupbox)
        {
            if (groupbox.Name != null && dic.ContainsKey(groupbox.Name.ToString())) { groupbox.Text = dic[groupbox.Name.ToString()].Valor; };
            if (groupbox.Controls.Count > 0) { groupbox.Controls.TranslateAll(dic); }
        }

        private static void TranslateToolStrips(this ToolStripDropDownItem item)
        {
            //if (item.Tag != null && dic.ContainsKey(item.Tag.ToString())) { item.Text = dic[item.Tag.ToString()].Valor; }; // ver si es necesario usar tags
            if (item.Name != null && dic.ContainsKey(item.Name.ToString())) { item.Text = dic[item.Name.ToString()].Valor; }

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