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
            //TODO: Disable telemetry.
        }

        public void Undo()
        {
            //TODO: Enable telemetry.
        }
    }
}