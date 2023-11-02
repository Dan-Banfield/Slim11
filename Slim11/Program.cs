using System;
using Slim11.Forms;
using System.Windows.Forms;
using MessageBox = Slim11.Utilities.MessageBox;

namespace Slim11
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            MessageBox.ShowInfo("This program is designed for Windows 11.");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}