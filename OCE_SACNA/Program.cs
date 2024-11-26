using Engine;
using Engine.Core;

namespace OCE_SACNA
{
    internal static class Program
    {
        [STAThread]
        public static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new AuthMenu());

            Process();
        }

        internal static void Process()
        {
            Engine.Engine.StartProcessing();
        }
    }
}