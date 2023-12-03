namespace PD.Presentation.Helpers
{
    internal static class MsgBoxHelpers
    {
        public static void ShowError(string message, string title = "Error")
        {
            ShowMessage(message, title, MessageBoxIcon.Error);
        }

        public static void ShowWarning(string message, string title = "Warning")
        {
            ShowMessage(message, title, MessageBoxIcon.Warning);
        }

        public static void ShowAlert(string message, string title = "Alert")
        {
            ShowMessage(message, title, MessageBoxIcon.Asterisk);
        }

        public static void ShowInfo(string message, string title = "Info")
        {
            ShowMessage(message, title, MessageBoxIcon.Information);
        }

        public static void Show(string message, string title = "*")
        {
            ShowMessage(message, title, MessageBoxIcon.Asterisk);
        }

        private static void ShowMessage(string message, string title, MessageBoxIcon icon)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, icon);
        }
    }
}