using System.Collections.Generic;

namespace Slim11.Features
{
    internal static class CommandInvoker
    {
        private static List<ICommand> commandList = new List<ICommand>();

        internal static void AddCommand(ICommand command) { commandList.Add(command); }

        internal static void ExecuteCommands()
        {
            foreach (ICommand command in commandList) { command.Execute(); }
            commandList.Clear();
        }

        internal static void UndoCommands()
        {
            foreach (ICommand command in commandList) { command.Undo(); }
            commandList.Clear();
        }
    }
}