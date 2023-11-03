using Microsoft.Win32;
using Slim11.Utilities;

namespace Slim11.Features.Privacy
{
    internal class DiagnosticData : ICommand
    {
        private static DiagnosticData instance;

        private DiagnosticData() { }

        public static DiagnosticData Instance
        {
            get
            {
                if (instance == null)
                    instance = new DiagnosticData();
                return instance;
            }
        }

        public void Execute()
        {
            try
            {
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Privacy", "TailoredExperiencesWithDiagnosticDataEnabled", 0, RegistryValueKind.DWord);
                MessageBox.ShowInfo("Diagnostic data disabled successfully!");
            }
            catch { MessageBox.ShowError("Failed to disable diagnostic data."); }
        }

        public void Undo()
        {
            try
            {
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Privacy", "TailoredExperiencesWithDiagnosticDataEnabled", 1, RegistryValueKind.DWord);
                MessageBox.ShowInfo("Diagnostic data enabled successfully.");
            }
            catch { MessageBox.ShowError("Failed to enable diagnostic data."); }
        }
    }
}