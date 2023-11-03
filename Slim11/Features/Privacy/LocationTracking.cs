using Microsoft.Win32;
using Slim11.Utilities;

namespace Slim11.Features.Privacy
{
    internal class LocationTracking : ICommand
    {
        private static LocationTracking instance;

        private LocationTracking() { }

        public static LocationTracking Instance
        {
            get
            {
                if (instance == null)
                    instance = new LocationTracking();
                return instance;
            }
        }

        public void Execute()
        {
            try
            {
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\CapabilityAccessManager\ConsentStore\location", "Value", "Deny", RegistryValueKind.String);
                MessageBox.ShowInfo("Location tracking disabled successfully!");
            }
            catch { MessageBox.ShowError("Failed to disable location tracking."); }
        }

        public void Undo()
        {
            try
            {
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\CapabilityAccessManager\ConsentStore\location", "Value", "Allow", RegistryValueKind.String);
                MessageBox.ShowInfo("Location tracking enabled successfully.");
            }
            catch { MessageBox.ShowError("Failed to enable location tracking."); }
        }
    }
}