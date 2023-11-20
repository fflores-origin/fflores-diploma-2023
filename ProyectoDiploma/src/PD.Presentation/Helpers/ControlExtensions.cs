namespace PD.Presentation.Helpers
{
    public static class ControlExtensions
    {
        public static Guid GetSelectedValueGuid(this ComboBox control)
        {
            _ = Guid.TryParse(control.SelectedValue.ToString(), out var result);
            return result;
        }
    }
}