using Microsoft.Win32;
using Slim11.Utilities;

namespace Slim11.Features.Privacy
{
    internal class AutomaticUpdates : ICommand
    {
        private static AutomaticUpdates instance;

        private AutomaticUpdates() { }

        public static AutomaticUpdates Instance
        {
            get
            {
                if (instance == null)
                    instance = new AutomaticUpdates();
                return instance;
            }
        }

        public void Execute()
        {
            try
            {
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU", "NoAutoUpdate", 1, RegistryValueKind.DWord);
                MessageBox.ShowInfo("Automatic updates disabled successfully!");
            }
            catch { MessageBox.ShowError("Failed to disable automatic updates."); }
        }

        public void Undo()
        {
            try
            {
                using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU", true))
                {
                    registryKey.DeleteValue("NoAutoUpdate");
                }
                MessageBox.ShowInfo("Automatic updates enabled successfully.");
            }
            catch { MessageBox.ShowError("Failed to enable automatic updates."); }
        }
    }
}