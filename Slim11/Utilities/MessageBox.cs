namespace Slim11.Utilities
{
    internal static class MessageBox
    {
        internal static void ShowInfo(string message) => System.Windows.Forms.MessageBox.Show(message, "Information", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
        internal static void ShowError(string message) => System.Windows.Forms.MessageBox.Show(message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
    }
}