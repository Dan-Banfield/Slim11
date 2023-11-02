using Slim11.Features;
using System.Windows.Forms;
using Slim11.Features.Privacy;

namespace Slim11.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region Event Handlers

        #region Buttons

        private void fixTelemetryButton_Click(object sender, System.EventArgs e)
        {
            CommandInvoker.AddCommand(Telemetry.Instance);
            CommandInvoker.ExecuteCommands();
        }

        private void restoreTelemetryButton_Click(object sender, System.EventArgs e)
        {
            CommandInvoker.AddCommand(Telemetry.Instance);
            CommandInvoker.UndoCommands();
        }



        private void fixAutomaticUpdatesButton_Click(object sender, System.EventArgs e)
        {
            CommandInvoker.AddCommand(AutomaticUpdates.Instance);
            CommandInvoker.ExecuteCommands();
        }

        private void restoreAutomaticUpdatesButton_Click(object sender, System.EventArgs e)
        {
            CommandInvoker.AddCommand(AutomaticUpdates.Instance);
            CommandInvoker.UndoCommands();
        }

        #endregion

        #endregion
    }
}