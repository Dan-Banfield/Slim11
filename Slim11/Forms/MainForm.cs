using System;
using Slim11.Features;
using System.Windows.Forms;
using Slim11.Features.Privacy;
using System.Runtime.InteropServices;

namespace Slim11.Forms
{
    public partial class MainForm : Form
    {
        #region Dark Title Bar

        [DllImport("DwmApi")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

        protected override void OnHandleCreated(EventArgs e)
        {
            if (DwmSetWindowAttribute(Handle, 19, new[] { 1 }, 4) != 0)
                DwmSetWindowAttribute(Handle, 20, new[] { 1 }, 4);
        }

        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        #region Event Handlers

        #region Buttons

        private void fixAllButton_Click(object sender, EventArgs e)
        {
            CommandInvoker.AddCommand(Telemetry.Instance);
            CommandInvoker.AddCommand(DiagnosticData.Instance);
            CommandInvoker.AddCommand(AutomaticUpdates.Instance);
            CommandInvoker.AddCommand(LocationTracking.Instance);
            CommandInvoker.ExecuteCommands();
        }

        private void restoreAllButton_Click(object sender, EventArgs e)
        {
            CommandInvoker.AddCommand(Telemetry.Instance);
            CommandInvoker.AddCommand(DiagnosticData.Instance);
            CommandInvoker.AddCommand(AutomaticUpdates.Instance);
            CommandInvoker.AddCommand(LocationTracking.Instance);
            CommandInvoker.UndoCommands();
        }

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

        private void fixDiagnosticDataButton_Click(object sender, EventArgs e)
        {
            CommandInvoker.AddCommand(DiagnosticData.Instance);
            CommandInvoker.ExecuteCommands();
        }

        private void restoreDiagnosticDataButton_Click(object sender, EventArgs e)
        {
            CommandInvoker.AddCommand(DiagnosticData.Instance);
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

        private void fixLocationTrackingButton_Click(object sender, EventArgs e)
        {
            CommandInvoker.AddCommand(LocationTracking.Instance);
            CommandInvoker.ExecuteCommands();
        }

        private void restoreLocationTrackingButton_Click(object sender, EventArgs e)
        {
            CommandInvoker.AddCommand(LocationTracking.Instance);
            CommandInvoker.UndoCommands();
        }

        #endregion

        #endregion
    }
}