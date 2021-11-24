namespace Carthagina.Core
{
    public class Startup
    {
        public static void StartupProcess()
        {
            SetupData.FillDatabase();
        }
    }
}