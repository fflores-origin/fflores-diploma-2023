namespace PD.Presentation.Helpers
{
    public static class StringExtensions
    {
        public static string MESSAGE_FIELD_EMPTY_ERROR = ", no puede estar vacio";
        public static string MESSAGE_FIELD_INVALID_ERROR = ", valor invalido";
        public static string MESSAGE_ERROR_DATA_TITLE = "Error en los datos";

        public static string GetMessageFieldEmptyError(string value)
            => $"{value} {MESSAGE_FIELD_EMPTY_ERROR}";

        public static string GetMessageFieldInvalidValueError(string value)
            => $"{value} {MESSAGE_FIELD_INVALID_ERROR}";

        public static void ShowMessageFieldsEmptyError(List<string> errors)
        {
            var messages = string.Join("\n", errors);
            MessageBox.Show(
                messages,
                MESSAGE_ERROR_DATA_TITLE,
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
    }
}