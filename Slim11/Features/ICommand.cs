namespace Slim11.Features
{
    internal interface ICommand
    {
        void Execute();
        void Undo();
    }
}