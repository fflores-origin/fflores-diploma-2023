namespace PD.Presentation.Helpers
{
    internal static class Validator
    {
        public static bool IsTextInvalid(this TextBox txt)
        {
            if (txt == null) return false;
            if (txt.Text == null || string.IsNullOrEmpty(txt.Text)) return false;
            return true;
        }
    }
}