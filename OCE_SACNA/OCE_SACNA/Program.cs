using OfficeLayer;

namespace OCE_SACNA
{
    internal static class Program
    {
        private static ProcessManager ProcessManager = new ProcessManager();

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new AuthMenu());

            Process();
        }

        static async Task Process()
        {
            await ProcessManager.StartProcess();
        }
    }
}