using Microsoft.Win32;
using Slim11.Utilities;

namespace Slim11.Features.Privacy
{
    internal class Telemetry : ICommand
    {
        private static Telemetry instance;

        private Telemetry() { }

        public static Telemetry Instance
        {
            get
            {
                if (instance == null)
                    instance = new Telemetry();
                return instance;
            }
        }

        public void Execute()
        {
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\CompatTelRunner.exe", "Debugger", @"%windir%\System32\taskkill.exe", RegistryValueKind.String);

            MessageBox.ShowInfo("Telemetry disabled successfully!");
        }

        public void Undo()
        {
            MessageBox.ShowInfo("Telemetry enabled successfully.");
        }
    }
}