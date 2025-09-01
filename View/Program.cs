using OCESACNA.View.Properties;
using System;
using System.Windows.Forms;
using Handler = OCESACNA.View.Menus.HandlerMenu;

namespace OCESACNA.View
{
    /// <summary>
    /// Representa a la aplicación.
    /// </summary>
    static class Program
    {
        /// <summary>
        /// Cantidad de intentos de inicialización máxima
        /// </summary>
        private const int MaxInitializationAttemps = 3;

        /// <summary>
        /// Configuración de la aplicación
        /// </summary>
        public static Settings Settings { get; private set; } = new Settings();

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool Initialized = false;
            int attempsCount = 0;

            while (!Initialized && attempsCount < MaxInitializationAttemps)
            {
                Initialized = Startup.Initialize(Settings, out var handler);

                if (!Initialized)
                {
                    Application.Run(handler);
                    if (Handler.CloseOnExit)
                    {
                        break;
                    }
                    else
                    {
                        attempsCount++;
                        continue;
                    }
                }
            }

            if (Initialized)
            {

            }
            else if (!Initialized && attempsCount >= MaxInitializationAttemps)
            {
                Console.WriteLine(Resources.Messages_InitializationAttempsError);
                MessageBox.Show(
                    Resources.Messages_InitializationAttempsError,
                    Resources.Titles_InitializationError,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                );
            }

            Startup.Finalize(Settings);
        }
    }
}
