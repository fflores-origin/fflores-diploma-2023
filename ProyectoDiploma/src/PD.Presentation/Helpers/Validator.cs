namespace PD.Presentation.Helpers
{
    internal static class Validator
    {
        public static bool IsTextInvalid(this TextBox txt)
        {
            if (txt == null) return true;
            if (txt.Text == null || string.IsNullOrEmpty(txt.Text)) return true;
            return false;
        }
    }
}