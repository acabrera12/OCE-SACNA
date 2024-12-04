using Engine.ClassDB.Asbtract;

namespace OCE_SACNA
{
    internal static class Program
    {
        public static Version3 = new Version3(0,0,7);

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new AuthMenu());
        }
    }
}